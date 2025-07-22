/*1. Create a stored procedure to show the number of students per department.[use ITI DB] */

create proc SP_GetstuNumbydepId @id int
with encryption
as 
	select count(St_Id)
	from Student
	where Dept_Id=@id
	------------------------
execute SP_GetstuNumbydepId 30
----------------------------------------------------------------------
/*2. Create a stored procedure that will check for the Number of employees in 
the project p1 if they are more than 3 print message to the user “'The 
number of employees in the project p1 is 3 or more'” if they are less display 
a message to the user “'The following employees work for the project p1'” 
in addition to the first name and last name of each one. [MyCompany DB]  */

create or alter proc SP_CheckNumEmpInProj @PNum int
with encryption
as 
   declare @numE int
	select @numE = count(*)
			from Employee e
			join Departments D on D.Dnum=e.Dno
			join Project P on p.Dnum=d.Dnum
			where Pnumber = @PNum
	if @numE >= 3
	begin
	select 'The number of employees in This Project is 3 or more'
	end
	else 
	begin
	select 'The following employees work for this Project'
	select  Fname, Lname
			from Employee e
			join Departments D on D.Dnum=e.Dno
			join Project P on p.Dnum=d.Dnum
			where Pnumber = @PNum
end
---------------------------------
execute SP_CheckNumEmpInProj 700
----------------------------------------------------------------------------------
/*3.Create a stored procedure that will be used in case there is an old 
employee has left the project and a new one become instead of him. The 
procedure should take 3 parameters (old Emp. number, new Emp. number 
and the project number) and it will be used to update works_on table.[MyCompany DB] */

create or alter proc SP_ReplaceEmployeeInProject @old_emp_no INT,@new_emp_no INT,@proj_no INT
with encryption
as 
    UPDATE works_for
    SET ESSn = @new_emp_no
    WHERE ESSn = @old_emp_no AND Pno = @proj_no
	
---------------------------------
execute SP_ReplaceEmployeeInProject 223344,123456,100 



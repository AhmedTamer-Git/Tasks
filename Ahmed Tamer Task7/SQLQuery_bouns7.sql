--1.Create a scalar function that takes date and returns Month name of that date. 

create or alter function GetMonthnameByDate (@date date)
	returns varchar(max)  -- signature
	begin
		 DECLARE @MonthName varchar(max)
		 SET @MonthName = DATENAME(MONTH, @date)
         RETURN @MonthName
	end
---------------------------------------
	select dbo.GetMonthnameByDate('5-5-2025')
----------------------------------------------------------------------------
create or alter proc SP_GetMonthnameByDate @date date,@MonthName varchar(max) output
 with encryption
as
 SET @MonthName = DATENAME(MONTH, @date)          

---------------------------------------
    DECLARE @MonthNamee varchar(max)
	EXEC dbo.SP_GetMonthnameByDate '5-5-2025',@MonthNamee output
	select @MonthNamee
	--------------------------------------------------------------------------------
--2.Create a multi-statements table-valued function that takes 2 integers and returns the values between them.

create or alter function GetNumbersBetween(@start int,@end int)
	returns @t table 
	(
		valuse int
	)
	as 
BEGIN
    DECLARE @Current INT
    SET @Current = @Start

    WHILE @Current < @End-1
    BEGIN
        SET @Current = @Current + 1
        INSERT INTO @t (valuse)
        VALUES (@Current)
    END

    RETURN
END
------------------------------------------
select * from GetNumbersBetween(1,10)
--------------------------------------------------------------------
create or alter proc SP_GetNumbersBetween @start int,@end int
 with encryption
as
 CREATE TABLE Table1 (valuse INT)
 DECLARE @Current INT
 SET @Current = @Start
    WHILE @Current < @End-1
    BEGIN
        SET @Current = @Current + 1
        INSERT INTO Table1 (valuse)
        VALUES (@Current)
    END
	SELECT * FROM Table1
	----------------------------------------
	EXEC SP_GetNumbersBetween 1, 10
-------------------------------------------------------------------------
--3.Create a tabled valued function that takes Student No and returns Department Name with Student full name.

create or alter function GetDeptName_stName_byStId(@stId int)
	returns table
	as 
		return
		(
			select d.Dept_Name,s.St_Fname+' '+s.St_Lname as [Full name]
			from Student s
			join Department d on s.Dept_Id=d.Dept_Id
			where St_Id=@stId
		)
-----------------------------------------------------
	select * from  GetDeptName_stName_byStId(55)
	-------------------------------------------------------------------
	create or alter proc SP_GetDeptName_stName_byStId @stId int
 with encryption
as
            select d.Dept_Name,s.St_Fname+' '+s.St_Lname as [Full name]
			from Student s
			join Department d on s.Dept_Id=d.Dept_Id
			where St_Id=@stId
	------------------------------------
		EXEC SP_GetDeptName_stName_byStId 55
--------------------------------------------------------------------------------------------
/* 4. Create a scalar function that takes Student ID and returns a message to user  
a. If first name and Last name are null then display 'First name & last name are null' 
b. If First name is null then display 'first name is null' 
c. If Last name is null then display 'last name is null' 
d. Else display 'First name & last name are not null' */

create or alter function  message_to_userByID (@ID int)
	returns varchar(max)  -- signature
	begin
		 DECLARE @Message varchar(max)
		 DECLARE @first varchar(max)
		 DECLARE @last varchar(max)
	set	@first = (select St_Fname isnull from Student where St_Id=@ID)
	set @last = (select St_Lname isnull from Student where St_Id=@ID)

        if @ID = (select St_Id from Student where St_Id=@ID) 
	begin
		 if @first is NULL and @last is NULL
	         SET @Message = 'First name & last name are null'
		 else if @first is NULL
			SET @Message = 'First name is null'
	   	 else if @last is NULL
		    SET @Message = 'Last name is null'
	     else if @first is not NULL and @last is not NULL
		    SET @Message = 'First name & last name are not null'
	end 
		else 	
		    SET @Message = 'ID not found'
    RETURN @message
	end
	-----------------------------------------------------
  select dbo.message_to_userByID(13)
  ------------------------------------------------------------------------------
  create or alter proc SP_message_to_userByID @ID int
 with encryption
as
 DECLARE @Message varchar(max)
		 DECLARE @first varchar(max)
		 DECLARE @last varchar(max)
	set	@first = (select St_Fname isnull from Student where St_Id=@ID)
	set @last = (select St_Lname isnull from Student where St_Id=@ID)

        if @ID = (select St_Id from Student where St_Id=@ID) 
	begin
		 if @first is NULL and @last is NULL
	         SET @Message = 'First name & last name are null'
		 else if @first is NULL
			SET @Message = 'First name is null'
	   	 else if @last is NULL
		    SET @Message = 'Last name is null'
	     else if @first is not NULL and @last is not NULL
		    SET @Message = 'First name & last name are not null'
	end 
		else 	
		    SET @Message = 'ID not found'
      select @message
	  ---------------------------------------------
	  EXEC SP_message_to_userByID 13
  -------------------------------------------------------------------------------------------------
/* 5.Create a function that takes integer which represents the format of the Manager hiring date and displays
     department name,Manager Name and hiring date with this format.*/  

create or alter function GetDeptName_ManagerName_hiringDate(@format int)
	returns table
	as 
		return
		(   
			select Dept_Name,Dept_Manager,
			CASE @format
            WHEN 1 THEN FORMAT(manager_hiredate, 'dd-MM-yyyy')       -- 15-07-2025
            WHEN 2 THEN FORMAT(manager_hiredate, 'MMMM dd, yyyy')    -- July 15, 2025
            WHEN 3 THEN FORMAT(manager_hiredate, 'yyyy/MM/dd')       -- 2025/07/15
            WHEN 4 THEN FORMAT(manager_hiredate, 'ddd, dd MMM yyyy') -- Tue, 15 Jul 2025
            ELSE FORMAT(manager_hiredate, 'yyyy-MM-dd')            
        END AS FormattedHiringDate
			from Department 
		)
 --------------------------------------------------------------
 select * from  GetDeptName_ManagerName_hiringDate(2)
 --------------------------------------------------------------------
 create or alter proc SP_GetDeptName_ManagerName_hiringDate @format int
 with encryption
as
            select Dept_Name,Dept_Manager,
			CASE @format
            WHEN 1 THEN FORMAT(manager_hiredate, 'dd-MM-yyyy')       -- 15-07-2025
            WHEN 2 THEN FORMAT(manager_hiredate, 'MMMM dd, yyyy')    -- July 15, 2025
            WHEN 3 THEN FORMAT(manager_hiredate, 'yyyy/MM/dd')       -- 2025/07/15
            WHEN 4 THEN FORMAT(manager_hiredate, 'ddd, dd MMM yyyy') -- Tue, 15 Jul 2025
            ELSE FORMAT(manager_hiredate, 'yyyy-MM-dd')            
        END AS FormattedHiringDate
			from Department
      ---------------------------------------------
	  EXEC SP_GetDeptName_ManagerName_hiringDate 1
-----------------------------------------------------------------------------------------------------
/* 6.Create multi-statements table-valued function that takes a string 
     If string='first name' returns student first name
	 If string='last name' returns student last name  
     If string='full name' returns Full Name from student table */

	 create function Get_StuName_ByPattern(@pattern varchar(20))
	returns @t table 
	(
		id int,
		stuNAme varchar(max)
	)

	as 
		begin
			if @pattern = 'first name'
			insert into @t
			select st_id,St_Fname
			from Student
			else if @pattern = 'last name'
			insert into @t
			select st_id,St_Lname
			from Student
			else if @pattern = 'full name'
			insert into @t
			select st_id,St_Fname+' '+St_Lname
			from Student
			return
		end
----------------------------------------------------
select * from  Get_StuName_ByPattern('first name')
--------------------------------------------------------------------
create or alter proc SP_Get_StuName_ByPattern @pattern varchar(20)
 with encryption
as
            
			if @pattern = 'first name'
			
			select st_id,St_Fname
			from Student
			else if @pattern = 'last name'
			
			select st_id,St_Lname
			from Student
			else if @pattern = 'full name'
			
			select st_id,St_Fname+' '+St_Lname
			from Student
-----------------------------------------
 EXEC SP_Get_StuName_ByPattern 'last name'
------------------------------------------------------------------------------------------------------
/* Use MyCompany DB 
   1.Create function that takes project number and display all employees in this project */
   use MyCompany

   create or alter function Get_All_Employees_BYProNum(@Num int)
	returns table
	as 
		return
		(   
			select Fname+' '+Lname as [Full Name]
			from Employee e
			join Departments D on D.Dnum=e.Dno
			join Project P on p.Dnum=d.Dnum
			where Pnumber = @Num
		)
 --------------------------------------------------------------
 select * from  Get_All_Employees_BYProNum(600)
--------------------------------------------------------------------------------

create or alter proc SP_Get_All_Employees_BYProNum @Num int
 with encryption
as
            select Fname+' '+Lname as [Full Name]
			from Employee e
			join Departments D on D.Dnum=e.Dno
			join Project P on p.Dnum=d.Dnum
			where Pnumber = @Num
--------------------------------------------------------------------
EXEC SP_Get_All_Employees_BYProNum 600




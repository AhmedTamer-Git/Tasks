
create view StudentExam 
 as
    select *
	from stu_takes_exam
 
create view StudentView 
as 
  select *
  from Student

create view TrackInView
as 
select *
from TrackIntake

create view StuExamPool
 as 
    select *
	from exampool

create view ExamView 
 as
    select *
	from Exam

create view AnswerView
 as
   select *
   from answer

create view questionView
 as
   select *
   from question

create view CourseView
 as
   select *
   from Course

create view InstructorCourse
 as
   select *
   from Course_Teach_By_Instructor

create view ManagerView
 as
   select *
   from Training_manager

create View BranView
as 
  select *
  from Branch

create View IntakeView
 as
   select *
   from Intake

create Schema Manger
 go
create schema Student
 go
create schema Instructor

--للطالب "يدخل الامتحان"
create or alter PROCEDURE Student.sp_StudentTakeExam
    @StudentID INT,
    @ExamID INT
 with encryption
AS

BEGIN
    SET NOCOUNT ON;

    
 INSERT INTO stu_takes_exam (Stu_id, Exam_id, stime, endtime)
VALUES (
    @StudentID,            -- Stu_id
    @ExamID,           -- Exam_id
    GETDATE(),    -- stime = الآن
    DATEADD(HOUR, 2, GETDATE()) -- endtime = بعد ساعتين
);
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Check if student is allowed to take this exam
        IF NOT EXISTS (
            SELECT 1 FROM StudentExam 
            WHERE Stu_id = @StudentID AND Exam_id = @ExamID
        )
        BEGIN
            RAISERROR('Student is not registered for this exam', 16, 1);
            RETURN;
        END
        
        -- Check if exam is currently available
        DECLARE @CurrentTime DATETIME = GETDATE();
        DECLARE @StartTime DATETIME, @EndTime DATETIME;
        
        SELECT @StartTime = stime, @EndTime = endtime 
        FROM StudentExam 
        WHERE Stu_id = @StudentID AND Exam_id = @ExamID;
        
        IF @CurrentTime < @StartTime
        BEGIN
            RAISERROR('Exam has not started yet', 16, 1);
            RETURN;
        END
        
        IF @CurrentTime > @EndTime
        BEGIN
            RAISERROR('Exam time has expired', 16, 1);
            RETURN;
        END
        
        -- Check if exam is already submitted
        IF EXISTS (
            SELECT 1 FROM StudentExam 
            WHERE Stu_id = @StudentID AND Exam_id = @ExamID AND issubmitted = 1
        )
        BEGIN
            RAISERROR('Exam already submitted', 16, 1);
            RETURN;
        END
        
        -- Return exam questions
        SELECT q.que_id, q.que_text, q.que_type, q.accanswer, e.poolid
        FROM StuExamPool e
        JOIN questionView q ON e.que_id = q.que_id
        WHERE e.exam_id = @ExamID;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END

go
drop proc sp_StudentTakeExam


--للطالب يعرف درجته في امتحان
--------------------------------
create or alter PROCEDURE Student.sp_GetStudentExamResult
    @StudentID INT,
    @ExamID INT
with encryption 
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Check if exam is submitted
    IF NOT EXISTS (
        SELECT 1 FROM StudentExam 
        WHERE Stu_id = @StudentID AND Exam_id = @ExamID AND issubmitted = 1
    )
    BEGIN
        RAISERROR('Exam not submitted yet', 16, 1);
        RETURN;
    END
    
    -- Get exam details and total grade
    SELECT 
        e.Exam_id,
        e.title,
        c.courseName,
        ste.finalgrade,
        c.maxDegree AS maxPossibleGrade,
        CASE 
            WHEN ste.finalgrade >= c.minDegree THEN 'Passed'
            ELSE 'Failed'
        END AS resultStatus
    FROM ExamView e
    JOIN StudentExam ste ON e.Exam_id = ste.Exam_id
    JOIN CourseView c ON e.course_id = c.courseID
    WHERE ste.Stu_id = @StudentID AND ste.Exam_id = @ExamID;
    
    -- Get detailed answers and marks
    SELECT 
        q.que_id,
        q.que_text,
        q.que_type,
        a.answer_text,
        q.corranswer AS correct_answer,
        a.iscorrect,
        a.mark,
        CASE 
            WHEN q.que_type IN ('Multiple Choice', 'True & False') THEN 'Auto-graded'
            ELSE 'Manual-graded'
        END AS grading_type
    FROM AnswerView a
    JOIN questionView q ON a.que_id = q.que_id
    WHERE a.Stu_id = @StudentID 
    AND q.que_id IN (SELECT que_id FROM exampool WHERE exam_id = @ExamID);
END
go
drop proc sp_GetStudentExamResult
-- للمدرس يعمل امتحان
create or alter PROCEDURE Instructor.sp_InstructorCreateExam
    @InstructorID INT,
    @CourseID INT,
    @Title VARCHAR(100),
    @IsRegular BIT,
    @IsCorrective BIT,
    @AllowReentry BIT,
    @StartDate DATETIME,
    @DurationMinutes INT,
    @QuestionList XML = NULL -- Optional: XML of question IDs and points
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Verify instructor teaches this course
        IF NOT EXISTS (
            SELECT 1 FROM InstructorCourse
            WHERE InstructorID = @InstructorID AND CourseID = @CourseID
        )
        BEGIN
            RAISERROR('Instructor does not teach this course', 16, 1);
            RETURN;
        END
        
        -- Create the exam
        DECLARE @ExamID INT;
        
        INSERT INTO ExamView (
            title, 
            ExamData, 
            regular, 
            corrective, 
            allow_reentry, 
            course_id, 
            ins_Id
        )
        VALUES (
            @Title, 
            @StartDate, 
            @IsRegular, 
            @IsCorrective, 
            @AllowReentry, 
            @CourseID, 
            @InstructorID
        );
        
        SET @ExamID = SCOPE_IDENTITY();
        
        -- If question list provided, add questions to exam
        IF @QuestionList IS NOT NULL
        BEGIN
            INSERT INTO StuExamPool(exam_id, que_id, CourseID, timedate)
            SELECT 
                @ExamID,
                x.q.value('@id', 'INT') AS que_id,
                @CourseID,
                GETDATE()
            FROM @QuestionList.nodes('/questions/question') AS x(q);
            
            -- Update points for each question (if provided)
            UPDATE a
            SET a.mark = x.q.value('@points', 'DECIMAL(5,2)')
            FROM AnswerView a
            JOIN @QuestionList.nodes('/questions/question') AS x(q)
                ON a.que_id = x.q.value('@id', 'INT')
            WHERE a.Stu_id IS NULL; -- Template answers
        END
        
        COMMIT TRANSACTION;
        
        -- Return the created exam ID
        SELECT @ExamID AS NewExamID;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
 
 go
drop proc sp_InstructorCreateExam

-- Add new intake
create or alter PROCEDURE Manger.sp_AddIntake
    @IntakeNumber VARCHAR(50),
    @StartDate DATE,
    @EndDate DATE,
    @BranchID INT,
    @ManagerID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Verify manager exists
    IF NOT EXISTS (SELECT 1 FROM ManagerView WHERE manId = @ManagerID)
    BEGIN
        RAISERROR('Invalid manager ID', 16, 1);
        RETURN;
    END
    
    -- Verify branch exists
    IF NOT EXISTS (SELECT 1 FROM BranView WHERE BranchID = @BranchID)
    BEGIN
        RAISERROR('Invalid branch ID', 16, 1);
        RETURN;
    END
    
    -- Add intake
    INSERT INTO IntakeView (IntakeNumber, StartDate, EndDate, BranchID)
    VALUES (@IntakeNumber, @StartDate, @EndDate, @BranchID);
    
    SELECT SCOPE_IDENTITY() AS NewIntakeID;
END

create or alter PROCEDURE Manger.sp_UpdateIntake
    @IntakeID INT,
    @IntakeNumber VARCHAR(50) = NULL,
    @StartDate DATE = NULL,
    @EndDate DATE = NULL,
    @BranchID INT = NULL,
    @ManagerID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Verify manager exists
    IF NOT EXISTS (SELECT 1 FROM ManagerView WHERE manId = @ManagerID)
    BEGIN
        RAISERROR('Invalid manager ID', 16, 1);
        RETURN;
    END
    
    -- Verify intake exists
    IF NOT EXISTS (SELECT 1 FROM IntakeView WHERE IntakeID = @IntakeID)
    BEGIN
        RAISERROR('Intake not found', 16, 1);
        RETURN;
    END
    
    -- Update only provided fields
    UPDATE IntakeView SET
        IntakeNumber = ISNULL(@IntakeNumber, IntakeNumber),
        StartDate = ISNULL(@StartDate, StartDate),
        EndDate = ISNULL(@EndDate, EndDate),
        BranchID = ISNULL(@BranchID, BranchID)
    WHERE IntakeID = @IntakeID;
    
    SELECT @@ROWCOUNT AS RowsAffected;
END
go
drop proc sp_UpdateIntake


create or alter PROCEDURE Manger.sp_DeleteIntake
    @IntakeID INT,
    @ManagerID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Verify manager exists
        IF NOT EXISTS (SELECT 1 FROM ManagerView WHERE manId = @ManagerID)
        BEGIN
            RAISERROR('Invalid manager ID', 16, 1);
            RETURN;
        END
        
        -- Verify intake exists
        IF NOT EXISTS (SELECT 1 FROM IntakeView WHERE IntakeID = @IntakeID)
        BEGIN
            RAISERROR('Intake not found', 16, 1);
            RETURN;
        END
        
        -- Check if intake has students
        IF EXISTS (SELECT 1 FROM StudentView WHERE IntakeID = @IntakeID)
        BEGIN
            RAISERROR('Cannot delete intake with assigned students', 16, 1);
            RETURN;
        END
        
        -- Delete from TrackIntake first
        DELETE FROM TrackInView
 WHERE IntakeID = @IntakeID;
        
        -- Delete the intake
        DELETE FROM IntakeView WHERE IntakeID = @IntakeID;
        
        COMMIT TRANSACTION;
        
        SELECT @@ROWCOUNT AS RowsAffected;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END

go 
drop proc sp_DeleteIntake

--هل ينفع يسيب سؤال من غير إجابة
create or alter TRIGGER trg_check_unanswered_questions
ON stu_takes_exam
AFTER UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM exampool ep
        LEFT JOIN answer a ON ep.que_id = a.que_id AND a.Stu_id = (SELECT Stu_id FROM inserted)
        WHERE ep.exam_id = (SELECT Exam_id FROM inserted)
        AND a.answer_id IS NULL
        AND (SELECT issubmitted FROM inserted) = 1
    )
    BEGIN
        RAISERROR('Some questions are unanswered!', 16, 1);
        ROLLBACK;
    END
END;

--هل ينفع في سؤال MCQ يختار اختيار مش موجود
-- هل ينفع يبعت الإجابة بعد انتهاء وقت الامتحان؟

create or alter TRIGGER trg_answer_validation
ON answer
INSTEAD OF INSERT
AS
BEGIN
    -- تحقق من صلاحية الاختيار في MCQ
    IF EXISTS (
        SELECT 1
        FROM inserted i
        LEFT JOIN choices c ON i.choice_id = c.choice_id
        WHERE c.que_id != i.que_id
    )
    BEGIN
        RAISERROR('❌ Invalid choice for this question (MCQ)', 16, 1);
        RETURN;
    END

    -- تحقق من عدم إرسال إجابة بعد وقت الامتحان
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN exampool ep ON i.que_id = ep.que_id
        JOIN stu_takes_exam s ON i.Stu_id = s.Stu_id AND ep.exam_id = s.Exam_id
        WHERE GETDATE() > s.endtime
    )
    BEGIN
        RAISERROR('⏰ Cannot submit answer after exam end time.', 16, 1);
        RETURN;
    END

    -- لو عدّى الشرطين يتم الإدخال
    INSERT INTO answer (que_id, Stu_id, answer_text, iscorrect, mark, choice_id)
    SELECT que_id, Stu_id, answer_text, iscorrect, mark, choice_id
    FROM inserted;
END;

CREATE PROCEDURE Student.SP_SubmitAnswer
    @Stu_id INT,
    @Exam_id INT,
    @Que_id INT,
    @Answer_text NVARCHAR(MAX),
    @Choice_id INT = NULL  -- optional, for MCQ
AS
BEGIN
    SET NOCOUNT ON;

    -- التأكد إن الامتحان لسه مفتوح
    IF NOT EXISTS (
        SELECT 1 FROM stu_takes_exam
        WHERE Stu_id = @Stu_id AND Exam_id = @Exam_id
          AND GETDATE() BETWEEN stime AND endtime
    )
    BEGIN
        RAISERROR('This exam is not currently open or does not exist for the student.', 16, 1);
        RETURN;
    END

    -- تأكد إن السؤال موجود ضمن الامتحان
    IF NOT EXISTS (
        SELECT 1 FROM exampool
        WHERE exam_id = @Exam_id AND que_id = @Que_id
    )
    BEGIN
        RAISERROR('This question is not part of the exam.', 16, 1);
        RETURN;
    END

    -- منع تكرار الإجابة
    IF EXISTS (
        SELECT 1 FROM answer
        WHERE que_id = @Que_id AND Stu_id = @Stu_id
    )
    BEGIN
        RAISERROR('You have already answered this question.', 16, 1);
        RETURN;
    END

    DECLARE @CorrectAnswer VARCHAR(100), @IsCorrect BIT = 0, @Mark DECIMAL(5,2) = 0, @MaxDegree DECIMAL(5,2);

    SELECT @CorrectAnswer = corranswer
    FROM question
    WHERE que_id = @Que_id;

    -- لو السؤال من نوع MCQ
    IF EXISTS (
        SELECT 1 FROM choices WHERE que_id = @Que_id
    )
    BEGIN
        IF NOT EXISTS (
            SELECT 1 FROM choices WHERE choice_id = @Choice_id AND que_id = @Que_id
        )
        BEGIN
            RAISERROR('Invalid choice.', 16, 1);
            RETURN;
        END

        IF @CorrectAnswer = CAST(@Choice_id AS VARCHAR)
        BEGIN
            SET @IsCorrect = 1;
        END
    END
    ELSE
    BEGIN
        -- سؤال نصي / صح أو خطأ
        IF LOWER(@Answer_text) = LOWER(@CorrectAnswer)
        BEGIN
            SET @IsCorrect = 1;
        END
    END

    -- حساب الدرجة لو صح
    IF @IsCorrect = 1
    BEGIN
        SELECT @MaxDegree = maxDegree
        FROM Course
        WHERE courseID = (
            SELECT course_id FROM Exam WHERE Exam_id = @Exam_id
        );

        SET @Mark = @MaxDegree / (
            SELECT COUNT(*) FROM exampool
            WHERE exam_id = @Exam_id
        );
    END

    -- تسجيل الإجابة
    INSERT INTO answer (que_id, Stu_id, answer_text, iscorrect, mark, choice_id)
    VALUES (@Que_id, @Stu_id, @Answer_text, @IsCorrect, @Mark, @Choice_id);

    PRINT 'Answer submitted successfully.';
END

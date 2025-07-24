CREATE TABLE Users (
    userId INT PRIMARY KEY IDENTITY(1,1),
    userName VARCHAR(150) NOT NULL UNIQUE,
    email VARCHAR(150) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    userRole VARCHAR(20) NOT NULL
);

-- الفروع
CREATE TABLE Branch (
    BranchID INT PRIMARY KEY IDENTITY(1,1),
    BranchName VARCHAR(100) NOT NULL,
    City VARCHAR(50) NOT NULL
);

-- الانتاكات
CREATE TABLE Intake (
    IntakeID INT PRIMARY KEY IDENTITY(1,1),
    IntakeNumber VARCHAR(50) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    BranchID INT NOT NULL,
    FOREIGN KEY (BranchID) REFERENCES Branch(BranchID)
);

-- التراكات
CREATE TABLE Track (
    TrackID INT PRIMARY KEY IDENTITY(1,1),
    TrackName VARCHAR(100) NOT NULL,
    BranchID INT NOT NULL,
    FOREIGN KEY (BranchID) REFERENCES Branch(BranchID)
);

-- ربط التراك بالانتيك
CREATE TABLE TrackIntake (
    TrackID INT NOT NULL,
    IntakeID INT NOT NULL,
    PRIMARY KEY (TrackID, IntakeID),
    FOREIGN KEY (TrackID) REFERENCES Track(TrackID),
    FOREIGN KEY (IntakeID) REFERENCES Intake(IntakeID)
);

-- الطلاب
CREATE TABLE Student(
    stId INT PRIMARY KEY IDENTITY(1,1),
    Fname VARCHAR(150) NOT NULL,
    Lname VARCHAR(150) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    nationalID VARCHAR(20) UNIQUE,
    Address NVARCHAR(255),
    phone VARCHAR(20),
    birthDate DATE,
    gender VARCHAR(10),
    UserID INT NOT NULL UNIQUE,
    IntakeID INT,
    TrackID INT,
    FOREIGN KEY (UserID) REFERENCES Users(userId),
    FOREIGN KEY (IntakeID) REFERENCES Intake(IntakeID),
    FOREIGN KEY (TrackID) REFERENCES Track(TrackID)
);

-- كورسات
CREATE TABLE Course (
    courseID INT PRIMARY KEY IDENTITY(1,1),
    courseName NVARCHAR(100) NOT NULL UNIQUE,
    description NVARCHAR(MAX),
    maxDegree DECIMAL(5,2) NOT NULL,
    minDegree DECIMAL(5,2) NOT NULL
);

-- مدربين
CREATE TABLE Instructor(
    insId INT PRIMARY KEY IDENTITY(1,1),
    Fname VARCHAR(150) NOT NULL,
    Lname VARCHAR(150) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    phone VARCHAR(20),
    UserID INT NOT NULL UNIQUE,
    FOREIGN KEY (UserID) REFERENCES Users(userId)
);

-- مدير تدريب
CREATE TABLE Training_manager(
    manId INT PRIMARY KEY IDENTITY(1,1),
    Fname VARCHAR(150) NOT NULL,
    Lname VARCHAR(150) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    UserID INT NOT NULL UNIQUE,
    FOREIGN KEY (UserID) REFERENCES Users(userId)
);

-- ربط المدرسين بالكورسات
CREATE TABLE Course_Teach_By_Instructor(
    CourseID INT NOT NULL,
    InstructorID INT NOT NULL,
    PRIMARY KEY (CourseID, InstructorID),
    FOREIGN KEY (CourseID) REFERENCES Course(courseID),
    FOREIGN KEY (InstructorID) REFERENCES Instructor(insId)
);

-- جدول الامتحانات
CREATE TABLE Exam (
    Exam_id INT PRIMARY KEY IDENTITY(1,1),
    title VARCHAR(100),
    ExamData DATE,
    regular BIT,
    corrective BIT,
    allow_reentry BIT,
    course_id INT REFERENCES Course(courseID),
    ins_Id INT REFERENCES Instructor(insId)
);

-- جدول استلام الطلاب للامتحان
CREATE TABLE stu_takes_exam (
    StuExam_id INT PRIMARY KEY IDENTITY(1,1),
    Stu_id INT REFERENCES Student(stId),
    Exam_id INT REFERENCES Exam(Exam_id),
    stime DATETIME,
    endtime DATETIME,
    finalgrade DECIMAL(5,2),
    issubmitted BIT
);

-- الأسئلة
CREATE TABLE question (
    que_id INT PRIMARY KEY IDENTITY(1,1),
    que_text TEXT,
    que_type VARCHAR(30),
    accanswer TEXT,
    corranswer VARCHAR(30),
    crs_id INT REFERENCES Course(courseID)
);

-- إجابات الطلاب
CREATE TABLE answer (
    answer_id INT PRIMARY KEY IDENTITY(1,1),
    que_id INT REFERENCES question(que_id),
    Stu_id INT REFERENCES Student(stId),
    answer_text TEXT,
    iscorrect BIT,
    mark DECIMAL(5,2)
);
--تحديث للجدول
ALTER TABLE answer
ADD choice_id INT;
ALTER TABLE answer
ADD CONSTRAINT FK_answer_choice
FOREIGN KEY (choice_id) REFERENCES choices(choice_id)
--جدول choices:
CREATE TABLE choices (
    choice_id INT PRIMARY KEY IDENTITY(1,1),
    que_id INT REFERENCES question(que_id),
    choice_text NVARCHAR(255) NOT NULL
)
-- الأسئلة في بنك الامتحان
CREATE TABLE exampool (
    poolid INT PRIMARY KEY IDENTITY(1,1),
    exam_id INT REFERENCES Exam(Exam_id),
    que_id INT REFERENCES question(que_id),
    CourseID INT REFERENCES Course(courseID),
    timedate DATETIME
);

-- الجدول اللي بيحدد الطالب او المدرس او المدير بيسجل ازاي
CREATE TABLE logged_as (
    use_id INT PRIMARY KEY,
    mgr_id INT REFERENCES Training_manager(manId),
    stu_id INT REFERENCES Student(stId),
    ins_id INT REFERENCES Instructor(insId),
    FOREIGN KEY (use_id) REFERENCES Users(userId)
);

-- أرقام المدرسين
CREATE TABLE ins_phone (
    ins_id INT REFERENCES Instructor(insId),
    ins_phone VARCHAR(20),
    PRIMARY KEY (ins_id, ins_phone)
);

-- أرقام الطلبة
CREATE TABLE st_phone (
    st_id INT REFERENCES Student(stId),
    st_phone VARCHAR(20),
    PRIMARY KEY (st_id, st_phone)
);
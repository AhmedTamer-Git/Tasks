-- Add users with different roles
INSERT INTO Users (userName, email, PasswordHash, userRole)
VALUES 
('admin1', 'admin@exam.com', 'hashed_password_123', 'Admin'),
('trainer1', 'trainer@exam.com', 'hashed_password_123', 'Training_manager'),
('instructor1', 'instructor1@exam.com', 'hashed_password_123', 'Instructor'),
('instructor2', 'instructor2@exam.com', 'hashed_password_123', 'Instructor'),
('student1', 'student1@exam.com', 'hashed_password_123', 'Student'),
('student2', 'student2@exam.com', 'hashed_password_123', 'Student'),
('student3', 'student3@exam.com', 'hashed_password_123', 'Student');

-- Add branches
INSERT INTO Branch (BranchName, City)
VALUES 
('Cairo', 'Cairo'),
('Alexandria', 'Alexandria'),
('Mansoura', 'Mansoura');

-- Add intakes
INSERT INTO Intake (IntakeNumber, StartDate, EndDate, BranchID)
VALUES 
('D001', '2023-01-01', '2023-06-30', 1),
('D002', '2023-07-01', '2023-12-31', 1),
('A001', '2023-01-01', '2023-06-30', 2);

-- Add tracks
INSERT INTO Track (TrackName, BranchID)
VALUES 
('Web Development', 1),
('Data Science', 1),
('Cybersecurity', 2);

-- Link tracks to intakes
INSERT INTO TrackIntake (TrackID, IntakeID)
VALUES 
(1, 1),
(2, 1),
(1, 2),
(3, 3);

-- Add training manager
INSERT INTO Training_manager (Fname, Lname, email, UserID)
VALUES ('Mohamed', 'Ali', 'trainer@exam.com', 2);

-- Add instructors
INSERT INTO Instructor (Fname, Lname, email, phone, UserID)
VALUES 
('Ahmed', 'Mahmoud', 'instructor1@exam.com', '01012345678', 3),
('Iman', 'Saad', 'instructor2@exam.com', '01087654321', 4);

-- Add students
INSERT INTO Student (Fname, Lname, email, nationalID, phone, birthDate, gender, UserID, IntakeID, TrackID)
VALUES 
('Ali', 'Mohamed', 'student1@exam.com', '29801011234567', '01111111111', '2000-01-01', 'Male', 5, 1, 1),
('Mariam', 'Ahmed', 'student2@exam.com', '29902021234567', '01111111112', '2000-02-02', 'Female', 6, 1, 2),
('Khaled', 'Ibrahim', 'student3@exam.com', '30003031234567', '01111111113', '2001-03-03', 'Male', 7, 3, 3);

-- Add courses
INSERT INTO Course (courseName, description, maxDegree, minDegree)
VALUES 
('Database Fundamentals', 'Introduction to SQL databases', 100, 50),
('Web Programming', 'Learn HTML, CSS, JavaScript', 100, 50),
('Data Analysis', 'Data analysis with Python', 100, 50);

-- Assign instructors to courses
INSERT INTO Course_Teach_By_Instructor (CourseID, InstructorID)
VALUES 
(1, 1), -- Ahmed teaches Database
(2, 1), -- Ahmed teaches Web Programming
(3, 2); -- Iman teaches Data Analysis

-- Add questions
INSERT INTO question (que_text, que_type, accanswer, corranswer, crs_id)
VALUES 
-- Multiple Choice questions
('What is the query language used in relational databases?', 'Multiple Choice', 'SQL,NoSQL,HTML,Python', 'SQL', 1),
('Which of the following is not a DBMS?', 'Multiple Choice', 'MySQL,Oracle,MongoDB,React', 'React', 1),
-- True/False questions
('Tables in SQL contain rows and columns', 'True & False', NULL, 'True', 1),
('NoSQL means no SQL at all', 'True & False', NULL, 'False', 1),
-- Essay questions
('Explain the difference between PRIMARY KEY and FOREIGN KEY', 'Text', 'Primary key uniquely identifies a row, while foreign key links to primary key in another table', NULL, 1),
('What are the advantages of using stored procedures?', 'Text', 'Performance improvement, security, data complexity abstraction, reusability', NULL, 1);



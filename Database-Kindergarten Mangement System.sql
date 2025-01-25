/*---------------------------Osamah Gamal Mohammed Esmail----------------------*/

create database Kindergarten_Mangement_System


--[Kindergarten Mangement System]

/*table empoyees  جدول الموظفين*/
create table Employees
(
e_id int identity(100000000,1)  primary key,
--1 job_id FK from table Jobs                                      اسم الوظيفة بيربط بجدول الوظائف
job_id int not null,

e_name varchar(50) not null,
--2  e_gender FK  from table genders                                   نوع الجنس يربط بجدول الجنس
gender_id int not null,



e_age int not null,
e_personal_card image not null,
e_ceirtificate image not null,

e_address varchar(50) not null,
e_phone varchar(15) unique not null,
e_salary numeric(9,2) not null,

--this driving_license but to driver-> (not null) .  - other null
-- صورة رخصة القيادة مطلوبة فقط من الموظف السائق اما البقيه ليس بالضروري
driving_license image

);

--1           FK for  Employees  from Jobs
alter table Employees
add constraint FK_employee_jops foreign key (job_id) references Jobs(job_id); -- تم الربط 

--2           FK for  Employees  from Genders
alter table Employees
add constraint FK_employee_gender foreign key (gender_id) references Genders(G_id); -- تم الربط 



--semester_works                      جدول اعمال الفصل
create table Semester_works
(
sw_id int identity(1,1)  primary key, 

--1 student_id FK  from table students                   يربط بجدول الطلاب 
student_id int not null,

--2 student_level FK  from table levels              يربط بجدول المستويات    
level_id int not null,

--3 student_subject FK  from table  subjects            يربط بجدول المواد
subject_id int not null,

test1 float not null,
test2 float not null,
final float not null,
total float not null,

);
--1           FK for  Semester_works  from Students
alter table Semester_works
add constraint FK_semester_student foreign key (student_id) references Students(student_id); -- تم الربط 

--2           FK for  Semester_works  from Levels
alter table Semester_works
add constraint FK_semester_levels foreign key (level_id) references Levels(l_id); -- تم الربط 

--3           FK for  Semester_works  from Subjects
alter table Semester_works
add constraint FK_semester_subjects foreign key (subject_id) references Subjects(subject_id); -- تم الربط 




/*---------------------------ذياب القادري----------------------*/

--table levels 
create table Levels(
l_id int identity(1,1) primary key,
l_name varchar(30) not null,
l_number int not null
);


--table Genders 
create table Genders(
g_id int identity(1,1) primary key,
g_name varchar(30) not null,
);


--table Classes_schedule
create table Classes_schedule(
c_id int identity(1,1) primary key,
c_name varchar(30) not null,
c_number int not null
);







/*---------------------------ملكه العكبري----------------------*/

--table Storess
create table Stores(
store_id int identity(1,1) primary key,
store_name varchar(30) not null,

--1 empoyee_id FK from table Employees
employee_id int not null

);

--1           FK for  Stores  from Employees
alter table Stores
add constraint FK_store_employee foreign key (employee_id) references Employees(e_id); -- تم الربط 




--table Jobs
create table Jobs
(
job_id int identity(1,1) primary key,
job_name varchar(30) not null

);






/*---------------------------مهدي امذيب----------------------*/

--table Students
create table Students
(
student_id  int identity(20000000,1)primary key,
student_name varchar(50) not null,

 --1 fk from table Genders
gender_id int not null, 

student_birth varchar(11) not null ,
student_photo image not null,
student_birth_certificaion image not null,
student_examination image not null,

 --2 fk from table Levels
level_id varchar(30) not null,

student_address varchar(30) not null,
student_state varchar(30) not null,
student_fees numeric(8,2) not null,

--3 fk from table Classes_schedule
class_id int not null 


);

--1           FK for  Students  from Genders
alter table Students
add constraint FK_student_gender foreign key (gender_id) references Genders(g_id); -- تم الربط 

--2           FK for  Students  from Levels
alter table Students
add constraint FK_student_level foreign key (gender_id) references Levels(l_id); -- تم الربط 

--3           FK for  Students  from Classes_schedule
alter table Students
add constraint FK_student_Classes_schedule foreign key (gender_id) references Classes_schedule(c_id); -- تم الربط 






-- table Guadians
create table Guadians
(
guadian_id int identity(1,1) primary key,
guadian_name varchar(50) not null,
--1 fk from table Genders
gender_id int not null,  
age int not null,
personal_card image not null,
phone varchar(15)  unique not null,
guadian_address varchar(50) not null
);

--1           FK for  Guadians  from Employees
--alter table Buses
--add constraint FK_guadian_gender foreign key (gender_id) references Genders(g_id); -- تم الربط 








/*---------------------------زياد عبدالحكيم----------------------*/

--table Buses
create table Buses
(
b_id int identity(1,1) primary key,
b_type varchar(20) not null,
b_plat_number int not null,
b_ownership_paper image not null,

--1 FK from table table Employees
employee_id int not null,
);

--    drop column gender_id from table buses


--1           FK for  Buses  from Employees
alter table Buses
add constraint FK_bus_levels foreign key (employee_id) references Employees(e_id); -- تم الربط 







--table Subjects
create table Subjects
(
subject_id int identity(1,1) primary key,
subject_name varchar(30) not null,

--1 fk from table Levels
l_id int not null,
--2 fk from table Employees
employee_id int not null
);

--1           FK for  Subjects  from Levels
alter table Subjects
add constraint FK_subject_levels foreign key (l_id) references Levels(l_id); -- تم الربط

--2           FK for  Subjects  from Employees
alter table Subjects
add constraint FK_subject_employees foreign key (employee_id) references Employees(e_id); -- تم الربط




/*---------- Tables M-M ----------*/

--table Students and Guadians   --> M-M
create table Students_Guadians
(
--1
student_id int not null,
--2
guadian_id int not null
);

--1           FK for  Students_Subjects  from Students
alter table Students_Guadians
add constraint FK_student_guadian_1_MM foreign key (student_id) references Students(student_id); --  تم الربط  ولاكن قيد الماربحعة  

--2           FK for  Students_Subjects  from Subjects
alter table Students_Guadians
add constraint FK_student_guadian_2_MM foreign key (guadian_id) references Guadians(guadian_id);--  تم الربط  ولاكن قيد الماربحعة  










--table Students and Subjects   --> M-M
create table Students_Subjects
(
--1
student_id int not null,
--2
subject_id int not null
);

--1           FK for  Students_Subjects  from Students
alter table Students_Subjects
add constraint FK_student_subject_1_MM foreign key (student_id) references Students(student_id); --  تم الربط  ولاكن قيد الماربحعة  


--2           FK for  Students_Subjects  from Subjects
alter table Students_Subjects
add constraint FK_student_subject_2_MM foreign key (subject_id) references Subjects(subject_id); --  تم الربط  ولاكن قيد الماربحعة  








--table Students and Subjects   --> M-M
create table Students_Semester_works_MM
(
--1
student_id int not null,
--2
semester_work_id int not null
);

--1           FK for  Students_Semester_works_MM  from Students
alter table Students_Semester_works_MM
add constraint FK_student_SW1_MM foreign key (student_id) references Students(student_id); --  تم الربط  ولاكن قيد الماربحعة  


--2           FK for  Students_Semester_works_MM  from Semester_works
alter table Students_Semester_works_MM
add constraint FK_student_SW2_MM foreign key (semester_work_id) references Semester_works(sw_id); --  تم الربط  ولاكن قيد الماربحعة  














/*-----------   log in form  -------------*/
--log in users
create table Passwords
(

P_id int identity(1,1) primary key,
--1  employee number-------------
e_id int not null,
pass varchar(20) not null,
forget varchar(30) not null
);

--1           FK for  Students_Semester_works_MM  from Students
alter table Passwords
add constraint FK_pass_emp foreign key (e_id) references Employees(e_id);  






-----------------------#جدول خاص بالسندات#------------------------------
create table Bonds
(
Student_id int primary key not null,
Student_name varchar(50) not null,
--date and time
date_time datetime not null,
bond_photo image not null
);
























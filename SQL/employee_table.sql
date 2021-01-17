create database rms;

use rms;

create table employee(
	empId int not null AUTO_INCREMENT,
    fname varchar(30) not null,
    sname varchar(30) not null,
    department varchar(100) not null,
    position varchar(100),
    qualification varchar(200),
    interests varchar(250),
    phone varchar(50), -- assuming phone can have characters like +
    email varchar(100) not null unique,
    photo varchar(200),
    
    CONSTRAINT pk_employees primary key(empId)
);



insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Nessy', 'Strathman', 'Computer Science and Information Systems', 'Lecturer', 'MSc, Tallinn University of Technology', 'Honeypots In Web Systems', '+81 (393) 288-7840', 'ms@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Etheline', 'Callister', 'Forensic Science', 'Lecturer', 'MSc, Crichton College', 'Evolutionary Biology', '+55 (621) 330-8567', 'ec@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Eleen', 'Duffill', 'Forensic Sciencet', 'Lecturer', 'PhD, St. Joseph University Beirut', 'Healthcare', '+260 (467) 374-3395', 'ed@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Hannie', 'Snowman', 'Computer Science and Information Systems', 'Senior Lecturer', 'PhD, Breyer State University (Virtual University)', 'Sports Play-by-play using machine learning', '+381 (465) 494-2265', 'hs@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Bob', 'Carlone', 'Forensic Science', 'Senior Lecturer', 'MSc, Université Chrétienne Bilingue du Congo', 'Forensic Analysis using Computers', '+27 (889) 321-3772', 'bc@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Nancy', 'Sivier', 'Mechanical Engineering', 'Senior Lecturer', 'PhD, College of Engineering America', '', '+86 (430) 425-1070', 'ns@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Roxie', 'Hellens', 'Computer Science and Information Systems', 'PhD, Professor', 'Hong Kong Academy for Computing ', 'Smart Metering', '+63 (445) 147-1316', 'rh@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Arda', 'Ferretti', 'Mechanical Engineering', 'Professor', 'PhD, Universidade de Passo Fundo', 'RF Systems', '+86 (331) 786-2478', 'af@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Augustin', 'Sinkings', 'Mechanical Engineering', 'PhD, Professor', 'Shanghai Second Polytechnic University', 'EGL', '+33 (243) 511-4136', 'as@gmail.com');

insert into employee (fname, sname, department, position, qualification, interests, phone, email) values ('Colet', 'Fitchen', 'Computer Science and Information Systems', 'PhD, Associate Professor', 'New England School of Communications', 'HTML Scripting', '+33 (339) 201-1574', 'cfgmail.com');



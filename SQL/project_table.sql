use rms;

create table project(
	pId int AUTO_INCREMENT,
    title varchar(200) not null,
    leader int not null,
    fsource varchar(100) not null, -- BIUST, Private, Public
    famount double not null,
    
    CONSTRAINT pk_project PRIMARY key (pId),
    CONSTRAINT fk_project_leader FOREIGN KEY (leader) REFERENCES employee(empId)
);


INSERT into project (title, leader, fsource, famount) values ('Forensic Science Evolution In Emerging Economies', 3, 'BIUST', 150000.00);

INSERT into project (title, leader, fsource, famount) values ('Human Body Decay', 5, 'Private', 250000.00);

INSERT into project (title, leader, fsource, famount) values ('Computational Fingerprint Analysis', 7, 'Private', 350000.00);

INSERT into project (title, leader, fsource, famount) values ('Bi-Focal Lenses', 2, 'Public', 350000.00);

INSERT into project (title, leader, fsource, famount) values ('Nonochip Development', 1, 'BIUST', 300000.00);

INSERT into project (title, leader, fsource, famount) values ('Genetic Algorithms', 4, 'Public', 100000.00);

INSERT into project (title, leader, fsource, famount) values ('Machine Learning in Africa', 10, 'BIUST', 200000.00);

INSERT into project (title, leader, fsource, famount) values ('Deep Learning Optimsation', 8, 'Private', 150000.00);
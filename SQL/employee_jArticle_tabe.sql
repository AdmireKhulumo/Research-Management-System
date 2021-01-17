use rms;

create table employee_jArticle(
	empId int,
    title varchar(200) not null,
    jname varchar(200) not null,
    
    CONSTRAINT fk_title_emp_jArt FOREIGN KEY (jname,title) REFERENCES jArticle(jname,title),
    CONSTRAINT fk_empId_emp_jArt FOREIGN KEY (empId) REFERENCES employee(empId),
    CONSTRAINT PRIMARY KEY (empId, title, jname)
);
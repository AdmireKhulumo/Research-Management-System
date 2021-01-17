use rms;

create table employee_cArticle(
	empId int,
    title varchar(200) not null,
    cname varchar(200) not null,
    
    CONSTRAINT fk_title_emp_cArt FOREIGN KEY (cname,title) REFERENCES cArticle(cname,title),
    CONSTRAINT fk_empId_emp_cArt FOREIGN KEY (empId) REFERENCES employee(empId),
    CONSTRAINT PRIMARY KEY (empId, title, cname)
);
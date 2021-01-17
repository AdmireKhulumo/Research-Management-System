use rms;

create table employee_bookChapter(
	empId int,
    chTitle varchar(200) not null,
    bkTitle varchar(200) not null,
    
    CONSTRAINT fk_title_emp_bk FOREIGN KEY (bkTitle, chTitle) REFERENCES bookChapter(bkTitle, chTitle),
    CONSTRAINT fk_empId_emp_bk FOREIGN KEY (empId) REFERENCES employee(empId),
    CONSTRAINT PRIMARY KEY (empId, bkTitle, chTitle)
);
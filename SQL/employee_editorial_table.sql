use rms;

create table employee_editorial(
    empId int,
		activity varchar(250),
    publication varchar(100),
    
    CONSTRAINT fk_empId_emp_ed FOREIGN KEY (empId) REFERENCES employee(empId),
    CONSTRAINT fk_act_pub__emp_ed FOREIGN KEY (activity, publication) REFERENCES editorial(activity, publication),
    CONSTRAINT primary key (empId, activity, publication)
);

insert into employee_editorial (empId, activity, publication) values (3, 'Journal article review', 'Forensic Science Conference');
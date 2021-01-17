use rms;

create table employee_project(
	empId int not null,
    pId int not null,
    
    CONSTRAINT fk_empId FOREIGN KEY (empId) REFERENCES employee(empId),
    CONSTRAINT fk_pId FOREIGN KEY (pId) REFERENCES project(pId),
    CONSTRAINT PRIMARY KEY (empId, pId)
);

INSERT INTO employee_project (empId, pId) VALUES (3,1);
INSERT INTO employee_project (empId, pId) VALUES (9,1);
INSERT INTO employee_project (empId, pId) VALUES (5,1);

INSERT INTO employee_project (empId, pId) VALUES (5,2);
INSERT INTO employee_project (empId, pId) VALUES (3,2);

INSERT INTO employee_project (empId, pId) VALUES (7,3);
INSERT INTO employee_project (empId, pId) VALUES (4,3);
INSERT INTO employee_project (empId, pId) VALUES (8,3);

INSERT INTO employee_project (empId, pId) VALUES (2,4);
INSERT INTO employee_project (empId, pId) VALUES (3,4);

INSERT INTO employee_project (empId, pId) VALUES (1,5);
INSERT INTO employee_project (empId, pId) VALUES (8,5);
INSERT INTO employee_project (empId, pId) VALUES (9,5);

INSERT INTO employee_project (empId, pId) VALUES (3,6);
INSERT INTO employee_project (empId, pId) VALUES (4,6);

INSERT INTO employee_project (empId, pId) VALUES (10,7);
INSERT INTO employee_project (empId, pId) VALUES (6,7);
INSERT INTO employee_project (empId, pId) VALUES (7,7);

INSERT INTO employee_project (empId, pId) VALUES (8,8);
INSERT INTO employee_project (empId, pId) VALUES (1,8);
INSERT INTO employee_project (empId, pId) VALUES (10,8);
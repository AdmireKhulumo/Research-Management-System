use rms;

create table project_funder(
	pId int,
    fId int,
    
    CONSTRAINT fk_pId_p_f FOREIGN KEY (pId) REFERENCES project(pId),
    CONSTRAINT fk_fId FOREIGN KEY (fId) REFERENCES funder(fId),
    CONSTRAINT pk_p_f PRIMARY KEY (pId,fId)
);

--A project can have more than one funder, and each funder can fund more than one project
insert into project_funder (pId, fId) values (1,3);
insert into project_funder (pId, fId) values (1,1);
insert into project_funder (pId, fId) values (1,4);

insert into project_funder (pId, fId) values (2,2);
insert into project_funder (pId, fId) values (2,3);

insert into project_funder (pId, fId) values (3,1);

insert into project_funder (pId, fId) values (4,4);
insert into project_funder (pId, fId) values (4,1);

insert into project_funder (pId, fId) values (5,3);
insert into project_funder (pId, fId) values (5,4);
insert into project_funder (pId, fId) values (5,2);

insert into project_funder (pId, fId) values (6,4);

insert into project_funder (pId, fId) values (7,3);
insert into project_funder (pId, fId) values (7,2);

insert into project_funder (pId, fId) values (8,1);
insert into project_funder (pId, fId) values (8,4);

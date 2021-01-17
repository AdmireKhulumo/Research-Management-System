use rms;

create table funder(
	fId int AUTO_INCREMENT,
    name varchar(50),
    organisation varchar(100),
    email varchar(100),
    
    CONSTRAINT pk_funder primary key (fId)
);

insert into funder(name, organisation, email) values ('Admire Khulumo', 'Tech Ventures PTY LTD', 'ak@gmail.com');
insert into funder(name, organisation, email) values ('Dorothy Miles', 'SELF', 'dm@gmail.com');
insert into funder(name, organisation, email) values ('Kagisanyo Mosupi', 'BIUST', 'km@gmail.com');
insert into funder(name, organisation, email) values ('Bridget Mawa', 'Science Supporters', 'bm@gmail.com');
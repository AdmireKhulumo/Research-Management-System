use rms;

create table editorial(
	activity varchar(250),
    publication varchar(100),
    url varchar(250),
    date varchar(100),
    
    CONSTRAINT PRIMARY KEY (activity, publication)
);

insert into editorial (activity, publication, url, date) values ('Journal article review', 'Forensic Science Conference', 'www.fsc.com', '12/10/2020');
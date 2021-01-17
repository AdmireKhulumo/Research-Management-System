USE rms;

create table cArticle(
	pId int not null,
    title varchar(200) not null,
    cname varchar(200) not null,
    pages int not null,
    publisher varchar(100) not null,
    location varchar(200) not null,
    year int not null,
    
    CONSTRAINT pk_cArticle PRIMARY KEY (cname, title),
    CONSTRAINT fk_cArticle_pId FOREIGN KEY (pId) REFERENCES project(pId)
);

insert INTO cArticle(pId, title, cname, publisher, location, pages, year)
	values(1, 'Cost of Forensic Analysis', 'Forensics Anonymous Conference', 'Penguin', 'London, UK', 4, 2017);

insert INTO cArticle(pId, title, cname, publisher, location, pages, year)
	values(1, 'Cheaper Forensic Analysis', 'Science Po', 'Mayther Publishers', 'New York, USA', 6, 2018);
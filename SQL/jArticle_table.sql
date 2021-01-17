USE rms;

create table jArticle(
	pId int not null,
    title varchar(200) not null,
    jname varchar(200) not null,
    volume int not null,
    issue int not null,
    pages int not null,
    year int not null
    
    CONSTRAINT pk_jArticle PRIMARY KEY (jname, title),
    CONSTRAINT fk_jArticle_pId FOREIGN KEY (pId) REFERENCES project(pId)
);

insert INTO jArticle(pId, title, jname, volume, issue, pages, year)
	values(1, 'The Impact of GDP on Forensic Analysis', 'Harvard Business Review', 2, 5, 3, 2019);
    
insert INTO jArticle(pId, title, jname, volume, issue, pages, year)
	values(1, 'Forensics and the Economy', 'IEEE', 1, 7, 5, 2020);
    
insert INTO jArticle(pId, title, jname, volume, issue, pages, year)
	values(1, 'Forensics 101', 'Science Direct', 2, 3, 8, 2015);
USE rms;

create table bookChapter(
	pId int not null,
    chTitle varchar(200) not null,
    bkTitle varchar(200) not null,
    publisher varchar(200) not null,
    pages int not null,
    year int not null,
    
    CONSTRAINT pk_bookChapter PRIMARY KEY (bkTitle, chTitle),
    CONSTRAINT fk_bookChapter_pId FOREIGN KEY (pId) REFERENCES project(pId)
);

insert INTO bookChapter(pId, chTitle, bkTitle, publisher, pages, year)
	values(1, 'Forensics and the Economy', 'Forensics Today', 'McMillan', 35, 2018);
    
insert INTO bookChapter(pId, chTitle, bkTitle, publisher, pages, year)
	values(4, 'Impact of Lenses', 'The Human Eye\'s Vision', 'Penguin', 15, 2016);
/*CREATE DATABASE TEST;*/


/*CREATE TABLE TEST.Test_schema.VISITS(
		visit_id INT PRIMARY KEY IDENTITY (1,1),
		first_name VARCHAR(50),
		last_name VARCHAR(50),
		visited_at DATETIME,
		phone_no varchar(20),
		store_id int not null, 
);*/
/*CREATE TABLE TEST.hr.PERSON(
	person_id INT IDENTITY (1,1) PRIMARY KEY ,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	gender char(1) NOT NULL
);*/
/*
INSERT INTO hr.PERSON(first_name, last_name, gender)
OUTPUT inserted.person_id
VALUES ('JOHN', 'DEO', 'M');*/

/*insert into hr.PERSON(first_name, last_name, gender)
output inserted.person_id
values('honey', 'ch', 'F');*/

/*create table TEST.hr.position(
	position_id int identity(1,1) primary key,
	position_name VARCHAR(250) not null
);

create table TEST.hr.person_position(
	person_id int,
	position_id int,
	primary key(person_id, position_id),
	foreign key(person_id) references hr.PERSON(person_id),
	FOREIGN KEY (position_id) REFERENCES hr. position (position_id)
);*/

/*BEGIN TRANSACTION
    BEGIN TRY
        -- insert a new person
        INSERT INTO TEST.hr.person(first_name,last_name, gender)
        VALUES('Joan','Smith','F');
 
        -- assign the person a position
        INSERT INTO TEST.hr.person_position(person_id, position_id)
        VALUES(@@IDENTITY, 1);
    END TRY
    BEGIN CATCH
         IF @@TRANCOUNT > 0  
            ROLLBACK TRANSACTION;  
    END CATCH
 
    IF @@TRANCOUNT > 0  
        COMMIT TRANSACTION;
GO*/

/*INSERT INTO TEST.hr.PERSON(first_name, last_name, gender)
output inserted.person_id
values('peter', 'parker', 'm');*/

/*create table TEST.sales.sales_quatations(
	quatation_no int primary key identity,
	valid_from date not null,
	valid_to date not null
);*/

/*alter table TEST.sales.sales_quatations
add description varchar(250) not null;*/

/*alter table TEST.sales.sales_quatations
add amount decimal (10, 2) not null,
	Customer_name varchar(50) not null;
Go*/

/*create TABLE TEST.hr.t1(c int)
insert into TEST.hr.t1
values (1),
		(2),
		(3);*/

/*alter table TEST.hr.t1 alter column c varchar(50);*/

/*alter table TEST.hr.t1 alter column c INT*/

/*alter table TEST.hr.t1 alter column c varchar(50);
insert into TEST.hr.t1// giving error here
values ('@');*/

/*create table t2(c varchar(20));*/
/*insert into t2
values
	('SQL Server'),
    ('Modify'),
    ('Column');*/

	/*alter table t2 alter column c varchar(50);*/

	/*alter table t2 alter column c varchar(5);*/


	insert into TEST.hr.PERSON(first_name, last_name,gender)
	values 
	('jahsf'),
	('g'),
	('m');















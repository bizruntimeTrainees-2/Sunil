create table production_parts(
	part_id int not null,
	part_name varchar(100)
);

insert into production_parts(part_id, part_name)
values(1, 'frame'), (2, 'Head Tube'), (3, 'Griper'), (4, 'Shock Absorber'), (5, 'Fork');

select 
	part_id,
	part_name
	from production_parts
	where part_id = 5;

	create table production_parts_prices(
			part_id int,
			valid_from date,
			price decimal (10,2) not null,
			primary key (part_id, valid_from));


create clustered index i_part_id
on production_parts(part_id);

select
	part_id,
	part_name
from 
	production_parts
where part_name = 'Griper';

create index i_part_name
on production_parts(part_name);


create unique index A_part_name
on production_parts(part_name);

create table t1( a int, b int, c int);

create unique index i_abc
on t1(a, b, c);

insert into t1(a, b, c)values(1,2,3);
insert into t1(a,b,c) values(1,2,3);
drop table t1

drop index IF EXISTS i_abc
on t1;


EXEC sp_rename
	i_abc,
	Z_def;

create table production_products(id int not null, product_name varchar(100), product_price int not null);

insert into production_products(id, product_name, product_price)
values(1, 'frame', 1000), (2, 'Head Tube', 2000), (3, 'Griper', 5000), (4, 'Shock Absorber', 5000), (5, 'Fork', 1500);

select 
	product_name,
	product_price
from 
	production_products
order by
	product_name;

/*CREATE PROCEDURE uspProductList
AS 
BEGIN
    SELECT 
        product_name, 
        product_price
    FROM 
        production.products
    ORDER BY 
        product_name;
END;*/


create table production(id int not null, product_name varchar(100), product_price int not null, model_year int);

insert into production(id, product_name, product_price, model_year)
values(1, 'frame', 1000, 2000), (2, 'Head Tube', 2000, 2019), (3, 'Griper', 5000, 2020), (4, 'Shock Absorber', 5000, 2018), (5, 'Fork', 1500, 2018);

Declare @model_year  SMALLINT;

SET @model_year = 2018;

SELECT 
		product_name,
		model_year,
		product_price
FROM	
	production
WHERE
	model_year  = @model_year
order by 
		product_name;


BEGIN
	DECLARE @NAME VARCHAR(MAX);

	SELECT TOP 1
			@NAME = product_name
	FROM 
			production
	ORDER BY 
			product_price DESC;
	IF @@ROWCOUNT <> 0
	BEGIN
		PRINT "The most expasive product is: " + @NAME
	END
END

DECLARE @counter int = 1;

WHILE @counter <= 5
BEGIN
	PRINT @COUNTER;
	SET @counter = @counter + 1;
END


DECLARE @count int = 0;

WHILE @count <= 5
BEGIN
	PRINT @COUNT;
	IF @count = 4
			break;
	SET @count = @count + 1;
END


CREATE TABLE TEST.hr.product_audits(
    change_id INT IDENTITY PRIMARY KEY,
    product_id INT NOT NULL,
    product_name VARCHAR(255) NOT NULL,
    brand_id INT NOT NULL,
    category_id INT NOT NULL,
    model_year SMALLINT NOT NULL,
    list_price DEC(10,2) NOT NULL,
    updated_at DATETIME NOT NULL,
    operation CHAR(3) NOT NULL,
    CHECK(operation = 'INS' or operation='DEL')
);



--INSERT INTO
--    TEST.hr.product_audits
--        (
--            product_id,
--            product_name,
--            brand_id,
--            category_id,
--            model_year,
--            list_price,
--            updated_at,
--            operation
--        )

SELECT 
	AVG(price)
from product_details;

select
	MAX(price)
from product_details;


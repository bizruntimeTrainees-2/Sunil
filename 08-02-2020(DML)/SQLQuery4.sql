

create table sales_customers2(
				customer_ID int primary key,
				first_name varchar(50) not null,
				last_name varchar(50) not null,
				phone_number varchar(10) not null,
				email_ID varchar(50),
				address varchar(200) not null);

insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(5,'are','jkgf','avbhu','ZXY@GMAIL.COM','HJTSR');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(1,'asdsf','jasdf','9678899012','vani@GMAIL.COM','jadcherla');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(2,'asdsf','jasdf','9678899012','vani@GMAIL.COM','jadcherla');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(6,'suri','khan','0987563532','suri@GMAIL.COM','banglore');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(7,'poori','nari','6564893739','ramana@GMAIL.COM','banglore');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(8,'mkaliu','novu','9876543210','kumud@GMAIL.COM','chennai');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(9,'lkoiu','gabdk','987123456','bortu@GMAIL.COM','chennai');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(10,'wdsadf','jsfsd','9867546352','kliu@GMAIL.COM','amaravathi');

select * from sales_customers2
delete top(2) from sales_customers2
delete from sales_customers2 where customer_ID = 5
select first_name, last_name from sales_customers2; 
select email_ID from sales_customers2;
select * from sales_customers2 where address= 'banglore';
SELECT first_name, last_name from sales_customers2 order by first_name;

select first_name, last_name from sales_customers2 order by first_name desc;

select first_name, last_name, address from sales_customers2 order by  address, first_name;

select first_name, last_name, address from sales_customers2 order by  address desc, first_name asc;
  
select first_name from sales_customers2 order by LEN(first_name) desc;
 
SELECT first_name FROM sales_customers2 order by first_name OFFSET 5 rows fetch next 5 rows only;

select top 50 percent first_name from sales_customers2 order by first_name asc;

select distinct first_name from sales_customers2
select phone_number from sales_customers2 where phone_number = null

insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(11,'wdsadf','jsfsd','null','kliu@GMAIL.COM','amaravathi');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(12,'wdsadf','jsfsd','null','kliu@GMAIL.COM','amaravathi');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(13,'wdsadf','jsfsd','null','kliu@GMAIL.COM','amaravathi');				
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(14,'wdsadf','jsfsd','null','kliu@GMAIL.COM','amaravathi');
insert into sales_customers2(customer_ID,first_name,last_name,phone_number,email_ID,address) values(15,'wdsadf','jsfsd','null','kliu@GMAIL.COM','amaravathi');

select phone_number, first_name, last_name from sales_customers2 where phone_number ='9678899012' order by first_name, last_name

select customer_ID from sales_customers2 order by customer_ID offset 10 rows fetch next 5 rows only;

delete from sales_customers2 where customer_ID between 11 and 15;

select * from sales_customers2;
create table product_details(product_ID int, product_name varchar(50), barnd_ID int, price int);
alter table product_details
add model_name varchar(50);

insert into product_details(product_ID, product_name, barnd_ID, price ) values(1, 'vivo', 1, 1800);
insert into product_details(product_ID, product_name, barnd_ID, price ) values(2, 'samsung', 1, 1000);
insert into product_details(product_ID, product_name, barnd_ID, price ) values(3, 'mi', 2, 1400);
insert into product_details(product_ID, product_name, barnd_ID, price ) values(4, 'realme', 2, 1040);
insert into product_details(product_ID, product_name, barnd_ID, price ) values(5, 'oppo', 3, 1002);
insert into product_details(product_ID, product_name, barnd_ID, price ) values(6, 'honor', 3, 2000);


delete from product_details where product_ID between 1 and 6;

select * from product_details where barnd_ID = 1 or barnd_ID = 2 and price > 1000 ;


CREATE TABLE candidates(
    id INT PRIMARY KEY IDENTITY,
    fullname VARCHAR(100) NOT NULL
);
 
CREATE TABLE employees(
    id INT PRIMARY KEY IDENTITY,
    fullname VARCHAR(100) NOT NULL
);
INSERT INTO 
    candidates(fullname)
VALUES
    ('John Doe'),
    ('Lily Bush'),
    ('Peter Drucker'),
    ('Jane Doe');
 
 
INSERT INTO 
    employees(fullname)
VALUES
    ('John Doe'),
    ('Jane Doe'),
    ('Michael Scott'),
    ('Jack Sparrow');

    
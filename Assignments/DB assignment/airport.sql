--CREATE DATABASE airport;

--CREATE TABLE airline(
--	air_id int primary key,
--	air_name char(60) not null,
--	phone char(10) not null,
--	contact_email char(20) not null,
--);

--CREATE TABLE flight(
--	flight_id int primary key,
--	gate_num int unique not null,
--	dep_time datetime not null,
--	arrival_time datetime not null,
--	flight_status char(20) not null,
--	air_id int foreign key references airline (air_id),
--);

--CREATE TABLE officer(
--	o_id int primary key,
--	department varchar(40) not null,
--	first_name varchar(40) not null,
--	last_name varchar(40) not null,
--	contact_phone varchar(40) not null,
--	contact_email varchar(40) not null,
--	position varchar(40) not null,
--	cp_id int foreign key references security_cp (cp_id),
--);

--CREATE TABLE security_cp(
--	cp_id int primary key,
--	t_id int foreign key references terminal(t_id),
--	t_name varchar(40),
--	p_capacity float not null,
--	location varchar(40) not null,

--);

--CREATE TABLE terminal (
--	t_id int primary key,
--	location varchar(40) not null,
--	t_name varchar(40) not null,
--	capacity float not null,
--);

--create table passenger(
--	p_id int primary key,
--	gender char(10) not null,
--	email varchar(20) not null,
--	dob date not null,
--	first_name varchar(20) not null,
--	last_name varchar(20) not null,
--	phone_num varchar(20) not null,
--);

--create table baggage(
--	b_id int primary key,
--	b_weight float,
--	p_id int foreign key references passenger(p_id),
--	track_num int not null,
--);

--create table gate(
--	gate_id int primary key,
--	air_id int foreign key references airline(air_id),
--	gate_num int unique not null,
--	t_id int foreign key references termianl(t_id),
--	gate_status varchar(20) not null,
	
--);

--alter table officer add air_id int foreign key references airline(air_id);
--alter table passenger add t_id int foreign key references terminal(t_id);
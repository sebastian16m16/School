SET DATEFORMAT ymd;

create table Patient(
	id int not null identity(1,1) primary key,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	caregiver int
);

create table Activity(

	id int not null identity(1,1) primary key,
	start_time datetime,
	end_time datetime,
	activity_label varchar(50) not null,
	patient int

);

create table Caregiver(

	id int not null identity(1,1) primary key,
	first_name varchar(50) not null,
	last_name varchar(50) not null

);

create table Notification(

	id int not null identity(1,1) primary key,
	notify int not null,
	about int not null

);

alter table Patient add foreign key (caregiver) references Caregiver(id);
alter table Activity add foreign key (patient) references Patient(id);

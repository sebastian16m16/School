
create table Doctor(

	id int not null identity(1,1) primary key,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	birthdate date not null,
	gender char(1) not null,
	address varchar(50) not null,
	medical_record varchar(50) not null,
	

);

create table Caregiver(

	id int not null identity(1,1) primary key,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	birthdate date not null,
	gender char(1) not null,
	address varchar(50) not null,


);

create table Patient(

	id int not null identity(1,1) primary key,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	birthdate date not null,
	gender char(1) not null,
	address varchar(50) not null,
	doctor int not null,
	caregiver int,
	medication_plan int 

);

create table Medication(

	id int not null identity(1,1) primary key,
	name varchar(50) not null,
	side_effect int not null,
	dosage int

);

create table Side_Effect(

	id int not null identity(1,1) primary key,
	detail varchar(50) not null

);

insert into Side_Effect (detail) values ('none');

create table Medication_Plan(

	id int not null identity(1,1) primary key,
	name varchar(50) not null,
	medication int,
	assigned_by int not null

);


alter table Patient add foreign key (doctor) references Doctor(id);
alter table Patient add foreign key (caregiver) references Caregiver(id);
alter table Patient add foreign key (medication_plan) references Medication_Plan(id);

alter table Medication add foreign key (side_effect) references Side_Effect(id);
alter table Medication_Plan add foreign key (Medication) references Medication(id);
alter table Medication_Plan add foreign key (assigned_by) references Doctor(id);



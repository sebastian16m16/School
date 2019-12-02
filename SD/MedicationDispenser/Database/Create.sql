SET DATEFORMAT dmy;

create table Patient(

	id int not null identity(1,1) primary key,
	name varchar(50) not null,
	doctor int

);

create table Doctor(

	id int not null identity(1,1) primary key,
	name varchar(50) not null

);

create table Medication(

	id int not null identity(1,1) primary key,
	name varchar(50) not null

);

create table Medication_Plan(

	id int not null identity(1,1) primary key,
	medication int not null,
	medication_schedule int,
	intakeTime datetime,
);

create table Medication_Schedule(

	id int not null identity(1,1) primary key,
	name varchar(50) not null,
	patient int,
	doctor int

);

create table ReplyData(

	id int not null identity(1,1) primary key,
	patient int,
	medication_Schedule int,
	taken bit,
	
);

alter table patient add foreign key (doctor) references Doctor(id);
alter table Medication_plan add foreign key (medication) references Medication(id);
alter table Medication_plan add foreign key (medication_schedule) references Medication_Schedule(id);

alter table Medication_Schedule add foreign key (patient) references Patient(id);
alter table Medication_Schedule add foreign key (doctor) references Doctor(id);
alter table ReplyData add foreign key (patient) references Patient(id);
alter table ReplyData add foreign key (medication_schedule) references medication_Schedule(id);

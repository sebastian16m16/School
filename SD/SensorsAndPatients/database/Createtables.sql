SET DATEFORMAT dmy;

create table Patient(
	id int not null identity(1,1) primary key,
	start_time date,
	end_time date,
	activity_label varchar(50) not null

);
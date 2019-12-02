insert into Doctor (name) values ('Augustin Valtritiu');

insert into Patient (name, doctor) values ('Valer Iustin', 1);

insert into Medication (name) values ('Algocalmin');

insert into Medication_Schedule (name, doctor, patient) values ('First', 1, 1);

insert into Medication_Plan (medication, medication_schedule, intakeTime) values (1, 1, CURRENT_TIMESTAMP);


insert into Doctor (name) values ('Balbla Arivederci');

insert into Patient (name, doctor) values ('Gurmand Vasile', 2);

insert into Medication (name) values ('Nurofen');

insert into Medication_Schedule (name, doctor, patient) values ('Second', 2, 2);

insert into Medication_Plan (medication, medication_schedule, intakeTime) values (2, 2, CURRENT_TIMESTAMP);


insert into Doctor (name) values ('Celciua Vraci');

insert into Patient (name, doctor) values ('Tastatura Viorel', 3);

insert into Medication (name) values ('Pultratofin');

insert into Medication_Schedule (name, doctor, patient) values ('Third', 3, 3);

insert into Medication_Plan (medication, medication_schedule, intakeTime) values (3, 3, CURRENT_TIMESTAMP);
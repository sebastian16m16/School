insert into Doctor (name) values ('Augustin Valtritiu');

insert into Patient (name, doctor) values ('Valer Iustin', 1);

insert into Medication (name) values ('Algocalmin');

insert into Medication_Schedule (name, doctor, patient) values ('First', 1, 1);

insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (1, 1, 1, CURRENT_TIMESTAMP);


insert into Doctor (name) values ('Balbla Arivederci');

insert into Patient (name, doctor) values ('Gurmand Vasile', 2);

insert into Medication (name) values ('Nurofen');

insert into Medication_Schedule (name, doctor, patient) values ('Second', 2, 2);

insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 2, 2, CURRENT_TIMESTAMP);


insert into Doctor (name) values ('Celciua Vraci');

insert into Patient (name, doctor) values ('Tastatura Viorel', 3);

insert into Medication (name) values ('Pultratofin');

insert into Medication_Schedule (name, doctor, patient) values ('Third', 3, 3);

insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (3, 3, 3, CURRENT_TIMESTAMP);

insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 3, 1, '2019/12/22 13:13:13');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (1, 2, 2, '2019/12/20 11:20:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 1, 1, '2019/12/4 08:33:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (3, 1, 2, '2019/12/06 09:44:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (3, 2, 2, '2019/12/18 12:22:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 3, 2, '2019/12/06 08:11:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 1, 3, '2019/12/09 22:15:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 2, 1, '2019/12/12 13:13:13');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (1, 1, 2, '2019/12/13 11:20:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 1, 1, '2019/12/14 08:33:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (3, 1, 2, '2019/12/15 09:44:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (3, 2, 2, '2019/12/16 12:22:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 2, 2, '2019/12/17 08:11:00');
insert into Medication_Plan (patient, medication, medication_schedule, intakeTime) values (2, 3, 3, '2019/12/12 22:15:00');
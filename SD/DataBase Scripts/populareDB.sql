insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Ion', 'Pop', '1994-Jan-29','M', 'Str.Crizantemelor nr 4');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Anton', 'Paap', '1968-Sep-21','M', 'Str.Vagabonzilor nr 4');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Valer', 'Boicu', '1999-Aug-23','M', 'Str.Pampassi nr 5');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Andrei', 'Popescu', '2000-May-20','M', 'Str.Memorandum nr 1');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Ioana', 'Popcorn', '2001-Jan-22','F', 'Str.Ion Maion nr 13');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Sergiu', 'Autostrada', '1997-Oct-10','M', 'Str.Cana Sparta nr 33');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Andreea', 'Nectar', '1994-Dec-11','F', 'Str.Clujului nr 44');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Memorandista', 'Solevita', '1989-Jul-09','F', 'Str.Viilor nr 23');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Ileana', 'Orange', '1988-Jun-14','F', 'Str.Mortilor nr 1223');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Victorita', 'Rascu', '1995-Aug-30','F', 'Str.Gurmanzilor nr 43');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Victor', 'Negru', '1996-Jan-28','M', 'Str.Telefoanelor nr 32');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Marius', 'Albastru', '1994-Feb-22','M', 'Str.Florilor nr 1');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Ian', 'Roz', '1991-Mar-10','M', 'Str.Petru Jan nr 44');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Petru', 'Televizor', '1990-Apr-01','M', 'Str.De acolo nr 23');
insert into Caregiver (first_name, last_name, birthdate, gender, address) values ('Iulia', 'Ecran', '1984-Apr-01','M', 'Str.De aici nr 123');

insert into Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('Anton', 'Valerantul', '1994-Jan-29', 'GM2','Str.Crizantemelor nr 4', 'M');
insert into Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('Ioana', 'Pop', '1984-Jan-19', 'GM2','Str.Jandarmilor nr 14', 'F');
insert into Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('Lenuta', 'Andreica', '1968-Jan-11', 'GM1','Str.Vascului nr 1', 'F');
insert into Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('Andrei', 'Neamtu', '1988-Apr-29', 'GM1','Str.Negrului Var nr 23', 'M');
insert into Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('Ion', 'Pop', '1964-Feb-19', 'GM1','Str.Somesului nr 41', 'M');
insert into Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('Alexandru', 'Booa', '1944-Dec-12', 'GM2','Str.Maramuresului nr 111', 'M');
insert into Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('Dina', 'Hagai', '1954-Jul-24', 'GM2','Str.Plopilor nr 32', 'F');
insert into Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('Ionut', 'Popescu', '1974-Mar-19', 'GM2','Str.Crizantemelor nr 41', 'M');

insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Lenuta', 'Neamtu', '1988-Apr-29', 'Str.Negrului Var nr 23','M',2, 2);
insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Andrei', 'Pop', '1968-Jan-11', 'Str.Gurmanzilor nr 111','M',3, 1);
insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Ionut', 'Albastru', '1964-Feb-19', 'Str.Jandarmilor nr 14','M',4, 2);
insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Marius', 'Orange', '1954-Jul-24', 'Str.Crizantemelor nr 41','M',5, 6);
insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Andreea', 'Pop', '1994-Jan-29', 'Str.Florilor nr 23','M',7, 12);
insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Ionut', 'Andrei', '1974-Mar-19', 'Str.De aici nr 4','M',4, 13);
insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Ian', 'Neamtu', '1990-Apr-01', 'Str.Mortilor nr 123','M',6, 4);
insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Petru', 'Ecran', '1991-Mar-10', 'Str.Clujului nr 44','M',1, 14);
insert into Patient(first_name, last_name, birthdate, address, gender, doctor,caregiver) values ('Andrei', 'Pop', '1991-Mar-10', 'Str.Gurmanzilor nr 46','M',2, 10);



insert into Side_Effect (detail) values ('Alergie');
insert into Side_Effect (detail) values ('Diaree');
insert into Side_Effect (detail) values ('Transpiratie');
insert into Side_Effect (detail) values ('Iritatie');
insert into Side_Effect (detail) values ('Cancer');
insert into Side_Effect (detail) values ('Sete');
insert into Side_Effect (detail) values ('Foame');
insert into Side_Effect (detail) values ('Varsare');

insert into Medication(name, dosage, side_effect) values ('Algocalmin', 10, 1);
insert into Medication(name, dosage, side_effect) values ('Antinevralgic', 1, 3);
insert into Medication(name, dosage, side_effect) values ('Nurofen', 2, 5);
insert into Medication(name, dosage, side_effect) values ('Valgofin', 25, 8);
insert into Medication(name, dosage, side_effect) values ('Ecnorelin', 10, 6);
insert into Medication(name, dosage, side_effect) values ('Hashpin', 1, 4);
insert into Medication(name, dosage, side_effect) values ('Speish', 2, 4);
insert into Medication(name, dosage, side_effect) values ('OrganoFill', 20, 1);
insert into Medication(name, dosage, side_effect) values ('Zuchinor', 5, 3);
insert into Medication(name, dosage, side_effect) values ('Almasol', 8, 2);
insert into Medication(name, dosage, side_effect) values ('Turnesol', 6, 2);
insert into Medication(name, dosage, side_effect) values ('Gondolir', 4, 6);
insert into Medication(name, dosage, side_effect) values ('Ghinionistil', 1, 5);

insert into Medication_Plan(name ,medication, assigned_by) values ('Vsh1',1, 3);
insert into Medication_Plan(name ,medication, assigned_by) values ('Vgh2',5, 4);
insert into Medication_Plan(name ,medication, assigned_by) values ('Mkk2',3, 6);
insert into Medication_Plan(name ,medication, assigned_by) values ('Njj2',5, 2);
insert into Medication_Plan(name ,medication, assigned_by) values ('Uth1',6, 5);
insert into Medication_Plan(name ,medication, assigned_by) values ('GGG1',4, 4);
insert into Medication_Plan(name ,medication, assigned_by) values ('FD2',3, 6);

insert into Login(username ,password, type, doctor) values ('doctor','doctor', 'D', 1);
insert into Login(username ,password, type, caregiver) values ('caregiver','caregiver','C', 1);
insert into Login(username ,password, type, patient) values ('patient','patient', 'P', 1);

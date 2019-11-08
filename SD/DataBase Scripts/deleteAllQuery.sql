delete from Medication_Plan
DBCC CHECKIDENT (Medication_Plan, RESEED, 0)

delete from Medication
DBCC CHECKIDENT (Medication, RESEED, 0)

delete from Patient
DBCC CHECKIDENT (Patient, RESEED, 0)

delete from Caregiver
DBCC CHECKIDENT (caregiver, RESEED, 0)

delete from Doctor
DBCC CHECKIDENT (Doctor, RESEED, 0)

delete from Side_Effect
DBCC CHECKIDENT (Side_Effect, RESEED, 0)

insert into Side_Effect (detail) values ('None');



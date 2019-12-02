delete from Doctor
DBCC CHECKIDENT (Doctor, RESEED, 0)

delete from Patient
DBCC CHECKIDENT (Patient, RESEED, 0)

delete from Medication
DBCC CHECKIDENT (Medication, RESEED, 0)

delete from Medication_Plan
DBCC CHECKIDENT (Medication_Plan, RESEED, 0)

delete from Medication_schedule
DBCC CHECKIDENT (Medication_schedule, RESEED, 0)

delete from ReplyData
DBCC CHECKIDENT (ReplyData, RESEED, 0)


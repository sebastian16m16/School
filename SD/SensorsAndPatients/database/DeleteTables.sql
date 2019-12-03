delete from Activity
DBCC CHECKIDENT (Activity, RESEED, 0)

delete from Patient
DBCC CHECKIDENT (Patient, RESEED, 0)

delete from Caregiver
DBCC CHECKIDENT (Caregiver, RESEED, 0)

delete from Notification
DBCC CHECKIDENT (Notification, RESEED, 0)





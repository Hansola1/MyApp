USE SportBase

INSERT INTO Roles (Name, AccesRights)
VALUES
('Admin', 'Edit, Add, Delete, View'),
('User', 'View');

INSERT INTO Users (Login, Password, RegistrationDate, Surname, Name, Phone, RoleId)
VALUES
('Admin1', '1234', '2025-05-12', 'Á', 'Á', '89994625486', 1);


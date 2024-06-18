USE master
GO
DROP DATABASE IF EXISTS TM
GO
CREATE DATABASE TM
GO
USE TM
GO

CREATE TABLE [Tank] (
	id int identity primary key,
	modelId int,
	manufactoryId int,
	unitId int,
	isDelete bit,
)
GO
CREATE TABLE [Manufactory] (
	id int identity primary key,
	name nvarchar(50),
	locationId int,
	isDelete bit,
)
GO
CREATE TABLE [Location] (
	id int identity primary key,
	name nvarchar(50),
	isDelete bit,
)
GO
CREATE TABLE [Model] (
	id int identity primary key,
	weight int,
	maxSpeed int,
	detail nvarchar(255),
	maxNoDriver int,
	ammoId int,
	price int,
	name nvarchar(50),
	shootingRange int,
	isDelete bit,
)
GO
CREATE TABLE [Ammo] (
	id int identity primary key,
	name nvarchar(50),
	price int,
	weight int,
	isDelete bit,
)
GO
CREATE TABLE [Unit] (
	id int identity primary key,
	name nvarchar(50),
	location nvarchar(50),
	isDelete bit,
)
GO
CREATE TABLE [Driver] (
	id int identity primary key,
	idCard char(12),
	name nvarchar(50),
	phone nvarchar(10),
	unitId integer,
	isDelete bit,
)
GO
CREATE TABLE [History] (
	id int identity primary key,
	fromUnitId int,
	toUnitId int,
	tankId int,
	date date,
	isDelete bit,
)
GO
CREATE TABLE [TankDriver] (
	id int identity primary key,
	tankId int,
	driverId int,
	isDelete bit,
)
GO
CREATE TABLE [Role] (
	id int identity primary key,
	description char(2),
	isDelete bit,
)
GO
CREATE TABLE [User] (
	id int identity primary key,
	username varchar(20),
	password varchar(20),
	roleId int,
	isDelete bit,
)
GO
CREATE TABLE [UnitManager] (
	id int identity primary key,
	userId int,
	unitId int,
	isDelete bit,
)
GO

ALTER TABLE [Tank] WITH CHECK ADD CONSTRAINT [Tank_fk0] FOREIGN KEY ([modelId]) REFERENCES [Model]([id])
ALTER TABLE [Tank] CHECK CONSTRAINT [Tank_fk0]
ALTER TABLE [Tank] WITH CHECK ADD CONSTRAINT [Tank_fk1] FOREIGN KEY ([manufactoryId]) REFERENCES [Manufactory]([id])
ALTER TABLE [Tank] CHECK CONSTRAINT [Tank_fk1]
ALTER TABLE [Tank] WITH CHECK ADD CONSTRAINT [Tank_fk2] FOREIGN KEY ([unitId]) REFERENCES [Unit]([id])
ALTER TABLE [Tank] CHECK CONSTRAINT [Tank_fk2]
ALTER TABLE [Manufactory] WITH CHECK ADD CONSTRAINT [Manufactory_fk0] FOREIGN KEY ([locationId]) REFERENCES [Location]([id])
ALTER TABLE [Manufactory] CHECK CONSTRAINT [Manufactory_fk0]
ALTER TABLE [Model] WITH CHECK ADD CONSTRAINT [Model_fk0] FOREIGN KEY ([ammoId]) REFERENCES [Ammo]([id])
ALTER TABLE [Model] CHECK CONSTRAINT [Model_fk0]
ALTER TABLE [Driver] WITH CHECK ADD CONSTRAINT [Driver_fk0] FOREIGN KEY ([unitId]) REFERENCES [Unit]([id])
ALTER TABLE [Driver] CHECK CONSTRAINT [Driver_fk0]
ALTER TABLE [History] WITH CHECK ADD CONSTRAINT [History_fk0] FOREIGN KEY ([fromUnitId]) REFERENCES [Unit]([id])
ALTER TABLE [History] CHECK CONSTRAINT [History_fk0]
ALTER TABLE [History] WITH CHECK ADD CONSTRAINT [History_fk1] FOREIGN KEY ([toUnitId]) REFERENCES [Unit]([id])
ALTER TABLE [History] CHECK CONSTRAINT [History_fk1]
ALTER TABLE [History] WITH CHECK ADD CONSTRAINT [History_fk2] FOREIGN KEY ([tankId]) REFERENCES [Tank]([id])
ALTER TABLE [History] CHECK CONSTRAINT [History_fk2]
ALTER TABLE [TankDriver] WITH CHECK ADD CONSTRAINT [TankDriver_fk0] FOREIGN KEY ([tankId]) REFERENCES [Tank]([id])
ALTER TABLE [TankDriver] CHECK CONSTRAINT [TankDriver_fk0]
ALTER TABLE [TankDriver] WITH CHECK ADD CONSTRAINT [TankDriver_fk1] FOREIGN KEY ([driverId]) REFERENCES [Driver]([id])
ALTER TABLE [User] WITH CHECK ADD CONSTRAINT [User_fk0] FOREIGN KEY ([roleId]) REFERENCES [Role]([id])
ALTER TABLE [User] CHECK CONSTRAINT [User_fk0]
ALTER TABLE [UnitManager] WITH CHECK ADD CONSTRAINT [UnitManager_fk0] FOREIGN KEY ([userId]) REFERENCES [User]([id])
ALTER TABLE [UnitManager] CHECK CONSTRAINT [UnitManager_fk0]
ALTER TABLE [UnitManager] WITH CHECK ADD CONSTRAINT [UnitManager_fk1] FOREIGN KEY ([unitId]) REFERENCES [Unit]([id])
ALTER TABLE [UnitManager] CHECK CONSTRAINT [UnitManager_fk1]
GO

-- Insert data into [Location] table
INSERT INTO [Location] (name) VALUES
    ('America'),
    ('Russia'),
    ('China');

-- Insert data into [Ammo] table
INSERT INTO [Ammo] (name, price, weight) VALUES
    ('N7Z2', 10, 5),
    ('A2B2', 15, 8),
    ('D7C1', 12, 6);

-- Insert data into [Role] table
INSERT INTO [Role] (description) VALUES
    ('ad'),
    ('us');

-- Insert data into [User] table
INSERT INTO [User] (username, password, roleId) VALUES
    ('unit1', 'unit1', 2),
    ('unit2', 'unit2', 2),
    ('unit3', 'unit3', 2),
	('admin', 'admin', 1);

-- Insert data into [Unit] table
INSERT INTO [Unit] (name, location) VALUES
    ('Unit1', '123 Main St, San Jose, CA 95131'),
    ('Unit2', '9883 Pacific Heights Blvd, San Diego, CA 92121'),
    ('Unit3', '1234 Main St, San Francisco, CA 94122');

-- Insert data into [Model] table
INSERT INTO [Model] (weight, maxSpeed, detail, maxNoDriver, ammoId, price, name, shootingRange) VALUES
    (50, 60, 'Model1', 4, 1, 100, 'BBX831', 500),
    (55, 70, 'Model2', 5, 2, 120, 'NNI912', 600),
    (60, 80, 'Model3', 6, 3, 130, 'XHS823', 700);

-- Insert data into [Manufactory] table
INSERT INTO [Manufactory] (name, locationId) VALUES
    ('Tanker Gold', 1),
    ('Fisher Tanker', 2),
    ('Heart Tank', 3);

-- Insert data into [Tank] table
INSERT INTO [Tank] (modelId, manufactoryId, unitId) VALUES
    (1, 1, 1),
    (2, 2, 2),
    (3, 3, 3);

-- Insert data into [Driver] table
INSERT INTO [Driver] (idCard, name, phone, unitId) VALUES
    ('07920311111', 'Driver1', '0911111119', 1),
    ('07920311112', 'Driver2', '0911112119', 2),
    ('07920311113', 'Driver3', '0911113119', 3);

-- Insert data into [History] table
INSERT INTO [History] (fromUnitId, toUnitId, tankId, date) VALUES
    (1, 2, 1, '2023-01-01'),
    (2, 3, 2, '2023-02-01'),
    (3, 1, 3, '2023-03-01');

-- Insert data into [TankDriver] table
INSERT INTO [TankDriver] (tankId, driverId) VALUES
    (1, 1),
    (2, 2),
    (3, 3);

-- Insert data into [UnitManager] table
INSERT INTO [UnitManager] (userId, unitId) VALUES
	(1, 1),
	(2, 2),
	(3, 3);
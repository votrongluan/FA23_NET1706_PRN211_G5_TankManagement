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
)
GO
CREATE TABLE [Manufactory] (
	id int identity primary key,
	name nvarchar(50),
	locationId int,
)
GO
CREATE TABLE [Location] (
	id int identity primary key,
	name nvarchar(50),
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
	name nvarchar,
	shootingRange int,
)
GO
CREATE TABLE [Ammo] (
	id int identity primary key,
	name nvarchar(50),
	price int,
	weight int,
)
GO
CREATE TABLE [Unit] (
	id int identity primary key,
	name nvarchar(50),
	location nvarchar(50),
)
GO
CREATE TABLE [Driver] (
	id int identity primary key,
	idCard char(12),
	name nvarchar(50),
	phone nvarchar(10),
	unitId integer,
)
GO
CREATE TABLE [History] (
	id int identity primary key,
	fromUnitId int,
	toUnitId int,
	tankId int,
	date date,
)
GO
CREATE TABLE [TankDriver] (
	id int identity primary key,
	tankId int,
	driverId int,
)
GO
CREATE TABLE [Role] (
	id int identity primary key,
	description char(2),
)
GO
CREATE TABLE [User] (
	id int identity primary key,
	username varchar(20),
	password varchar(20),
	roleId int,
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


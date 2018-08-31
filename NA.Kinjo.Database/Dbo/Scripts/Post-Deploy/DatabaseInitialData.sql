PRINT 'Starting Post deploy queries'

INSERT INTO AppUser (UserName,Email,Password,EmailConfirmed) VALUES ('SuperUser','foluis@hotmail.com','123',1)
INSERT INTO AppUser (UserName,Email,Password,EmailConfirmed) VALUES ('Nest','foluis2008@gmail.com','123',1)

INSERT INTO Module (Id,Name) VALUES	(1,'Company')
INSERT INTO Module (Id,Name) VALUES	(2,'Neighbour')
INSERT INTO Module (Id,Name) VALUES	(3,'Event')

INSERT INTO Role (Id,Name) VALUES (1,'AppAdmin')
INSERT INTO Role (Id,Name) VALUES (2,'Business')
INSERT INTO Role (Id,Name) VALUES (3,'NeighbourAdmin')
INSERT INTO Role (Id,Name) VALUES (4,'Neighbour')

--INSERT INTO AppUserRole (Id,AppUser,RoleId) VALUES (1,1,1)
--INSERT INTO AppUserRole (Id,AppUser,RoleId) VALUES (1,2,2)

--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (1,1,1)
--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (2,1,2)
--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (3,1,3)

--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (1,1,1)
--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (2,1,2)
--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (3,1,3)
--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (4,1,4)

--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (1,1,1)
--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (2,1,2)
--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (3,1,3)
--INSERT INTO ModeModuleRole(Id,ModuleId,RoleId) VALUES (4,1,4)

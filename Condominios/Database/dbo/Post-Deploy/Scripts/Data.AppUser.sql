IF(NOT EXISTS (SELECT 1 FROM AppUser WHERE Email = 'foluis@hotmail.com'))
BEGIN
INSERT INTO AppUser 
	(Email,Password)
Values ('foluis@hotmail.com','123')
END
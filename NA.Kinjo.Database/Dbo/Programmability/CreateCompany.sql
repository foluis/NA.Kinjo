CREATE PROCEDURE CreateCompany		
	@Email varchar(100), 
	@Password varchar(100) ,
	@Name varchar(50), 
	@Address varchar(200), 
	@Phone varchar(20)	
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @AppUserId int
	DECLARE @CompanyId int

    INSERT INTO AppUser 
		( Email, Password )		
	VALUES 
		(@Email,@Password)

	SET @AppUserId = scope_identity()

	INSERT INTO Company
	( Name,Email, Address ,Phone)	
	Values (@Name,@Email,@Address,@Phone)

	SEt @CompanyId = scope_identity()

	Insert into UserCompany
	Values (@AppUserId, @CompanyId)	
END
GO
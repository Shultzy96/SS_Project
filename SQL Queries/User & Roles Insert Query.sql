SELECT *
FROM Users

	INSERT INTO dbo.Users ([ProfileID], [UserFirstName], [UserLastName], [Email], [UserName], [Password], [PayrollID], [RoleID])	
	VALUES                  (1, 'Dakota', 'Shultz', 'Shultzy0630@gmail.com', 'Shultzy', '0a5df1c4644677c8060e7775f46a4564a2b2c0e87565fa454ad6411104d05a77', 1, 5),
							(2, 'Jacob', 'Lyons', 'Jlyons12@gmail.com', 'JakeLyons', 'b4a5b2582b582440ce82648aadae2b4d762808b1e5f3296123e39ada71bdda27', 1, 4),
							(3, 'Tim', 'Yearns', 'tyearns15@gmail.com', 'TimYearns', 'ae09c1e90749b76a7e796d2d48883cef43cf544f0942f1fd49f24862ba59f720', 1, 4)
	
SELECT *
FROM UserRoles	

	INSERT INTO dbo.UserRoles (RoleName, RoleDescription)
	VALUES					  ('User', 'View'),
							  ('Employee', 'View, Create Templates, Update Portfolio'),
							  ('Lead', 'View, Create Templates, Update Portfolio, Delete Portfolio, Manager Forum Access'),
							  ('Manager', 'View, Create Templates & Forums, Update Portfolio & Forums, Delete Portfolios & Forums, Manager Forum Access, User & Employee Delete'),
							  ('CEO', 'All Permissions')


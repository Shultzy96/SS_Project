SELECT * FROM Payroll

INSERT INTO dbo.Payroll ( [JobTitle], [JobDescription], [HourlyRate], [Salary])
VALUES                  ( 'Default Job Title', 'Default Job Description For New Accounts', 0, 0),
					    ( 'Entry Level Developer', 'Tier 1 Software Developer', 18.35, 38480.00),
					    ( 'Entry Level Dev 2', 'Tier 2 Software Developer', 22.45, 44900.00),
						( 'Software Developer', 'Tier 3 Software Developer', 26.86, 53720.00),
						( 'Software Dev 2', 'Tier 4 Software Developer', 29.55, 59100.00),
						( 'Software Dev 3', 'Tier 5 Software Developer', 33.82, 67640.00),
						( 'Lead Software Developer', 'Tier 1 Lead Software Developer', 38.65, 77300.00),
						( 'Lead Dev 2', 'Tier 2 Lead Software Developer', 42.35, 84700.00),
						( 'Lead Dev 3', 'Tier 3 Lead Software Developer', 45.25, 90500.00),
						( 'Accountant', 'Accounting Specialist', 24.36, 48720.00),
						( 'Accounting Manager', 'Finacial Manager', 27.86, 55720.00),
						( 'Accounting Director', 'Director of Finances', 31.38, 62760.00),
						( 'Opperations Manager', 'Upper Management', 49.82, 99640.00),
						( 'Vice President', 'Second to the top', 53.86, 107720.00),
						( 'CEO/President', 'All Hail The King', 56.80, 113600.00)
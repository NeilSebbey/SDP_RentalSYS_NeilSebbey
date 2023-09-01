-- Empty tables before populating them
DELETE FROM RentalItems;
DELETE FROM Rentals;
DELETE FROM Movies;
DELETE FROM Members;
DELETE FROM Counties;
DELETE FROM Genres;
DELETE FROM AgeRating;
DELETE FROM Categories;
DELETE FROM Status;


-- Populate the Counties table
INSERT INTO Counties
VALUES('CW','Carlow');
INSERT INTO Counties
VALUES('CN','Cavan');
INSERT INTO Counties
VALUES('CE','Clare');
INSERT INTO Counties
VALUES('CK','Cork');
INSERT INTO Counties
VALUES('DL','Donegal');
INSERT INTO Counties
VALUES('DN','Dublin');
INSERT INTO Counties
VALUES('GY','Galway');
INSERT INTO Counties
VALUES('KY','Kerry');
INSERT INTO Counties
VALUES('KE','Kildare');
INSERT INTO Counties
VALUES('KK','Kilkenny');
INSERT INTO Counties
VALUES('LS','Laois');
INSERT INTO Counties
VALUES('LM','Leitrim');
INSERT INTO Counties
VALUES('LK','Limerick');
INSERT INTO Counties
VALUES('LD','Longford');
INSERT INTO Counties
VALUES('LH','Louth');
INSERT INTO Counties
VALUES('MO','Mayo');
INSERT INTO Counties
VALUES('MH','Meath');
INSERT INTO Counties
VALUES('MN','Monaghan');
INSERT INTO Counties
VALUES('OY','Offaly');
INSERT INTO Counties
VALUES('RN','Roscommon');
INSERT INTO Counties
VALUES('SO','Sligo');
INSERT INTO Counties
VALUES('TY','Tipperary');
INSERT INTO Counties
VALUES('WD','Waterford');
INSERT INTO Counties
VALUES('WH','Westmeath');
INSERT INTO Counties
VALUES('WX','Wexford');
INSERT INTO Counties
VALUES('WW','Wicklow');

-- Populate the table Genres
INSERT INTO Genres
VALUES('AC', 'Action');
INSERT INTO Genres
VALUES('AD', 'Adventure');
INSERT INTO Genres
VALUES('CO', 'Comedy');
INSERT INTO Genres
VALUES('CR', 'Crime');
INSERT INTO Genres
VALUES('DO', 'Documentary');
INSERT INTO Genres
VALUES('DR', 'Drama');
INSERT INTO Genres
VALUES('HO', 'Horror');
INSERT INTO Genres
VALUES('MY', 'Mystery');
INSERT INTO Genres
VALUES('RO', 'Romance');
INSERT INTO Genres
VALUES('SC', 'Sci-Fi');
INSERT INTO Genres
VALUES('TH', 'Thriller');

-- Populate the table Counties
INSERT INTO AgeRating
VALUES('G ','General');
INSERT INTO AgeRating
VALUES('PG','Parental Guidance');
INSERT INTO AgeRating
VALUES('12','12 and Older');
INSERT INTO AgeRating
VALUES('15','15 and Older');
INSERT INTO AgeRating
VALUES('16','16 and Older');
INSERT INTO AgeRating
VALUES('18','18 and Older');

-- Populate the table Categories
INSERT INTO Categories
VALUES('NR','New Release', 10.00);
INSERT INTO Categories
VALUES('OR','Old Release', 5.00);

-- Populate the table Status
INSERT INTO Status
VALUES('A','Available');
INSERT INTO Status
VALUES('U','Unavailable');
INSERT INTO Status
VALUES('D','Deleted');

-- Populate the table Members
INSERT INTO Members
VALUES(0001,'Bloggs','Joe',0834567890,'Dromthacker','Tralee','KY','V92 1A2D','joe.bloggs@test.xyz');
INSERT INTO Members
VALUES(0002,'Doe','Jane',0851234567,'Clash','Tralee','KY','V92 1A4C','jane.doe@test.xyz');
INSERT INTO Members
VALUES(0003,'Brown','James',0850102340,'53 Merchants Quay','Cork','CK','A20 AB31','james.smith@gmail.com');
INSERT INTO Members
VALUES(0004,'Daniels','Mary',0851432567,'Ashe St','Tralee','KY','V92 2A4Z','mdaniels@test.xyz');
INSERT INTO Members
VALUES(0005,'James','James',0873214567,'Manor West','Tralee','KY','V92 JJ1A','jj1@gmail.com');
INSERT INTO Members
VALUES(0006,'Johnson','John',0862314567,'Turners Cross','Cork','CK','A30 JJ2B','jj2@gmail.com');

-- Populate the table Movies
INSERT INTO Movies
VALUES(0001,'Tenet','AC','12',2020,'NR','U');
INSERT INTO Movies
VALUES(0002,'Bad Boys for Life','AC','16',2020,'NR','A');
INSERT INTO Movies
VALUES(0003,'The Social Network','DR','15',2010,'OR','U');
INSERT INTO Movies
VALUES(0004,'Avatar','AC','12',2009,'OR','U');
INSERT INTO Movies
VALUES(0005,'Black Widow','AC','12',2021,'NR','A');
INSERT INTO Movies
VALUES(0006,'Birds of Prey','AC','12',2020,'NR','A');
INSERT INTO Movies
VALUES(0007,'The Karate Kid','AC','PG',2010,'OR','A');
INSERT INTO Movies
VALUES(0008,'The Way Back','DR','16',2020,'NR','A');
INSERT INTO Movies
VALUES(0009,'Alone','TH','16',2020,'NR','A');
INSERT INTO Movies
VALUES(0010,'The Invisible Man','HO','16',2020,'NR','A');
INSERT INTO Movies
VALUES(0011,'Table 19','CO','12',2017,'OR','A');
INSERT INTO Movies
VALUES(0012,'American Hustle','CR','16',2014,'OR','A');
INSERT INTO Movies
VALUES(0013,'Brothers','DR','16',2010,'OR','A');
INSERT INTO Movies
VALUES(0014,'Once Upon a Time in Hollywood','CO','16',2019,'NR','A');
INSERT INTO Movies
VALUES(0015,'Up in the Air','CO','16',2009,'OR','A');
INSERT INTO Movies
VALUES(0016,'Inside Man','TH','16',2006,'OR','A');
INSERT INTO Movies
VALUES(0017,'Kingsman The Secret Service','AC','16',2014,'OR','A');
INSERT INTO Movies
VALUES(0018,'Knives Out','MY','12',2019,'NR','U');

-- Populate the table Rentals
INSERT INTO Rentals
VALUES(0001,0001,DATE '2021-04-14',DATE '2021-04-15',5.00);
INSERT INTO Rentals
VALUES(0002,0003,DATE '2021-04-28',DATE '2021-04-29',15.00);
INSERT INTO Rentals
VALUES(0003,0002,DATE '2021-05-09',DATE '2021-04-10',10.00);

-- Populate the table RentalItems
INSERT INTO RentalItems
VALUES(0001,0004,'OR',NULL,NULL,0.00);
INSERT INTO RentalItems
VALUES(0002,0001,'NR',NULL,NULL,0.00);
INSERT INTO RentalItems
VALUES(0002,0003,'OR',NULL,NULL,0.00);
INSERT INTO RentalItems
VALUES(0003,0018,'NR',NULL,NULL,0.00);

COMMIT;



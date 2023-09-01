-- CountiesAndMembers.sql
-- February 2021 / Neil Sebbey - KCOMP_B_2S

-- Drop tables before building
DROP TABLE RentalItems;
DROP TABLE Rentals;
DROP TABLE Movies;
DROP TABLE Members;
DROP TABLE Counties;
DROP TABLE Genres;
DROP TABLE AgeRating;
DROP TABLE Categories;
DROP TABLE Status;


-- Create table Counties
CREATE TABLE Counties
(CountyCode char(2),
 Name varchar(20),
 CONSTRAINT pk_Counties PRIMARY KEY (CountyCode));
 
 -- Create table Genres
CREATE TABLE Genres
(GenreCode char(2),
 Name varchar(20),
 CONSTRAINT pk_Genres PRIMARY KEY (GenreCode));
 
 -- Create table AgeRating
CREATE TABLE AgeRating
(AgeRatingCode varchar(2),
 Description varchar(20),
 CONSTRAINT pk_AgeRating PRIMARY KEY (AgeRatingCode));
 
 -- Create table Categories
CREATE TABLE Categories
(CategoryCode char(2),
 Description varchar(25),
 Rate numeric(4,2),
 CONSTRAINT pk_Categories PRIMARY KEY (CategoryCode));
 
 -- Create table Status
CREATE TABLE Status
(StatusCode char(1),
 Description varchar(20),
 CONSTRAINT pk_Status PRIMARY KEY (StatusCode));
 
 -- Create table Members
CREATE TABLE Members
(MemberId numeric(4),
 Surname varchar2(24),
 Forename varchar2(24),
 Phone numeric(14),
 Street varchar2(50),
 Town varchar2(25),
 County varchar2(2),
 Eircode varchar2(8),
 Email varchar2(64),
 CONSTRAINT pk_Members PRIMARY KEY (MemberId));
 
 -- Create table Movies
CREATE TABLE Movies
(MovieId numeric(4),
 Title varchar2(30),
 GenreCode char(2),
 AgeRatingCode varchar2(2),
 Year numeric(4),
 Category char(2),
 Status char(1),
 CONSTRAINT pk_Movies PRIMARY KEY (MovieId),
 CONSTRAINT fk_Genre FOREIGN KEY (GenreCode) REFERENCES Genres(GenreCode),
 CONSTRAINT fk_AgeRating FOREIGN KEY (AgeRatingCode) REFERENCES AgeRating(AgeRatingCode),
 CONSTRAINT fk_Category FOREIGN KEY (Category) REFERENCES Categories(CategoryCode),
 CONSTRAINT fk_Status FOREIGN KEY (Status) REFERENCES Status(StatusCode));
 
 -- Create table Rentals
CREATE TABLE Rentals
(RentalId numeric(4),
 MemberId numeric(4),
 RentDate DATE,
 DueDate DATE,
 Cost decimal(4,2),
 CONSTRAINT pk_Rentals PRIMARY KEY (RentalId),
 CONSTRAINT fk_Member FOREIGN KEY (MemberId) REFERENCES Members(MemberId));
 
 -- Create table RentalItems
 /**************************
*    Title:  Oracle SQL Tutorial 20 - How to Create Composite Primary Keys [length: 4:56]
*    Author: Caleb Curry
*    Site owner/sponsor:  youtube.com
*    Date: 06/12/2011
*    Code version:  1.0 (2011)
*    Availability:  https://www.youtube.com/watch?v=5yifu5JwYxE&t=296s (Accessed 6 April 2021)
*    Modified:  Code refactored (Identifiers renamed) 
 ***************************/
 CREATE TABLE RentalItems
(RentalId NOT NULL REFERENCES Rentals(RentalId) ON DELETE CASCADE,
 MovieId NOT NULL REFERENCES Movies(MovieId) ON DELETE CASCADE,
 Category NOT NULL REFERENCES Categories(CategoryCode) ON DELETE CASCADE,
 ReturnedDate DATE,
 ReturnedByMemId numeric(4),
 Fine decimal(3,2),
 CONSTRAINT pk_RentalItems PRIMARY KEY(RentalId, MovieId, Category));
--- End of refactored code

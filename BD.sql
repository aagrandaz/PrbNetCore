-- Creación de la tabla User
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL
);

-- Creación de la tabla Movie
CREATE TABLE Movies (
    MovieID INT PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    GenreID INT,
    Director NVARCHAR(50),
    Description NVARCHAR(500)
);

-- Creación de la tabla Preference
CREATE TABLE Preferences (
    PreferenceID INT PRIMARY KEY,
    UserID INT,
    GenreID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (GenreID) REFERENCES Genres(GenreID)
);

-- Creación de la tabla Genre (si es necesario)
CREATE TABLE Genres (
    GenreID INT PRIMARY KEY,
    GenreName NVARCHAR(50) NOT NULL
);

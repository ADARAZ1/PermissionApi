-- Example SQL Setup (Not used in current project)

CREATE TABLE Users (
    Id INT PRIMARY KEY,
    Username NVARCHAR(50),
    Email NVARCHAR(50)
);

CREATE TABLE Roles (
    Id INT PRIMARY KEY,
    RoleName NVARCHAR(50)
);

CREATE TABLE UserRoles (
    UserId INT,
    RoleId INT,
    PRIMARY KEY(UserId, RoleId)
);

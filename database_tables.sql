CREATE TABLE `AspNetRoles` (
    `Id` varchar(128) NOT NULL,
    `Name` varchar(256),
    `NormalizedName` varchar(256),
    `ConcurrencyStamp` varchar(256),
    PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetUsers` (
    `Id` varchar(128) NOT NULL,
    `UserName` varchar(256) NOT NULL,
    `NormalizedUserName` varchar(256) NOT NULL,
    `Email` varchar(256) DEFAULT NULL,
    `NormalizedEmail` varchar(256) NOT NULL,
    `EmailConfirmed` tinyint(1) NOT NULL,
    `PasswordHash` longtext,
    `SecurityStamp` longtext,
    `PhoneNumber` longtext,
    `PhoneNumberConfirmed` tinyint(1) NOT NULL,
    `TwoFactorEnabled` tinyint(1) NOT NULL,
    `LockoutEnd` datetime DEFAULT NULL,
    `LockoutEnabled` tinyint(1) NOT NULL,
    `AccessFailedCount` int(11) NOT NULL,
    `ConcurrencyStamp` varchar(256), 
    PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetRoleClaims` (
    `Id` int(11) NOT NULL AUTO_INCREMENT,
    `RoleId` varchar(256) NOT NULL,
    `ClaimType` varchar(256) NOT NULL,
    `ClaimValue` varchar(256) NOT NULL,
    PRIMARY KEY (`Id`),
    UNIQUE KEY `Id` (`Id`),
    CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
);

CREATE TABLE `AspNetUserClaims` (
    `Id` int(11) NOT NULL AUTO_INCREMENT,
    `UserId` varchar(128) NOT NULL,
    `ClaimType` longtext,
    `ClaimValue` longtext,
    PRIMARY KEY (`Id`),
    UNIQUE KEY `Id` (`Id`),
    KEY `UserId` (`UserId`),
    CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
);

CREATE TABLE `AspNetUserLogins` (
    `LoginProvider` varchar(128) NOT NULL,
    `ProviderKey` varchar(128) NOT NULL,
    `ProviderDisplayName` varchar(128) NOT NULL,
    `UserId` varchar(128) NOT NULL,
    PRIMARY KEY (`LoginProvider`,`ProviderKey`),
    KEY `ApplicationUser_Logins` (`UserId`),
    CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
);

CREATE TABLE `AspNetUserRoles` (
    `UserId` varchar(128) NOT NULL,
    `RoleId` varchar(128) NOT NULL,
    PRIMARY KEY (`UserId`,`RoleId`),
    KEY `IdentityRole_Users` (`RoleId`),
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ;

CREATE TABLE `AspNetUserTokens` (
    `UserId` varchar(256) NOT NULL,
    `LoginProvider` varchar(128) NOT NULL,
    `Name` varchar(128) NOT NULL,
    `Value` varchar(256) NOT NULL,
    PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
    CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
);

CREATE TABLE `AspNetArticulos` (
	`Id` int(11) IDENTITY NOT NULL PRIMARY KEY, 
    `Nombre` VARCHAR(250) NOT NULL, 
    `Precio` int(11) NOT NULL, 
    `CantStock` int(11) NOT NULL, 
    `Categoria` int(11) NULL, 
    CONSTRAINT `FK_AspNetArticulos_AspNetCategorias_Id` FOREIGN KEY (`UserId`) REFERENCES `AspNetCategorias` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
)

CREATE TABLE `AspNetCategorias` (
	`Id` int(11) NOT NULL AUTO_INCREMENT, 
    `Nombre` varchar(256) NOT NULL,
    `Articulos` varchar(128),
    PRIMARY KEY (`Id`)
)

CREATE INDEX IX_AspNetRoleClaims_RoleId ON AspNetRoleClaims(RoleId);

CREATE UNIQUE INDEX RoleNameIndex ON AspNetRoles(NormalizedName);

CREATE INDEX IX_AspNetUserClaims_UserId ON AspNetUserClaims(UserId);

CREATE INDEX IX_AspNetUserLogins_UserId ON AspNetUserLogins(UserId);

CREATE INDEX IX_AspNetUserRoles_RoleId ON AspNetUserRoles(RoleId);

CREATE INDEX EmailIndex ON AspNetUsers(NormalizedEmail);

CREATE UNIQUE INDEX UserNameIndex ON AspNetUsers(NormalizedUserName);
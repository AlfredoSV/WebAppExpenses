CREATE DATABASE Expenses;
Go

USE Expenses;

CREATE TABLE Account(Id Uniqueidentifier, TotalAccount decimal(2),
IdUser Uniqueidentifier,DateCreated DATE);

CREATE TABLE Expense(Id Uniqueidentifier,
NameExpense VARCHAR(40), Description VARCHAR(MAX),
CreatedDate DATE, UpdatedDate DATE, IdUser Uniqueidentifier, Total decimal(2), IsService BIT
, UseCreditCard BIT);


CREATE TABLE Product(Id Uniqueidentifier,
NameProduct VARCHAR(40), Description VARCHAR(MAX),
CreatedDate DATE, UpdatedDate DATE, IdExpense Uniqueidentifier, Cost decimal(2));

CREATE TABLE Service(Id Uniqueidentifier,
NameService VARCHAR(40), Description VARCHAR(MAX),
CreatedDate DATE, UpdatedDate DATE, IdExpense Uniqueidentifier, Cost decimal(2));
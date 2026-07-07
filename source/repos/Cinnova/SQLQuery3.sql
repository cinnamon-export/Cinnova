-- This adds the new column and links it to your friend's Employees table
ALTER TABLE Users
ADD EmployeeID INT NULL FOREIGN KEY REFERENCES Employees(EmployeeID);
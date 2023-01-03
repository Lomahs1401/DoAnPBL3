# PBL3 (Project Base Learning 3) :books:
A Book sales management project using C# and Winform
## Purpose of the project 
Building a book sales management software system to help easily perform book management and book selling processes, helping users have the best experience
## What to prepare
+ Use SQL Server database (for easy customing in `App.config` file). You can use another database like MySQL but I don't recommend it because it will be more customizing
+ Need to install [XanderUI-master.rar](https://drive.google.com/file/d/14TUaw8OTthofiYPu2uxCsKE2aXbsGXOW/edit) library
## How to run
After cloning the project and opening the solution file, you will see the project folder structure like this:

![image](https://user-images.githubusercontent.com/77973385/210359015-e1195da9-f427-4f40-9595-f120db2fe278.png)

Here, open the `App.config` file and search for the following line `connectionString="Data Source=DESKTOP-P9VT12M\SQLEXPRESS`

![image](https://user-images.githubusercontent.com/77973385/210359537-ec431828-c336-4b92-b9cd-f697694f96dd.png)

Here, you need to connect to the server installed on your computer. To do that, open the SSMS application. It will display the first dialog that looks like this. You copy the line "Server name" and then replace the connectionString string (highlighted in red in the image above) to connect to the server in your computer.

![image](https://user-images.githubusercontent.com/77973385/210360064-e190d49a-50f0-493b-aa82-66c1865fd65e.png)

Next, you need to import the XanderUI library into References. If you're not familiar with how to import library, here's a guide.
First, right-click on References, select Add Reference. You will see something look like this

![image](https://user-images.githubusercontent.com/77973385/210360774-b210282c-a157-44f4-9fdf-bd64aa4a21d3.png)

Go to Browse, select the Browse button and search for the Xander.dll file, then save and click OK

![image](https://user-images.githubusercontent.com/77973385/210361044-73b8ed0f-4281-4472-b615-2a24e1bf5b79.png)

Once done, you can already run the project :smile:

## Databases
![image](https://user-images.githubusercontent.com/77973385/210361525-c8b817a8-3432-4b33-81ef-1e4db767a13d.png)

## Features
### Login function
+ Use account to log in to the system
+ Two roles: Admin and Employee
+ Send code to gmail if forgot the password
### Account management function
+ Allow to edit the password and avatar of the account
+ Allow to note important information in the account
+ Allows to change the background color of the interface (for admin accounts)
+ Allow logging out of the system
### For administration :office_worker:
#### Employee management function
- Allows viewing of employee details information
- Detailed statistics of the total number of employees working
- Allows searching for employee information by:
  - ID
  - Name
  - Phone
- Allows listing employees by gender
- Allows adding information of new employees
- Allow modification of employee information
- Allow to delete employee information (soft delete)
- Allow to view the list of employees who have quit their jobs.
#### Book management function
- Allows to view detailed information of the book
- Detailed statistics of the total number of available book items
- Allows searching for information of books by:
  - ID
  - Name author
  - Name book
- Allows listing books information by:
  - Publiser
  - Language
  - Genre
- Allows to sort the list of available books by: 
  - Letter
  - Purchase price
  - The level of selling
  - Number of books available
#### Revenue management function
- Statistics of total invoices, total money, profit, number of customers, number of goods left, quantity of goods sold, 5 best-selling books by:
  - Optional.
  - Today.
  - 7 days.
  - This month.
  - This quarter.
- Use charts to describe book sales.
#### Customer management function
- Allows viewing of customer details
- Detailed statistics of the total number of customers who have purchased books
- Allows searching for customer information by:
  - ID
  - Full Name
  - Phone
- Allows listing customers information by gender
- Allows to view the list of purchased invoices
- Allows to view detailed information of each invoice purchased by the customer
### For Employee :man_technologist:
#### Book management function
- Allows to view detailed information of the book
- Detailed statistics of the total number of available book items
- Allows searching for information of books by:
  - ID
  - Name author
  - Name book
- Allows listing books information by:
  - Publiser
  - Language
  - Genre
- Allows adding information of new books
- Allows modification of book information
- Allow to delete book message tones (Soft delete)
#### Book selling function
- Allows to view detailed information of the book
- Detailed statistics of the total number of books available
- Allows searching for information of books by:
  - ID.
  - Title of the book
  - Author's name
- Allows listing books information by:
  - Language
  - Publisher
  - Genre
- Allow adding books to cart
- Enter customer phone number to confirm purchase
- Allow to enter new customer information
- Create a book purchase invoice
#### Customer management function
- Allows viewing of customer details
- Detailed statistics of the total number of customers who have purchased books
- Allows searching for customer information by:
  - ID
  - Full Name
  - Phone
- Allows listing customers information by gender
- Allows to view the list of purchased invoices
- Allows to view detailed information of each invoice purchased by the customer
## Program interface
#### Program start interface

![image](https://user-images.githubusercontent.com/77973385/210368459-af6002b0-1bd4-4d5f-8229-b99ec44e1f06.png)
![image](https://user-images.githubusercontent.com/77973385/210368493-11d35b07-10ea-428d-8e0d-562009f870db.png)
![image](https://user-images.githubusercontent.com/77973385/210368505-a264b071-5eae-4aec-a1ca-a40e5438ebaa.png)

#### Login interface

![image](https://user-images.githubusercontent.com/77973385/210368567-fa5d7cc4-9058-4ef8-9a2d-6c1b5b34e946.png)

### For Administration
#### Admin main interface

![image](https://user-images.githubusercontent.com/77973385/210369327-0261e2c8-fcbf-48c6-91f1-8518919a782e.png)

#### Employee management interface

![image](https://user-images.githubusercontent.com/77973385/210369592-95eacdc4-7ceb-4297-9849-b497a075177e.png)

+ View employee details

![image](https://user-images.githubusercontent.com/77973385/210369884-ed97e3f0-03a7-4bc8-9c6b-daad59fe688f.png)

+ Search for employees by: ID or Name or Phone

![image](https://user-images.githubusercontent.com/77973385/210370155-7b78c5ad-36a3-40c9-b850-96a2555fc88f.png)

+ Add new employee

![image](https://user-images.githubusercontent.com/77973385/210370258-3efedfa2-a25b-42bb-b116-4c16d3ce0a9a.png)

+ Update info employee

If the data is invalid (invalid email, invalid date...) will display update failed message. If the data is valid, a dialog box to confirm if you want to update is displayed. If yes, will show update successful message

![image](https://user-images.githubusercontent.com/77973385/210370349-615d4f6c-53b2-4169-b0f7-81403099c47b.png)
![image](https://user-images.githubusercontent.com/77973385/210371900-597a3df6-3b91-44ae-954d-b0b8ee7fcc83.png)
![image](https://user-images.githubusercontent.com/77973385/210372415-40c6387c-5da6-4765-98b3-26259720743e.png)

+ Delete employee

When deleting an employee, a warning dialog box will appear. If deleted, display a dialog box asking the administrator to enter the correct password of the account in use. If entered correctly, a message will be displayed stating that the deletion was successful

![image](https://user-images.githubusercontent.com/77973385/210370725-83f76ca4-dd14-46f0-85fe-5e58fd93bce4.png)
![image](https://user-images.githubusercontent.com/77973385/210370989-72c34920-a80c-478c-8abf-0ea6ec981284.png)
![image](https://user-images.githubusercontent.com/77973385/210371044-18cba2dd-bb0c-471b-aeab-148cf55945bb.png)

+ View the list of employees who quit job

![image](https://user-images.githubusercontent.com/77973385/210371295-bef299b8-5c58-483b-8acc-d2cfe98d8dfa.png)

#### Books management interface
+ View the list of available books in the system

![image](https://user-images.githubusercontent.com/77973385/210373059-25045a0c-5070-4f80-8612-a88e4389d999.png)

+ View detailed information of all kinds of books

![image](https://user-images.githubusercontent.com/77973385/210373469-44fa947a-ebbd-41cb-9483-c2fa3493c544.png)

+ Search for books by ID, book title or author name

![image](https://user-images.githubusercontent.com/77973385/210373506-8da67fc6-9425-4a6c-ad42-d90da0ae58ec.png)

+ List of books by criteria: publisher, genre, language

![image](https://user-images.githubusercontent.com/77973385/210373896-b948b947-137f-4686-92aa-45e4f75bb7b5.png)

+ Sort the list of books by different criteria

![image](https://user-images.githubusercontent.com/77973385/210373978-32963870-d392-4095-9b8c-fc8ab301093b.png)

#### Revenue management interface
+ Revenue statistics by different timelines (today, last week, this month, this quarter and advanced options)

![image](https://user-images.githubusercontent.com/77973385/210374531-8a813e90-6f26-4cf6-b79b-7dc9f3a047a0.png)

#### Customer management interface
+ View list of customers

![image](https://user-images.githubusercontent.com/77973385/210374978-a014ffec-caf3-4bf0-aefc-8bd0a79ffaaf.png)

+ View customer details

![image](https://user-images.githubusercontent.com/77973385/210375413-0de92a2d-e2fa-4b31-9910-6aeacc5e7201.png)

+ View the list of customer invoices

![image](https://user-images.githubusercontent.com/77973385/210375539-d3f72af8-111f-445c-93a1-9769b81c1d38.png)

+ View customer invoice details

![image](https://user-images.githubusercontent.com/77973385/210375663-f51db86d-7e38-416b-9d01-988618adafcf.png)

#### Change theme

![image](https://user-images.githubusercontent.com/77973385/210376092-ff05d857-ce66-407b-8d2b-fd2d50190065.png)
![image](https://user-images.githubusercontent.com/77973385/210378700-a33b4f1e-a5b7-42f9-b6de-c2fa1d8ce640.png)

### For Employee
#### Admin main interface

![image](https://user-images.githubusercontent.com/77973385/210379008-d594a2cf-d9ff-4069-9aed-9fa1148a61a7.png)

#### Book management interface
+ View the list of available books in the system

![image](https://user-images.githubusercontent.com/77973385/210379211-ba641dd3-2193-4c63-8742-8799eef1ff58.png)

+ Add new books to the system

![image](https://user-images.githubusercontent.com/77973385/210379320-91c8fc7e-2b4d-4073-9197-462ce77dd5d5.png)

+ Update the information of the book

![image](https://user-images.githubusercontent.com/77973385/210379465-57ce0dc4-3ee3-46bc-9dc5-e54e7825234e.png)

+ Delete book
The function of displaying a warning dialog, asking for a password to confirm deletion is exactly the same as the admin side

#### Book selling interface

+ Add books to cart

![image](https://user-images.githubusercontent.com/77973385/210380912-59dc989a-f5a7-4d89-b403-bdfd7ff53a53.png)

+ View cart details

![image](https://user-images.githubusercontent.com/77973385/210380957-63a6eadd-3533-4513-953d-400d146e3ab8.png)

+ Customer Authentication

![image](https://user-images.githubusercontent.com/77973385/210381054-d7a7ab57-7250-4905-a064-e1e9eb08ac46.png)

+ Add new customer information if not exist in the system

![image](https://user-images.githubusercontent.com/77973385/210381151-b36e3980-a91d-42ab-915a-39c2bff0dcc6.png)




# Project E-commerce

## How to Run and Install

1. **Delete Folder Migrations in Folder `Shop_Tech_Server`:**
   - Remove the existing migrations folder to ensure a clean setup.

2. **Go to `Shop_Tech_Server` and Find the File Named `Program.cs`:**
   - Change the SQL connection string to your own connection in `Program.cs`.

3. **Open Package Manager Console and Write:**
   - Run the following command to add migrations:
     ```sh
     Add-Migrations First_Data  # You can change the name
     ```
   - If the connection is successful, run the next command to update the database:
     ```sh
     Update-Database
     ```

4. **Run the App and Test:**
   - Now you can run the application and start testing.

## License

Add your licensing information here.


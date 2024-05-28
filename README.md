# RetailStoreManagement

# Database and Postman Requests
- You can find them in the respective folder inside the project

# Connect to Database
- Find appsettings.json
- Change `"DefaultConnection": "Server=`**Your-PC-Name**`\\SQLEXPRESS;Database=RetailStoreDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"`

Then open SQL Server Management studio:
- Right click **Databases** on left pane (Object Explorer)
- Click **Restore Database...**
- Choose **Device**, click **...**, and add the **_.bak_** file
- Click **OK**, then **OK** again

using System;
using Dapper;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DapperConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection(@"Server=(localdb)\Mysqllocaldb.Northwind;Data Source=.;Initial Catalog=Northwind;Integrated Security=True")
            using (IDbConnection dbConnection = new SqlConnection("Server=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=SSPI;Trusted_Connection=yes;"))
            {
                dbConnection.Open();

                //Veri Ekleme işlemi
                dbConnection.Execute(
                    "insert into Customers(CustomerID,CompanyName,ContactName, ContactTitle, Address, City,  Region, PostalCode, Country,  Phone, Fax ) " +
                    "values (@CustomerID,@CompanyName, @ContactName, @ContactTitle, @Address, @City,  @Region, @PostalCode, @Country,  @Phone, @Fax )",
                    new Customers
                    {
                        CustomerID = "AELIF",
                        CompanyName = "Dapper Company",
                        ContactName = "Elif Sirin",
                        ContactTitle = "Owner",
                        Address = "Osmangazi mh.",
                        City = "İzmir",
                        Region = "NULL",
                        PostalCode = "35535",
                        Country = "Turkey",
                        Phone = "0514-12",
                        Fax = "0133-2"
                    }
                    );

                // Veriyi çekme
                List<Customers> customerList = dbConnection.Query<Customers>("select * from Customers").ToList();
                foreach (Customers customer in customerList)
                {
                    Console.WriteLine(customer.toString());
                } 

                dbConnection.Close();


            }



        Console.WriteLine("Hello World!");
        }
    }
}

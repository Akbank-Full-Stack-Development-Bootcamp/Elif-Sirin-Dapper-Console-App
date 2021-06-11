using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsoleApp
{
    class Customers
    {

        // Northwind Veri Tabanındaki Customers tablosunun kolonlarına göre Customers Sınıfı oluşturulmuştur.
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName{ get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }


        // Konsolda tablodaki elemanların okunması için toString() fonksiyonu yardımıyla string'e çevrildi.
        public string toString()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            return CustomerID + " " + CompanyName + " " + ContactName + " " + ContactTitle + " " + Address + " " + City
                + " " + Region + " " + PostalCode + " " + Country + " " + Phone + " " + Fax + " ";
        }
    }
}

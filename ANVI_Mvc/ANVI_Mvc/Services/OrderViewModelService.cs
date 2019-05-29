using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ANVI_Mvc.Models;
using ANVI_Mvc.ViewModels;

namespace ANVI_Mvc.Services
{
    public class OrderViewModelService
    {
        public OrderCustomerViewModel OCVM { get; set; }
        private AnviModel DB { get; set; }
        private int CID { get; set; }
        public OrderViewModelService(AnviModel db, int cid)
        {
            DB = db;
            CID = cid;
            OCVM = new OrderCustomerViewModel()
            {
                CustomerName = GetCustomerName(),
                City = GetCity(),
                ZipCode = GetZipCode(),
                Address = GetAddress(),
                Phone = GetPhone()
            };
        }

        private Customer GetCustomer()
        {
            return DB.Customers.First(x => x.CustomerID == CID);
        }

        public string GetCustomerName()
        {
            var Name = GetCustomer().CustomerName;
            return DB.Customers.First(x => x.CustomerName == Name).CustomerName;
        }


        public string GetCity()
        {
            var city = GetCustomer().City;
            return DB.Customers.First(x => x.City == city).City;
        }

        public string GetZipCode()
        {
            var zipcode = GetCustomer().ZipCode;
            return DB.Customers.First(x => x.ZipCode == zipcode).ZipCode;
        }

        public string GetAddress()
        {
            var address = GetCustomer().Address;
            return DB.Customers.First(x => x.Address == address).Address;
        }

        public string GetPhone()
        {
            var phone = GetCustomer().Phone;
            return DB.Customers.First(x => x.Phone == phone).Phone;
        }
    }
}
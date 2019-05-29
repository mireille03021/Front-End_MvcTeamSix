using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ANVI_Mvc.Models;

namespace ANVI_Mvc.ViewModels
{
    public class OrderCustomerViewModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string BankAccount { get; set; }
        public string CreditCard { get; set; }

        //以下是資料庫沒有的欄位
        public string Bill_CustomerName { get; set; }
        public string Bill_Address { get; set; }
        public string Bill_City { get; set; }
        public string Bill_ZipCode { get; set; }
        public string Bill_Phone { get; set; }
    }
}
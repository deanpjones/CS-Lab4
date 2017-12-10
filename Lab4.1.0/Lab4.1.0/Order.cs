using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1._0
{
    //**********************************************************************
    //**********************************************************************

    //LAB 4 ADO.NET 
    //ORDER CLASS (based on Order table)
    //Author: Dean Jones
    //Date: Jan.6, 2017

    //**********************************************************************
    //**********************************************************************

    public class Order
    {
        //CONSTRUCTOR
        public Order() { }

        //SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate FROM Orders;
        //GETTERS AND SETTERS
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }


        /// <summary>
        /// TOSTRING (override)
        /// </summary>
        public override string ToString()
        {
            return OrderID.ToString() + "\t" +
                CustomerID + "\t" +
                OrderDate.ToString() + "\t" +
                RequiredDate.ToString() + "\t" +
                ShippedDate.ToString();
        }
    }
}

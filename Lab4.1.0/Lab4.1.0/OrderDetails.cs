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
    //ORDER DETAILS CLASS (based on OrderDetails table)
    //Author: Dean Jones
    //Date: Jan.6, 2017

    //**********************************************************************
    //**********************************************************************

    public class OrderDetails
    {
        //CONSTRUCTOR
        public OrderDetails() { }


        //GETTERS AND SETTERS
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        /// <summary>
        /// TOSTRING (override)
        /// </summary>
        public override string ToString()
        {
            return OrderId.ToString() + "\t" +
                ProductId.ToString() + "\t" +
                UnitPrice.ToString() + "\t" +
                Quantity.ToString() + "\t" +
                Discount.ToString();
        }

    }
}

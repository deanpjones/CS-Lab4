using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._1._0
{
    //**********************************************************************
    //**********************************************************************

    //LAB 4 ADO.NET 
    //DATABASE CONNECTION (OrderDetails table)
    //Author: Dean Jones
    //Date: Jan.6, 2017

    //**********************************************************************
    //**********************************************************************

    public static class OrderDetailsDB
    {
        /// <summary>
        /// READ ORDER DETAILS (by OrderID)
        /// </summary>
        public static List<OrderDetails> ReadOrderDetails(int order_id)
        {
            List<OrderDetails> myorder_details_list = new List<OrderDetails>();  //blank list
            OrderDetails myorder_details = null;    //default object (to place in list)

            //define connection
            SqlConnection connection = NorthwindDB.ConnectToDB();

            //define query
            //SELECT * FROM[Order Details]
            //    WHERE OrderID = 10248
            //    ORDER BY ProductID;
            string selectOrderDetailsQuery = "SELECT * FROM[Order Details] " +
                "WHERE OrderID = @OrderID " +       //parameter @OrderID
                "ORDER BY ProductID;";
            SqlCommand selectOrderIDListSQLCommand = new SqlCommand(selectOrderDetailsQuery, connection);
            selectOrderIDListSQLCommand.Parameters.AddWithValue("@OrderID", order_id);

            try
            {
                //open connection
                connection.Open();

                //execute query
                SqlDataReader readDB = selectOrderIDListSQLCommand.ExecuteReader();

                //process result (0 or 1 order)
                while (readDB.Read())
                {
                    //CREATE (OrderDetails) OBJECT
                    myorder_details = new OrderDetails();   //make new object for OrderDetails
                    //OrderID, ProductID, UnitPrice, Quantity, Discount
                    myorder_details.OrderId = (int) readDB["OrderID"];
                    myorder_details.ProductId = (int) readDB["ProductID"];
                    myorder_details.UnitPrice = (decimal) readDB["UnitPrice"];
                    myorder_details.Quantity = (short) readDB["Quantity"];
                    myorder_details.Discount = (float) readDB["Discount"];

                    //ADD OBJECT TO LIST
                    myorder_details_list.Add(myorder_details);
                }

            }
            catch (Exception ex)
            {
                throw ex;   //pass it to the form
            }
            finally
            {
                //close connection
                connection.Close();
            }

            return myorder_details_list;
        }

        /// <summary>
        /// CALCULATE ORDER TOTAL (Order Details table) 
        /// </summary>
        public static double CalculateOrderTotal(int id)
        {
            double total = 0;

            //define connection
            SqlConnection connection = NorthwindDB.ConnectToDB();

            //define query (SUM(UnitPrice * (1 - Discount) * Quantity))
            //SELECT SUM(UnitPrice * (1 - Discount) * Quantity) FROM [Order Details] WHERE OrderID = 10250;
            string sumOrderTotalQuery = "SELECT SUM(UnitPrice * (1 - Discount) * Quantity) FROM [Order Details] WHERE OrderID = " + id + ";";
            SqlCommand sumOrderTotalSQLCommand = new SqlCommand(sumOrderTotalQuery, connection);

            try
            {
                //open connection
                connection.Open();

                //execute query
                SqlDataReader readDB = sumOrderTotalSQLCommand.ExecuteReader(System.Data.CommandBehavior.SingleResult);

                if (readDB.Read())
                {
                    total = (double)readDB[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //close connection
                connection.Close();
            }

            return total;
        }
    }

}

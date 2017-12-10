using System;
using System.Collections.Generic;
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
    //DATABASE CONNECTION (Order table)
    //Author: Dean Jones
    //Date: Jan.6, 2017

    //**********************************************************************
    //**********************************************************************

    public static class OrdersDB
    {
        /// <summary>
        /// READ FIRST ORDER ID ONLY (return one integer)
        /// </summary>
        public static int ReadFirstOrderID()
        {
            int result = 0;

            //define connection
            SqlConnection connection = NorthwindDB.ConnectToDB();

            //define query (get first OrderId)
            //SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID;        //return int 10248
            string selectFirstIDQuery = "SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID ASC;";
            SqlCommand selectFirstSQLCommand = new SqlCommand(selectFirstIDQuery, connection);

            try
            {
                //open connection
                connection.Open();

                //execute query
                SqlDataReader readDB = selectFirstSQLCommand.ExecuteReader(System.Data.CommandBehavior.SingleResult);

                if (readDB.Read())
                {
                    result = (int) readDB["OrderID"];
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

            return result;
        }

        /// <summary>
        /// READ (OrderID) LIST FOR COMBOBOX
        /// </summary>
        public static List<int> ReadOrderIDList()
        {
            List<int> myorder_list = new List<int>();   //blank list

            //define connection
            SqlConnection connection = NorthwindDB.ConnectToDB();

            //define query
            //SELECT OrderID FROM Orders ORDER BY OrderID ASC;
            string selectOrderIDListQuery = "SELECT OrderID FROM Orders ORDER BY OrderID ASC;";
            SqlCommand selectOrderIDListSQLCommand = new SqlCommand(selectOrderIDListQuery, connection);

            try
            {
                //open connection
                connection.Open();

                //execute query
                SqlDataReader readDB = selectOrderIDListSQLCommand.ExecuteReader();

                while (readDB.Read())
                {
                    myorder_list.Add((int)readDB["OrderID"]);
                    //result = (int)readDB["OrderID"];
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

            return myorder_list;
        }

        /// <summary>
        /// READ ORDERS METHOD (sql SELECT)
        /// </summary>
        public static Order ReadOrders(int order_id)
        {
            Order ord = null;                                           //current order object (in database)
            //DateTime NULL_DATE = new DateTime(1900, 1, 1);              //use as null value

            //define connection
            SqlConnection connection = NorthwindDB.ConnectToDB();

            //define query
            //SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate FROM Orders;
            string selectQuery = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                "FROM Orders " +
                "WHERE OrderID = @OrderID;";                                //Parameter @OrderID
            SqlCommand selectSQLCommand = new SqlCommand(selectQuery, connection);
            selectSQLCommand.Parameters.AddWithValue("@OrderID", order_id);    //add parameters

            try
            {
                //open connection
                connection.Open();

                //execute query...
                SqlDataReader readDB = selectSQLCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                //process results (no customers or one per row)
                if (readDB.Read())
                {
                    ord = new Order();              //create new order object

                    //var test = readDB.IsDBNull(0);
                    if (readDB.IsDBNull(0))
                    {
                        MessageBox.Show("The OrderID is NULL");
                    }
                    else
                    {
                        ord.OrderID = (int)readDB["OrderID"];                   //int object
                        ord.CustomerID = readDB["CustomerID"].ToString();       //string object
                        ord.OrderDate = (DateTime)readDB["OrderDate"];          //date object
                        ord.RequiredDate = (DateTime)readDB["RequiredDate"];    //date object

                        //if this (shipped date) is NOT null (otherwise defaults to null)
                        if (!readDB.IsDBNull(4))
                        {
                            ord.ShippedDate = (DateTime)readDB["ShippedDate"];      //date object
                        }
                        else
                        {                            
                            ord.ShippedDate = null;         //set to null
                        }
                    }
                }
            }
            catch(InvalidCastException e)
            {
                MessageBox.Show("This is a null value on the date.\n\n" + e.Message);
            }
            catch(Exception ex)
            {
                throw ex;   //pass it to the form
            }
            finally
            {
                //close connection
                connection.Close(); 
            }

            return ord;
        }

        /// <summary>
        /// UPDATE SHIPDATE METHOD (sql UPDATE)
        /// </summary>
        public static bool UpdateOrderByShipDate(int id, Order oldOrder, Order newOrder)
        {
            bool update_success = false;   //default value to confirm update (to database)

            //create two order objects (old and new to compare before update)
            //new order (for update)
            //old order (to revert back if someone else has changed DB, concurrency problem)

            //define connection
            SqlConnection connection = NorthwindDB.ConnectToDB();

            //define query
            //UPDATE Orders SET ShippedDate='1996-07-17 00:00:00.000' WHERE OrderID = 10248;
            string updateQuery = "UPDATE Orders " +
                "SET ShippedDate = @NewShippedDate " +
                "WHERE (OrderID = " + id + ") " +                           //update only selected record (OrderID=10248)
                "AND (ShippedDate = @OldShippedDate " +                     //update only if record hasn't changed
                "OR ShippedDate IS NULL AND @OldShippedDate IS NULL);";

            //updateSQLCommand
            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            //set parameter (old shipped date)
            var x = updateCommand.Parameters.AddWithValue("@OldShippedDate", oldOrder.ShippedDate ?? (object)DBNull.Value );
            //set parameter (new shipped date)
            var y = updateCommand.Parameters.AddWithValue("@NewShippedDate", newOrder.ShippedDate ?? (object)DBNull.Value );

            try
            {
                //open connection
                connection.Open();

                int count = updateCommand.ExecuteNonQuery();    //execute query (return rows affected)
                if(count == 1)
                {
                    update_success = true;                      //set return value to (true) if query returns result
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

            return update_success;
        }
    }
}

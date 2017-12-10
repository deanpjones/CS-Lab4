using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1._0
{
    //**********************************************************************
    //**********************************************************************

    //LAB 4 ADO.NET 
    //DATABASE CONNECTION
    //Author: Dean Jones
    //Date: Jan.6, 2017

    //**********************************************************************
    //**********************************************************************

    public static class NorthwindDB
    {
        //CREATE CONNECTION TO DATABASE
        public static SqlConnection ConnectToDB()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

    }
}

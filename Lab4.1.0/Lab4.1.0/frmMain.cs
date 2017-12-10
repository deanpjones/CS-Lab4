using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._1._0
{
    public partial class frmMain : Form
    {
        //**********************************************************************
        //**********************************************************************

        //LAB 4 ADO.NET 
        //MAIN FORM
        //Author: Dean Jones
        //Date: Jan.6, 2017

        //**********************************************************************
        //**********************************************************************
        //FILES

        //NORTHWND.MDF      DATABASE FILE (local in project folder)

        //NorthwindDB.cs    Connects to database
        //Orders.cs         Class for Orders object
        //OrderDetails.cs   Class for OrderDetails object
        //OrdersDB.cs       Database connection (Orders table)
        //OrderDetailsDB    Database connection (OrderDetails table)

        //**********************************************************************
        //**********************************************************************

        //VARIABLES
        public Order my_order;                      //order data object
        public List<int> list_orderID;              //list of orderID's for combobox
        int cbo_int;                                //combobox int (? null exception)
        public List<OrderDetails> myOrderDetails;   //empty order details object
        DateTime orddate, reqdate, shipdate;        //save form dates

        public frmMain()
        {
            InitializeComponent();         
        }

        /// <summary>
        /// LOAD FORM
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //set color theme
                this.dgdOrder_Details.DefaultCellStyle.ForeColor = Color.Black;
                this.dgdOrder_Details.DefaultCellStyle.BackColor = Color.LightGreen;

                //tooltip for shipped date
                toolTip1.SetToolTip(dtpShippedDate, "Please choose date between order date and required date.");    //datepicker
                toolTip1.SetToolTip(btnUpdateShipDate, "Click update button to save changes to the database.");     //update button
                toolTip1.SetToolTip(chkShipDateNull, "Check if the shipped date is not known.");                    //null checkbox
                toolTip1.SetToolTip(btnExit, "Click to exit, this does not save changes");                          //exit button

                //focus on combobox
                cboOrderID.Focus();

                //LOAD COMBOBOX (OrderID)
                FillOrderIDCombo();

                //LOAD (Order) FIELDS
                //*************************************
                DisplayOrder(ComboBoxOrderIdDefault());        //display fields
                //DisplayOrder(10248);                         //hard coded, just for test
                //*************************************

                //LOAD (OrderDetails) GRID
                //*************************************
                DisplayGridView(OrderDetailsDB.ReadOrderDetails(ComboBoxOrderIdDefault()));
                //OrderDetailsDB.ReadOrderDetails(10248);
                //DisplayGridView();
                //DisplayGridView(OrderDetailsDB.ReadOrderDetails(10248));  //hard coded, testing
                //*************************************

                //CALCULATE ORDER TOTAL
                lblOrderTotal.Text = OrderDetailsDB.CalculateOrderTotal(cbo_int).ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem loading the form.\n\n" + ex.Message + ": " + ex.GetType());
            }
        }

        /// <summary>
        /// DISPLAY (OrderDetails) GRIDVIEW
        /// </summary>
        private void DisplayGridView(List<OrderDetails> detail_list)
        {
            int count = detail_list.Count;  //get list count (# of rows)

            try
            {
                //clear grid first
                dgdOrder_Details.Rows.Clear();

                //fill grid
                for (int i = 0; i < count; i++)
                {
                    //this.dgdOrder_Details.Rows.Add("asdf", "bbb", "ccc", "ddd", "eee");
                    this.dgdOrder_Details.Rows.Add(
                        detail_list[i].OrderId.ToString(),
                        detail_list[i].ProductId.ToString(),
                        detail_list[i].UnitPrice.ToString("c"),
                        detail_list[i].Quantity.ToString(),
                        detail_list[i].Discount.ToString()
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem loading the order details grid view.\n\n" + ex.Message + ": " + ex.GetType());
            }

        }

        /// <summary>
        /// COMBOBOX DEFAULT (if null to start)(return first OrderID value instead)
        /// </summary>
        private int ComboBoxOrderIdDefault()
        {
            try
            {
                if (cboOrderID.SelectedItem == null)
                {
                    cbo_int = OrdersDB.ReadFirstOrderID();
                    cboOrderID.SelectedItem = cbo_int;
                    return cbo_int;
                }
                else
                {
                    return (int)cboOrderID.SelectedItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem setting the combobox default value.\n\n" + ex.Message + ": " + ex.GetType());
                return -1;
            }
        }

        /// <summary>
        /// DISPLAY ORDER METHOD
        /// </summary>
        private void DisplayOrder(int id)
        {
            //VARIABLES
            id = ComboBoxOrderIdDefault();      //set default orderId (current OrderID or 10248)    
            my_order = new Order();             //create new (Order object)

            try
            {
                //set combobox (default)
                cboOrderID.SelectedItem = id;
                //set other fields         
                my_order = OrdersDB.ReadOrders(id);
                //my_order = OrdersDB.ReadOrders(10248);              //test default first order

                //TEST FOR NULL BEFORE LOADING
                if (my_order == null)
                {
                    //clear fields
                    MessageBox.Show("No order found with this ID while loading.", "Order Not Found");
                }
                else
                {
                    //ASSIGN Order object (to form fields)               
                    cboOrderID.Text = my_order.OrderID.ToString();
                    txtCustomerID.Text = my_order.CustomerID;
                    dtpOrderDate.Text = my_order.OrderDate.Date.ToString();             //date only (my_order.OrderDate.Date)
                    dtpRequiredDate.Text = my_order.RequiredDate.Date.ToString();

                    //if null
                    if (my_order.ShippedDate == null)
                    {
                        //if SQL (is null)
                        chkShipDateNull.Checked = true;     //checkbox ON
                        dtpShippedDate.Visible = false;
                        lblNullShippedDate.Visible = true;
                        lblNullShippedDate.Text = "Shipped date is null";

                        //update picker
                        dtpShippedDate.Text = my_order.ShippedDate.ToString();
                    }
                    else
                    {
                        //if SQL (is not null)
                        chkShipDateNull.Checked = false;     //checkbox OFF
                        dtpShippedDate.Visible = true;
                        lblNullShippedDate.Visible = false;
                        lblNullShippedDate.Text = "lblNullShippedDate";

                        //update picker
                        dtpShippedDate.Text = my_order.ShippedDate.ToString();
                    }                
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                MessageBox.Show("There was a problem with the date.\n\n" + e.Message + ", " + e.GetType());
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error displaying the order info.\n\n" + ex.Message + ", " + ex.GetType());
            }      
        }

        /// <summary>
        /// COMBOBOX CHANGED
        /// </summary>
        private void cboOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int current_id = (int)cboOrderID.SelectedItem;                  //get current OrderID from combobox
                cbo_int = current_id;                                           //update cbo_int

                //set fields to the based on the combobox orderId
                my_order = OrdersDB.ReadOrders((int)cboOrderID.SelectedItem);   //set Order to new fields
                DisplayOrder(current_id);                                       //update fields

                //update the grid
                DisplayGridView(OrderDetailsDB.ReadOrderDetails(ComboBoxOrderIdDefault()));

                //update Order Total
                lblOrderTotal.Text = OrderDetailsDB.CalculateOrderTotal(cbo_int).ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error combobox index changed\n\n" + ex.Message + ": " + ex.GetType());
            }

        }

        /// <summary>
        /// FILL COMBOBOX (OrderID's)
        /// </summary>
        private void FillOrderIDCombo()
        {
            try
            {
                list_orderID = new List<int>();             //create new list object
                list_orderID = OrdersDB.ReadOrderIDList();  //get list (from database)

                if (list_orderID == null)
                {
                    MessageBox.Show("The OrderID combobox could not be filled out.");
                }
                else
                {
                    foreach (int n in list_orderID)
                    {
                        cboOrderID.Items.Add(n);                //add OrderId's to combobox
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error updating the combobox\n\n" + ex.Message + ": " + ex.GetType());
            }

        }

        /// <summary>
        /// UPDATE BUTTON (Shipped Date field)
        /// </summary>
        private void btnUpdateShipDate_Click(object sender, EventArgs e)
        {
            //new order object
            Order my_new_order = new Order();

            try
            {
                //----------------------------------------------------
                //
                //Assign updated fields (for new Order)
                my_new_order.OrderID = Convert.ToInt32(cboOrderID.Text);
                my_new_order.CustomerID = txtCustomerID.Text;
                my_new_order.OrderDate = dtpOrderDate.Value;
                my_new_order.RequiredDate = dtpRequiredDate.Value;

                //Update (ShippedDate) if null
                if(chkShipDateNull.Checked == true)
                {
                    my_new_order.ShippedDate = null;
                }
                else
                {
                    my_new_order.ShippedDate = dtpShippedDate.Value;
                }
                //
                //----------------------------------------------------
                //validate date
                if (IsValidShippedDate())
                {
                    //if update is successful
                    if (OrdersDB.UpdateOrderByShipDate(cbo_int, my_order, my_new_order)) //update shipped date (to database)
                    {
                        //if successful
                        MessageBox.Show("The database was updated successfully!", "Database Update");
                    }
                    else
                    {
                        //if fails (concurrency error)
                        MessageBox.Show("The Order row has been updated or deleted from another source", "Database Concurrency Error");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem UPDATING to the database.\n\n" + ex.Message + "\n" + ex.GetType().ToString());
            }

        }

        /// <summary>
        /// EXIT BUTTON
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        /// <summary>
        /// (OBSOLETE) CHECKBOX (Shipped Date) IS NULL
        /// //OLD, was a problem using COMBOBOX, would update with MessageBox
        /// //SEE CLICK EVENT...
        /// </summary>
        private void chkShipDateNull_CheckedChanged(object sender, EventArgs e)
        {            
            //if (chkShipDateNull.Checked == true)                    //checked test
            //{                 
            //    dtpShippedDate.Visible = false;                     //hide shipped date
            //    lblNullShippedDate.Visible = true;                  //show label
            //    lblNullShippedDate.Text = "Shipped date is null";   //update label text
            //}
            //else
            //{
            //    dtpShippedDate.Visible = true;                      //show shipped date
            //    lblNullShippedDate.Visible = false;                 //hide label
            //    lblNullShippedDate.Text = "lblNullShippedDate";     //reset label

            //    //message to warn to update (default value is Jan.1, 1900)
            //    dtpShippedDate.Value = new DateTime(1900, 1, 1);    //reset datepicker 
            //    MessageBox.Show("Please update the date to the proper shipped date." +
            //        "\n\nThe default value is currently January 1, 1900.");
            //    //put focus on shipped date datepicker
            //    dtpShippedDate.Focus();
            //}

        }

        /// <summary>
        ///  (OBSOLETE) VALIDATION (Shipped Date)(for entering MinDate and MaxDate)
        ///  //NOT REQUIRED, datepicker only allows selecting of the range set MinDate and MaxDate
        /// </summary>
        private void dtpShippedDate_ValueChanged(object sender, EventArgs e)
        {
            ////if the date is below MinDate
            //if(dtpShippedDate.Value < dtpShippedDate.MinDate)
            //{
            //    MessageBox.Show("The date value is below the minimum date required" +
            //        "\n\nThe date must be greater than " + dtpShippedDate.MinDate.ToString());
            //}
            //else if (dtpShippedDate.Value > dtpShippedDate.MaxDate)
            //{
            //    MessageBox.Show("The date value is above the maximum date required" +
            //        "\n\nThe date must be less than " + dtpShippedDate.MaxDate.ToString());
            //}
        }

        //CHECKBOX CLICKED (NOT CHANGED, otherwise combo triggers message)
        private void chkShipDateNull_Click(object sender, EventArgs e)
        {
            if (chkShipDateNull.Checked == true)                    //checked test
            {
                dtpShippedDate.Visible = false;                     //hide shipped date
                lblNullShippedDate.Visible = true;                  //show label
                lblNullShippedDate.Text = "Shipped date is null";   //update label text
            }
            else
            {
                dtpShippedDate.Visible = true;                      //show shipped date
                lblNullShippedDate.Visible = false;                 //hide label
                lblNullShippedDate.Text = "lblNullShippedDate";     //reset label

                //message to warn to update (default value is Jan.1, 1900)
                dtpShippedDate.Value = new DateTime(1900, 1, 1);    //reset datepicker 
                MessageBox.Show("Please update the date to the proper shipped date." +
                    "\n\nThe default value is currently January 1, 1900.", "UPDATE DATE");
                //put focus on shipped date datepicker
                dtpShippedDate.Focus();
            }
        }

        /// <summary>
        /// VALIDATION (Shipped Date)(shipped date should be BETWEEN order date and required date)
        /// </summary>
        private bool IsValidShippedDate()
        {
            //get order date
            orddate = new DateTime();
            orddate = dtpOrderDate.Value;
            //get required date
            reqdate = new DateTime();
            reqdate = dtpRequiredDate.Value;
            //get shipped date
            shipdate = new DateTime();
            shipdate = dtpShippedDate.Value;

            //check for null first (ignore datepickers if null is checked)
            if(chkShipDateNull.Checked == false)
            {
                //test for valid shipped date
                if (orddate < shipdate && shipdate < reqdate)
                {                    
                    return true;
                }
                else
                {
                    MessageBox.Show("The date needs to be between the order and required date.", "Date Range Error");
                    return false;
                }
            }
            else
            {
                return true;        //still valid if null
            }
     
        }

    }
}

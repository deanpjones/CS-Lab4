namespace Lab4._1._0
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            this.dgdOrder_Details = new System.Windows.Forms.DataGridView();
            this.clmOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.cboOrderID = new System.Windows.Forms.ComboBox();
            this.btnUpdateShipDate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkShipDateNull = new System.Windows.Forms.CheckBox();
            this.lblNullShippedDate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            orderIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdOrder_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(13, 39);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(63, 13);
            orderIDLabel.TabIndex = 12;
            orderIDLabel.Text = "Order ID:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(13, 65);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(86, 13);
            customerIDLabel.TabIndex = 14;
            customerIDLabel.Text = "Customer ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(13, 92);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(76, 13);
            orderDateLabel.TabIndex = 16;
            orderDateLabel.Text = "Order Date:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(13, 118);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(94, 13);
            requiredDateLabel.TabIndex = 18;
            requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shippedDateLabel.Location = new System.Drawing.Point(13, 144);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(97, 13);
            shippedDateLabel.TabIndex = 20;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // dgdOrder_Details
            // 
            this.dgdOrder_Details.AllowUserToAddRows = false;
            this.dgdOrder_Details.AllowUserToDeleteRows = false;
            this.dgdOrder_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdOrder_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOrderID,
            this.clmProductID,
            this.clmUnitPrice,
            this.clmQuantity,
            this.clmDiscount});
            this.dgdOrder_Details.Location = new System.Drawing.Point(16, 220);
            this.dgdOrder_Details.Name = "dgdOrder_Details";
            this.dgdOrder_Details.ReadOnly = true;
            this.dgdOrder_Details.Size = new System.Drawing.Size(543, 166);
            this.dgdOrder_Details.TabIndex = 6;
            this.dgdOrder_Details.Tag = "Order Details Table";
            // 
            // clmOrderID
            // 
            this.clmOrderID.HeaderText = "OrderID";
            this.clmOrderID.Name = "clmOrderID";
            this.clmOrderID.ReadOnly = true;
            // 
            // clmProductID
            // 
            this.clmProductID.HeaderText = "ProductID";
            this.clmProductID.Name = "clmProductID";
            this.clmProductID.ReadOnly = true;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.HeaderText = "Unit Price";
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            // 
            // clmDiscount
            // 
            this.clmDiscount.HeaderText = "Discount";
            this.clmDiscount.Name = "clmDiscount";
            this.clmDiscount.ReadOnly = true;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(112, 62);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(233, 21);
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.Tag = "Customer ID";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Location = new System.Drawing.Point(112, 88);
            this.dtpOrderDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpOrderDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(233, 21);
            this.dtpOrderDate.TabIndex = 2;
            this.dtpOrderDate.Tag = "Order Date";
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Enabled = false;
            this.dtpRequiredDate.Location = new System.Drawing.Point(112, 114);
            this.dtpRequiredDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpRequiredDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(233, 21);
            this.dtpRequiredDate.TabIndex = 3;
            this.dtpRequiredDate.Tag = "Required Date";
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(112, 140);
            this.dtpShippedDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpShippedDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(233, 21);
            this.dtpShippedDate.TabIndex = 4;
            this.dtpShippedDate.Tag = "Shipped Date";
            this.dtpShippedDate.ValueChanged += new System.EventHandler(this.dtpShippedDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Order Info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Order Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(352, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Order Total:";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblOrderTotal.Location = new System.Drawing.Point(446, 203);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(111, 13);
            this.lblOrderTotal.TabIndex = 23;
            this.lblOrderTotal.Text = "lblOrderTotal";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboOrderID
            // 
            this.cboOrderID.FormattingEnabled = true;
            this.cboOrderID.Location = new System.Drawing.Point(112, 36);
            this.cboOrderID.Name = "cboOrderID";
            this.cboOrderID.Size = new System.Drawing.Size(233, 21);
            this.cboOrderID.TabIndex = 0;
            this.cboOrderID.Tag = "Order ID";
            this.cboOrderID.SelectedIndexChanged += new System.EventHandler(this.cboOrderID_SelectedIndexChanged);
            // 
            // btnUpdateShipDate
            // 
            this.btnUpdateShipDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateShipDate.Location = new System.Drawing.Point(270, 167);
            this.btnUpdateShipDate.Name = "btnUpdateShipDate";
            this.btnUpdateShipDate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateShipDate.TabIndex = 5;
            this.btnUpdateShipDate.Text = "&Update";
            this.btnUpdateShipDate.UseVisualStyleBackColor = true;
            this.btnUpdateShipDate.Click += new System.EventHandler(this.btnUpdateShipDate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(484, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkShipDateNull
            // 
            this.chkShipDateNull.AutoSize = true;
            this.chkShipDateNull.Location = new System.Drawing.Point(351, 143);
            this.chkShipDateNull.Name = "chkShipDateNull";
            this.chkShipDateNull.Size = new System.Drawing.Size(156, 17);
            this.chkShipDateNull.TabIndex = 24;
            this.chkShipDateNull.Text = "Ship date is not known";
            this.chkShipDateNull.UseVisualStyleBackColor = true;
            this.chkShipDateNull.CheckedChanged += new System.EventHandler(this.chkShipDateNull_CheckedChanged);
            this.chkShipDateNull.Click += new System.EventHandler(this.chkShipDateNull_Click);
            // 
            // lblNullShippedDate
            // 
            this.lblNullShippedDate.AutoSize = true;
            this.lblNullShippedDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNullShippedDate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNullShippedDate.Location = new System.Drawing.Point(116, 144);
            this.lblNullShippedDate.Name = "lblNullShippedDate";
            this.lblNullShippedDate.Size = new System.Drawing.Size(130, 13);
            this.lblNullShippedDate.TabIndex = 25;
            this.lblNullShippedDate.Text = "lblNullShippedDate";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.BackColor = System.Drawing.Color.Khaki;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnUpdateShipDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(590, 424);
            this.Controls.Add(this.lblNullShippedDate);
            this.Controls.Add(this.chkShipDateNull);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateShipDate);
            this.Controls.Add(this.cboOrderID);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgdOrder_Details);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.dtpShippedDate);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGreen;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPRG200 Lab4 - Order Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdOrder_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdOrder_Details;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiscount;
        private System.Windows.Forms.ComboBox cboOrderID;
        private System.Windows.Forms.Button btnUpdateShipDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkShipDateNull;
        private System.Windows.Forms.Label lblNullShippedDate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


namespace SW_Cons__T_T_Asgnmnt
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.CustId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OrderIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.QtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderGv = new System.Windows.Forms.DataGridView();
            this.CustName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotAmount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 125);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(894, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "SALES AND INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(524, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 885);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 15);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(94, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 34);
            this.label4.TabIndex = 32;
            this.label4.Text = "CUSTOMERS LIST";
            // 
            // CustomersGV
            // 
            this.CustomersGV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.CustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGV.Location = new System.Drawing.Point(25, 220);
            this.CustomersGV.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.RowHeadersWidth = 51;
            this.CustomersGV.RowTemplate.Height = 24;
            this.CustomersGV.Size = new System.Drawing.Size(370, 172);
            this.CustomersGV.TabIndex = 33;
            this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCombo.ForeColor = System.Drawing.Color.Crimson;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(731, 171);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(180, 31);
            this.SearchCombo.TabIndex = 39;
            this.SearchCombo.Text = "SelectCategory";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            this.SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo_SelectionChangeCommitted);
            // 
            // ProductsGV
            // 
            this.ProductsGV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(497, 220);
            this.ProductsGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 24;
            this.ProductsGV.Size = new System.Drawing.Size(663, 192);
            this.ProductsGV.TabIndex = 38;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(31, 582);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Order Date";
            // 
            // orderdate
            // 
            this.orderdate.Location = new System.Drawing.Point(13, 620);
            this.orderdate.Margin = new System.Windows.Forms.Padding(4);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(332, 30);
            this.orderdate.TabIndex = 42;
            this.orderdate.ValueChanged += new System.EventHandler(this.orderdate_ValueChanged);
            // 
            // CustId
            // 
            this.CustId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustId.ForeColor = System.Drawing.Color.Crimson;
            this.CustId.HintForeColor = System.Drawing.Color.Empty;
            this.CustId.HintText = "";
            this.CustId.isPassword = false;
            this.CustId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CustId.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CustId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.CustId.LineThickness = 3;
            this.CustId.Location = new System.Drawing.Point(25, 460);
            this.CustId.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CustId.Name = "CustId";
            this.CustId.Size = new System.Drawing.Size(215, 32);
            this.CustId.TabIndex = 41;
            this.CustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OrderIdTb
            // 
            this.OrderIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.OrderIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.OrderIdTb.HintText = "";
            this.OrderIdTb.isPassword = false;
            this.OrderIdTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.OrderIdTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.OrderIdTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.OrderIdTb.LineThickness = 3;
            this.OrderIdTb.Location = new System.Drawing.Point(106, 416);
            this.OrderIdTb.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.OrderIdTb.Name = "OrderIdTb";
            this.OrderIdTb.Size = new System.Drawing.Size(215, 30);
            this.OrderIdTb.TabIndex = 40;
            this.OrderIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OrderIdTb.OnValueChanged += new System.EventHandler(this.OrderIdTb_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(378, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 34);
            this.label6.TabIndex = 44;
            this.label6.Text = "Quantity";
            // 
            // QtyTb
            // 
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.ForeColor = System.Drawing.Color.Crimson;
            this.QtyTb.HintForeColor = System.Drawing.Color.Empty;
            this.QtyTb.HintText = "";
            this.QtyTb.isPassword = false;
            this.QtyTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.QtyTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.QtyTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.QtyTb.LineThickness = 3;
            this.QtyTb.Location = new System.Drawing.Point(518, 441);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(172, 51);
            this.QtyTb.TabIndex = 45;
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QtyTb.OnValueChanged += new System.EventHandler(this.QtyTb_OnValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(731, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 44);
            this.button1.TabIndex = 46;
            this.button1.Text = "Add to Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderGv
            // 
            this.OrderGv.BackgroundColor = System.Drawing.Color.DarkGray;
            this.OrderGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGv.Location = new System.Drawing.Point(497, 510);
            this.OrderGv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.RowHeadersWidth = 51;
            this.OrderGv.RowTemplate.Height = 24;
            this.OrderGv.Size = new System.Drawing.Size(663, 205);
            this.OrderGv.TabIndex = 47;
            this.OrderGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGv_CellContentClick);
            // 
            // CustName
            // 
            this.CustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.ForeColor = System.Drawing.Color.Crimson;
            this.CustName.HintForeColor = System.Drawing.Color.Empty;
            this.CustName.HintText = "";
            this.CustName.isPassword = false;
            this.CustName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CustName.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CustName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.CustName.LineThickness = 3;
            this.CustName.Location = new System.Drawing.Point(25, 521);
            this.CustName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(215, 32);
            this.CustName.TabIndex = 48;
            this.CustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustName.OnValueChanged += new System.EventHandler(this.CustName_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(440, 743);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 34);
            this.label7.TabIndex = 49;
            this.label7.Text = "Total Amount Rs.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.BackColor = System.Drawing.Color.DarkKhaki;
            this.TotAmount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotAmount.Location = new System.Drawing.Point(683, 755);
            this.TotAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(38, 22);
            this.TotAmount.TabIndex = 50;
            this.TotAmount.Text = "Rs. ";
            this.TotAmount.Click += new System.EventHandler(this.TotAmount_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 671);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 44);
            this.button2.TabIndex = 51;
            this.button2.Text = "Insert Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(190, 671);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 44);
            this.button3.TabIndex = 52;
            this.button3.Text = "View Orders";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(21, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "OrderId";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(268, 743);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 44);
            this.button4.TabIndex = 54;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(35, 743);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 44);
            this.button5.TabIndex = 55;
            this.button5.Text = "Payment";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 900);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.CustId);
            this.Controls.Add(this.OrderIdTb);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker orderdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OrderIdTb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QtyTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrderGv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
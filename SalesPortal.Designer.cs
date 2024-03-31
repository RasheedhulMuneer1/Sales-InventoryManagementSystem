namespace SW_Cons__T_T_Asgnmnt
{
    partial class SalesPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPortal));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TotAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderGv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.QtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BillnoTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(73, 599);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 44);
            this.button5.TabIndex = 77;
            this.button5.Text = "Payment";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(119, 710);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 44);
            this.button4.TabIndex = 76;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(35, 389);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 44);
            this.button2.TabIndex = 73;
            this.button2.Text = "Generate Bill no";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.BackColor = System.Drawing.Color.DarkKhaki;
            this.TotAmount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotAmount.Location = new System.Drawing.Point(668, 785);
            this.TotAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(38, 22);
            this.TotAmount.TabIndex = 72;
            this.TotAmount.Text = "Rs. ";
            this.TotAmount.Click += new System.EventHandler(this.TotAmount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(440, 775);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 34);
            this.label7.TabIndex = 71;
            this.label7.Text = "Total Amount Rs.";
            // 
            // OrderGv
            // 
            this.OrderGv.BackgroundColor = System.Drawing.Color.DarkGray;
            this.OrderGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGv.Location = new System.Drawing.Point(384, 549);
            this.OrderGv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.RowHeadersWidth = 51;
            this.OrderGv.RowTemplate.Height = 24;
            this.OrderGv.Size = new System.Drawing.Size(800, 205);
            this.OrderGv.TabIndex = 69;
            this.OrderGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGv_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(696, 477);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 44);
            this.button1.TabIndex = 68;
            this.button1.Text = "Add to Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.QtyTb.Location = new System.Drawing.Point(518, 470);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(172, 51);
            this.QtyTb.TabIndex = 67;
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QtyTb.OnValueChanged += new System.EventHandler(this.QtyTb_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(378, 487);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 34);
            this.label6.TabIndex = 66;
            this.label6.Text = "Quantity";
            // 
            // orderdate
            // 
            this.orderdate.Location = new System.Drawing.Point(26, 499);
            this.orderdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(332, 22);
            this.orderdate.TabIndex = 64;
            this.orderdate.ValueChanged += new System.EventHandler(this.orderdate_ValueChanged);
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCombo.ForeColor = System.Drawing.Color.Crimson;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(494, 208);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(180, 31);
            this.SearchCombo.TabIndex = 61;
            this.SearchCombo.Text = "SelectCategory";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            // 
            // ProductsGV
            // 
            this.ProductsGV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(384, 254);
            this.ProductsGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 24;
            this.ProductsGV.Size = new System.Drawing.Size(747, 192);
            this.ProductsGV.TabIndex = 60;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 878);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 22);
            this.panel2.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 9);
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
            this.label1.Location = new System.Drawing.Point(468, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Portal";
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
            this.panel1.Size = new System.Drawing.Size(1254, 180);
            this.panel1.TabIndex = 56;
            // 
            // BillnoTb
            // 
            this.BillnoTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillnoTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillnoTb.ForeColor = System.Drawing.Color.Crimson;
            this.BillnoTb.HintForeColor = System.Drawing.Color.Empty;
            this.BillnoTb.HintText = "";
            this.BillnoTb.isPassword = false;
            this.BillnoTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.BillnoTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.BillnoTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.BillnoTb.LineThickness = 3;
            this.BillnoTb.Location = new System.Drawing.Point(97, 300);
            this.BillnoTb.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.BillnoTb.Name = "BillnoTb";
            this.BillnoTb.Size = new System.Drawing.Size(215, 30);
            this.BillnoTb.TabIndex = 83;
            this.BillnoTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillnoTb.OnValueChanged += new System.EventHandler(this.BillnoTb_OnValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(30, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Billno";
            // 
            // SalesPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 900);
            this.Controls.Add(this.BillnoTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesPortal";
            this.Load += new System.EventHandler(this.SalesPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TotAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView OrderGv;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QtyTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker orderdate;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillnoTb;
        private System.Windows.Forms.Label label4;
    }
}
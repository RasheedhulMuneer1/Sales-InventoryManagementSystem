namespace SW_Cons__T_T_Asgnmnt
{
    partial class ManagePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PaymentGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TotAmount = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Payment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 885);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 15);
            this.panel2.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(64, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 80);
            this.button1.TabIndex = 57;
            this.button1.Text = "Cash Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(64, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 80);
            this.button2.TabIndex = 58;
            this.button2.Text = "Credit Card";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(64, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 80);
            this.button3.TabIndex = 59;
            this.button3.Text = "Loyal Points";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // PaymentGV
            // 
            this.PaymentGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentGV.Location = new System.Drawing.Point(316, 183);
            this.PaymentGV.Name = "PaymentGV";
            this.PaymentGV.RowHeadersWidth = 51;
            this.PaymentGV.RowTemplate.Height = 24;
            this.PaymentGV.Size = new System.Drawing.Size(849, 389);
            this.PaymentGV.TabIndex = 60;
            this.PaymentGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentGV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(306, 622);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 34);
            this.label7.TabIndex = 61;
            this.label7.Text = "Total Amount Rs.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.BackColor = System.Drawing.Color.DarkKhaki;
            this.TotAmount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotAmount.Location = new System.Drawing.Point(535, 632);
            this.TotAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(38, 22);
            this.TotAmount.TabIndex = 62;
            this.TotAmount.Text = "Rs. ";
            this.TotAmount.Click += new System.EventHandler(this.TotAmount_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGreen;
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(553, 683);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 80);
            this.button4.TabIndex = 63;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog1";
            this.printPreviewDialog2.Visible = false;
            this.printPreviewDialog2.Load += new System.EventHandler(this.printPreviewDialog2_Load);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(112, 651);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 61);
            this.button5.TabIndex = 64;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ManagePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 900);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PaymentGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePayment";
            this.Load += new System.EventHandler(this.ManagePayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView PaymentGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotAmount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.Button button5;
    }
}
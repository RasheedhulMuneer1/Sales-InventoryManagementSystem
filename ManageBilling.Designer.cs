namespace SW_Cons__T_T_Asgnmnt
{
    partial class ManageBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBilling));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PaymentGV = new System.Windows.Forms.DataGridView();
            this.TotAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BalanceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CashTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.printPreviewDialog3 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGV)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 125);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(178, 0);
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
            this.label1.Location = new System.Drawing.Point(484, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Billing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 885);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 15);
            this.panel2.TabIndex = 23;
            // 
            // PaymentGV
            // 
            this.PaymentGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentGV.Location = new System.Drawing.Point(117, 153);
            this.PaymentGV.Name = "PaymentGV";
            this.PaymentGV.RowHeadersWidth = 51;
            this.PaymentGV.RowTemplate.Height = 24;
            this.PaymentGV.Size = new System.Drawing.Size(974, 389);
            this.PaymentGV.TabIndex = 61;
            this.PaymentGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentGV_CellContentClick);
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.BackColor = System.Drawing.Color.DarkKhaki;
            this.TotAmount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotAmount.Location = new System.Drawing.Point(395, 602);
            this.TotAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(38, 22);
            this.TotAmount.TabIndex = 64;
            this.TotAmount.Text = "Rs. ";
            this.TotAmount.Click += new System.EventHandler(this.TotAmount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(152, 590);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 34);
            this.label7.TabIndex = 63;
            this.label7.Text = "Total Amount Rs.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(195, 646);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 34);
            this.label3.TabIndex = 65;
            this.label3.Text = "Cash Rs.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(152, 704);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 34);
            this.label4.TabIndex = 67;
            this.label4.Text = "Balance Rs.";
            // 
            // BalanceTb
            // 
            this.BalanceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BalanceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTb.ForeColor = System.Drawing.Color.Crimson;
            this.BalanceTb.HintForeColor = System.Drawing.Color.Empty;
            this.BalanceTb.HintText = "";
            this.BalanceTb.isPassword = false;
            this.BalanceTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.BalanceTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.BalanceTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.BalanceTb.LineThickness = 3;
            this.BalanceTb.Location = new System.Drawing.Point(348, 687);
            this.BalanceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BalanceTb.Name = "BalanceTb";
            this.BalanceTb.Size = new System.Drawing.Size(172, 51);
            this.BalanceTb.TabIndex = 68;
            this.BalanceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BalanceTb.OnValueChanged += new System.EventHandler(this.BalanceTb_OnValueChanged);
            // 
            // CashTb
            // 
            this.CashTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CashTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashTb.ForeColor = System.Drawing.Color.Crimson;
            this.CashTb.HintForeColor = System.Drawing.Color.Empty;
            this.CashTb.HintText = "";
            this.CashTb.isPassword = false;
            this.CashTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CashTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CashTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.CashTb.LineThickness = 3;
            this.CashTb.Location = new System.Drawing.Point(348, 629);
            this.CashTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CashTb.Name = "CashTb";
            this.CashTb.Size = new System.Drawing.Size(172, 51);
            this.CashTb.TabIndex = 69;
            this.CashTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CashTb.OnValueChanged += new System.EventHandler(this.CashTb_OnValueChanged);
            // 
            // printPreviewDialog3
            // 
            this.printPreviewDialog3.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog3.Enabled = true;
            this.printPreviewDialog3.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog3.Icon")));
            this.printPreviewDialog3.Name = "printPreviewDialog3";
            this.printPreviewDialog3.Visible = false;
            this.printPreviewDialog3.Load += new System.EventHandler(this.printPreviewDialog3_Load);
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(654, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 80);
            this.button1.TabIndex = 70;
            this.button1.Text = "Print Invoice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(698, 693);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 58);
            this.button4.TabIndex = 77;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ManageBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 900);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CashTb);
            this.Controls.Add(this.BalanceTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PaymentGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBilling";
            this.Load += new System.EventHandler(this.ManageBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView PaymentGV;
        private System.Windows.Forms.Label TotAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BalanceTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CashTb;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog3;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}
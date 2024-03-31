namespace SW_Cons__T_T_Asgnmnt
{
    partial class ManageProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DescriptionTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 15);
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
            this.label1.Location = new System.Drawing.Point(478, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 885);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 15);
            this.panel2.TabIndex = 19;
            // 
            // PriceTb
            // 
            this.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.ForeColor = System.Drawing.Color.Crimson;
            this.PriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTb.HintText = "";
            this.PriceTb.isPassword = false;
            this.PriceTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PriceTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.PriceTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PriceTb.LineThickness = 3;
            this.PriceTb.Location = new System.Drawing.Point(59, 446);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(172, 51);
            this.PriceTb.TabIndex = 23;
            this.PriceTb.Text = "ProductPrice";
            this.PriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.QtyTb.Location = new System.Drawing.Point(59, 358);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(201, 51);
            this.QtyTb.TabIndex = 22;
            this.QtyTb.Text = "ProductStockQty";
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QtyTb.OnValueChanged += new System.EventHandler(this.QtyTb_OnValueChanged);
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProdNameTb.HintText = "";
            this.ProdNameTb.isPassword = false;
            this.ProdNameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.ProdNameTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.ProdNameTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.ProdNameTb.LineThickness = 3;
            this.ProdNameTb.Location = new System.Drawing.Point(59, 274);
            this.ProdNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(172, 51);
            this.ProdNameTb.TabIndex = 21;
            this.ProdNameTb.Text = "ProductName";
            this.ProdNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdIdTb
            // 
            this.ProdIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProdIdTb.HintText = "";
            this.ProdIdTb.isPassword = false;
            this.ProdIdTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.ProdIdTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.ProdIdTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.ProdIdTb.LineThickness = 3;
            this.ProdIdTb.Location = new System.Drawing.Point(59, 196);
            this.ProdIdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.Size = new System.Drawing.Size(172, 51);
            this.ProdIdTb.TabIndex = 20;
            this.ProdIdTb.Text = "ProductId";
            this.ProdIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProdIdTb.OnValueChanged += new System.EventHandler(this.ProdIdTb_OnValueChanged);
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTb.ForeColor = System.Drawing.Color.Crimson;
            this.DescriptionTb.HintForeColor = System.Drawing.Color.Empty;
            this.DescriptionTb.HintText = "";
            this.DescriptionTb.isPassword = false;
            this.DescriptionTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DescriptionTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.DescriptionTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DescriptionTb.LineThickness = 3;
            this.DescriptionTb.Location = new System.Drawing.Point(59, 539);
            this.DescriptionTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(172, 51);
            this.DescriptionTb.TabIndex = 24;
            this.DescriptionTb.Text = "Description";
            this.DescriptionTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCombo
            // 
            this.CatCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCombo.ForeColor = System.Drawing.Color.Crimson;
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(59, 598);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(201, 31);
            this.CatCombo.TabIndex = 25;
            this.CatCombo.Text = "ProductCategory";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(629, 771);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 44);
            this.button4.TabIndex = 29;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(416, 771);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 28;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(248, 771);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 44);
            this.button2.TabIndex = 27;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(59, 771);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(534, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 40);
            this.label4.TabIndex = 31;
            this.label4.Text = "PRODUCTS LIST";
            // 
            // ProductsGV
            // 
            this.ProductsGV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(382, 294);
            this.ProductsGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 24;
            this.ProductsGV.Size = new System.Drawing.Size(855, 417);
            this.ProductsGV.TabIndex = 30;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCombo.ForeColor = System.Drawing.Color.Crimson;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(530, 232);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(201, 31);
            this.SearchCombo.TabIndex = 32;
            this.SearchCombo.Text = "SelectCategory";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(744, 222);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 44);
            this.button5.TabIndex = 33;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(902, 222);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 44);
            this.button6.TabIndex = 34;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 900);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.ProdNameTb);
            this.Controls.Add(this.ProdIdTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QtyTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DescriptionTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
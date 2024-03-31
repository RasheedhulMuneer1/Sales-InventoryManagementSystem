namespace SW_Cons__T_T_Asgnmnt
{
    partial class ManageCategories
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
            this.CategoryNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CategoryIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoriesGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(894, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "SALES AND INVENTORY MANAGEMENT SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(386, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Categories";
            // 
            // CategoryNameTb
            // 
            this.CategoryNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.CategoryNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CategoryNameTb.HintText = "";
            this.CategoryNameTb.isPassword = false;
            this.CategoryNameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CategoryNameTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CategoryNameTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.CategoryNameTb.LineThickness = 3;
            this.CategoryNameTb.Location = new System.Drawing.Point(42, 271);
            this.CategoryNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryNameTb.Name = "CategoryNameTb";
            this.CategoryNameTb.Size = new System.Drawing.Size(295, 51);
            this.CategoryNameTb.TabIndex = 7;
            this.CategoryNameTb.Text = "CategoryName";
            this.CategoryNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CategoryNameTb.OnValueChanged += new System.EventHandler(this.CategoryNameTb_OnValueChanged);
            // 
            // CategoryIdTb
            // 
            this.CategoryIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.CategoryIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.CategoryIdTb.HintText = "";
            this.CategoryIdTb.isPassword = false;
            this.CategoryIdTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CategoryIdTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CategoryIdTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.CategoryIdTb.LineThickness = 3;
            this.CategoryIdTb.Location = new System.Drawing.Point(42, 183);
            this.CategoryIdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryIdTb.Name = "CategoryIdTb";
            this.CategoryIdTb.Size = new System.Drawing.Size(150, 51);
            this.CategoryIdTb.TabIndex = 6;
            this.CategoryIdTb.Text = "CategoryId";
            this.CategoryIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CategoryIdTb.OnValueChanged += new System.EventHandler(this.CategoryIdTb_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(577, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "CATEGORIES LIST";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CategoriesGV
            // 
            this.CategoriesGV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.CategoriesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGV.Location = new System.Drawing.Point(545, 281);
            this.CategoriesGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CategoriesGV.Name = "CategoriesGV";
            this.CategoriesGV.RowHeadersWidth = 51;
            this.CategoriesGV.RowTemplate.Height = 24;
            this.CategoriesGV.Size = new System.Drawing.Size(340, 416);
            this.CategoriesGV.TabIndex = 14;
            this.CategoriesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(190, 568);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 44);
            this.button4.TabIndex = 21;
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
            this.button3.Location = new System.Drawing.Point(41, 568);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 44);
            this.button3.TabIndex = 20;
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
            this.button2.Location = new System.Drawing.Point(190, 437);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 19;
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
            this.button1.Location = new System.Drawing.Point(41, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 885);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 15);
            this.panel2.TabIndex = 22;
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoriesGV);
            this.Controls.Add(this.CategoryNameTb);
            this.Controls.Add(this.CategoryIdTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CategoryNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CategoryIdTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CategoriesGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}
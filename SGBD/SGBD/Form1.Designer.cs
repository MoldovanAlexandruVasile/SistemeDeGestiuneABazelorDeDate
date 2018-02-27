namespace SGBD
{
    partial class Form1
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
            this.ShopView = new System.Windows.Forms.DataGridView();
            this.PopulateButton = new System.Windows.Forms.Button();
            this.AddStoreID = new System.Windows.Forms.TextBox();
            this.AddStoreName = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InfoView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoStoreID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteCarID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdateNewPrice = new System.Windows.Forms.TextBox();
            this.UpdateCarID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShopView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopView
            // 
            this.ShopView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopView.Location = new System.Drawing.Point(37, 59);
            this.ShopView.Name = "ShopView";
            this.ShopView.RowTemplate.Height = 24;
            this.ShopView.Size = new System.Drawing.Size(243, 568);
            this.ShopView.TabIndex = 0;
            // 
            // PopulateButton
            // 
            this.PopulateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulateButton.Location = new System.Drawing.Point(37, 668);
            this.PopulateButton.Name = "PopulateButton";
            this.PopulateButton.Size = new System.Drawing.Size(243, 49);
            this.PopulateButton.TabIndex = 1;
            this.PopulateButton.Text = "Populate";
            this.PopulateButton.UseVisualStyleBackColor = true;
            this.PopulateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStoreID
            // 
            this.AddStoreID.Location = new System.Drawing.Point(172, 25);
            this.AddStoreID.Name = "AddStoreID";
            this.AddStoreID.Size = new System.Drawing.Size(200, 22);
            this.AddStoreID.TabIndex = 2;
            // 
            // AddStoreName
            // 
            this.AddStoreName.Location = new System.Drawing.Point(172, 78);
            this.AddStoreName.Name = "AddStoreName";
            this.AddStoreName.Size = new System.Drawing.Size(200, 22);
            this.AddStoreName.TabIndex = 3;
            this.AddStoreName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(111, 143);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 57);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Store ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Store name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Car stores:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AddStoreName);
            this.groupBox1.Controls.Add(this.AddStoreID);
            this.groupBox1.Location = new System.Drawing.Point(756, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a store";
            // 
            // InfoView
            // 
            this.InfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoView.Location = new System.Drawing.Point(17, 185);
            this.InfoView.Name = "InfoView";
            this.InfoView.RowTemplate.Height = 24;
            this.InfoView.Size = new System.Drawing.Size(405, 240);
            this.InfoView.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(128, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 61);
            this.button2.TabIndex = 14;
            this.button2.Text = "Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Store ID:";
            // 
            // InfoStoreID
            // 
            this.InfoStoreID.Location = new System.Drawing.Point(172, 44);
            this.InfoStoreID.Name = "InfoStoreID";
            this.InfoStoreID.Size = new System.Drawing.Size(200, 22);
            this.InfoStoreID.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.InfoView);
            this.groupBox2.Controls.Add(this.InfoStoreID);
            this.groupBox2.Location = new System.Drawing.Point(299, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 453);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.DeleteCarID);
            this.groupBox3.Location = new System.Drawing.Point(756, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 208);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete a car";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Car ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeleteCarID
            // 
            this.DeleteCarID.Location = new System.Drawing.Point(158, 52);
            this.DeleteCarID.Name = "DeleteCarID";
            this.DeleteCarID.Size = new System.Drawing.Size(200, 22);
            this.DeleteCarID.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.UpdateNewPrice);
            this.groupBox4.Controls.Add(this.UpdateCarID);
            this.groupBox4.Location = new System.Drawing.Point(756, 509);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 208);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update a car";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "New price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Car ID:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(129, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 57);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateNewPrice
            // 
            this.UpdateNewPrice.Location = new System.Drawing.Point(181, 84);
            this.UpdateNewPrice.Name = "UpdateNewPrice";
            this.UpdateNewPrice.Size = new System.Drawing.Size(200, 22);
            this.UpdateNewPrice.TabIndex = 3;
            // 
            // UpdateCarID
            // 
            this.UpdateCarID.Location = new System.Drawing.Point(181, 31);
            this.UpdateCarID.Name = "UpdateCarID";
            this.UpdateCarID.Size = new System.Drawing.Size(200, 22);
            this.UpdateCarID.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 746);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PopulateButton);
            this.Controls.Add(this.ShopView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShopView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShopView;
        private System.Windows.Forms.Button PopulateButton;
        private System.Windows.Forms.TextBox AddStoreID;
        private System.Windows.Forms.TextBox AddStoreName;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView InfoView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InfoStoreID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DeleteCarID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox UpdateNewPrice;
        private System.Windows.Forms.TextBox UpdateCarID;
    }
}


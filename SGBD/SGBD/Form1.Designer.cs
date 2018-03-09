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
            this.AddCarID = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddCarStoreID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddCarHorsePower = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddCarEngineCapacity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddCarFabricationDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddCarColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCarPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCarModel = new System.Windows.Forms.TextBox();
            this.InfoView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
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
            this.EmployeeView = new System.Windows.Forms.DataGridView();
            this.OfficeView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShopView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeView)).BeginInit();
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
            this.PopulateButton.Text = "Display stores";
            this.PopulateButton.UseVisualStyleBackColor = true;
            this.PopulateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCarID
            // 
            this.AddCarID.Location = new System.Drawing.Point(172, 25);
            this.AddCarID.Name = "AddCarID";
            this.AddCarID.Size = new System.Drawing.Size(200, 22);
            this.AddCarID.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(129, 379);
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
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Car ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
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
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.AddCarStoreID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.AddCarHorsePower);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.AddCarEngineCapacity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.AddCarFabricationDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddCarColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddCarPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddCarModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AddCarID);
            this.groupBox1.Location = new System.Drawing.Point(1219, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 453);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a car";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Store ID:";
            // 
            // AddCarStoreID
            // 
            this.AddCarStoreID.Location = new System.Drawing.Point(172, 302);
            this.AddCarStoreID.Name = "AddCarStoreID";
            this.AddCarStoreID.Size = new System.Drawing.Size(200, 22);
            this.AddCarStoreID.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Horse power:";
            // 
            // AddCarHorsePower
            // 
            this.AddCarHorsePower.Location = new System.Drawing.Point(172, 260);
            this.AddCarHorsePower.Name = "AddCarHorsePower";
            this.AddCarHorsePower.Size = new System.Drawing.Size(200, 22);
            this.AddCarHorsePower.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Engine capacity:";
            // 
            // AddCarEngineCapacity
            // 
            this.AddCarEngineCapacity.Location = new System.Drawing.Point(172, 216);
            this.AddCarEngineCapacity.Name = "AddCarEngineCapacity";
            this.AddCarEngineCapacity.Size = new System.Drawing.Size(200, 22);
            this.AddCarEngineCapacity.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fabrication date:";
            // 
            // AddCarFabricationDate
            // 
            this.AddCarFabricationDate.Location = new System.Drawing.Point(172, 176);
            this.AddCarFabricationDate.Name = "AddCarFabricationDate";
            this.AddCarFabricationDate.Size = new System.Drawing.Size(200, 22);
            this.AddCarFabricationDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color:";
            // 
            // AddCarColor
            // 
            this.AddCarColor.Location = new System.Drawing.Point(172, 136);
            this.AddCarColor.Name = "AddCarColor";
            this.AddCarColor.Size = new System.Drawing.Size(200, 22);
            this.AddCarColor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price:";
            // 
            // AddCarPrice
            // 
            this.AddCarPrice.Location = new System.Drawing.Point(172, 99);
            this.AddCarPrice.Name = "AddCarPrice";
            this.AddCarPrice.Size = new System.Drawing.Size(200, 22);
            this.AddCarPrice.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Car model:";
            // 
            // AddCarModel
            // 
            this.AddCarModel.Location = new System.Drawing.Point(172, 60);
            this.AddCarModel.Name = "AddCarModel";
            this.AddCarModel.Size = new System.Drawing.Size(200, 22);
            this.AddCarModel.TabIndex = 6;
            // 
            // InfoView
            // 
            this.InfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoView.Location = new System.Drawing.Point(16, 143);
            this.InfoView.Name = "InfoView";
            this.InfoView.RowTemplate.Height = 24;
            this.InfoView.Size = new System.Drawing.Size(405, 240);
            this.InfoView.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(133, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 61);
            this.button2.TabIndex = 14;
            this.button2.Text = "Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmployeeView);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.InfoView);
            this.groupBox2.Location = new System.Drawing.Point(299, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 687);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cars";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.DeleteCarID);
            this.groupBox3.Location = new System.Drawing.Point(762, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 208);
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
            this.groupBox4.Location = new System.Drawing.Point(1219, 500);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 208);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update the price of a car";
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
            // EmployeeView
            // 
            this.EmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeView.Location = new System.Drawing.Point(16, 438);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.RowTemplate.Height = 24;
            this.EmployeeView.Size = new System.Drawing.Size(405, 240);
            this.EmployeeView.TabIndex = 15;
            // 
            // OfficeView
            // 
            this.OfficeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfficeView.Location = new System.Drawing.Point(762, 31);
            this.OfficeView.Name = "OfficeView";
            this.OfficeView.RowTemplate.Height = 24;
            this.OfficeView.Size = new System.Drawing.Size(437, 434);
            this.OfficeView.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 746);
            this.Controls.Add(this.OfficeView);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShopView;
        private System.Windows.Forms.Button PopulateButton;
        private System.Windows.Forms.TextBox AddCarID;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView InfoView;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AddCarStoreID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AddCarHorsePower;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AddCarEngineCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AddCarFabricationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddCarColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddCarPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddCarModel;
        private System.Windows.Forms.DataGridView EmployeeView;
        private System.Windows.Forms.DataGridView OfficeView;
    }
}


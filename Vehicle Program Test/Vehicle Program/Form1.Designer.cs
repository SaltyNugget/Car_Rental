namespace Vehicle_Program
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
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFuelQtyPurchase = new System.Windows.Forms.TextBox();
            this.txtKilometres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFuelCost = new System.Windows.Forms.TextBox();
            this.btnTravel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDayRental = new System.Windows.Forms.Button();
            this.txtPerDayRental = new System.Windows.Forms.TextBox();
            this.txtKmRental = new System.Windows.Forms.TextBox();
            this.btnKmRental = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnServiceVehicle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(131, 39);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturer.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(131, 65);
            this.txtModel.Name = "txtModel";
            this.txtModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 10;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(131, 91);
            this.txtYear.Name = "txtYear";
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 11;
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(131, 117);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistration.Size = new System.Drawing.Size(100, 20);
            this.txtRegistration.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Registration:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.YellowGreen;
            this.btnInsert.Location = new System.Drawing.Point(165, 145);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(79, 36);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert Vehicle";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(452, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 173);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 173);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 235);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total Kilometers Travelled:";
            // 
            // txtFuelQtyPurchase
            // 
            this.txtFuelQtyPurchase.Location = new System.Drawing.Point(559, 268);
            this.txtFuelQtyPurchase.Name = "txtFuelQtyPurchase";
            this.txtFuelQtyPurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFuelQtyPurchase.Size = new System.Drawing.Size(100, 20);
            this.txtFuelQtyPurchase.TabIndex = 25;
            // 
            // txtKilometres
            // 
            this.txtKilometres.Location = new System.Drawing.Point(559, 234);
            this.txtKilometres.Name = "txtKilometres";
            this.txtKilometres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKilometres.Size = new System.Drawing.Size(100, 20);
            this.txtKilometres.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 302);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Fuel Cost Per L:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 269);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(166, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fuel Quantity Purchased L:";
            // 
            // txtFuelCost
            // 
            this.txtFuelCost.Location = new System.Drawing.Point(559, 302);
            this.txtFuelCost.Name = "txtFuelCost";
            this.txtFuelCost.Size = new System.Drawing.Size(100, 20);
            this.txtFuelCost.TabIndex = 33;
            // 
            // btnTravel
            // 
            this.btnTravel.BackColor = System.Drawing.Color.Chocolate;
            this.btnTravel.Location = new System.Drawing.Point(559, 339);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(110, 46);
            this.btnTravel.TabIndex = 21;
            this.btnTravel.Text = "Submit";
            this.btnTravel.UseVisualStyleBackColor = false;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(477, 405);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Per Kilometer Rental:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 406);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Per Day Rental:";
            // 
            // btnDayRental
            // 
            this.btnDayRental.BackColor = System.Drawing.Color.Tomato;
            this.btnDayRental.Location = new System.Drawing.Point(386, 432);
            this.btnDayRental.Name = "btnDayRental";
            this.btnDayRental.Size = new System.Drawing.Size(85, 34);
            this.btnDayRental.TabIndex = 36;
            this.btnDayRental.Text = "Submit";
            this.btnDayRental.UseVisualStyleBackColor = false;
            this.btnDayRental.Click += new System.EventHandler(this.btnDayRental_Click);
            // 
            // txtPerDayRental
            // 
            this.txtPerDayRental.Location = new System.Drawing.Point(393, 406);
            this.txtPerDayRental.Name = "txtPerDayRental";
            this.txtPerDayRental.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPerDayRental.Size = new System.Drawing.Size(78, 20);
            this.txtPerDayRental.TabIndex = 37;
            // 
            // txtKmRental
            // 
            this.txtKmRental.Location = new System.Drawing.Point(616, 403);
            this.txtKmRental.Name = "txtKmRental";
            this.txtKmRental.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKmRental.Size = new System.Drawing.Size(81, 20);
            this.txtKmRental.TabIndex = 38;
            // 
            // btnKmRental
            // 
            this.btnKmRental.BackColor = System.Drawing.Color.Tomato;
            this.btnKmRental.Location = new System.Drawing.Point(611, 432);
            this.btnKmRental.Name = "btnKmRental";
            this.btnKmRental.Size = new System.Drawing.Size(85, 34);
            this.btnKmRental.TabIndex = 39;
            this.btnKmRental.Text = "Submit";
            this.btnKmRental.UseVisualStyleBackColor = false;
            this.btnKmRental.Click += new System.EventHandler(this.btnKmRental_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Service Vehicle:";
            // 
            // btnServiceVehicle
            // 
            this.btnServiceVehicle.BackColor = System.Drawing.Color.Firebrick;
            this.btnServiceVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceVehicle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnServiceVehicle.Location = new System.Drawing.Point(117, 432);
            this.btnServiceVehicle.Name = "btnServiceVehicle";
            this.btnServiceVehicle.Size = new System.Drawing.Size(85, 34);
            this.btnServiceVehicle.TabIndex = 41;
            this.btnServiceVehicle.Text = "Service Vehicle";
            this.btnServiceVehicle.UseVisualStyleBackColor = false;
            this.btnServiceVehicle.Click += new System.EventHandler(this.btnServiceVehicle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtRegistration);
            this.groupBox1.Controls.Add(this.txtManufacturer);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(43, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 181);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Vehicle";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDisplay.Location = new System.Drawing.Point(377, 208);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(69, 22);
            this.btnDisplay.TabIndex = 18;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 478);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnServiceVehicle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnKmRental);
            this.Controls.Add(this.txtKmRental);
            this.Controls.Add(this.txtPerDayRental);
            this.Controls.Add(this.btnDayRental);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTravel);
            this.Controls.Add(this.txtFuelCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtKilometres);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtFuelQtyPurchase);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFuelQtyPurchase;
        private System.Windows.Forms.TextBox txtKilometres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFuelCost;
        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDayRental;
        private System.Windows.Forms.TextBox txtPerDayRental;
        private System.Windows.Forms.TextBox txtKmRental;
        private System.Windows.Forms.Button btnKmRental;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnServiceVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisplay;
    }
}


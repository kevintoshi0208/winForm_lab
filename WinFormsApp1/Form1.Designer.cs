
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateRented = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtDateReturned = new System.Windows.Forms.DateTimePicker();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental System";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(12, 116);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(249, 23);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Rented";
            // 
            // dtDateRented
            // 
            this.dtDateRented.Location = new System.Drawing.Point(12, 172);
            this.dtDateRented.Name = "dtDateRented";
            this.dtDateRented.Size = new System.Drawing.Size(249, 23);
            this.dtDateRented.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Returned";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type Of Car";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(393, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 47);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtDateReturned
            // 
            this.dtDateReturned.Location = new System.Drawing.Point(376, 172);
            this.dtDateReturned.Name = "dtDateReturned";
            this.dtDateReturned.Size = new System.Drawing.Size(223, 23);
            this.dtDateReturned.TabIndex = 10;
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Tesla"});
            this.cbTypeOfCar.Location = new System.Drawing.Point(12, 237);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(249, 23);
            this.cbTypeOfCar.TabIndex = 11;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(376, 97);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(32, 15);
            this.CostLabel.TabIndex = 12;
            this.CostLabel.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(376, 116);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(223, 23);
            this.tbCost.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 342);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.dtDateReturned);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateRented);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDateRented;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtDateReturned;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCose;
        private System.Windows.Forms.TextBox tbCost;
    }
}


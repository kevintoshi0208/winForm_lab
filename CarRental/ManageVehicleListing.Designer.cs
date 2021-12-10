
namespace CarRental
{
    partial class ManageVehicleListing
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
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonEditCar = new System.Windows.Forms.Button();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(27, 93);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.RowTemplate.Height = 24;
            this.gvVehicleList.Size = new System.Drawing.Size(293, 270);
            this.gvVehicleList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(486, 104);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(138, 42);
            this.buttonAddCar.TabIndex = 2;
            this.buttonAddCar.Text = "Add Car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonEditCar
            // 
            this.buttonEditCar.Location = new System.Drawing.Point(486, 211);
            this.buttonEditCar.Name = "buttonEditCar";
            this.buttonEditCar.Size = new System.Drawing.Size(138, 41);
            this.buttonEditCar.TabIndex = 3;
            this.buttonEditCar.Text = "Edit Car";
            this.buttonEditCar.UseVisualStyleBackColor = true;
            this.buttonEditCar.Click += new System.EventHandler(this.buttonEditCar_Click);
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Location = new System.Drawing.Point(486, 316);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(138, 47);
            this.buttonDeleteCar.TabIndex = 4;
            this.buttonDeleteCar.Text = "Delete Car";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteCar);
            this.Controls.Add(this.buttonEditCar);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvVehicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonEditCar;
        private System.Windows.Forms.Button buttonDeleteCar;
    }
}
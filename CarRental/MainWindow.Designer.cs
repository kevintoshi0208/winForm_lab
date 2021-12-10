﻿
namespace CarRental
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVehicleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehicleListingToolStripMenuItem,
            this.manageRentalRecordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVehicleListingToolStripMenuItem
            // 
            this.manageVehicleListingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.removeVehicleToolStripMenuItem,
            this.editVehicleToolStripMenuItem,
            this.viewListingToolStripMenuItem});
            this.manageVehicleListingToolStripMenuItem.Name = "manageVehicleListingToolStripMenuItem";
            this.manageVehicleListingToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.manageVehicleListingToolStripMenuItem.Text = "Manage Vehicle Listing";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            // 
            // removeVehicleToolStripMenuItem
            // 
            this.removeVehicleToolStripMenuItem.Name = "removeVehicleToolStripMenuItem";
            this.removeVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeVehicleToolStripMenuItem.Text = "Remove Vehicle";
            // 
            // editVehicleToolStripMenuItem
            // 
            this.editVehicleToolStripMenuItem.Name = "editVehicleToolStripMenuItem";
            this.editVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editVehicleToolStripMenuItem.Text = "Edit Vehicle";
            // 
            // viewListingToolStripMenuItem
            // 
            this.viewListingToolStripMenuItem.Name = "viewListingToolStripMenuItem";
            this.viewListingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewListingToolStripMenuItem.Text = "View Listing";
            // 
            // manageRentalRecordsToolStripMenuItem
            // 
            this.manageRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalRecordToolStripMenuItem,
            this.editRentalRecordToolStripMenuItem,
            this.viewRentalRecordToolStripMenuItem});
            this.manageRentalRecordsToolStripMenuItem.Name = "manageRentalRecordsToolStripMenuItem";
            this.manageRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.manageRentalRecordsToolStripMenuItem.Text = "Manage Rental Records";
            // 
            // addRentalRecordToolStripMenuItem
            // 
            this.addRentalRecordToolStripMenuItem.Name = "addRentalRecordToolStripMenuItem";
            this.addRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addRentalRecordToolStripMenuItem.Text = "Add Rental Record";
            this.addRentalRecordToolStripMenuItem.Click += new System.EventHandler(this.addRentalRecordToolStripMenuItem_Click);
            // 
            // editRentalRecordToolStripMenuItem
            // 
            this.editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            this.editRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editRentalRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // viewRentalRecordToolStripMenuItem
            // 
            this.viewRentalRecordToolStripMenuItem.Name = "viewRentalRecordToolStripMenuItem";
            this.viewRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewRentalRecordToolStripMenuItem.Text = "View Archive";
            this.viewRentalRecordToolStripMenuItem.Click += new System.EventHandler(this.viewRentalRecordToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(843, 492);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Car Rental Sytem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRentalRecordToolStripMenuItem;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{

    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            PopulateGrid();   
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void buttonEditCar_Click(object sender, EventArgs e)
        {

            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id); 

            var addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

                _db.TypesOfCars.Remove(car);
                _db.SaveChanges();

                gvVehicleList.Refresh();
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
       
        }

        private void gvVehicleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var cars = _db.TypesOfCars
               .Select(q => new {
                   Make = q.Make,
                   Model = q.Model,
                   VIN = q.VIN,
                   Year = q.Year,
                   LicensePlateNumber = q.LicensePlateNumber,
                   Id = q.id
               })
               .ToList()
           ;
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
        }
    }
}

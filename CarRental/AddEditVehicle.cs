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
    public partial class AddEditVehicle : Form
    {
        private bool IsEditMode;
        private readonly CarRentalEntities _db;

        public AddEditVehicle()
        {
            InitializeComponent();
            lb1Title.Text = "Add New Vehicle";
            IsEditMode = false;
            _db = new CarRentalEntities();
        }

        public AddEditVehicle(TypesOfCars carToEdit)
        {
            InitializeComponent();
            lb1Title.Text = "Edit Vehicle";
            PupulateFields(carToEdit);
            IsEditMode = true;
            _db = new CarRentalEntities();
        }

        private void PupulateFields(TypesOfCars car)
        {
            lblId.Text = car.id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicensePlateNumber.Text = car.LicensePlateNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                var id = int.Parse(lblId.Text);
                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);
                setUpCarAndSave(car);
            } else {
                var car = new TypesOfCars();
                setUpCarAndSave(car);
                _db.TypesOfCars.Add(car);
            }
          
        }

        private void setUpCarAndSave(TypesOfCars car)
        {
            car.Model = tbModel.Text;
            car.Make = tbMake.Text;
            car.VIN = tbVIN.Text;
            car.Year = int.Parse(tbYear.Text);
            car.LicensePlateNumber = tbLicensePlateNumber.Text;

            _db.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

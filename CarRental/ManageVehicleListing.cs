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
            gvVehicleList.DataSource = _db.TypesOfCars
                .Select(q=> new { ID = q.id , Name = q.name })
                .ToList()
            ;
            gvVehicleList.Columns[0].HeaderText = "ID";
            gvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditCar_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {

        }
    }
}

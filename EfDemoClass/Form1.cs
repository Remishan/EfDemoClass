using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfDemoClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ModelContext Db = new ModelContext();
            Car car = new Car();
            car.Name = txtName.Text;
            car.Year = Convert.ToInt32(txtYear.Text);
            Db.CarList.Add(car);
            Db.SaveChanges();
            MessageBox.Show("Done");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (ModelContext Db=new ModelContext())
            //{
                
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class MainActivity : Form
    {
        public MainActivity()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            AddControls(new MainActivity());
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {

        }

        private void IngredientsBtn_Click(object sender, EventArgs e)
        {

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {

        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

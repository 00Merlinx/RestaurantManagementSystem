using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Add
{
    public partial class addCategory : sampleAdd
    {
        public addCategory()
        {
            InitializeComponent();
        }
        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void sampleAdd_Load(object sender, EventArgs e)
        {

        }

        public virtual void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

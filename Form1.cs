using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance.SIT405' table. You can move, or remove it, as needed.
            this.sIT405TableAdapter.Fill(this.attendance.SIT405);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCODE qRCODE = new QRCODE();
            qRCODE.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;


namespace Attendance
{
    public partial class QRCODE : Form
    {
        public QRCODE()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;
        private void button1_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void QRCODE_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                comboBox1.Items.Add(filterInfo.Name);

            comboBox1.SelectedIndex = 0;
            timer1.Start();
        }

        private void QRCODE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice.IsRunning == true)
            {
                VideoCaptureDevice.Stop();
            }

            else
            {
                VideoCaptureDevice.Stop();
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            using (SqlConnection con = connection.CONN())
            {
                if (pictureBox1.Image != null)
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                    {
                        textBox1.Text = result.ToString();
                        timer1.Stop();
                        if (VideoCaptureDevice.IsRunning == true)
                        {
                            VideoCaptureDevice.Stop();
                        }

                        SqlCommand cmd = new SqlCommand("select * from [dbo].[ImportData] where [QrCode] = '" + textBox1.Text + "'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds1 = new DataSet();
                        da.Fill(ds1);
                        int i = ds1.Tables[0].Rows.Count;
                        if (i > 0)
                        {
                            string Name = Convert.ToString(ds1.Tables[0].Rows[0]["Name"]);
                            string RegNo = Convert.ToString(ds1.Tables[0].Rows[0]["RegNo"]);
                            string Form = Convert.ToString(ds1.Tables[0].Rows[0]["Form"]);

                            SqlCommand cmd1 = new SqlCommand("select * from [dbo].[SIT405] where [RegNo] = '" + RegNo + "'", con);
                            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                            DataSet ds2 = new DataSet();
                            da1.Fill(ds2);
                            int h = ds2.Tables[0].Rows.Count;
                            if (h == 0)
                            {
                                // If the student doesn't exist, insert a new record
                                SqlCommand insertCmd = new SqlCommand("INSERT INTO [dbo].[SIT405] (RegNo,StudentName, " + comboBox2.SelectedItem.ToString() + ") VALUES (@regno, @name, @attendance)", con);
                                insertCmd.Parameters.AddWithValue("@name", Name);
                                insertCmd.Parameters.AddWithValue("@regno", RegNo);    
                                insertCmd.Parameters.AddWithValue("@attendance", comboBox2.SelectedItem.ToString());
                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("JOH");                              
                            }
                            else
                            {
                                // If the student already exists, update the corresponding week of attendance
                                SqlCommand updateCmd = new SqlCommand("UPDATE [dbo].[SIT405] SET " + comboBox2.SelectedItem.ToString() + "= @attendance WHERE RegNo=@regno", con);
                                updateCmd.Parameters.AddWithValue("@attendance", comboBox2.SelectedItem.ToString());
                                updateCmd.Parameters.AddWithValue("@regno", RegNo);
                                updateCmd.ExecuteNonQuery();
                                //SqlCommand insertCmd1 = new SqlCommand("INSERT INTO [dbo].[SIT405] (RegNo,StudentName, " + comboBox2.SelectedItem.ToString() + ") VALUES ( @regno, @name, @attendance)", con);
                                //insertCmd1.Parameters.AddWithValue("@name", Name);
                                //insertCmd1.Parameters.AddWithValue("@regno", RegNo);
                                //insertCmd1.Parameters.AddWithValue("@attendance", comboBox2.SelectedItem.ToString());
                                //insertCmd1.ExecuteNonQuery();
                                MessageBox.Show("wAZI JOH");
                                //VideoCaptureDevice.Stop();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("tUZIDI");
                        }
                    }
                }
            }
        }
    }
}

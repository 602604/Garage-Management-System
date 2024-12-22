
using System.Data;
using Microsoft.Data.SqlClient;

namespace Garage
{
    public partial class Cars : Form
    {
        bool sidebarExpand;
        public Cars()
        {
            InitializeComponent();
            displayCars();
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\UzairShah\\Documents\\GarageDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void displayCars()
        {
            Con.Open();
            String Query = "select * from CarTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CarNumTb.Text == "Car Number" || CarBrandTb.Text == "Car Brand" || CarModelTb.Text == "Car Model" || ColorTb.Text == "Color" || OwnerNameTb.Text == "OwnerName" || CarNumTb.Text == "" || CarBrandTb.Text == "" || CarModelTb.Text == "" || ColorTb.Text == "" || OwnerNameTb.Text == "")
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CarTbl (Num, CBrand, CModel, CDate, CColor, OwnerName) values(@CN,@CB,@CM,@CD,@CC,@ON)", Con);
                    cmd.Parameters.AddWithValue("@CN", CarNumTb.Text);
                    cmd.Parameters.AddWithValue("@CB", CarBrandTb.Text);
                    cmd.Parameters.AddWithValue("@CM", CarModelTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CC", ColorTb.Text);
                    cmd.Parameters.AddWithValue("@ON", OwnerNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Register");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Cars_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //SET the minimum and maximum size of sidebar Panel 
            if (sidebarExpand)
            {
                //if sidebar  is expand, minimize 
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void manuButton_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest to make smoother
            sidebarTimer.Start();
        }
    }
}

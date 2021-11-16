using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace view1
{
    public partial class CRUDTEST : Form
    {
        public CRUDTEST()
        {
            InitializeComponent();
        }


        // INSERT(CREATE)
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // sql연결
                SqlConnection con = new SqlConnection("Data Source=blank;Initial Catalog=curdTest;Integrated Security=True");
                // db 열기
                con.Open();

                // SQL Server 데이터베이스에 대해 실행할 Transact-SQL 문이나 저장 프로시저를 나타냄
                SqlCommand cmd = new SqlCommand("insert into viewTb1 values (@product_id, @product_name, @price, @img_path)", con);

                cmd.Parameters.AddWithValue("@product_id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@product_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@img_path", textBox4.Text);
                cmd.ExecuteNonQuery();


                // db 닫기
                con.Close();
                MessageBox.Show("성공적으로 저장되었습니다.");

            }
            catch (Exception)
            {
                throw;
            }
        }

        // UPDATE
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // sql연결
                SqlConnection con = new SqlConnection("Data Source=blank;Initial Catalog=curdTest;Integrated Security=True");

                con.Open();

                SqlCommand cmd = new SqlCommand("Update viewTb1 set product_name=@product_name, price=@price, img_path=@img_path where product_id=@product_id", con);

                cmd.Parameters.AddWithValue("@product_id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@product_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@img_path", textBox4.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("성공적으로 갱신되었습니다.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                // sql연결
                SqlConnection con = new SqlConnection("Data Source=blank;Initial Catalog=curdTest;Integrated Security=True");

                con.Open();

                SqlCommand cmd = new SqlCommand("Delete viewTb1 where product_id=@product_id", con);
                cmd.Parameters.AddWithValue("@product_id", textBox1.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("성공적으로 삭제되었습니다.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // SELECT(READ)
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                // sql연결
                SqlConnection con = new SqlConnection("Data Source=blank;Initial Catalog=curdTest;Integrated Security=True");

                // sql연결
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from viewTb1", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Columns["product_id"].ReadOnly = true;
            //dataGridView1.Columns["product_name"].ReadOnly = true;
            //dataGridView1.Columns["price"].ReadOnly = true;
            //dataGridView1.Columns["img_path"].ReadOnly = true;
            dataGridView1.ReadOnly = true;

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            pictureBox1.Load(@"C:\Users\admin\Desktop\제품사진/" + textBox1.Text + ".jpg");
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        // textbox초기화
        private void button5_Click(object sender, EventArgs e)
        {
           textBox1.Text = string.Empty;
           textBox2.Text = string.Empty;
           textBox3.Text = string.Empty;
           textBox4.Text = string.Empty;
        }
    }
}

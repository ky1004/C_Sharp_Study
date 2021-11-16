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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /* INSERT */
        private void button1_Click(object sender, EventArgs e)
        {
            // sql연결
            SqlConnection con = new SqlConnection("Data Source=blank;Initial Catalog=curdTest;Integrated Security=True");
            // db 열기
            con.Open();

            // SQL Server 데이터베이스에 대해 실행할 Transact-SQL 문이나 저장 프로시저를 나타냄
            SqlCommand cmd = new SqlCommand("insert into testTable values (@ID, @Name, @Age)", con);

            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();


            // db 닫기
            con.Close();
            MessageBox.Show("성공적으로 저장되었습니다.");


        }

        /* UPDATE */
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=blank;Initial Catalog=curdTest;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Update testTable set Name=@Name, Age=@Age where ID=@ID", con);

            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("성공적으로 갱신되었습니다.");
        }

        /* UPDATE */
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=blank;Initial Catalog=curdTest;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete testTable where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("성공적으로 삭제되었습니다.");
        }
        /* SELECT */
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=blank;Initial Catalog=curdTest;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from testTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}

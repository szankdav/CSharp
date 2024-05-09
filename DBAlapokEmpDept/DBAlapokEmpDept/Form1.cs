using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAlapokEmpDept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0HFV1GE\\SQLEXPRESS;Initial Catalog=EmpDept;Integrated Security=True");
            try
            {
                conn.Open();
                //MessageBox.Show("Kapcsolat megnyitva.");
                SqlCommand cmd = new SqlCommand("SELECT * FROM emp", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["empno"]);
                }
                reader.Close();
                conn.Close();
                //MessageBox.Show("Lekerdezes sikeres.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM emp", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (listView1.Columns.Count == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listView1.Columns.Add(reader.GetName(i));
                        }
                    }

                    string[] datas = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        datas[i] = reader.GetValue(i).ToString();
                    }
                    listView1.Items.Add(new ListViewItem(datas));
                }

                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM emp", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (dataGridView1.Columns.Count < 1)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                        }
                    }
                    dataGridView1.Rows.Add();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = reader.GetValue(i);
                    }
                }
                conn.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

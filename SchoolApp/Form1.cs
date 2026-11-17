
using MySql.Data.MySqlClient;
using System.Data;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        int selectedId = 0;

        public Form1()
        {
            InitializeComponent();
            ShowData();
        }

        private void ClearData()
        {
            txtName.Clear();
            txtInstitution.Clear();
            selectedId = 0;
            txtName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private MySqlConnection Connection()
        {
            string strConnection = "Server=localhost;Database=pi_school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }

        private void ShowData()
        {
            using (MySqlConnection conn = Connection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM visitor";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvData.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtInstitution.Text))
            {
                MessageBox.Show("Please fill all fields!",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Connection())
            {
                try
                {
                    conn.Open();

                    string queryInsert = "INSERT INTO visitor (visitor_name, institution) VALUES (@name, @institution)";

                    using (MySqlCommand cmd = new MySqlCommand(queryInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@institution", txtInstitution.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Input data Success!",
                        "Input Notif",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearData();
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["id"].Value);

                txtName.Text = row.Cells["visitor_name"].Value.ToString();
                txtInstitution.Text = row.Cells["institution"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record to edit!",
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtInstitution.Text))
            {
                MessageBox.Show("Please fill all fields!",
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Connection())
            {
                try
                {
                    conn.Open();

                    string queryUpdate = "UPDATE visitor SET visitor_name = @name, institution = @institution WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(queryUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@institution", txtInstitution.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Update data Success!",
                        "Update Notif",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearData();
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record to delete!",
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this data?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = Connection())
                {
                    try
                    {
                        conn.Open();

                        string queryDelete = "DELETE FROM visitor WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(queryDelete, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Delete data Success!",
                            "Delete Notif",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        ClearData();
                        ShowData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                    }
                }
            }
        }

    }
}

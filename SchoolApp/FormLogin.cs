using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnNavToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister frmRegister = new FormRegister();
            frmRegister.Show();
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                 string.IsNullOrWhiteSpace(txtRegister.Text))
            {
                MessageBox.Show("Login Gagal! Username dan password wajib diisi.");

                return;
            }

            Connection conn = new Connection();

            using (MySqlConnection connection = conn.ConnectionToSQL())
            {
            connection.Open();

            string query = "SELECT full_name, password FROM users WHERE username = @user";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullName = reader["full_name"].ToString();
                            string storedPassword = reader["password"].ToString();

                            string passwordHashed = SecurityHelper.HashingPassword(txtRegister.Text);

                            if (passwordHashed == storedPassword)
                            {
                                MessageBox.Show("Login Berhasil! Selamat datang, " + fullName + ".");

                                this.Hide();

                                Form1 frm1= new Form1();
                                frm1.Show();
                            }
                            else
                            {
                                MessageBox.Show("Login Gagal! Password salah.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Gagal! Username tidak ditemukan.");
                        }
                    }
                }
            }
        }
    }
}

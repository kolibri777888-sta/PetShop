using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PetShop
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            using (var con = DB.Get())
            {
                var da = new MySqlDataAdapter(@"
        SELECT 
            e.Id,
            e.FullName   AS 'ФИО',
            e.Phone      AS 'Телефон',
            e.Login      AS 'Логин',
            r.Name       AS 'Роль'
        FROM Employees e
        JOIN Roles r ON e.RoleId = r.Id", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv.DataSource = dt;

                // Скрываем ID
                dgv.Columns["Id"].Visible = false;

                dgv.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника!");
                return;
            }

            int id = (int)dgv.SelectedRows[0].Cells["Id"].Value;

            new EditEmployeeForm(id).ShowDialog();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника!");
                return;
            }

            int id = Convert.ToInt32(
                dgv.SelectedRows[0].Cells["Id"].Value);

            if (id == 1)
            {
                MessageBox.Show("Администратора удалять нельзя!");
                return;
            }

            if (MessageBox.Show(
                "Удалить сотрудника?",
                "Подтверждение",
                MessageBoxButtons.YesNo)
                != DialogResult.Yes)
                return;

            try
            {
                using (var con = DB.Get())
                {
                    var cmd = new MySqlCommand(
                        "DELETE FROM Employees WHERE Id=@id", con);

                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Удалено!");
                LoadData();
            }
            catch
            {
                MessageBox.Show(
                    "Есть связанные заказы!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm().ShowDialog();
            LoadData();
        }
    }
}

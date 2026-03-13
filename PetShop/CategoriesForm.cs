using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PetShop
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            using (var con = DB.Get())
            {
                var da = new MySqlDataAdapter(
                    "SELECT Id, Name FROM Categories", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv.DataSource = dt;

                // Скрываем ID
                dgv.Columns["Id"].Visible = false;

                dgv.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            int id =
              (int)dgv.SelectedRows[0].Cells["Id"].Value;

            new EditCategoryForm(id).ShowDialog();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            if (MessageBox.Show(
                "Удалить категорию?",
                "Подтверждение",
                MessageBoxButtons.YesNo)
                != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(
                dgv.SelectedRows[0].Cells["Id"].Value);

            try
            {
                using (var con = DB.Get())
                {
                    var cmd = new MySqlCommand(
                        "DELETE FROM Categories WHERE Id=@id", con);

                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Категория удалена!");
                LoadData();
            }
            catch
            {
                MessageBox.Show(
                    "В категории есть товары!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddCategoryForm().ShowDialog();
            LoadData();
        }
    }
}
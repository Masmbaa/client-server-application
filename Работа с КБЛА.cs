using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class Работа_сКБЛА : Form
    {
        private int _employeeId;
        private string _connectionString = ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString;
        public Работа_сКБЛА(int employeeId)
        {
            InitializeComponent();
            LoadKBLAData();
            _employeeId = employeeId;
        }

        private void LoadKBLAData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = @"SELECT * FROM КБЛА";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewKBLA.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_AddKBLA_Click(object sender, EventArgs e)
        {
            var addForm = new Добавить_КБЛА(_employeeId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadKBLAData();
            }
        }

        private void btn_up_trg_Click(object sender, EventArgs e)
        {
            if (dataGridViewKBLA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите КБЛА для обновления", "Информация",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewKBLA.SelectedRows[0];
            int kblaId = Convert.ToInt32(selectedRow.Cells["IDкбла"].Value);
            string currentState = selectedRow.Cells["Состояние_КБЛА"].Value.ToString();

            using (var updateForm = new ОбновлениеКБЛА(kblaId, currentState, _connectionString, _employeeId))
            {
                if (updateForm.ShowDialog() == DialogResult.OK && updateForm.IsUpdated)
                {
                    // Обновляем данные в таблице
                    LoadKBLAData();

                    // Проверяем новое состояние через свойство NewState
                    if (updateForm.NewState == "Неисправен")
                    {
                        MessageBox.Show("КБЛА переведен в состояние 'Неисправен'. Отчет о поломке создан автоматически.",
                                      "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Работа_сКБЛА_Load(object sender, EventArgs e)
        {

        }
    }
}

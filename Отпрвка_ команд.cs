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
    public partial class Отправка_команд : Form
    {
        private int _employeeId;
        public Отправка_команд(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            LoadTasks();
        }

        private void LoadTasks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString))
                {
                    string query = "SELECT * FROM ЖурналКомандСДетализацией WHERE Код_сотрудника = @EmployeeId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@EmployeeId", _employeeId);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Отладочная информация
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show($"Данные для сотрудника {_employeeId} не найдены. Проверьте БД.");
                    }

                    dataGridViewCommand.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке задач: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_com_Click(object sender, EventArgs e)
        {
            var addForm = new Добавить_команду(_employeeId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Явно обновляем DataGridView
                LoadTasks();
            }
        }

        private void dataGridViewCommand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Отправка_команд_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Управление_задачами : Form
    {
        private int _employeeId;
        public Управление_задачами(int employeeId)
        {
            InitializeComponent();
            LoadTasks();
            _employeeId = employeeId;
        }

        private void LoadTasks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString))
                {
                    string query = "SELECT * FROM Текущие_задачи";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewTasks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке задач: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Код для открытия формы добавления новой задачи
            var addForm = new Добавить_задачу(_employeeId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Явно обновляем DataGridView
                LoadTasks();
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["IDзадачи"].Value);
                var updateForm = new Изменить_статус_задачи(taskId, _employeeId);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTasks(); // Обновляем список после изменения
                }
            }
            else
            {
                MessageBox.Show("Выберите задачу для изменения статуса", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Управление_задачами_Load(object sender, EventArgs e)
        {

        }
    }
}

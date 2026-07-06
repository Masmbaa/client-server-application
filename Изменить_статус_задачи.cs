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
using System.Windows.Forms.VisualStyles;

namespace курсач
{
    public partial class Изменить_статус_задачи : Form
    {
        private int _taskId;
        private int _employeeId;
        public Изменить_статус_задачи(int taskId, int employeeId)
        {
            _taskId = taskId;
            InitializeComponent();
            LoadTaskData();
            LoadStatusOptions();
            _employeeId = employeeId;
        }

        private void LoadTaskData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString))
                {
                    string query = @"
                    SELECT 
                        IDзадачи, 
                        Цель_задачи, 
                        Стадия_выполнения,
                        Ответственный_оператор,
                        КБЛА
                    FROM Текущие_задачи
                    WHERE IDзадачи = @TaskId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskId", _taskId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTaskInfo.Text = $"Задача №{reader["IDзадачи"]}: {reader["Цель_задачи"]}\n" +
                                              $"Текущий статус: {reader["Стадия_выполнения"]}\n" +
                                              $"Ответственный: {reader["Ответственный_оператор"]}\n" +
                                              $"КБЛА: {reader["КБЛА"]}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatusOptions()
        {
            comboBoчStatus.Items.Clear();

            // Вариант 1: Статические статусы
            string[] statuses = { "Новая", "В работе", "На проверке", "Завершена", "Отменена" };
            comboBoчStatus.Items.AddRange(statuses);
        }

        private void comboBoчStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoчStatus.SelectedItem == null)
            {
                MessageBox.Show("Выберите новый статус!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = comboBoчStatus.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("ОбновитьСтатусЗадачи", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IDзадачи", _taskId);
                    cmd.Parameters.AddWithValue("@НовыйСтатус", newStatus);
                    cmd.Parameters.AddWithValue("@Код_оператора", _employeeId);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Читаем как int и преобразуем в bool
                            bool success = reader.GetBoolean(reader.GetOrdinal("Success"));
                            string message = reader.GetString(reader.GetOrdinal("Message"));

                            if (success)
                            {
                                MessageBox.Show(message, "Успех",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(message, "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Изменить_статус_задачи_Load(object sender, EventArgs e)
        {

        }
    }
}

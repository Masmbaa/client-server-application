using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсач
{
    public partial class Добавить_команду : Form
    {
        private int _employeeId;
        private string _connectionString = ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString;

        public Добавить_команду(int employeeId)
        {
            _employeeId = employeeId;
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Заполняем ComboBox с КБЛА
            LoadKBLAList();

            // Заполняем ComboBox с командами
            LoadCommandsList();

            // Устанавливаем текущее время по умолчанию
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now.AddMinutes(1);
        }

        private void LoadKBLAList()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT IDкбла, Состояние_КБЛА FROM КБЛА ORDER BY IDкбла";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxKBLA.DataSource = dt;
                    comboBoxKBLA.DisplayMember = "IDкбла";
                    comboBoxKBLA.ValueMember = "IDкбла";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка КБЛА: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCommandsList()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT Номер_команды, Общее_описание FROM Команда ORDER BY Номер_команды";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxCommand.DataSource = dt;
                    comboBoxCommand.DisplayMember = "Общее_описание";
                    comboBoxCommand.ValueMember = "Номер_команды";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка команд: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            // Проверка времени выполнения
            TimeSpan duration = dateTimePickerEnd.Value - dateTimePickerStart.Value;
            if (duration.TotalSeconds <= 0)
            {
                MessageBox.Show("Время завершения должно быть позже времени отправки", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("ДобавитьКомандуВЖурнал", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Код_сотрудника", _employeeId);
                    cmd.Parameters.AddWithValue("@IDкбла", comboBoxKBLA.SelectedValue);
                    cmd.Parameters.AddWithValue("@Номер_команды", comboBoxCommand.SelectedValue);
                    cmd.Parameters.AddWithValue("@Длительность_выполнения", duration);
                    cmd.Parameters.AddWithValue("@Время_отправки_команды", dateTimePickerStart.Value);
                    cmd.Parameters.AddWithValue("@Время_завершения", dateTimePickerEnd.Value);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Исправленное чтение результата
                            int successInt = reader.GetInt32(0);
                            bool success = successInt != 0;
                            string message = reader.GetString(1);

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
                MessageBox.Show($"Системная ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
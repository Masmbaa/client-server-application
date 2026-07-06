using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсач
{
    public partial class Добавить_КБЛА : Form
    {
        private int _employeeId;
        private string _connectionString = ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString;

        public Добавить_КБЛА(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            InitializeForm();
        }

        private void InitializeForm()
        {
            dateTimePickerLaunchDate.Value = DateTime.Now;

            LoadTasks();
            LoadOrbits();
            LoadKBLaTypes();
            LoadStatuses();
        }

        private void LoadTasks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                                   SELECT IDзадачи, Цель_задачи 
                                   FROM Задача 
                                   WHERE LTRIM(RTRIM(Стадия_выполнения)) IN ('В процессе', 'В ожидании', 'Назначена', 'Новая')";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxTask.DataSource = dt;
                    comboBoxTask.DisplayMember = "Цель_задачи";
                    comboBoxTask.ValueMember = "IDзадачи";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка задач: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrbits()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT IDорбиты, Функции_орбиты FROM Орбита";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxOrbit.DataSource = dt;
                    comboBoxOrbit.DisplayMember = "Функции_орбиты";
                    comboBoxOrbit.ValueMember = "IDорбиты";
                    comboBoxOrbit.SelectedIndex = -1; // Можно не выбирать по умолчанию
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка орбит: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKBLaTypes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT ID_типа, Название FROM Тип_КБЛА";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxType.DataSource = dt;
                    comboBoxType.DisplayMember = "Название";
                    comboBoxType.ValueMember = "ID_типа";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки типов КБЛА: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatuses()
        {
            comboBoxStatus.Items.AddRange(new object[] {
                "Работает",
                "Неисправен",
                "На обслуживании",
                "Выведен из строя",
                "Проверяется",
                "Не работает"
            });
            comboBoxStatus.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxManufacturer.Text))
            {
                MessageBox.Show("Укажите производителя КБЛА", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("ДобавитьКБЛА", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Код_сотрудника", SqlDbType.Int).Value = _employeeId;
                    cmd.Parameters.Add("@IDзадачи", SqlDbType.Int).Value = comboBoxTask.SelectedValue;

                    if (comboBoxOrbit.SelectedValue != null)
                        cmd.Parameters.Add("@IDорбиты", SqlDbType.Int).Value = comboBoxOrbit.SelectedValue;
                    else
                        cmd.Parameters.Add("@IDорбиты", SqlDbType.Int).Value = DBNull.Value;

                    cmd.Parameters.Add("@ID_типа_КБЛА", SqlDbType.Int).Value = comboBoxType.SelectedValue;
                    cmd.Parameters.Add("@Состояние_КБЛА", SqlDbType.NVarChar, 50).Value = comboBoxStatus.SelectedItem.ToString();
                    cmd.Parameters.Add("@Дата_запуска", SqlDbType.Date).Value = dateTimePickerLaunchDate.Value.Date;
                    cmd.Parameters.Add("@Производитель", SqlDbType.NVarChar, 100).Value = textBoxManufacturer.Text.Trim();

                    conn.Open();
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show($"КБЛА успешно добавлен с ID: {newId}", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении КБЛА: {ex.Message}", "Ошибка",
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

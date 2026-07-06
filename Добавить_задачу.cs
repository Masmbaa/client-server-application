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
    public partial class Добавить_задачу : Form
    {
        private int _employeeId;
        public Добавить_задачу(int employeeId)
        {
            InitializeComponent();
            InitializeForm();
            _employeeId = employeeId;
        }

        private void Добавить_задачу_Load(object sender, EventArgs e)
        {

        }

        private void InitializeForm()
        {
            // Установка значений по умолчанию
            dateTimePickerBegin.Value = DateTime.Today;
            dateTimePickerEnd.ShowCheckBox = true; // Включаем чекбокс
            dateTimePickerEnd.Checked = false; // По умолчанию NULL (не задана)
            dateTimePickerEnd.Value = DateTime.Today; // Значение по умолчанию, но не будет использоваться при Checked=false


            // Заполнение статусов
            comboBoxStatus.Items.AddRange(new[] { "Новая", "В работе", "На проверке", "Завершена", "Отменена" });
            comboBoxStatus.SelectedIndex = 0;

            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Валидация ввода
            if (string.IsNullOrWhiteSpace(textBoxNameTask.Text))
            {
                MessageBox.Show("Введите цель задачи", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("ДобавитьЗадачу", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Параметры
                    cmd.Parameters.AddWithValue("@Код_оператора", _employeeId);
                    cmd.Parameters.AddWithValue("@Цель_задачи", textBoxNameTask.Text.Trim());
                    cmd.Parameters.AddWithValue("@Дата_начала", dateTimePickerBegin.Value.Date);

                    // Обработка NULL для даты окончания
                    if (dateTimePickerEnd.Checked)
                        cmd.Parameters.AddWithValue("@Дата_окончания", dateTimePickerEnd.Value.Date);
                    else
                        cmd.Parameters.AddWithValue("@Дата_окончания", DBNull.Value);

                    cmd.Parameters.AddWithValue("@Статус_задачи", comboBoxStatus.SelectedItem.ToString());

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
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
                MessageBox.Show($"Системная ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerEnd.Value < dateTimePickerBegin.Value)
            {
                MessageBox.Show("Дата окончания не может быть раньше даты начала", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerEnd.Value = dateTimePickerBegin.Value;
            }
        }
    }
}

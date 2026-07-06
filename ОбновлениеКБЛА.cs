using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class ОбновлениеКБЛА : Form
    {
        private int _kblaId;
        private string _currentState;
        private string _connectionString;
        private int _employeeId;

        public bool IsUpdated { get; private set; } = false;
        public string NewState { get; private set; }

        public ОбновлениеКБЛА(int kblaId, string currentState, string connectionString, int employeeId)
        {
            InitializeComponent();
            _kblaId = kblaId;
            _currentState = currentState;
            _connectionString = connectionString;
            _employeeId = employeeId;

            InitializeForm();
        }

        private void InitializeForm()
        {
            this.Text = $"Обновление состояния КБЛА (ID: {_kblaId})";
            lblCurrentState.Text = $"Текущее состояние: {_currentState}";

            comboBoxStates.Items.AddRange(new string[]
            {
            "Работает",
            "Неисправен",
            "На обслуживании",
            "Выведен из строя",
                "Проверяется",
            "Не работает"
            });

            comboBoxStates.SelectedItem = _currentState;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string NewState = comboBoxStates.SelectedItem.ToString();

            if (NewState == _currentState)
            {
                MessageBox.Show("Состояние не изменилось", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ОбновитьСостояниеКБЛА", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IDкбла", _kblaId);
                        command.Parameters.AddWithValue("@НовоеСостояние", NewState);
                        command.Parameters.AddWithValue("@КодСотрудника", _employeeId);

                        command.ExecuteNonQuery();

                        IsUpdated = true;
                        MessageBox.Show("Состояние КБЛА успешно обновлено", "Успех",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при обновлении состояния:\n{ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка:\n{ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

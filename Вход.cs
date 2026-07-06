using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace курсач
{
    public partial class Vhod : Form
    {
        // Публичное свойство для хранения данных сотрудника
        public int EmployeeId { get; private set; }
        public string EmployeePosition { get; private set; }

        public Vhod()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Метод для проверки сотрудника в БД
        private bool CheckEmployeeInDatabase(string snils, out int employeeId, out string position)
        {
            employeeId = 0;
            position = string.Empty;
            string query = @"SELECT s.Код_сотрудника, d.Название 
                            FROM Сотрудник s
                            JOIN Должность d ON s.Код_должности = d.Код_должности
                            WHERE s.СНИЛС = @SNILS";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SNILS", snils);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeId = reader.GetInt32(0);
                            position = reader.GetString(1);
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при проверке сотрудника: " + ex.Message, "Ошибка БД",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        // Метод для проверки формата СНИЛС
        private bool IsValidSNILS(string snils)
        {
            // Регулярное выражение для формата XXX-XXX-XXX XX
            var regex = new System.Text.RegularExpressions.Regex(@"^\d{3}-\d{3}-\d{3} \d{2}$");
            return regex.IsMatch(snils);
        }

        private void btn_vh_Click(object sender, EventArgs e)
        {
            string UserSNILS = textBox_vh.Text.Trim();

            if (string.IsNullOrEmpty(UserSNILS))
            {
                MessageBox.Show("Пожалуйста, введите СНИЛС!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidSNILS(UserSNILS))
            {
                MessageBox.Show("СНИЛС должен быть в формате: XXX-XXX-XXX XX", "Неверный формат",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем существование СНИЛС в БД
            if (!CheckEmployeeInDatabase(UserSNILS, out int employeeId, out string position))
            {
                MessageBox.Show("Сотрудник с таким СНИЛС не найден или нет доступа!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Сохраняем данные сотрудника
            EmployeeId = employeeId;
            EmployeePosition = position;

            // В зависимости от должности открываем соответствующую форму
            if (position == "Оператор")
            {
                this.Hide(); // Скрываем форму входа
                var mainForm = new Главная_оператора(employeeId);
                mainForm.ShowDialog();
                this.Close(); // Закрываем форму входа после закрытия основной формы
            }
            else
            {
                MessageBox.Show($"Должность '{position}' не имеет доступа к этой системе", "Ограничение доступа",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Vhod_Load(object sender, EventArgs e)
        {

        }
    }
}

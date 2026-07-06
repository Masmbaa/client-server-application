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
    public partial class Главная_оператора : Form
    {
        private int _employeeId;
        private string _operatorName;
        public Главная_оператора(int employeeId)
        {
            _employeeId = employeeId;
            InitializeComponent();
            LoadOperatorData();
        }

        private void LoadOperatorData()
        {
            // Загрузка данных оператора
            string query = "SELECT ФИО FROM Сотрудник WHERE Код_сотрудника = @EmployeeId";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeId", _employeeId);
                conn.Open();
                _operatorName = cmd.ExecuteScalar()?.ToString() ?? "Оператор";
            }

            lblWelcome.Text = $"Добро пожаловать, {_operatorName}!";
        }

        // Обработчики событий для кнопок
        private void btnTaskManagement_Click(object sender, EventArgs e)
        {
            // Код для открытия формы управления задачами
            var taskForm = new Управление_задачами(_employeeId);
            taskForm.ShowDialog();
        }

        private void btnUAVStatus_Click(object sender, EventArgs e)
        {
            // Код для открытия формы контроля состояния
            var statusForm = new Контроль_состояния();
            statusForm.ShowDialog();
        }

        private void btnSendCommands_Click(object sender, EventArgs e)
        {
            // Код для открытия формы отправки команд
            var commandsForm = new Отправка_команд(_employeeId);
            commandsForm.ShowDialog();
        }



        private void btnKBLA_Click(object sender, EventArgs e)
        {
            // Код для открытия формы работы с КБЛА
            var sensorsForm = new Работа_сКБЛА(_employeeId);
            sensorsForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // Код для открытия формы генерации отчетов
            var reportsForm = new Отчет();
            reportsForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Код для выхода из приложения
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDatchick_Click(object sender, EventArgs e)
        {

            var reportsForm = new Датчики();
            reportsForm.ShowDialog();
        }

        private void Главная_оператора_Load(object sender, EventArgs e)
        {

        }
    }
}

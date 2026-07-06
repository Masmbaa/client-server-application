using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсач
{
    public partial class Отчет : Form
    {
        private string connectionString;

        public Отчет()
        {
            InitializeComponent();
            InitializeConnectionString();
            InitializeReportTypes();
        }

        private void InitializeConnectionString()
        {
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["КБЛА_Management"].ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Не найдена строка подключения в конфигурации", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении строки подключения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void InitializeReportTypes()
        {
            comboBoxReportType.Items.AddRange(new string[]
            {
                "Отчет о текущем состоянии КБЛА",
                "Отчет об ошибках"
            });
            comboBoxReportType.SelectedIndex = 0;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                btnGenerateReport.Enabled = false;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    DataTable dataTable = new DataTable();

                    if (comboBoxReportType.SelectedIndex == 0)
                    {
                        GenerateUAVStatusReport(conn, dataTable);
                        lblReportTitle.Text = "Отчет о текущем состоянии КБЛА (" + DateTime.Now.ToString("dd.MM.yyyy") + ")";
                    }
                    else
                    {
                        GenerateErrorsReport(conn, dataTable);
                        lblReportTitle.Text = "Отчет об ошибках (" + DateTime.Now.ToString("dd.MM.yyyy") + ")";
                    }

                    dataGridViewReport.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при формировании отчета: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnGenerateReport.Enabled = true;
            }
        }

        private void GenerateUAVStatusReport(SqlConnection conn, DataTable dataTable)
        {
            string query = @"
                SELECT 
                    к.IDкбла,
                    к.Состояние_КБЛА,
                    т.Название AS Тип_КБЛА,
                    о.Функции_орбиты,
                    з.Стадия_выполнения AS Текущая_задача
                FROM КБЛА к
                JOIN Тип_КБЛА т ON к.ID_типа_КБЛА = т.ID_типа
                JOIN Орбита о ON к.IDорбиты = о.IDорбиты
                LEFT JOIN Задача з ON к.IDзадачи = з.IDзадачи";

            new SqlDataAdapter(query, conn).Fill(dataTable);
        }

        private void GenerateErrorsReport(SqlConnection conn, DataTable dataTable)
        {
            string query = @"
                SELECT 
                    о.ID_отчета,
                    д.Серийный_номер AS Датчик,
                    т.Название_типа AS Тип_ошибки,
                    о.Дата_и_время_ошибки,
                    к.Состояние_КБЛА
                FROM Отчет_об_ошибках о
                JOIN Датчики д ON о.Серийный_номер = д.Серийный_номер
                JOIN Ошибка е ON о.Код_ошибки = е.Код_ошибки
                JOIN Тип_ошибки т ON е.ID_типа_ошибки = т.ID_типа
                JOIN КБЛА к ON д.IDкбла = к.IDкбла
                ORDER BY о.Дата_и_время_ошибки DESC";

            new SqlDataAdapter(query, conn).Fill(dataTable);
        }

        private void Отчет_Load(object sender, EventArgs e)
        {

        }
    }
}
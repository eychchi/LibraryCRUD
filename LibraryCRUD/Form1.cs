using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryCRUD
{
    public partial class LibraryCRUDApplication : Form
    {
        string myConnectionString = "server=sql.freedb.tech;database=freedb_LibraryLoanSystem;uid=freedb_Group30;pwd=&?YuUVn72Z!dpG!;Allow User Variables=True";


        public LibraryCRUDApplication()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Leave Empty
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Leave Empty
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Leave Empty. Causes I
        }

        private void LibraryCRUDApplication_Load(object sender, EventArgs e)
        {
            LoadDataIntoGrid();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoanID_Entry.Text) || string.IsNullOrEmpty(MemberID_Entry.Text) || string.IsNullOrEmpty(MemberName_Entry.Text) || string.IsNullOrEmpty(BookTitle_Entry.Text) || string.IsNullOrEmpty(LoanStatus_Entry.Text) || string.IsNullOrEmpty(CheckoutDate_Entry.Text) || string.IsNullOrEmpty(ReturnDate_Entry.Text))
            {
                MessageBox.Show("Please enter all the necessary details.");
            }
            else
            {
                if (!MemberIDValidity(MemberID_Entry.Text))
                {
                    MessageBox.Show("Member ID not found.");
                    return;
                }

                string query = "INSERT INTO Loans (Loan_ID, Member_ID, Member_Name, Book_Title, Loan_Status, Checkout_Date, Return_Date) VALUES (@LoanID, @MemberID, @MemberName, @BookTitle, @LoanStatus, @CheckoutDate, @ReturnDate)";
                ExecuteQueryAndUpdateGrid(query, LoanID_Entry.Text, MemberID_Entry.Text, MemberName_Entry.Text, BookTitle_Entry.Text, LoanStatus_Entry.Text, CheckoutDate_Entry.Text, ReturnDate_Entry.Text); //change 3

            }

        }
        private bool MemberIDValidity(string memberID)
        {
            string query = $"SELECT COUNT(*) FROM Members WHERE Member_ID = '{memberID}'";

            using (MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Loans WHERE";
            List<string> conditions = new List<string>();

            if (!string.IsNullOrEmpty(LoanID_Entry.Text))
            {
                conditions.Add($"Loan_ID = {LoanID_Entry.Text}");
            }
            if (!string.IsNullOrEmpty(MemberID_Entry.Text))
            {
                conditions.Add($"Member_ID = {MemberID_Entry.Text}");
            }
            if (!string.IsNullOrEmpty(MemberName_Entry.Text))
            {
                conditions.Add($"Member_Name LIKE '%{MemberName_Entry.Text}%'");
            }
            if (!string.IsNullOrEmpty(BookTitle_Entry.Text))
            {
                conditions.Add($"Book_Title LIKE '%{BookTitle_Entry.Text}%'");
            }
            if (!string.IsNullOrEmpty(LoanStatus_Entry.Text))
            {
                conditions.Add($"Loan_Status = '{LoanStatus_Entry.Text}'");
            }
            if (!string.IsNullOrEmpty(CheckoutDate_Entry.Text))
            {
                conditions.Add($"Checkout_Date = '{CheckoutDate_Entry.Text}'");
            }
            if (!string.IsNullOrEmpty(ReturnDate_Entry.Text))
            {
                conditions.Add($"Return_Date = '{ReturnDate_Entry.Text}'");
            }

            if (conditions.Count > 0)
            {
                query += " " + string.Join(" AND ", conditions);
                LoadData(query);
            }
            else
            {
                MessageBox.Show("Please enter at least one data to search.");
            }
        }

        private void LoadData(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Loans " +
                           "SET Member_ID = @MemberID, Member_Name = @MemberName, " +
                           "Book_Title = @BookTitle, Loan_Status = @LoanStatus, " +
                           "Checkout_Date = @CheckoutDate, Return_Date = @ReturnDate " +
                           "WHERE Loan_ID = @LoanID";

            Console.WriteLine("Query: " + query);

            ExecuteQueryAndUpdateGrid(query, MemberID_Entry.Text, MemberName_Entry.Text, BookTitle_Entry.Text, LoanStatus_Entry.Text, CheckoutDate_Entry.Text, ReturnDate_Entry.Text, LoanID_Entry.Text);
        }

        private void ExecuteQueryAndUpdateGrid(string query, params string[] parameters)
        {
            using (MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.Clear();

                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.AddWithValue($"@Param{i}", parameters[i]);
                }

                command.ExecuteNonQuery();

                LoadDataIntoGrid();
            }
        }
        private void LoadDataIntoGrid()
        {
            string query = "SELECT * FROM Loans";
            using (MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void LoanID_Entry_TextChanged(object sender, EventArgs e)
        {
            string Loan_ID = LoanID_Entry.Text;
        }
        private void MemberID_Entry_TextChanged(object sender, EventArgs e)
        {
            string Member_ID = MemberID_Entry.Text;
        }
        private void MemberName_Entry_TextChanged(object sender, EventArgs e)
        {
            string Member_Name = MemberName_Entry.Text;
        }
        private void BookTitle_Entry_TextChanged(object sender, EventArgs e)
        {
            string Book_Title = BookTitle_Entry.Text;
        }
        private void LoanStatus_Entry_TextChanged(object sender, EventArgs e)
        {
            string Loan_Status = LoanStatus_Entry.Text;
        }
        private void CheckoutDate_Entry_TextChanged(object sender, EventArgs e)
        {
            string Checkout_Date = CheckoutDate_Entry.Text;
        }
        private void ReturnDate_Entry_TextChanged(object sender, EventArgs e)
        {
            string Return_Date = ReturnDate_Entry.Text;
        }
        private void CreateDB_Entry_TextChanged(object sender, EventArgs e)
        {
            string dbName = DB_Entry.Text;
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LoanID_Entry.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string loanID = LoanID_Entry.Text;
                    string query = $"DELETE FROM Loans WHERE Loan_ID = {loanID}";

                    ExecuteQueryAndUpdateGrid(query);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Loan ID.");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {   //Display Folder Directory
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                //Export saved Excel file to specified Folder Directory
                ExportToExcel(folderPath);
            }
        }

        private void ExportToExcel(string folderPath)
        {
            try
            {
                //Folder Directory/Creation
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                //From Database to Excel File name
                Dictionary<string, string> tableFileNames = new Dictionary<string, string>
        {
            { "Loans", "Loans.xlsx" },
            { "Members", "Members.xlsx" },
            { "Books", "Books.xlsx" },
            { "LibraryCopies", "LibraryCopies.xlsx" },
            { "Librarians", "Librarians.xlsx" }
        };

                //Exporting data
                foreach (var kvp in tableFileNames)
                {
                    string tableName = kvp.Key;
                    string fileName = kvp.Value;

                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false;

                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                    //Saving the data from current table
                    DataTable dataTable = new DataTable();
                    using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                    {
                        connection.Open();
                        string query = $"SELECT * FROM {tableName}";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }

                    //Writing data in Excel
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            if (dataTable.Rows[i][j] is DateTime)
                            {
                                worksheet.Cells[i + 2, j + 1] = ((DateTime)dataTable.Rows[i][j]).ToString("yyyy/MM/dd");
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                            }
                        }
                    }

                    //Saving the Excel file in a specified directory
                    string filePath = Path.Combine(folderPath, fileName);
                    workbook.SaveAs(filePath);

                    workbook.Close();
                    excelApp.Quit();

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }

                MessageBox.Show("Data saved to Excel successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Loans";

            using (MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void CreateDB_Click(object sender, EventArgs e)
        {   // Get the database name from the CreateDB_Entry_TextChanged or any other input control
            string dbName = DB_Entry.Text;

            if (string.IsNullOrWhiteSpace(dbName))
            {
                MessageBox.Show("Please enter a valid database name.");
                return;
            }

            string createDatabaseQuery = $"CREATE DATABASE IF NOT EXISTS `{dbName}`";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(createDatabaseQuery, connection);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show($"Database '{dbName}' created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating database: {ex.Message}");
            }
        }

        private void DisplayDB_Click(object sender, EventArgs e)
        {
            string query = "SHOW DATABASES";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying databases: {ex.Message}");
            }
        }
    }
}
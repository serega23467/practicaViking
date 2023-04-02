using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using dataBaseViking;
using System.IO;
using System.Xml.Linq;
using System.Threading;

namespace Viking
{
    public partial class FormMain : Form
    {
        int selectedRow;
        public static int ID;
        public static DataBase dataBase = DataBase.getInstance();
        public FormMain()
        {
            InitializeComponent();

            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.AllowUserToDeleteRows = false;

            dataGridViewClients.EnableHeadersVisualStyles = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewClients.ColumnHeadersDefaultCellStyle.Font.FontFamily, 12f);

            textBoxName.MaxLength = 20;
            textBoxSurname.MaxLength = 20;
            textBoxPatronymic.MaxLength = 20;
            textBoxPhoneNumber.MaxLength = 11;
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CreateColumns()
        {
            dataGridViewClients.Columns.Add("client_id", "ID");
            dataGridViewClients.Columns.Add("client_name", "Имя");
            dataGridViewClients.Columns.Add("client_surname", "Фамилия");
            dataGridViewClients.Columns.Add("client_patronymic", "Отчество");
            dataGridViewClients.Columns.Add("client_gender", "Пол");
            dataGridViewClients.Columns.Add("client_phone_number", "Номер телефона");
            dataGridViewClients.Columns.Add("client_birthday", "Возраст");
            dataGridViewClients.Columns.Add("client_status", "Статус");
            dataGridViewClients.Columns.Add("client_aboniment_end", "Абонимент до");
        }
        private void ReadSingleRows(DataGridView dgw, IDataRecord record, string aboniment)
        {
            TimeSpan ts = DateTime.Now.Subtract(record.GetDateTime(6));
            double totalDays = ts.TotalDays;
            DateTime dt = new DateTime().AddDays(totalDays);
            DateTime age = new DateTime().AddDays(totalDays);
            if (dt.Year + record.GetDateTime(6).Year > DateTime.Now.Year)
                age = dt.AddYears(-1);
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), age.Year, record.GetString(7), aboniment);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string sqlQueryDgw = "select * from Clients order by client_id desc";            
            SQLiteCommand sqliteCommandDgw = new SQLiteCommand(sqlQueryDgw, dataBase.getConnection());
            dataBase.openConnection();
            SQLiteDataReader sqliteDataReaderDgw = sqliteCommandDgw.ExecuteReader();
            string aboniment = "";
            while (sqliteDataReaderDgw.Read())
            {
                if(DateTime.Now>sqliteDataReaderDgw.GetDateTime(8))
                {
                    aboniment = "Истёк";
                }
                else
                {
                    aboniment = sqliteDataReaderDgw.GetDateTime(8).ToShortDateString();
                }
                ReadSingleRows(dgw, sqliteDataReaderDgw, aboniment);
            }
            sqliteDataReaderDgw.Close();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string sqlQueryDgwSearch = "select * from Clients where client_id || client_name || client_surname || client_patronymic || client_gender || client_phone_number || client_birthday || client_status || client_aboniment_end like '%" + textBoxSearch.Text + "%' order by client_id desc";
            SQLiteCommand sqliteCommandSearch = new SQLiteCommand(sqlQueryDgwSearch, dataBase.getConnection());
            dataBase.openConnection();
            string aboniment = "";
            SQLiteDataReader sqliteDataReaderSearch = sqliteCommandSearch.ExecuteReader();
            while (sqliteDataReaderSearch.Read())
            {
                if (DateTime.Now > sqliteDataReaderSearch.GetDateTime(8))
                {
                    aboniment = "Истёк";
                }
                else
                {
                    aboniment = sqliteDataReaderSearch.GetDateTime(8).ToShortDateString();
                }
                ReadSingleRows(dgw, sqliteDataReaderSearch, aboniment);
            }
            sqliteDataReaderSearch.Close();
            dataBase.closeConnection();
        }       
        private void labelAddClient_Click(object sender, EventArgs e)
        {
            ClientAdd clientAdd = new ClientAdd();
            clientAdd.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewClients);
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewClients);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridViewClients);
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataBase.openConnection();
            selectedRow = e.RowIndex;
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridViewClients.Rows[selectedRow];
                string sqliteQueryBirthday= $"select client_birthday from Clients where client_id = {int.Parse(row.Cells[0].Value.ToString())}";
                SQLiteCommand sqliteCommand = new SQLiteCommand(sqliteQueryBirthday, dataBase.getConnection());
                SQLiteDataReader sqliteDataReaderBirthday = sqliteCommand.ExecuteReader();
                while(sqliteDataReaderBirthday.Read())
                {
                    if (!sqliteDataReaderBirthday.IsDBNull(0))
                        monthCalendarBirthday2.SelectionStart = sqliteDataReaderBirthday.GetDateTime(0);
                }
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxSurname.Text = row.Cells[2].Value.ToString();
                textBoxPatronymic.Text = row.Cells[3].Value.ToString();
                comboBoxGender.SelectedItem = row.Cells[4].Value.ToString();
                textBoxPhoneNumber.Text = row.Cells[5].Value.ToString();
                comboBoxStatus.SelectedItem = row.Cells[7].Value.ToString();
            }
            dataBase.closeConnection();
        }

        private void labelDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.Rows.Count>0)
            {
                DataGridViewRow row = dataGridViewClients.Rows[selectedRow];
                int index = dataGridViewClients.CurrentCell.RowIndex;
                string sqlQueryDelete = $"delete from Clients where client_id = {row.Cells[0].Value}";
                dataGridViewClients.Rows[index].Visible = false;
                dataBase.openConnection();
                SQLiteCommand sqliteCommandDelete = new SQLiteCommand(sqlQueryDelete, dataBase.getConnection());
                sqliteCommandDelete.ExecuteNonQuery();
                RefreshDataGrid(dataGridViewClients);
            }
        }

        private void labelEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.Rows.Count > 0)
            {
                DateTime birthday = monthCalendarBirthday2.SelectionStart;
                bool isNameNull = string.IsNullOrEmpty(textBoxName.Text);
                bool isSurnameNameNull = string.IsNullOrEmpty(textBoxSurname.Text);
                bool hasPhoneNumber = false;
                DataGridViewRow row = dataGridViewClients.Rows[selectedRow];
                if (textBoxPhoneNumber.Text.Length == 11 && monthCalendarBirthday2.SelectionStart <= DateTime.Now.AddYears(-18) && !isNameNull && !isSurnameNameNull)
                {
                    dataBase.openConnection();
                    string sqlQueryCheckPhoneNumber = $"select client_id, client_name, client_surname from Clients where client_phone_number = '{textBoxPhoneNumber.Text}' and client_id !={row.Cells[0].Value}";
                    string sqlQueryEdit = $"update Clients set client_name = '{textBoxName.Text}', client_surname = '{textBoxSurname.Text}', client_patronymic = '{textBoxPatronymic.Text}', client_gender = '{comboBoxGender.Text}', client_phone_number = '{textBoxPhoneNumber.Text}', client_birthday = '{FormMain.dataBase.ToDateSQLite(birthday)}', client_status ='{comboBoxStatus.Text}' where client_id = {row.Cells[0].Value}";
                    SQLiteCommand sqliteCommandEdit = new SQLiteCommand(sqlQueryEdit, dataBase.getConnection());
                    SQLiteCommand sqlCommandCheckPhoneNumber = new SQLiteCommand(sqlQueryCheckPhoneNumber, FormMain.dataBase.getConnection());
                    SQLiteDataReader readerPhoneNumber = sqlCommandCheckPhoneNumber.ExecuteReader();
                    while (readerPhoneNumber.Read())
                    {
                        if (!readerPhoneNumber.IsDBNull(0))
                        {
                            hasPhoneNumber = true;
                            int userId = readerPhoneNumber.GetInt32(0);
                            string userName = readerPhoneNumber.GetString(1);
                            string userSurname = readerPhoneNumber.GetString(2);
                            MessageBox.Show($"Такой номер телефона уже используется пользователем:\nID:{userId}, Имя:{userName}, Фамилия:{userSurname}", "Ошибка");
                            readerPhoneNumber.Close();
                            break;
                        }
                    }
                    if (hasPhoneNumber == false)
                    {
                        sqliteCommandEdit.ExecuteNonQuery();
                        MessageBox.Show("Клиент успешно изменён", "Успех");
                    }
                }
                else
                {
                    MessageBox.Show("Клиент не изменён!", "Ошибка");
                }
                dataBase.closeConnection();
                RefreshDataGrid(dataGridViewClients);
            }           
        }

        private void labelAboniment_Click(object sender, EventArgs e)
        {

            if (dataGridViewClients.Rows.Count > 0)
            {
                DataGridViewRow row = dataGridViewClients.Rows[selectedRow];
                ID = (int)row.Cells[0].Value;
                if (row.Cells[8].Value != "Истёк")
                {
                    MessageBox.Show("Абонимент еще не истёк", "Ошибка");
                }
                else
                {
                    Aboniment aboniment = new Aboniment();
                    aboniment.Show();
                }
            }
        }

        private void labelTest_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            List<string> surnames = new List<string>();
            List<string> patronymic= new List<string>();
            List<string> gender = new List<string>();

            List<string> phoneNumber = new List<string>();
            List<string> birthday = new List<string>();
            List<string> status = new List<string>();
            List<string> aboniment = new List<string>();

            string pathNames = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "имена.txt");
            string pathSurnames = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "фамилии.txt");
            string pathPatronymic = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "отчества.txt");
            string pathGender = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "пол.txt");

            string pathPhoneNumber = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "номера_телефонов.txt");
            string pathBirthday = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "дни_рождения.txt");
            string pathStatus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "статус.txt");
            string pathAboniment= Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "абонимент.txt");

            using(StreamReader sr = new StreamReader(pathNames))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader(pathSurnames))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    surnames.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader(pathPatronymic))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    patronymic.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader(pathGender))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    gender.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader(pathPhoneNumber))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    phoneNumber.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader(pathBirthday))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    birthday.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader(pathStatus))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    status.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader(pathAboniment))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    aboniment.Add(FormMain.dataBase.ToDateSQLite(DateTime.Now.AddDays(int.Parse(line))));
                }
            }
            dataBase.openConnection();
            for(int i = 0; i<patronymic.Count; i++)
            {
                string sqlQueryAddClient = $"insert into Clients(client_name, client_surname, client_patronymic, client_gender, client_phone_number, client_birthday, client_status, client_aboniment_end) values('{names[i]}', '{surnames[i]}', '{patronymic[i]}', '{gender[i]}', '{phoneNumber[i]}', '{birthday[i]}', '{status[i]}', '{aboniment[i]}')";
                SQLiteCommand sqlCommandAddClient = new SQLiteCommand(sqlQueryAddClient, FormMain.dataBase.getConnection());
                sqlCommandAddClient.ExecuteNonQuery();
                Thread.Sleep(10);
            }
            dataBase.closeConnection();
            MessageBox.Show("Тестовые пользователи добавлены","Успех");
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewClients);
        }
    }
}

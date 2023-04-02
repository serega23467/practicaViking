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
using System.Data.SqlClient;

namespace Viking
{
    public partial class ClientAdd : Form
    {
        public ClientAdd()
        {
            InitializeComponent();
            textBoxName.MaxLength = 20;
            textBoxSurname.MaxLength = 20;
            textBoxPatronymic.MaxLength = 20;
            textBoxPhoneNumber.MaxLength = 11;
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAboniment.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void labelAddClient_Click(object sender, EventArgs e)
        {
            bool hasPhoneNumber = false;
            DateTime birthday = monthCalendarBirthday.SelectionStart;
            bool isNameNull = string.IsNullOrEmpty(textBoxName.Text);
            bool isSurnameNameNull = string.IsNullOrEmpty(textBoxSurname.Text);
            bool isGenderNull = string.IsNullOrEmpty(comboBoxGender.Text);
            bool isStatusNull = string.IsNullOrEmpty(comboBoxStatus.Text);
            bool isAbonimentNull = string.IsNullOrEmpty(comboBoxAboniment.Text);
            string sqlQueryAddClient = $"insert into Clients(client_name, client_surname, client_patronymic, client_gender, client_phone_number, client_birthday, client_status, client_aboniment_end) values('{textBoxName.Text}', '{textBoxSurname.Text}', '{textBoxPatronymic.Text}', '{comboBoxGender.Text}', '{textBoxPhoneNumber.Text}', '{FormMain.dataBase.ToDateSQLite(birthday)}', '{comboBoxStatus.Text}', '{FormMain.dataBase.ToDateSQLite(DateTime.Now.AddDays(int.Parse(comboBoxAboniment.Text)))}')";
            string sqlQueryCheckPhoneNumber = $"select client_id, client_name, client_surname from Clients where client_phone_number = '{textBoxPhoneNumber.Text}'";
            SQLiteCommand sqlCommandAddClient = new SQLiteCommand(sqlQueryAddClient, FormMain.dataBase.getConnection());
            SQLiteCommand sqlCommandCheckPhoneNumber = new SQLiteCommand(sqlQueryCheckPhoneNumber, FormMain.dataBase.getConnection());
            if (textBoxPhoneNumber.Text.Length == 11 && monthCalendarBirthday.SelectionStart <= DateTime.Now.AddYears(-18) && !isNameNull && !isSurnameNameNull && !isGenderNull && !isStatusNull && !isAbonimentNull)
            {
                FormMain.dataBase.openConnection();
                SQLiteDataReader readerPhoneNumber = sqlCommandCheckPhoneNumber.ExecuteReader();
                while(readerPhoneNumber.Read())
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
                    sqlCommandAddClient.ExecuteNonQuery();
                    MessageBox.Show("Клиент успешно добавлен!", "Успех");
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Клиент не добавлен!", "Ошибка");
            }
            FormMain.dataBase.closeConnection();
        }

        private void textBoxStringKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}

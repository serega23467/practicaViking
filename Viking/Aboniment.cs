using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Viking
{
    public partial class Aboniment : Form
    {
        public Aboniment()
        {
            InitializeComponent();
            comboBoxAbonimentExtend.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonAboniment_Click(object sender, EventArgs e)
        {
            FormMain.dataBase.openConnection();
            string sqlQueryBalance = $"update Clients set client_aboniment_end = '{FormMain.dataBase.ToDateSQLite(DateTime.Now.AddDays(int.Parse(comboBoxAbonimentExtend.Text)))}' where client_id = {FormMain.ID}";
            SQLiteCommand sqliteCommandAboniment = new SQLiteCommand(sqlQueryBalance, FormMain.dataBase.getConnection());
            sqliteCommandAboniment.ExecuteNonQuery();
            MessageBox.Show("Абонимент клиента продлён","Успех");
            this.Hide();
        }
    }
}

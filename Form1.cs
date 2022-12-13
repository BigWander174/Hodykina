using MySqlConnector;
using System.Data;

namespace Hodykina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataGridViewCell UsersViewSeletedCell => users.SelectedCells[0];

        private void Form1_Load(object sender, EventArgs e)
        {
            FillUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataFromDB($"select * from users where Surname Like '{textBox1.Text}%' or " +
                $"Firstname Like '{textBox1.Text}%' or " +
                $"Lastname Like '{textBox1.Text}%'", users);
        }

        private void DeleteRowFromDataGridView(object sender, DataGridViewRowCancelEventArgs e)
        {
            var selectedRow = ((DataGridView)sender).SelectedRows[0];

            var idToDelete = selectedRow.Cells[0].Value;

            string query = $"delete from {selectedRow.DataGridView.Name} where {selectedRow.Cells[0].OwningColumn.DataPropertyName} = {idToDelete}";
            RunSQLCommand(query);
        }

        private void userView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var ColumnName = UsersViewSeletedCell.OwningColumn.DataPropertyName;

            var SelectedUserID = users.Rows[UsersViewSeletedCell.RowIndex].Cells[0].Value.ToString();
            string query = (SelectedUserID == "") ? $"Insert into users({UsersViewSeletedCell.OwningColumn.DataPropertyName}) Values('{UsersViewSeletedCell.Value}')"
                : "update users " +
                           $"set {ColumnName} = '{UsersViewSeletedCell.Value}' " +
                           $"where userID = '{SelectedUserID}'";

            RunSQLCommand(query);
            FillUsers();
        }
        private void phonesView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string phoneId = phones.Rows[e.RowIndex].Cells[0].Value.ToString();
                string userID = users.SelectedCells[0].Value.ToString();

                string query = (phoneId == "") ? $"Insert into phones(number, userID) " +
                                                 $"values('{phones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}', {userID})"
                                               : "update phones " +
                                                 $"set number = '{phones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}' " +
                                                 $"where phoneID = '{phoneId}'";

                RunSQLCommand(query);
                FillPhones(UsersViewSeletedCell.RowIndex);
            }
            catch
            {
                return;
            }
        }

        private void userView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillPhones(e.RowIndex);
        }


        private void FillPhones(int rowIndex)
        {
            FillDataFromDB($"SELECT " +
                          "phones.phoneID AS phoneID, " +
                          "phones.number AS number, " +
                          "phones.userID AS userID, " +
                          "phonetypes.description AS typeDescription" +
                          " FROM (`phonetypes` JOIN (`phones` JOIN `users` " +
                          "ON ((`phones`.`userID` = `users`.`userID`)))) " +
                          "WHERE ((LENGTH(phones.number) = phonetypes.length) " +
                          $"AND (phones.userID = '{users.Rows[rowIndex].Cells[0].Value}'))" , phones);
        }

        private void FillUsers()
        {
            FillDataFromDB("Select * from phoneholder.users", users);
        }

        private void FillDataFromDB(string query, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            sqlDataAdapter.Fill(dataTable);

            dataGridView.DataSource = new BindingSource
            {
                DataSource = dataTable
            };
        }

        private void RunSQLCommand(string query)
        {
            databaseConnection.Open();
            MySqlCommand command1 = new MySqlCommand(query, databaseConnection);
            command1.ExecuteNonQuery();
            databaseConnection.Close();
        }
    }
}
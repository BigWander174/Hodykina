namespace Hodykina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.users = new System.Windows.Forms.DataGridView();
            this.userLabel = new System.Windows.Forms.Label();
            this.phones = new System.Windows.Forms.DataGridView();
            this.phoneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseConnection = new MySqlConnector.MySqlConnection();
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.selectUsers = new MySqlConnector.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phones)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // users
            // 
            this.users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users.Location = new System.Drawing.Point(11, 65);
            this.users.Name = "users";
            this.users.RowHeadersWidth = 51;
            this.users.RowTemplate.Height = 29;
            this.users.Size = new System.Drawing.Size(470, 239);
            this.users.TabIndex = 1;
            this.users.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.userView_CellEnter);
            this.users.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.userView_CellValueChanged);
            this.users.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DeleteRowFromDataGridView);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(189, 43);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(108, 20);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Пользователи";
            // 
            // phones
            // 
            this.phones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneId,
            this.SelectedUserID,
            this.phoneNumber,
            this.phoneType});
            this.phones.Location = new System.Drawing.Point(11, 331);
            this.phones.Name = "phones";
            this.phones.RowHeadersWidth = 51;
            this.phones.RowTemplate.Height = 29;
            this.phones.Size = new System.Drawing.Size(470, 188);
            this.phones.TabIndex = 3;
            this.phones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.phonesView_CellValueChanged);
            this.phones.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DeleteRowFromDataGridView);
            // 
            // phoneId
            // 
            this.phoneId.DataPropertyName = "phoneID";
            this.phoneId.HeaderText = "Id";
            this.phoneId.MinimumWidth = 6;
            this.phoneId.Name = "phoneId";
            this.phoneId.ReadOnly = true;
            this.phoneId.Visible = false;
            // 
            // userID
            // 
            this.SelectedUserID.DataPropertyName = "userID";
            this.SelectedUserID.HeaderText = "Id владельца";
            this.SelectedUserID.MinimumWidth = 6;
            this.SelectedUserID.Name = "userID";
            this.SelectedUserID.Visible = false;
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "number";
            this.phoneNumber.HeaderText = "Номер";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            // 
            // phoneType
            // 
            this.phoneType.DataPropertyName = "typeDescription";
            this.phoneType.HeaderText = "Тип телефона";
            this.phoneType.MinimumWidth = 6;
            this.phoneType.Name = "phoneType";
            this.phoneType.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Телефоны";
            // 
            // databaseConnection
            // 
            this.databaseConnection.ConnectionString = "server=localhost;user=root;password=X-Medium174;database=phoneholder";
            this.databaseConnection.ProvideClientCertificatesCallback = null;
            this.databaseConnection.ProvidePasswordCallback = null;
            this.databaseConnection.RemoteCertificateValidationCallback = null;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // selectUsers
            // 
            this.selectUsers.CommandTimeout = 0;
            this.selectUsers.Connection = null;
            this.selectUsers.Transaction = null;
            this.selectUsers.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phones);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.users);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Ходыкина";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private DataGridView users;
        private Label userLabel;
        private DataGridView phones;
        private Label label1;
        private MySqlConnector.MySqlConnection databaseConnection;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private MySqlConnector.MySqlCommand selectUsers;
        private DataGridViewTextBoxColumn phoneId;
        private DataGridViewTextBoxColumn SelectedUserID;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn phoneType;
    }
}
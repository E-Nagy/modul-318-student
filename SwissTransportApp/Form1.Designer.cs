namespace SwissTransportApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.dateTimeDeparture = new System.Windows.Forms.DateTimePicker();
            this.connectionsTable = new System.Windows.Forms.DataGridView();
            this.StartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showConnectionsButton = new System.Windows.Forms.Button();
            this.departureLabel = new System.Windows.Forms.Label();
            this.showDeparturesButton = new System.Windows.Forms.Button();
            this.arrivalCombobox = new System.Windows.Forms.ComboBox();
            this.startCombobox = new System.Windows.Forms.ComboBox();
            this.StationSearchButton = new System.Windows.Forms.Button();
            this.GridViewChanger = new System.Windows.Forms.TabControl();
            this.ConnectionsTabPage = new System.Windows.Forms.TabPage();
            this.DeparturesTabPage = new System.Windows.Forms.TabPage();
            this.DepartureTable = new System.Windows.Forms.DataGridView();
            this.DeparturePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowConnection = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).BeginInit();
            this.GridViewChanger.SuspendLayout();
            this.ConnectionsTabPage.SuspendLayout();
            this.DeparturesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureTable)).BeginInit();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startLabel.Location = new System.Drawing.Point(36, 39);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(39, 17);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Start :";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arrivalLabel.Location = new System.Drawing.Point(36, 93);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(34, 17);
            this.arrivalLabel.TabIndex = 3;
            this.arrivalLabel.Text = "Ziel :";
            // 
            // dateTimeDeparture
            // 
            this.dateTimeDeparture.Location = new System.Drawing.Point(119, 137);
            this.dateTimeDeparture.Name = "dateTimeDeparture";
            this.dateTimeDeparture.Size = new System.Drawing.Size(200, 23);
            this.dateTimeDeparture.TabIndex = 4;
            this.dateTimeDeparture.Value = new System.DateTime(2022, 4, 27, 11, 2, 59, 0);
            // 
            // connectionsTable
            // 
            this.connectionsTable.AllowUserToOrderColumns = true;
            this.connectionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.connectionsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.connectionsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.connectionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartColumn,
            this.TimeColumn,
            this.PlatformColumn,
            this.EndColumn,
            this.ArrivalTimeColumn});
            this.connectionsTable.Location = new System.Drawing.Point(0, 0);
            this.connectionsTable.Name = "connectionsTable";
            this.connectionsTable.ReadOnly = true;
            this.connectionsTable.RowTemplate.Height = 25;
            this.connectionsTable.Size = new System.Drawing.Size(469, 435);
            this.connectionsTable.TabIndex = 5;
            // 
            // StartColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.StartColumn.HeaderText = "Abfahrtsort";
            this.StartColumn.Name = "StartColumn";
            this.StartColumn.ReadOnly = true;
            this.StartColumn.Width = 92;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Zeit";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.Width = 52;
            // 
            // PlatformColumn
            // 
            this.PlatformColumn.HeaderText = "Plattform";
            this.PlatformColumn.Name = "PlatformColumn";
            this.PlatformColumn.ReadOnly = true;
            this.PlatformColumn.Width = 82;
            // 
            // EndColumn
            // 
            this.EndColumn.HeaderText = "Ankunftsort";
            this.EndColumn.Name = "EndColumn";
            this.EndColumn.ReadOnly = true;
            this.EndColumn.Width = 95;
            // 
            // ArrivalTimeColumn
            // 
            this.ArrivalTimeColumn.HeaderText = "Ankunftszeit";
            this.ArrivalTimeColumn.Name = "ArrivalTimeColumn";
            this.ArrivalTimeColumn.ReadOnly = true;
            this.ArrivalTimeColumn.Width = 98;
            // 
            // showConnectionsButton
            // 
            this.showConnectionsButton.Location = new System.Drawing.Point(401, 128);
            this.showConnectionsButton.Name = "showConnectionsButton";
            this.showConnectionsButton.Size = new System.Drawing.Size(146, 23);
            this.showConnectionsButton.TabIndex = 6;
            this.showConnectionsButton.Text = "Verbindungen anzeigen";
            this.showConnectionsButton.UseVisualStyleBackColor = true;
            this.showConnectionsButton.Click += new System.EventHandler(this.ShowConnectionsButton_Click);
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.departureLabel.Location = new System.Drawing.Point(36, 143);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(52, 17);
            this.departureLabel.TabIndex = 7;
            this.departureLabel.Text = "Abfahrt:";
            // 
            // showDeparturesButton
            // 
            this.showDeparturesButton.Location = new System.Drawing.Point(401, 99);
            this.showDeparturesButton.Name = "showDeparturesButton";
            this.showDeparturesButton.Size = new System.Drawing.Size(146, 23);
            this.showDeparturesButton.TabIndex = 8;
            this.showDeparturesButton.Text = "Abfahrten anzeigen";
            this.showDeparturesButton.UseVisualStyleBackColor = true;
            this.showDeparturesButton.Click += new System.EventHandler(this.ShowDeparturesButton_Click);
            // 
            // arrivalCombobox
            // 
            this.arrivalCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.arrivalCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.arrivalCombobox.Location = new System.Drawing.Point(119, 87);
            this.arrivalCombobox.Name = "arrivalCombobox";
            this.arrivalCombobox.Size = new System.Drawing.Size(121, 23);
            this.arrivalCombobox.TabIndex = 2;
            // 
            // startCombobox
            // 
            this.startCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.startCombobox.FormattingEnabled = true;
            this.startCombobox.Location = new System.Drawing.Point(119, 33);
            this.startCombobox.Name = "startCombobox";
            this.startCombobox.Size = new System.Drawing.Size(121, 23);
            this.startCombobox.TabIndex = 0;
            // 
            // StationSearchButton
            // 
            this.StationSearchButton.Location = new System.Drawing.Point(262, 33);
            this.StationSearchButton.Name = "StationSearchButton";
            this.StationSearchButton.Size = new System.Drawing.Size(90, 77);
            this.StationSearchButton.TabIndex = 9;
            this.StationSearchButton.Text = "Station suchen";
            this.StationSearchButton.UseVisualStyleBackColor = true;
            this.StationSearchButton.Click += new System.EventHandler(this.StationSearchButton_Click);
            // 
            // GridViewChanger
            // 
            this.GridViewChanger.Controls.Add(this.ConnectionsTabPage);
            this.GridViewChanger.Controls.Add(this.DeparturesTabPage);
            this.GridViewChanger.Location = new System.Drawing.Point(36, 199);
            this.GridViewChanger.Name = "GridViewChanger";
            this.GridViewChanger.SelectedIndex = 0;
            this.GridViewChanger.Size = new System.Drawing.Size(479, 465);
            this.GridViewChanger.TabIndex = 10;
            // 
            // ConnectionsTabPage
            // 
            this.ConnectionsTabPage.Controls.Add(this.connectionsTable);
            this.ConnectionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ConnectionsTabPage.Name = "ConnectionsTabPage";
            this.ConnectionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionsTabPage.Size = new System.Drawing.Size(471, 437);
            this.ConnectionsTabPage.TabIndex = 0;
            this.ConnectionsTabPage.Text = "Verbindungen";
            this.ConnectionsTabPage.UseVisualStyleBackColor = true;
            // 
            // DeparturesTabPage
            // 
            this.DeparturesTabPage.Controls.Add(this.DepartureTable);
            this.DeparturesTabPage.Location = new System.Drawing.Point(4, 24);
            this.DeparturesTabPage.Name = "DeparturesTabPage";
            this.DeparturesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DeparturesTabPage.Size = new System.Drawing.Size(471, 437);
            this.DeparturesTabPage.TabIndex = 1;
            this.DeparturesTabPage.Text = "Abfahrten";
            this.DeparturesTabPage.UseVisualStyleBackColor = true;
            // 
            // DepartureTable
            // 
            this.DepartureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartureTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeparturePlace,
            this.Arrival,
            this.ShowConnection});
            this.DepartureTable.Location = new System.Drawing.Point(0, 2);
            this.DepartureTable.Name = "DepartureTable";
            this.DepartureTable.RowTemplate.Height = 25;
            this.DepartureTable.Size = new System.Drawing.Size(344, 435);
            this.DepartureTable.TabIndex = 0;
            // 
            // DeparturePlace
            // 
            this.DeparturePlace.HeaderText = "Abfahrtsort";
            this.DeparturePlace.Name = "DeparturePlace";
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Ankunftsort";
            this.Arrival.Name = "Arrival";
            // 
            // ShowConnection
            // 
            this.ShowConnection.HeaderText = "Verbindung anzeigen";
            this.ShowConnection.Name = "ShowConnection";
            this.ShowConnection.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 676);
            this.Controls.Add(this.GridViewChanger);
            this.Controls.Add(this.StationSearchButton);
            this.Controls.Add(this.showDeparturesButton);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.showConnectionsButton);
            this.Controls.Add(this.dateTimeDeparture);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.arrivalCombobox);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startCombobox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).EndInit();
            this.GridViewChanger.ResumeLayout(false);
            this.ConnectionsTabPage.ResumeLayout(false);
            this.DeparturesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DepartureTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label startLabel;
        private Label arrivalLabel;
        private DateTimePicker dateTimeDeparture;
        private DataGridView connectionsTable;
        private DataGridViewTextBoxColumn StartColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn PlatformColumn;
        private DataGridViewTextBoxColumn EndColumn;
        private DataGridViewTextBoxColumn ArrivalTimeColumn;
        private Button showConnectionsButton;
        private Label departureLabel;
        private Button showDeparturesButton;
        private ComboBox arrivalCombobox;
        private ComboBox startCombobox;
        private Button StationSearchButton;
        private TabControl GridViewChanger;
        private TabPage ConnectionsTabPage;
        private TabPage DeparturesTabPage;
        private DataGridView DepartureTable;
        private DataGridViewTextBoxColumn DeparturePlace;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewButtonColumn ShowConnection;
    }
}
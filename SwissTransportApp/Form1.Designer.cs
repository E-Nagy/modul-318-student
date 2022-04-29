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
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
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
            this.ShowDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Start :";
            this.startLabel.UseWaitCursor = true;
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arrivalLabel.Location = new System.Drawing.Point(36, 93);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(34, 17);
            this.arrivalLabel.TabIndex = 2;
            this.arrivalLabel.Text = "Ziel :";
            this.arrivalLabel.UseWaitCursor = true;
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.CustomFormat = "dd.MM.yy";
            this.DepartureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DepartureDatePicker.Location = new System.Drawing.Point(104, 131);
            this.DepartureDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DepartureDatePicker.MinDate = new System.DateTime(2022, 4, 28, 0, 0, 0, 0);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.Size = new System.Drawing.Size(153, 23);
            this.DepartureDatePicker.TabIndex = 6;
            this.DepartureDatePicker.UseWaitCursor = true;
            this.DepartureDatePicker.Value = new System.DateTime(2022, 4, 28, 0, 0, 0, 0);
            // 
            // connectionsTable
            // 
            this.connectionsTable.AllowUserToOrderColumns = true;
            this.connectionsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.connectionsTable.Size = new System.Drawing.Size(469, 387);
            this.connectionsTable.TabIndex = 11;
            this.connectionsTable.UseWaitCursor = true;
            // 
            // StartColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.StartColumn.HeaderText = "Abfahrtsort";
            this.StartColumn.Name = "StartColumn";
            this.StartColumn.ReadOnly = true;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Zeit";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // PlatformColumn
            // 
            this.PlatformColumn.HeaderText = "Plattform";
            this.PlatformColumn.Name = "PlatformColumn";
            this.PlatformColumn.ReadOnly = true;
            // 
            // EndColumn
            // 
            this.EndColumn.HeaderText = "Ankunftsort";
            this.EndColumn.Name = "EndColumn";
            this.EndColumn.ReadOnly = true;
            // 
            // ArrivalTimeColumn
            // 
            this.ArrivalTimeColumn.HeaderText = "Ankunftszeit";
            this.ArrivalTimeColumn.Name = "ArrivalTimeColumn";
            this.ArrivalTimeColumn.ReadOnly = true;
            // 
            // showConnectionsButton
            // 
            this.showConnectionsButton.Location = new System.Drawing.Point(66, 170);
            this.showConnectionsButton.Name = "showConnectionsButton";
            this.showConnectionsButton.Size = new System.Drawing.Size(146, 23);
            this.showConnectionsButton.TabIndex = 8;
            this.showConnectionsButton.Text = "Verbindungen anzeigen";
            this.showConnectionsButton.UseVisualStyleBackColor = true;
            this.showConnectionsButton.UseWaitCursor = true;
            this.showConnectionsButton.Click += new System.EventHandler(this.ShowConnectionsButton_Click);
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.departureLabel.Location = new System.Drawing.Point(36, 137);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(52, 17);
            this.departureLabel.TabIndex = 5;
            this.departureLabel.Text = "Abfahrt:";
            this.departureLabel.UseWaitCursor = true;
            // 
            // showDeparturesButton
            // 
            this.showDeparturesButton.Location = new System.Drawing.Point(218, 170);
            this.showDeparturesButton.Name = "showDeparturesButton";
            this.showDeparturesButton.Size = new System.Drawing.Size(146, 23);
            this.showDeparturesButton.TabIndex = 9;
            this.showDeparturesButton.Text = "Abfahrten anzeigen";
            this.showDeparturesButton.UseVisualStyleBackColor = true;
            this.showDeparturesButton.UseWaitCursor = true;
            this.showDeparturesButton.Click += new System.EventHandler(this.ShowDeparturesButton_Click);
            // 
            // arrivalCombobox
            // 
            this.arrivalCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.arrivalCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.arrivalCombobox.Location = new System.Drawing.Point(81, 87);
            this.arrivalCombobox.Name = "arrivalCombobox";
            this.arrivalCombobox.Size = new System.Drawing.Size(176, 23);
            this.arrivalCombobox.TabIndex = 3;
            this.arrivalCombobox.UseWaitCursor = true;
            // 
            // startCombobox
            // 
            this.startCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.startCombobox.FormattingEnabled = true;
            this.startCombobox.Location = new System.Drawing.Point(81, 36);
            this.startCombobox.Name = "startCombobox";
            this.startCombobox.Size = new System.Drawing.Size(176, 23);
            this.startCombobox.TabIndex = 1;
            this.startCombobox.UseWaitCursor = true;
            // 
            // StationSearchButton
            // 
            this.StationSearchButton.Location = new System.Drawing.Point(263, 33);
            this.StationSearchButton.Name = "StationSearchButton";
            this.StationSearchButton.Size = new System.Drawing.Size(90, 77);
            this.StationSearchButton.TabIndex = 4;
            this.StationSearchButton.Text = "Station suchen";
            this.StationSearchButton.UseVisualStyleBackColor = true;
            this.StationSearchButton.UseWaitCursor = true;
            this.StationSearchButton.Click += new System.EventHandler(this.StationSearchButton_Click);
            // 
            // GridViewChanger
            // 
            this.GridViewChanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewChanger.Controls.Add(this.ConnectionsTabPage);
            this.GridViewChanger.Controls.Add(this.DeparturesTabPage);
            this.GridViewChanger.Location = new System.Drawing.Point(36, 199);
            this.GridViewChanger.Name = "GridViewChanger";
            this.GridViewChanger.SelectedIndex = 0;
            this.GridViewChanger.Size = new System.Drawing.Size(479, 414);
            this.GridViewChanger.TabIndex = 10;
            this.GridViewChanger.UseWaitCursor = true;
            // 
            // ConnectionsTabPage
            // 
            this.ConnectionsTabPage.Controls.Add(this.connectionsTable);
            this.ConnectionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ConnectionsTabPage.Name = "ConnectionsTabPage";
            this.ConnectionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionsTabPage.Size = new System.Drawing.Size(471, 386);
            this.ConnectionsTabPage.TabIndex = 0;
            this.ConnectionsTabPage.Text = "Verbindungen";
            this.ConnectionsTabPage.UseVisualStyleBackColor = true;
            this.ConnectionsTabPage.UseWaitCursor = true;
            // 
            // DeparturesTabPage
            // 
            this.DeparturesTabPage.Controls.Add(this.DepartureTable);
            this.DeparturesTabPage.Location = new System.Drawing.Point(4, 24);
            this.DeparturesTabPage.Name = "DeparturesTabPage";
            this.DeparturesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DeparturesTabPage.Size = new System.Drawing.Size(471, 386);
            this.DeparturesTabPage.TabIndex = 1;
            this.DeparturesTabPage.Text = "Abfahrten";
            this.DeparturesTabPage.UseVisualStyleBackColor = true;
            this.DeparturesTabPage.UseWaitCursor = true;
            // 
            // DepartureTable
            // 
            this.DepartureTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartureTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepartureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartureTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeparturePlace,
            this.Arrival,
            this.ShowDepartureTime});
            this.DepartureTable.Location = new System.Drawing.Point(0, 2);
            this.DepartureTable.Name = "DepartureTable";
            this.DepartureTable.RowTemplate.Height = 25;
            this.DepartureTable.Size = new System.Drawing.Size(471, 388);
            this.DepartureTable.TabIndex = 12;
            this.DepartureTable.UseWaitCursor = true;
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
            // ShowDepartureTime
            // 
            this.ShowDepartureTime.HeaderText = "Abfahrt";
            this.ShowDepartureTime.Name = "ShowDepartureTime";
            // 
            // DepartureTimePicker
            // 
            this.DepartureTimePicker.CustomFormat = "HH:mm";
            this.DepartureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureTimePicker.Location = new System.Drawing.Point(263, 131);
            this.DepartureTimePicker.Name = "DepartureTimePicker";
            this.DepartureTimePicker.ShowUpDown = true;
            this.DepartureTimePicker.Size = new System.Drawing.Size(90, 23);
            this.DepartureTimePicker.TabIndex = 7;
            this.DepartureTimePicker.UseWaitCursor = true;
            this.DepartureTimePicker.Value = new System.DateTime(2022, 4, 28, 15, 56, 54, 0);
            // 
            // Form1
            // 
            this.AcceptButton = this.showDeparturesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 625);
            this.Controls.Add(this.DepartureTimePicker);
            this.Controls.Add(this.GridViewChanger);
            this.Controls.Add(this.StationSearchButton);
            this.Controls.Add(this.showDeparturesButton);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.showConnectionsButton);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.arrivalCombobox);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startCombobox);
            this.Name = "Form1";
            this.Text = "Swiss Transport";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.OnFormLoad);
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
        private DateTimePicker DepartureDatePicker;
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
        private DateTimePicker DepartureTimePicker;
        private DataGridViewTextBoxColumn DeparturePlace;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn ShowDepartureTime;
    }
}
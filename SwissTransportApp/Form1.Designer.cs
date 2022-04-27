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
            this.connectionsDeparturesTable = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDeparturesTable)).BeginInit();
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
            this.dateTimeDeparture.Location = new System.Drawing.Point(305, 36);
            this.dateTimeDeparture.Name = "dateTimeDeparture";
            this.dateTimeDeparture.Size = new System.Drawing.Size(200, 23);
            this.dateTimeDeparture.TabIndex = 4;
            this.dateTimeDeparture.Value = new System.DateTime(2022, 4, 27, 11, 2, 59, 0);
            // 
            // connectionsDeparturesTable
            // 
            this.connectionsDeparturesTable.AllowUserToOrderColumns = true;
            this.connectionsDeparturesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.connectionsDeparturesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.connectionsDeparturesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.connectionsDeparturesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsDeparturesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartColumn,
            this.TimeColumn,
            this.PlatformColumn,
            this.EndColumn,
            this.ArrivalTimeColumn});
            this.connectionsDeparturesTable.Location = new System.Drawing.Point(36, 179);
            this.connectionsDeparturesTable.Name = "connectionsDeparturesTable";
            this.connectionsDeparturesTable.ReadOnly = true;
            this.connectionsDeparturesTable.RowTemplate.Height = 25;
            this.connectionsDeparturesTable.Size = new System.Drawing.Size(469, 485);
            this.connectionsDeparturesTable.TabIndex = 5;
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
            this.showConnectionsButton.Location = new System.Drawing.Point(36, 150);
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
            this.departureLabel.Location = new System.Drawing.Point(249, 39);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(50, 15);
            this.departureLabel.TabIndex = 7;
            this.departureLabel.Text = "Abfahrt:";
            // 
            // showDeparturesButton
            // 
            this.showDeparturesButton.Location = new System.Drawing.Point(359, 150);
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
            this.arrivalCombobox.Location = new System.Drawing.Point(91, 90);
            this.arrivalCombobox.Name = "arrivalCombobox";
            this.arrivalCombobox.Size = new System.Drawing.Size(121, 23);
            this.arrivalCombobox.TabIndex = 2;
            // 
            // startCombobox
            // 
            this.startCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.startCombobox.FormattingEnabled = true;
            this.startCombobox.Location = new System.Drawing.Point(91, 36);
            this.startCombobox.Name = "startCombobox";
            this.startCombobox.Size = new System.Drawing.Size(121, 23);
            this.startCombobox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 676);
            this.Controls.Add(this.showDeparturesButton);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.showConnectionsButton);
            this.Controls.Add(this.connectionsDeparturesTable);
            this.Controls.Add(this.dateTimeDeparture);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.arrivalCombobox);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startCombobox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDeparturesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label startLabel;
        private Label arrivalLabel;
        private DateTimePicker dateTimeDeparture;
        private DataGridView connectionsDeparturesTable;
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
    }
}
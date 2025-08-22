using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolutionDataEntryApplication
{
    public partial class MainForm : Form
    {
        private ComboBox comboTables;
        private DataGridView dataGrid;
        private Button btnInsert;
        private Button btnImportCsv;
        private Button btnImportExcel;
        private TextBox txtSearchId;
        private Button btnSearch;
        private Label lblTableSelect;
        private Label lblSearch;
        private Panel topPanel;

        public MainForm()
        {
            InitializeComponent();
            InitializeManualComponent();
        }

        private void InitializeManualComponent()
        {
            // Form properties
            this.Text = "Evolution Data Entry Tool";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Top Panel
            topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.FromArgb(52, 58, 64)
            };
            this.Controls.Add(topPanel);

            // Label for Table selection
            lblTableSelect = new Label
            {
                Text = "Select Table:",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(20, 25),
                AutoSize = true
            };
            topPanel.Controls.Add(lblTableSelect);

            // ComboBox for Tables
            comboTables = new ComboBox
            {
                Location = new Point(120, 22),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            comboTables.Items.AddRange(new string[] { "Species", "Traits", "EvolutionaryEvents" });
            comboTables.SelectedIndex = 0;
            topPanel.Controls.Add(comboTables);

            // Search Label
            lblSearch = new Label
            {
                Text = "Search ID:",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(350, 25),
                AutoSize = true
            };
            topPanel.Controls.Add(lblSearch);

            // Search TextBox
            txtSearchId = new TextBox
            {
                Location = new Point(430, 22),
                Width = 150,
                Font = new Font("Segoe UI", 10)
            };
            topPanel.Controls.Add(txtSearchId);

            // Search Button
            btnSearch = new Button
            {
                Text = "Search",
                Location = new Point(590, 20),
                Width = 80,
                Height = 30,
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSearch.FlatAppearance.BorderSize = 0;
            topPanel.Controls.Add(btnSearch);

            // Data Grid View
            dataGrid = new DataGridView
            {
                Location = new Point(20, 100),
                Size = new Size(940, 360),
                AllowUserToAddRows = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.Fixed3D
            };
            this.Controls.Add(dataGrid);

            // Insert Button
            btnInsert = new Button
            {
                Text = "Insert Data",
                Location = new Point(20, 480),
                Width = 120,
                Height = 40,
                BackColor = Color.FromArgb(0, 123, 255),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnInsert.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnInsert);

            // Import CSV Button
            btnImportCsv = new Button
            {
                Text = "Import CSV",
                Location = new Point(160, 480),
                Width = 120,
                Height = 40,
                BackColor = Color.FromArgb(23, 162, 184),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnImportCsv.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnImportCsv);

            // Import Excel Button
            btnImportExcel = new Button
            {
                Text = "Import Excel",
                Location = new Point(300, 480),
                Width = 140,
                Height = 40,
                BackColor = Color.FromArgb(255, 193, 7),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnImportExcel.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnImportExcel);
        }
    }
}

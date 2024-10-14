using System;
using System.Windows.Forms;

namespace QuickCameraImporter
{
    public class MainWindow : Form
    {
        private Label label;
        private TextBox pathInput;
        private Button buttonBrowse;
        private Button buttonCopy;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Set window size
            ClientSize = new Size(640, 320);
            TopMost = true;
            
            // Set start position to center screen
            StartPosition = FormStartPosition.CenterScreen;
            
            

            pathInput = new TextBox()
            {
                Anchor = AnchorStyles.None,
                //Size = new Size(300, 20)
            };
            
            buttonBrowse = new Button()
            {
                Text = "Browse", 
                Size = new Size() { Width = 150, Height = 50 },
                Anchor = AnchorStyles.None
            };
            buttonBrowse.Click += ButtonBrowseClick;
            
            buttonCopy = new Button()
            {
                Text = "Copy Files Now", 
                Size = new Size() { Width = 150, Height = 50 },
                Anchor = AnchorStyles.None
            };
            buttonCopy.Click += ButtonCopyClick;
            
            label = new Label() { 
                Text = "Hello, World!", 
                AutoSize = true, 
                Anchor = AnchorStyles.None
            };
            
            

            var tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 2, // Drei Spalten für Label, TextBox und Button
                Dock = DockStyle.Fill
            };

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // TextBox column
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // Button column
            
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            // Add controls to the TableLayoutPanel
            tableLayoutPanel.Controls.Add(label, 0, 0); // Label in first column, first row
            tableLayoutPanel.SetColumnSpan(label, 2); // Make label span across both columns
            tableLayoutPanel.Controls.Add(pathInput, 0, 1); // TextBox in first column, second row
            tableLayoutPanel.Controls.Add(buttonBrowse, 1, 1);
            
            // Add the TableLayoutPanel to the Form
            Controls.Add(tableLayoutPanel);
        }
        
        private void ButtonBrowseClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    Console.WriteLine("Selected Folder: " + folderDialog.SelectedPath);
                }
            }
        }
        
        private void ButtonCopyClick(object sender, EventArgs e)
        {
            Console.WriteLine("Todo: Copy now");
        }
    }
}
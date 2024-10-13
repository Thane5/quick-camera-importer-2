using System;
using System.Windows.Forms;

namespace QuickCameraImporter
{
    public class MainWindow : Form
    {
        private Label label;
        private Button button;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Set window size
            ClientSize = new Size(640, 320);
            
            label = new Label() { 
                Text = "Hello, World!", 
                AutoSize = true, 
                Anchor = AnchorStyles.None
            };
            
            button = new Button()
            {
                Text = "Copy Files Now", 
                Size = new Size() { Width = 150, Height = 50 },
                Anchor = AnchorStyles.None
            };
            
            button.Click += Button_Click;

            var tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 1,
                Dock = DockStyle.Fill
            };

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            // Add controls to the TableLayoutPanel
            tableLayoutPanel.Controls.Add(label, 0, 0);
            tableLayoutPanel.Controls.Add(button, 0, 1);

            // Add the TableLayoutPanel to the Form
            Controls.Add(tableLayoutPanel);
        }

        private void Button_Click(object sender, EventArgs e)
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
    }
}
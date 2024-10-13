using System;
using System.Windows.Forms;
using QuickCameraImporter;

class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainWindow());
    }
}
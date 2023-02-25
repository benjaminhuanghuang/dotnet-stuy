using System.Windows;
using Microsoft.Win32;

namespace PBiLogViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogParser? CurrentFile = null;
        private readonly LogGridViewModel logGridViewModel = new LogGridViewModel();

        public MainWindow()
        {
            InitializeComponent();
            LogGrid.DataContext = logGridViewModel;
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            var fileDlg = new OpenFileDialog();
            if (fileDlg.ShowDialog(this) == true)
            {
                CurrentFile = new LogParser(fileDlg.FileName);
                logGridViewModel.ClearLogLines();
                /*
                 * The null! syntax in C# is called a null-forgiving operator
                 * It is used to tell the compiler to ignore potential null reference warnings for a particular expression
                 */
                Refresh_Click(null!, null!);
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentFile != null)
            {
                var logLines = CurrentFile.GetLogsLines();
                logGridViewModel.AddLogLines(logLines);
            }
        }
    }
}

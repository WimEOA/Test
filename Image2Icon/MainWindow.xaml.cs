using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Image2Icon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog {Filter = "Png files|*.png"};
            if (ofd.ShowDialog() == true)
            {
                var file = ofd.FileName;
                var icoFile = Path.ChangeExtension(file, ".ico");
                ImagingHelper.ConvertToIcon(file, icoFile);
            }
        }
    }
}

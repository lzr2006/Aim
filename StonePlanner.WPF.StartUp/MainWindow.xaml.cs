using StonePlanner.WPF.StartUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StonePlanner.WPF.StartUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<VersionData> Versions = new List<VersionData>
            {
                new VersionData { VersionName="Origin 114514", DownloadUri=new Uri("https://114514.1919810"), VersionType=VersionType.Beta },
                new VersionData { VersionName="Alpha 114514", DownloadUri=new Uri("https://114514.1919810"), VersionType=VersionType.Origin },
                new VersionData { VersionName="Beta 114514", DownloadUri=new Uri("https://114514.1919810"), VersionType=VersionType.Epsilon },
                new VersionData { VersionName="Epsilon 114514", DownloadUri=new Uri("https://114514.1919810"), VersionType=VersionType.Alpha },
            };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listViewVersions_Loaded(object sender, RoutedEventArgs e)
        {
            listViewVersions.ItemsSource = Versions;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace To_DoHub
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Project> projects = new ObservableCollection<Project>();

        public MainWindow()
        {
            InitializeComponent();
            projects.Add(new Project { Name = "하이욤", TODOs = new ObservableCollection<TODO>(new List<TODO>()
            {
                new TODO() { Description = "", IsDone = false },
                new TODO() { Description = "", IsDone = false },
                new TODO() { Description = "", IsDone = true },
                new TODO() { Description = "", IsDone = false },
            }) });
            todolist.ItemsSource = projects;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textbox.Clear();
            }
        }
    }
}

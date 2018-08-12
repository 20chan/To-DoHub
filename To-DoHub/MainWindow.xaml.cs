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
            todolist.ItemsSource = projects;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                projects.Add(new Project { Name = textbox.Text });
                textbox.Clear();
            }
        }

        private void ItemClicked(object sender, MouseButtonEventArgs e)
        {
            var source = (DependencyObject)e.OriginalSource;
            var item = source.FindParent<ListViewItem>();
            if (item == null) return;
            item.IsSelected = true;
            var selected = projects[todolist.SelectedIndex];
            var window = new ProjectViewer(selected);
            window.ShowDialog();
        }
    }
}

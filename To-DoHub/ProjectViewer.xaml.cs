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
using System.Windows.Shapes;

namespace To_DoHub
{
    /// <summary>
    /// ProjectViewer.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProjectViewer : Window
    {
        Project self;
        public ProjectViewer(Project project)
        {
            InitializeComponent();
            self = project;
            this.todolist.ItemsSource = project.TODOs;
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                self.TODOs.Add(new TODO { Description = textbox.Text });
                textbox.Clear();
                self.RaiseProgressChanged();
            }
        }

        private void DataChanged(object sender, RoutedEventArgs e)
        {
            self.RaiseProgressChanged();
        }
    }
}

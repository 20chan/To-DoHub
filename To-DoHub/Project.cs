using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace To_DoHub
{
    public class Project : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public double Progress
        {
            get => (double)TODOs.Where(t => t.IsDone).Count() / TODOs.Count;
            set { }
        }
        public bool IsDone
        {
            get => Progress == 1;
            set { }
        }

        public ObservableCollection<TODO> TODOs;
        public event PropertyChangedEventHandler PropertyChanged;
                
        public Project()
        {
            TODOs = new ObservableCollection<TODO>();
        }

        internal void RaiseProgressChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsDone)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Progress)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_DoHub
{
    public class Project
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

        public Project()
        {
            TODOs = new ObservableCollection<TODO>();
        }
    }
}

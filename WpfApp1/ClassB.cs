using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fody;
using PropertyChanged;

namespace WpfApp1
{
    [AddINotifyPropertyChangedInterface]
    public class ClassB
    {
        public string Name { get; set; }
        public ObservableCollection<ClassB> ClassBList { get; set; }
    }
}

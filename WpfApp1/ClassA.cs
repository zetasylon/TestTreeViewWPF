using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [AddINotifyPropertyChangedInterface]
   public class ClassA
    {
        public string Name{ get;set;}
        public ClassB OneClassB{ get;set;}
    }
}

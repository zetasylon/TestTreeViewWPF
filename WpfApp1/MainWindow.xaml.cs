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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ClassA> ClassAList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClassAList = new ObservableCollection<ClassA>()
            {
                new ClassA()
                {
                    Name="FirstClassAName",
                    OneClassB = new ClassB()
                    {
                        Name="FirstClassBName",
                        ClassBList = new ObservableCollection<ClassB>()
                        {
                            new ClassB()
                            {
                                Name="SecondClassB",
                                ClassBList = new ObservableCollection<ClassB>()
                                {
                                    new ClassB()
                                    {
                                         Name="SecondClassBChild"
                                    }
                                }

                            },
                            new ClassB()
                            {
                                Name="thirdClassB",

                            }
                        }
                    }
                },
                new ClassA()
                {
                    Name="SecondClassAName",
                    OneClassB = new ClassB()
                    {
                        Name="AAA",
                        ClassBList = new ObservableCollection<ClassB>()
                        {
                            new ClassB()
                            {
                                Name="BBB",
                                ClassBList = new ObservableCollection<ClassB>()
                                {
                                    new ClassB()
                                    {
                                         Name="BBBChild"
                                    }
                                }

                            },
                            new ClassB()
                            {
                                Name="CCC",

                            }
                        }
                    }
                }
            };
        }
    }
}

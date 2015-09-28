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

namespace PracticeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
            //automatically generated when you compile your application. Calls the LoadComponent method of the System.Windows.Application class. 
            //The LoadComponent() method extracts the BAML (compiled XAML) from your assembly and uses it to build your user interface. As it
            //parses the BAML, it creates each control object, sets it properties, and attaches any event handlers. 
            AskEightBall show = new AskEightBall();
            show.Show();
        }
    }
}

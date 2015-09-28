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
using System.IO;
using System.Windows.Markup;

namespace PracticeWPF
{
    /// <summary>
    /// Interaction logic for CodeAndUncompiledXAML.xaml
    /// </summary>
    public partial class CodeAndUncompiledXAML : Window
    {
        private Button button1;

        public CodeAndUncompiledXAML()
        {
            InitializeComponent();
        }

        public CodeAndUncompiledXAML(string xamlFile)
        {
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML";

            DependencyObject rootElement;
            using(FileStream fs = new FileStream(xamlFile, FileMode.Open))
            {
                rootElement = (DependencyObject)XamlReader.Load(fs);
            }

            //insert the new markup into this window
            this.Content = rootElement;

            //Find the control with the appropriate name
            button1 = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "button1");
            
            //the two lines below do the same thing as the line above
            FrameworkElement frameworkElement = (FrameworkElement)rootElement;
            button1 = (Button)frameworkElement.FindName("button1");

            button1.Click += button1_Click;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Thank you";
        }
    }
}

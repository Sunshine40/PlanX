using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using xFramework;

namespace WpfApplicationTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var sao = new Node();
            sao.Content.Add(new Text { Key = "Title", Value = "刀剑神域" });
            sao.Characteristics.Add("ACG");
            var saoTv = new Node();
            saoTv.RelativeNodes.Add(sao);
            saoTv.Content.Add(new Node { Key = "Episodes" });
            var s = new XmlSerializer(typeof(Node));
            var stream = new StringWriter();
            s.Serialize(stream, sao);
            MessageBox.Show(stream.ToString());
            //123456789
        }
    }
}

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using AppForMaraphone.Forms;

namespace AppForMaraphone.Resource
{
    /// <summary>
    /// Логика взаимодействия для ImagesItem.xaml
    /// </summary>
    public partial class ImagesItem : UserControl
    {
        public string Header { get; set; }
        public string Discription { get; set; }
        public ImageSource ColoredSourse { get; set; }
        public RoutedEvent clip {  get; set; }
        public ImagesItem()
        {
            InitializeComponent();
            DataContext = this;
               
        }
    }
}

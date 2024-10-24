using System.Windows.Controls;

namespace AppForMaraphone.Resource
{
    /// <summary>
    /// Логика взаимодействия для RunnerCombo.xaml
    /// </summary>
    public partial class RunnerCombo : UserControl
    {
        public string Header { get; set; }
        public string Discription { get; set; }
        public RunnerCombo()
        {
            InitializeComponent();
            Name_tv.Text =$"{Header} -{Discription}";
        }
    }
}

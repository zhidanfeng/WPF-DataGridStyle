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

namespace Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<DbInfo> dbInfoList;

        public ObservableCollection<DbInfo> DbInfoList
        {
            get { return dbInfoList; }
            set { dbInfoList = value; }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DbInfoList = new ObservableCollection<DbInfo>();
            for(int i = 0; i < 10; i++)
            {
                this.DbInfoList.Add(new DbInfo()
                {
                    OrgName = "成都消防支队",
                    Ip = "我我我" + i,
                    Port = 1521,
                    UserName = "zhi",
                    Password = "123456"
                });
            }

            this.dgDbConfig.ItemsSource = this.DbInfoList;
        }
    }
}

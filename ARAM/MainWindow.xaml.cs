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
using RiotWrapper.Summoner_V3;

namespace ARAM
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            var sum = new Summoner();
            string apikey = "RGAPI-6369a470-4345-458e-9a0d-1d9a036af1c2";
            var client = new RiotWrapper.ApiCaller(apikey);
            var summonerName = TbName.Text;
            client.GetSummonerAsync(RiotWrapper.Region.EUW1, summonerName);

            var level = sum.SummonerLevel;
            LblLvl.Content = level;
        }

    }
}

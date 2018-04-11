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

namespace u2EthanSFishing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            int ValuePickerel = 0;
            int ValueTrout = 0;
            int ValuePike = 0;
            int ValueTotal = 0;
            int[] FishValues = new int[2];
            string[] strFishValues = new string[2];

            string strInput = txtInput.Text; //turns input into a string that needs less typing to use
            int intLength = strInput.Length - strInput.LastIndexOf("\r"); //finds the number of digits the last value is
            int.TryParse(strInput.Substring(strInput.LastIndexOf("\r"), intLength), out ValueTotal); //sets total value of all fish
            MessageBox.Show(ValueTotal.ToString());

            strFishValues = strInput.Split('\r');
            int.TryParse(strFishValues[0], out FishValues[0]);
            int.TryParse(strFishValues[1], out FishValues[1]);
            int.TryParse(strFishValues[2], out FishValues[2]);
            MessageBox.Show(FishValues[0].ToString());
            MessageBox.Show(FishValues[1].ToString());
            MessageBox.Show(FishValues[2].ToString());

            lblOutput.Content = strInput; //output
        }
    }
}

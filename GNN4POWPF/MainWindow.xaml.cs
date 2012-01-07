using System;
using System.Collections.Generic;
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
using GNN4PortfolioOptimizationClass;

namespace GNN4POWPF
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

        private void btnCal1_Click(object sender, RoutedEventArgs e)
        {
            GNN4PO po1 = new GNN4PO();
            txtk.Text = po1.k.ToString();
            txtR.Text = po1.R.ToString();
            txtT.Text = po1.T.ToString();
            txtw.Text = po1.w.ToString();
            txta.Text = po1.a.ToString();

        }
    }
}

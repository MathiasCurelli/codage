﻿using System;
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

namespace agenda
{
    /// <summary>
    /// Logique d'interaction pour addCustomer.xaml
    /// </summary>
    public partial class addCustomer : Page
    {
        agenda db = new agenda();

        public addCustomer()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

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

namespace EventMap.Front.View
{
    /// <summary>
    /// Interaction logic for _6.xaml
    /// </summary>
    public partial class _6 : Page
    {
        public _6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            NavigationService.Navigate(homePage); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _7 aaa = new _7();
            NavigationService.Navigate(aaa);
        }
    }
}

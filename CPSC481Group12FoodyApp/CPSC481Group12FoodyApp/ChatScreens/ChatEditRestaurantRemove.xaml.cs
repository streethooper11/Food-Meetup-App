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

namespace CPSC481Group12FoodyApp
{
    /// <summary>
    /// Interaction logic for ChatEditRestaurantRemove.xaml
    /// </summary>
    public partial class ChatEditRestaurantRemove : Page
    {
        internal PageNavigator navigate_helper;

        public ChatEditRestaurantRemove(PageNavigator navigate_helper)
        {
            this.navigate_helper = navigate_helper;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

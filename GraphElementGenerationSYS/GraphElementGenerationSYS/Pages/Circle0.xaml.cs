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

namespace GraphElementGenerationSYS.Pages
{
    /// <summary>
    /// Circle0.xaml 的交互逻辑
    /// </summary>
    public partial class Circle0 : Page
    {
        public Circle0()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://blog.csdn.net/u013044116/article/details/49305017");
            }
            catch(Exception)
            {

            }
        }
    }
}

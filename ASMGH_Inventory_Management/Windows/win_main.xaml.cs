﻿using ASMGH_Inventory_Management.ViewModel;
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
using System.Windows.Shapes;

namespace ASMGH_Inventory_Management.Windows
{
    /// <summary>
    /// Interaction logic for win_main.xaml
    /// </summary>
    public partial class win_main : Window
    {

        main_viewModel vm = new main_viewModel();


        public win_main()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btn_newItem_Click(object sender, RoutedEventArgs e)
        {
            win_newItem winNewItem = win_newItem.Instance;
            winNewItem.Show();
        }
    }
}

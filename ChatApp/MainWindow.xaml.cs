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

namespace ChatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isConnected = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Minimize_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Maximize_Button(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void Close_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
            {
                TextBoxUserName.IsEnabled = true;
                TextBoxPrivateKey.IsEnabled = true;
                ConnectButton.Content = "CONNECT";
                isConnected = false;
                ConnectButton.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                TextBoxUserName.IsEnabled = false;
                TextBoxPrivateKey.IsEnabled = false;
                ConnectButton.Content = "DISCONNECT";
                isConnected = true;
                ConnectButton.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

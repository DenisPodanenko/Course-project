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
using System.Windows.Shapes;

namespace kursovojNew
{
    /// <summary>
    /// Логика взаимодействия для FirstAppAnswers.xaml
    /// </summary>
    public partial class FirstAppAnswers : Window
    {
        public FirstAppAnswers()
        {
            InitializeComponent();
        }

        private void closedAnswer(object sender, EventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }
    }
}

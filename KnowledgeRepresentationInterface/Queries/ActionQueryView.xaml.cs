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
using Action = KR_Lib.DataStructures.Action;

namespace KnowledgeRepresentationInterface.Queries
{
    /// <summary>
    /// Interaction logic for ActionQuery.xaml
    /// </summary>
    public partial class ActionQueryView : UserControl
    {
        public ActionQueryView()
        {
            InitializeComponent();

        }

        public void Set_Actions(List<Action> actions)
        {
            Actions_ComboBox.ItemsSource = actions;
            Actions_ComboBox.Items.Refresh();
        }

        private void Moment_UIntUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (Moment_UIntUpDown.Text == "")
            {
                // Create an ImageBrush.
                ImageBrush textImageBrush = new ImageBrush();
                textImageBrush.ImageSource =
                    new BitmapImage(
                        new Uri(@"../../Backgrounds/Moment.bmp", UriKind.Relative)
                    );
                textImageBrush.AlignmentX = AlignmentX.Left;
                textImageBrush.AlignmentY = AlignmentY.Top;
                textImageBrush.Stretch = Stretch.Uniform;
                // Use the brush to paint the button's background.
                Moment_UIntUpDown.Background = textImageBrush;
            }
            else
            {

                Moment_UIntUpDown.Background = null;
            }
        }
    }
}
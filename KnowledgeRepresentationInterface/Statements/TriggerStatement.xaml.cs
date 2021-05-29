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

namespace KnowledgeRepresentationInterface.Statements
{
    /// <summary>
    /// Interaction logic for TriggerStatement.xaml
    /// </summary>
    public partial class TriggerStatement : UserControl
    {
        public TriggerStatement()
        {
            InitializeComponent();
        }

        public void Set_Actions(List<Action> actions)
        {
            TriggerStatementAction_ComboBox.ItemsSource = actions;
            TriggerStatementAction_ComboBox.Items.Refresh();
        }
    }
}

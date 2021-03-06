﻿using ShadowrunInitTracker.Model;
using ShadowrunInitTracker.ViewModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace ShadowrunInitTracker.View
{
    /// <summary>
    /// Interaction logic for ActorSelectionView.xaml
    /// </summary>
    public partial class ActorSelectionView : UserControl
    {
        CombatViewModel vm { get { return DataContext as CombatViewModel; } }

        public ActorSelectionView()
        {
            InitializeComponent();
        }
    }
}

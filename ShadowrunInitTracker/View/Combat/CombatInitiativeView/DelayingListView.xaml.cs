﻿using ShadowrunInitTracker.Model;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ShadowrunInitTracker.View
{
    /// <summary>
    /// Interaction logic for PhasePassListBox.xaml
    /// </summary>
    public partial class DelayingListView : UserControl
    {
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(DelayingListView));
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(DelayingListView));
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public DelayingListView()
        {
            InitializeComponent();
        }

        public static readonly RoutedUICommand EndDelayActorCmd = new RoutedUICommand(
            "Resume Acting", "EndDelayActorCmd", typeof(CombatInitiativeView));
        private void EndDelayActor(object sender, ExecutedRoutedEventArgs e)
        {
            var actor = (e.Parameter as InitiativeEntry).Source as Actor;
            actor.Delaying = false;
        }
    }
}

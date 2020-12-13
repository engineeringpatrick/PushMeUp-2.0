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

namespace PushMeUp_2._0_by_Deniso
{
    /// <summary>
    /// Interaction logic for WorkoutItemControl.xaml
    /// </summary>
    public partial class WorkoutItemControl : UserControl
    {
        public int workoutItemId;
        public WorkoutItemControl(int _workoutItemId)
        {
            InitializeComponent();

            workoutItemId = _workoutItemId;
        }

        public Uri ImageSource
        {
            get { return (Uri)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ImageSource. This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(Uri), typeof(WorkoutItemControl));

        public string ExerciseName
        {
            get { return (string)GetValue(ExerciseNameProperty); }
            set { SetValue(ExerciseNameProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ExerciseName. This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ExerciseNameProperty = DependencyProperty.Register("ExerciseName", typeof(string), typeof(WorkoutItemControl));

        public string ItemType
        {
            get { return (string)GetValue(ItemTypeProperty); }
            set { SetValue(ItemTypeProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ItemType. This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemTypeProperty = DependencyProperty.Register("ItemType", typeof(string), typeof(WorkoutItemControl));

        public string ItemTypeValue
        {
            get { return (string)GetValue(ItemTypeValueProperty); }
            set { SetValue(ItemTypeValueProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ItemTypeValue. This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemTypeValueProperty = DependencyProperty.Register("ItemTypeValue", typeof(string), typeof(WorkoutItemControl));

        public string EquipmentUsed
        {
            get { return (string)GetValue(EquipmentUsedProperty); }
            set { SetValue(EquipmentUsedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EquipmentUsed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EquipmentUsedProperty = DependencyProperty.Register("EquipmentUsed", typeof(string), typeof(WorkoutItemControl), new PropertyMetadata(""));



        private void deleteClick_Click(object sender, RoutedEventArgs e)
        {
            WorkoutInfoControl parent = Helper.GetAncestorOfType<WorkoutInfoControl>(this);
            if (parent != null)
            {
                parent.DeleteItem(workoutItemId);
            }
        }

        private void editClick_Click(object sender, RoutedEventArgs e)
        {
            WorkoutInfoControl parent = Helper.GetAncestorOfType<WorkoutInfoControl>(this);
            if (parent != null)
            {
                parent.EditItem(workoutItemId);
            }
        }
    }
}

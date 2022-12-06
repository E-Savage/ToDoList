using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ToDoList.ViewModels;
using ToDoList.Model;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for DemoMainWindow.xaml
    /// </summary>
    public partial class DemoMainWindow : Window
    {
        public ViewModel _viewModel;

        public string editedTaskName = "";

        public static DemoMainWindow? instance;

        public DemoMainWindow()
        {
            InitializeComponent();
        
            TxtUCEnteredTask.txtLimitedInput.Text = "Do the dishes";

           _viewModel = new ViewModel();

            DataContext = _viewModel;
            
            instance = this;

        }

        private void BtnAddTask_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Tasks.Add(new TaskModel() { TaskName = TxtUCEnteredTask.txtLimitedInput.Text });
        }

        private void BtnDeleteTask_Click(object sender, RoutedEventArgs e)
        {
            /*
             while (lst.SelectedItems.Count > 0)
{
   lst.Items.Remove(lst.SelectedItems[0]);
}
             */


            //                if (LstBoxTasks.SelectedItem != null)
            //                {
            //#pragma warning disable CS8604 // Possible null reference argument.
            //                    _ = _viewModel.Tasks.Remove(item: LstBoxTasks.SelectedItem as TaskModel);
            //#pragma warning restore CS8604 // Possible null reference argument.
            //                }

            if (LstBoxTasks.SelectedItems.Count >= 1)
            {
                while(LstBoxTasks.SelectedItems.Count > 0)
                {
                    _ = _viewModel.Tasks.Remove(item: LstBoxTasks.SelectedItems[0] as TaskModel);
                }
            } 
            else
            {
                MessageBox.Show("You don't have any tasks to delete!");
            }
            
        }

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();

            helpWindow.Show();
        }

        private void BtnEditTask_Click(object sender, RoutedEventArgs e)
        {
            if (LstBoxTasks.SelectedItem != null)
            {

                EditWindow editWindow = new EditWindow();
                editWindow.Show();

                if (!string.IsNullOrEmpty(editedTaskName))
                {
                    _viewModel.Tasks[LstBoxTasks.SelectedIndex].TaskName = editedTaskName;
                }
            }
        }
    }
}


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
using ToDoList.ViewModels;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
       
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            //DemoMainWindow.instance.editedTaskName = EditTextBox.Text;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            //DemoMainWindow.instance.editedTaskName = EditTextBox.Text;
            if (!string.IsNullOrEmpty(EditTextBox.Text)) 
            {
                DemoMainWindow.instance._viewModel.Tasks[DemoMainWindow.instance.LstBoxTasks.SelectedIndex].TaskName = EditTextBox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("You tried to edit your task to nothing, please type somehting in!");
            }
            
        }
    }
}

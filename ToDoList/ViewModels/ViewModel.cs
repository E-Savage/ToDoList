using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model;

namespace ToDoList.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        private string newTaskName = "";
        private string editedTaskName = "";
        private ObservableCollection<TaskModel> tasks = new ObservableCollection<TaskModel>();
    
        public ObservableCollection<TaskModel> Tasks { 
            get { return tasks; } 
            set { tasks = value; }
        }

        public string NewTaskName
        {
            get { return newTaskName; }
            set 
            { 
                if(newTaskName != value)
                {
                    newTaskName = value;
                    OnPropertyChanged(nameof(NewTaskName));
                }
            }
        }

        public string EditedTaskName
        {
            get { return editedTaskName; }
            set
            {
                if (editedTaskName != value)
                {
                    editedTaskName = value;
                    OnPropertyChanged(nameof (EditedTaskName));
                }
            }
        }
    }
}

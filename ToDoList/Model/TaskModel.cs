using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.ViewModels;

namespace ToDoList.Model
{
    public class TaskModel : ViewModelBase
    {
        private string? taskName;
        private bool isCehecked;

        public string TaskName
        {
#pragma warning disable CS8603 // Possible null reference return.
            get => taskName;
#pragma warning restore CS8603 // Possible null reference return.
            set
            {
                if (value != this.taskName)
                {
                    taskName = value;
                }
                this.OnPropertyChanged(nameof(TaskName));
            }
        }

        public bool IsCehecked { 
            get { return isCehecked; } 
            set { 
                isCehecked = value; 
            }
        }
    }
}

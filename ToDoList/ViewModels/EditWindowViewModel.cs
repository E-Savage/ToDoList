using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.ViewModels
{
    internal class EditWindowViewModel : ViewModelBase
    {
        private string? _editTextProperty;
        public string EditTextProperty
        {
#pragma warning disable CS8603 // Possible null reference return.
            get => _editTextProperty;
#pragma warning restore CS8603 // Possible null reference return.
            set
            {
                if (_editTextProperty != value)
                {
                    _editTextProperty = value;
                    OnPropertyChanged(nameof(EditTextProperty));
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public class SaveDataModel
    {
        public string FullPath { get; set; } = @"C:\First Name List.txt";
        public string FirstNameData { get; set; }
    }
}

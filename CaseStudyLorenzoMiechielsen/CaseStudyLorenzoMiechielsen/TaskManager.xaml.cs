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

namespace CaseStudyLorenzoMiechielsen
{
    /// <summary>
    /// Interaction logic for TaskManager.xaml
    /// </summary>
    public partial class TaskManager : Window,ICommand
    {
        private string? _taskName;
        private DateTime? _dueDate;
        private string? _priority;

        public string[] errors;

        public TaskManager()
        {
            InitializeComponent();
            errors= new string[0];
        }

        public string? TaskName
        {
            get { return _taskName; }
            set 
            { 
                _taskName = value; 
            }
        }
        public DateTime? DueDate
        {
            get { return _dueDate; }
            set
            {
                _dueDate = value;
            }
        }

        public string? Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
            }
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            switch (parameter?.ToString())
            {
                case "Add":
                    this.AddNewTask();
                    break;
            }
        }

        public void AddNewTask()
        {
            DateTime trueDate = DateTime.Now;
            List<String> errorList = new List<String>(errors);

            if(string.IsNullOrWhiteSpace(_taskName))
            {
                errorList.Add("Give a task name");
            }
            else if (!_dueDate.HasValue)
            {
                errorList.Add("Give a due date");
                trueDate = _dueDate.Value;
            }
            else if (_priority == null)
            {
                errorList.Add("Give a task name");
            }
            else
            {

                DatabaseOperations.AddTask(_taskName, trueDate, _priority);
            }
        }
    }
}

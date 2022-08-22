using MvvmCommand.Base;
using MvvmCommand.Command;
using MvvmCommand.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MvvmCommand.ViewModels
{
    public class PersonViewModel : NotifyBase
    {
        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { _person = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }

        public PersonViewModel()
        {
            _person = new Person();
            _persons = new ObservableCollection<Person>();
        }

        private ICommand _submitCommand;

        public ICommand SubmitCommand
        {
            get 
            { 
                if (_submitCommand == null)
                {
                    _submitCommand = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }
                return _submitCommand; 
            }
        }

        private bool CanSubmitExecute(object arg)
        {
            if (string.IsNullOrEmpty(Person.FName) || 
                string.IsNullOrEmpty(Person.LName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SubmitExecute(object obj)
        {
            Persons.Add(Person);

            MessageBox.Show("增加一筆資料");
        }
    }
}

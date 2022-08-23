using MvvmSample.Base;
using System;
using System.ComponentModel;

namespace MvvmSample.Models
{
    public class Person : NotifyBase, IDataErrorInfo
    {
        private string _fName;

        public string FName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        private string _lName;

        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName = FName + " " + LName; }
            set 
            { 
                if (_fullName != value)
                {
                    _fullName = value;
                }
            }
        }

        public DateTime DateAdded { get; set; }

        // IDataErrorInfo
        public string this[string propertyName]
        {
            get
            {
                string result = string.Empty;

                switch (propertyName)
                {
                    case "FName":
                        if (string.IsNullOrEmpty(FName))
                            result = "First Name is required!";
                        break;
                    case "LName":
                        if (string.IsNullOrEmpty(FName))
                            result = "Last Name is required!";
                        break;
                }

                return result;
            }
        }

        public string Error => null;
    }
}

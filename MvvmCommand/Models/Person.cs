using MvvmCommand.Base;

namespace MvvmCommand.Models
{
    public class Person : NotifyBase
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
    }
}

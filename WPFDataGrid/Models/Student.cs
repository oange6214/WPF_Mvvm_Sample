using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace WPFDataGrid.Models
{
	public class Student
    {
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private bool _isSoccerPlayer;

		public bool IsSoccerPlayer
		{
			get { return _isSoccerPlayer; }
			set { _isSoccerPlayer = value; }
		}

		private Gender _gender;

		public Gender Gender
		{
			get { return _gender; }
			set { _gender = value; }
		}

		private ObservableCollection<string> _books;

		public ObservableCollection<string> Books
		{
			get { return _books; }
			set { _books = value; }
		}

		public static ObservableCollection<Student> GetStudents()
		{
			ObservableCollection<Student> studentColl = new ObservableCollection<Student>
			{
				new Student() { Id = 001, Name = "John", IsSoccerPlayer = true, Gender = Gender.Male },
				new Student() { Id = 002, Name = "Johny", IsSoccerPlayer = true, Gender = Gender.Male },
				new Student() { Id = 003, Name = "Tim", Gender = Gender.Male },
				new Student() { Id = 004, Name = "Lucky", IsSoccerPlayer = false, Gender = Gender.Female },
				new Student() { Id = 005, Name = "Lucy", Gender = Gender.Female }
			};

            return studentColl;
        }
	}
}

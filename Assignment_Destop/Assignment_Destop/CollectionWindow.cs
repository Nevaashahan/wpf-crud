
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Assignment_Destop
{
    public partial class CollectionWindow : ObservableObject
    {


        [ObservableProperty]
        public ObservableCollection<Student> students;
        [ObservableProperty]
        public Student? edit_student = null;




        [RelayCommand]
        public void RemoveStudent()
        {
            if (edit_student != null)
            {
                string name = edit_student.FirstName;
                students.Remove(edit_student);
                MessageBox.Show($"{name} is Deleted successfuly");

            }
            else
            {
                MessageBox.Show("Please Select Student");


            }
        }

        [RelayCommand]
        public void AddStudent()
        {
            /*
            var student = new Student(21, "wall", "King", "2001/08/04", 3.9, "4.png");
            Person.Add(student);
            */
            var newWindow = new NewWindowVM();

            newWindow.title = "ADD STUDENT";
            NewWindow window = new NewWindow(newWindow);
            window.ShowDialog();

            if (newWindow.addStudent.FirstName != null)
            {
                students.Add(newWindow.addStudent);
            }
        }

        [RelayCommand]
        public void EditStudent()
        {
            if (edit_student != null)
            {
                var newWindow = new NewWindowVM(edit_student);
                newWindow.title = "EDIT STUDENT";
                var window = new NewWindow(newWindow);

                window.ShowDialog();


                int index = students.IndexOf(edit_student);
                students.RemoveAt(index);
                students.Insert(index, newWindow.addStudent);



            }
            else
            {
                MessageBox.Show("Please Select the student");
            }
        }

        public CollectionWindow()
        {
            students = new ObservableCollection<Student>();
            students.Add(new Student(21, "Kamal","Kumar", "1999/02/04", 3.4, "2.png"));
            students.Add(new Student(28, "Edward", "Browny", "1995/06/12", 3.2, "3.png"));
            students.Add(new Student(20, "Chao", "Wils", "2000/07/29", 3.5, "10.png"));
            students.Add(new Student(24, "Simon",  "Johnson", "2001/07/07", 3.2, "5.png"));
            students.Add(new Student(26, "Mav",  "George", "1999/11/08", 3.0, "8.png"));
            students.Add(new Student(27, "Manthon",  "Harton", "2000/05/06", 3.8, "1.png"));
        }



    }
}

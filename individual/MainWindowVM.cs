using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using individual.Messenger;
using individual.Models;
using individual.ViewModels;
using individual.Views;

namespace individual
{
    public partial class MainWindowVM : ObservableObject, IRecipient<PersonMessenger>, IRecipient<SendBackEditPersonMessenger>
    {
        public Action CloseAction { get; set; }

        private readonly WindowFactory m_windowFactory;

        [ObservableProperty]
        public ObservableCollection<Student> studentList;
        [ObservableProperty]
        public Student selectedStudent;

        private int selectedStudentIndex;

        public MainWindowVM()
        {
            WindowFactory windowFactory = new ProductionWindowFactory();
            m_windowFactory = windowFactory;

            studentList = new ObservableCollection<Student>()
            {
                new Student(01, "Noah", "Brown", 24, "1.png"),
                new Student(02, "William", "Miller", 24, "2.png"),
                new Student(03, "Emma", "Johnson", 24, "4.png")
            };

            
            WeakReferenceMessenger.Default.Register<PersonMessenger>(this);
            WeakReferenceMessenger.Default.Register<SendBackEditPersonMessenger>(this);
        }

        public void AddStudentList(Student student)
        {
            student.Id = studentList.Count + 1;
            studentList.Add(student);
        }

        [RelayCommand]
        public void RemoveStudent()
        {
            try
            {
                selectedStudentIndex = studentList.IndexOf(selectedStudent);
                studentList.Remove(selectedStudent);
                for (int i = selectedStudentIndex; i < studentList.Count; i++)
                {
                    Student student;
                    student = studentList[i];
                    student.Id = i + 1;
                    studentList.RemoveAt(i);
                    studentList.Insert(i, student);
                }
            }
            catch (Exception ex)
            {
                if (studentList.Count == 0)
                    m_windowFactory.CreateMessageBox("Student List is Empty!");
                else
                    m_windowFactory.CreateMessageBox("Please Select a Student to Delete.");
            }

        }


        [RelayCommand]
        public void DoOpenNewWindow()
        {
            m_windowFactory.CreateNewWindow();


            //CloseAction();
        }

        [RelayCommand]
        public async void EditSelectedStudent()
        {
            if (selectedStudent != null)
            {
                selectedStudentIndex = studentList.IndexOf(selectedStudent);
                Task messageTask = SendSelectedStudent();
                Task windowTask = m_windowFactory.CreateEditWindow();

                await messageTask;
                await windowTask;
            }
            else
            {
                m_windowFactory.CreateMessageBox("Please Select a Student to Edit.");
            }

        }

        public void Receive(PersonMessenger message)
        {
            AddStudentList(message.Value);
        }

        public void Receive(SendBackEditPersonMessenger message)
        {
            studentList.RemoveAt(selectedStudentIndex);
            studentList.Insert(selectedStudentIndex, message.Value);
        }

        public async Task SendSelectedStudent()
        {
            await Task.Delay(100);
            WeakReferenceMessenger.Default.Send(new EditPersonMessenger(selectedStudent));
        }

    }

    public interface WindowFactory
    {
        void CreateNewWindow();
        Task CreateEditWindow();
        void CreateMessageBox(string messageString);
    }

    public class ProductionWindowFactory : WindowFactory
    {
        public void CreateNewWindow()
        {

            AddStudent window = new AddStudent();
            window.ShowDialog();
        }

        public async Task CreateEditWindow()
        {
            EditStudent window = new EditStudent();
            await Task.Delay(100);
            window.ShowDialog();
        }

        public void CreateMessageBox(string messageString)
        {
            CustomMessageBox window = new CustomMessageBox(messageString);
            window.ShowDialog();
        }
    }
}

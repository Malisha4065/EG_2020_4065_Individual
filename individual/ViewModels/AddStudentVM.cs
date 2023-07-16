using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using individual.Messenger;
using individual.Models;
using individual.Views;
using Microsoft.Win32;

namespace individual.ViewModels
{
    public partial class AddStudentVM : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string firstName;
        [ObservableProperty]
        public string lastName;
        [ObservableProperty]
        public DateTime dateOfBirth;
        [ObservableProperty]
        public string city;
        [ObservableProperty]
        public BitmapImage formPhoto;

        //------------------------------------------
        [ObservableProperty]
        public string ee3301;
        [ObservableProperty]
        public string ee3302;
        [ObservableProperty]
        public string ee3203;
        [ObservableProperty]
        public string ee3305;
        [ObservableProperty]
        public string ee3206;
        [ObservableProperty]
        public string ee3151;
        [ObservableProperty]
        public string is3302;
        //------------------------------------------

        public Student Student;
        public Action CloseAction { get; set; }
        private readonly WindowFactory m_windowFactory;

        [RelayCommand]
        public void InsertPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            
            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                FormPhoto = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        public AddStudentVM()
        {
            WindowFactory windowFactory = new ProductionWindowFactory();
            m_windowFactory = windowFactory;

            Student = new Student();
            formPhoto = new BitmapImage(new Uri("/Icons/default.png", UriKind.Relative));
        }

        [RelayCommand]
        public void SubmitButton()
        {
            if (firstName == "" || lastName == "")
            {
                m_windowFactory.CreateMessageBox("First and Last Names are Compulsory!");
            }
            else
            {
                Student.FirstName = firstName;
                Student.LastName = lastName;
                Student.DateofBirth = dateOfBirth;
                Student.Age = CalcAge();
                Student.City = city;
                Student.Photo = formPhoto;

                //-------------------------------------
                Student.Modules[0].Grade = ee3301;
                Student.Modules[1].Grade = ee3302;
                Student.Modules[2].Grade = ee3203;
                Student.Modules[3].Grade = ee3305;
                Student.Modules[4].Grade = ee3206;
                Student.Modules[5].Grade = ee3151;
                Student.Modules[6].Grade = is3302;
                //-------------------------------------
                Student.GPA = CalcGPA();

                WeakReferenceMessenger.Default.Send(new PersonMessenger(Student));
                CloseAction();
            }
        }

        private int CalcAge()
        {
            int thisYear = DateTime.Now.Year;
            int thisMonth = DateTime.Now.Month;
            int thisDay = DateTime.Now.Day;
            int bornYear = dateOfBirth.Year;
            int bornMonth = dateOfBirth.Month;
            int bornDay = dateOfBirth.Day;
            int age;

            if (thisMonth > bornMonth)
            {
                age = thisYear - bornYear;
            }
            else if (thisMonth == bornMonth)
            {
                if (thisDay >= bornDay)
                    age = thisYear - bornYear;
                else
                    age = thisYear - bornYear - 1;
            }
            else
            {
                age = thisYear - bornYear - 1;
            }

            return age;
        }

        private string CalcGPA()
        {
            Dictionary<string, float> GPV = new Dictionary<string, float>()
            {
                {"A+", 4.0F}, {"A", 4.0F}, {"A-", 3.7F}, {"B+", 3.3F}, {"B", 3.0F}, {"B-", 2.7F}, {"C+", 2.3F},
                {"C", 2.0F}, {"C-", 1.7F}, {"E", 0.0F}
            };
            
            List<string> Modules = new List<string> { ee3301, ee3302, ee3203, ee3305, ee3206, ee3151, is3302 };
            List<int> Credits = new List<int> { 3, 3, 2, 3, 2, 1, 3 };

            float numerator = 0.0F;
            float denominator = 0.0F;

            for (int i = 0; i < Modules.Count; i++) {
                float product;
                if (Modules[i] == null) { 
                    product = 0;
                } else { 
                    product = GPV[Modules[i]] * Credits[i];
                }
                numerator += product;
                denominator += Credits[i];
            }

            float GPA = numerator / denominator;

            return GPA.ToString("0.00");
        }
    }
}


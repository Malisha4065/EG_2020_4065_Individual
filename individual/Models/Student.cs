using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace individual.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateofBirth { get; set; }
        public string City { get; set; }
        public string GPA { get; set; }
        public List<Module> Modules { get; set; }
        public string Image { get; set; }
        public BitmapImage Photo { get; set; }
        public string ImageURL
        {
            get
            {
                return $"/Icons/{Image}";
            }
        }


        public Student() { 
            Modules = new List<Module>()
            {
                new Module(1, "EE3301", "Analog Electronics"),
                new Module(2, "EE3302", "Data Structures and Algorithms"),
                new Module(3, "EE3203", "Electrical and Electronic Measurements"),
                new Module(4, "EE3305", "Signals and Systems"),
                new Module(5, "EE3206", "GUI Programming"),
                new Module(6, "EE3151", "Programming Project"),
                new Module(7, "IS3302", "Complex Analysis and Mathematical Transforms")
            };
            
        }
        public Student(int id, string firstName, string lastName, int age, string image)
        {
            Id = id;
            FirstName = firstName;  
            LastName = lastName;
            Age = age;
            Image = image;
            Photo = new BitmapImage(new Uri(ImageURL, UriKind.Relative));
            DateofBirth = new DateTime(1999, 01, 01);

            Modules = new List<Module>()
            {
                new Module(1, "EE3301", "Analog Electronics"),
                new Module(2, "EE3302", "Data Structures and Algorithms"),
                new Module(3, "EE3203", "Electrical and Electronic Measurements"),
                new Module(4, "EE3305", "Signals and Systems"),
                new Module(5, "EE3206", "GUI Programming"),
                new Module(6, "EE3151", "Programming Project"),
                new Module(7, "IS3302", "Complex Analysis and Mathematical Transforms")
            };
        }
    }
}

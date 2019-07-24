using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args)
        {
            Student brailee = new Student();//This is how you create a new instance of a class.  Will be done alot.  It is using a default constructor.
            brailee.FirstName = "Brailee";//Sets the firstname to "Brailee"
            brailee.LastName = "Begley";
            brailee.Address = "123 Main St";
            brailee.City = "Cincinnati";
            brailee.State = "OH";
            brailee.Zip = "45244";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);

            Student jesse = new Student();
            jesse.FirstName = "Jesse";
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1990, 01, 01);

            Student alex = new Student();
            alex.FirstName = "Alex";
            alex.LastName = "Chan";
            alex.IsPaid = false;

            string name = jesse.FirstName;
        }
    }
    class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Bootcamp { get; set; }
        public string Status { get; set; } //current, future, past
        public string Email { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime Birthdate { get; set; }


    }
}

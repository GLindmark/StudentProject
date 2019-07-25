using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args)
        {
            Student brailee = new Student();//This is how you create a new instance of a class.  Will be done alot.  It is using a default constructor.
            brailee.SetStatus(StudentStatus.Current);

            brailee.FirstName = "Brailee";//Sets the firstname to "Brailee"
            brailee.LastName = "Begley";
            brailee.Address = "123 Main St";
            brailee.City = "Cincinnati";
            brailee.State = "OH";
            brailee.Zip = "45244";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);
            //brailee.SetCreditScore(40);
            Console.WriteLine($"Brailee status is {brailee.CreditScore}");
           

            //Student jesse = new Student("Jesse", "Kyle");//This one uses the Constructor that has 'firstname', 'lastname'
            //Console.WriteLine($"Jess:{jesse.FirstName} { jesse.LastName}");
            //jesse.IsPaid = true;
            //jesse.Birthdate = new DateTime(1990, 01, 01);



            Console.WriteLine($"Brailee's Bootcamp is {brailee.Bootcamp}");//This is using the Contructor that uses the default Constructor

            //Student alex = new Student();
            //alex.FirstName = "Alex";
            //alex.LastName = "Chan";
            //alex.IsPaid = false;
            //alex.Birthdate = new DateTime(1990, 02, 01);

            //Student Titus = new Student();
            //Titus.FirstName = "Titus";
            //Titus.LastName = "Moore";
            //Titus.IsPaid = true;
            //Titus.Birthdate = new DateTime(1990, 01, 01);

            //string name = jesse.FirstName;
        }
    }
    enum StudentStatus { Past, Current, Future }//Don't place inside of class student

    class Student {
        private int nextId = 1;
        public int Id { get; set; }//primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Bootcamp { get; set; }
        public StudentStatus Status { get; set; } //current, future, past
        public string Email { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime Birthdate { get; set; }
        public int CreditScore { get; private set; }// set to Private so that a value can't be put in that is outside the accepted values
        /// </summary>
        /// <param name="status"></param>

        //above are the Properties; below are the Methods
        //'Void' doesn't return a value.

        public void SetStatus(StudentStatus status) {
            if ((status == "CURRENT")
                    || (status == "PAST")
                    || (status == "FUTURE")) {
                this.Status = status;
        } else {
                Console.WriteLine("Status must be: PAST, CURRENT or FUTURE");
            //    }//This forces the status to be one of the three listed


            //}

            //public void SetCreditScore (int score) {
            //    if(score >= 400 && score <= 900) {
            //        this.CreditScore = score;
            //    }
            //    else {
            //        Console.WriteLine("Creditscore must be between 400 and 900");
            //    }

            //}






            public Student(string firstname, string lastname)
        {
            this.Id = nextId;
                nextId = nextId + 1;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Bootcamp = "Java";
        }
        public Student()
        {
            this.Bootcamp = ".NET";//sets the default course to .NET



        }
    }
}

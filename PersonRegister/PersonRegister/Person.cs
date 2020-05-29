using System;

namespace PersonRegister
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        //Get set metod som anropas av i Form3.cs dokumentet i samband med att ge den nya personen värden
        public string FirstName 
        {
            get { return firstName;}
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        {
            
            FirstName = "Jamiro";
            LastName = "Liebe";
            Age = 17;
        
        }

        //En konstruktor som tar tre agrument
        public Person(string firstName, string secondName, int age) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        //ToString() ger oss i detta fallet ett format hur innput ska bearbetas, Age blir en string, sedan Lastname, och sist Firstname
        public override string ToString()
        {
            string output = string.Empty;
            output += String.Format(Convert.ToString(Age));
            output += String.Format(" {0}, {1}", LastName, FirstName);

            return output;
        }


    } //slutet på klassen

} // slutet på namespace


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    public class Person
    {
        private readonly string firstName;
        private readonly Gender gender;


        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName { get; private set; }

        public DateTime Birthday { get; }

        public int Age
        {
            get
            {

                var now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                var bth = int.Parse(Birthday.ToString("yyyyMMdd"));
                return (now - bth) / 10000;

            }
        }

        public Person(string firstName, string lastName, DateTime birthday, Gender gender)
        {
            this.firstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            this.gender = gender;
        }


        public override string ToString()
        {
            return $"{ConvertGenderToText()} {FirstName} {LastName} was born in {Birthday.ToString("dd/MMM/yyyy", new CultureInfo("en-GB"))}";
        }

        private string ConvertGenderToText()
        {
            return gender == Gender.Male ? "Mister." : "Miss.";
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
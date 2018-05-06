using System;

namespace assignment1Q3 {

class Student : Person {
        public Student (string firstName, string lastname, DateTime dob) : base(firstName, lastname, dob) {}
        public void EnrollStudent()
         {
            var rand = new Random();
            }
        public override string PersonInfo() {

        return $"\nFull Name: {GetFullName()} \nAge: {GetAge()} years old\n";

        }

    }

}
using System;
namespace Dog
{
    public class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public void Bark(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write("Woof!");
            }
            Console.WriteLine("");
        }

        public string GetTag()
        {
            bool genders = gender == Gender.Female;
            string years = age == 1 ? " year" : " years";

            return String.Format("If lost, call " + owner + ". " + (genders ? "Her" : "His") + " name is " + name + " and " + (genders 
            ? "she" : "he") + " is " + age + years + " old. \n");
        }
}
}

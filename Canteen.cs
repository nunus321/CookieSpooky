using System.ComponentModel;

namespace DIKUCanteen
{

    public class Canteen : Room
    {
        public int cups = 100;

        public override String ToString()
        { return String.Format("Name:" + Name + ", " + "Cups:" + cups);
        }
        public Canteen(string name) : base(name)
        {
        }

        public Canteen(string name, int cups) : base(name)
        {
            this.cups = cups;
        }
      
        public int Cups
        {
            get { return cups; }
        }
    }


public class Person {
    string Name;
    string Occupation;
    int Age;
    public Person(string name, string occupation, int age)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
    }
}

public class Student : Person
{
    bool HasCup = false;
    public Student(string name, string occupation, int age) : base(name,occupation,age)
    {

    }
    public void TakeCup(Canteen canteen)
    {
        if (canteen.cups > 0 && HasCup != true) 
        {
            canteen.cups -= 1;
            HasCup = true;
        }
        else
        {
            Console.WriteLine("ingen kopper oh noooo!");
        }
    }

        public void ReturnCup(Canteen canteen)
    {
        if (HasCup == true) 
        {
            canteen.cups += 1;
            HasCup = false;
        }
        else
        {
            Console.WriteLine("ingen kopper oh noooo!");
        }
    }
}





public class CanteenBoardMember :  Student
{
    static int CupBudget = 10;
    public CanteenBoardMember(string name, string occupation, int age) : base(name,occupation,age)
        {

        } 
    public void BuyCup(Canteen canteen)
    {
        if (CupBudget >= 1)
        {
            CupBudget -= 1;
            canteen.cups += 1;
        }
        else 
        {
            Console.Write("Kan ikke købe da der ikke er flere penge :( ");
        }

    }
}



}
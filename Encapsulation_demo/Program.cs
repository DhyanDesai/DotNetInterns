using System;

public class Person
{

    private string? name;
    private int age;

    // Encapsulated property for the name field
    public string? Name
    {
        get { return name; }
        set { name = value; }
    }

    // Encapsulated property for the age field
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 120)
                age = value;
            else
                throw new ArgumentException("Age must be between 0 and 120.");
        }
    }
}

public class Encapsulation
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // Set values using properties
        person.Name = "tina";
        person.Age = 21;

        // Get values using properties
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}

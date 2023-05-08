namespace OutTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Modify(out person);
            Console.WriteLine(person.Name);
           
        }
        static void Modify(out Person person)
        {
            person = new Person();
            person.Age += 1;
            person.Name = "Hikmet";
        }
        class Person
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public Person()
            {
                
            }
            public string Name { get; set; }    
            public int Age { get; set; }
        }
    }
}
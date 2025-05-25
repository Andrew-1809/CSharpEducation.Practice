namespace ClassLibrary_Person
{
    public class Person
    {
        public string name;
        public int age;
        public void Print()
        {
            Console.WriteLine($"Человек по имени {name} возрастом {age}");
        }
    }
}

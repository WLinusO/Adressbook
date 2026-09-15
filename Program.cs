// namespace Lektion_7;

// class Program
// {
//     static void Main()
//     {











//     }









// }

class Program
{
    static void Main()
    {

        Person person1 = new Person();

        Console.Write("Skriv ditt namn: ");
        person1.userName = Console.ReadLine();
        Console.Write("Skriv in din Ålder: ");
        person1.age = int.Parse(Console.ReadLine());




        Person person2 = new Person();
        person2.userName = "Bengt";
        person2.age = 45;






        Console.WriteLine("Hej :" + person1.userName + " du är : " + person1.age + " år gammal");
        Console.WriteLine("Hej :" + person2.userName + " du är : " + person2.age + " år gammal");

    }
}

//Göra en class
class Person
{
    public string userName;
    public int age;



}





// namespace Lektion_7;

// class Program
// {
//     static void Main()
//     {











//     }









// }



//Göra en class

class Student
{
    public string userName = "Inget namn";
    public int age;
}

class bla
{

    static void Main()
    {
        Student student1 = new Student();
        student1.userName = "Bengt";

        Student student2 = new Student();

        Console.WriteLine("student1: " + student1.userName);
        Console.WriteLine("student 2: " + student2.userName);
    }
}
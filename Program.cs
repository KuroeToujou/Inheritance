namespace baru.LatihanInheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Supri", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Huda", 30, "2122", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Dias", 20, "2314", "Diaskuncoro@gmail.com");
            student.GetNameAndAge();
        }
    }
}
namespace PrincipiosSolid
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"Estudiante {student.Name} te has suscrito al curso offline\n\n");
        }
    }
}

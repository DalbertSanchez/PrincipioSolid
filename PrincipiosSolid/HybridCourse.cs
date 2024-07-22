namespace PrincipiosSolid
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"Estudiante {student.Name} te has suscrito al curso hibrido en el cual podras disfrutar del contenido online y offline\n\n");
        }
    }
}

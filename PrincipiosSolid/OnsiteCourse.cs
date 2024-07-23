namespace PrincipiosSolid
{
    public class OnsiteCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"Estudiante {student.Name} te has suscrito al curso presencial\n\n");
        }
    }
}

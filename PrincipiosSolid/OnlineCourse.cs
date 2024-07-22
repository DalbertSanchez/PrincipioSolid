namespace PrincipiosSolid
{
    public class OnlineCouse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"Estudiante {student.Name} te has suscrito al curso online\n\n");
        }
    }
}

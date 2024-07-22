namespace PrincipiosSolid
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string? Tittle { get; set; }

        public abstract void Subscribe(Student student);
    }
}

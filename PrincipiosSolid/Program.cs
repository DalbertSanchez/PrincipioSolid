using PrincipiosSolid;

var student = new Student { StudentId = 20230213, Name = "Dalbert Sanchez" };


Course course = new OnlineCouse { CourseId = 4005, Tittle = "Curso online de fundamentos de programacion" };
Console.WriteLine(course.Tittle);
course.Subscribe(student);

course = new OnsiteCourse { CourseId = 1505, Tittle = "Curso presencial de Programacion I" };
Console.WriteLine(course.Tittle);
course.Subscribe(student);

course = new HybridCourse { CourseId = 2589, Tittle = "Curso hybrido de fundamentos de programacion / Programacion I" };
Console.WriteLine(course.Tittle);
course.Subscribe(student);




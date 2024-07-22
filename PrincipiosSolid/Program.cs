using PrincipiosSolid;

var student = new Student { StudentId = 20230213, Name = "Dalbert Sanchez" };


Course online = new OnlineCouse { CourseId = 4005, Tittle = "Curso online de fundamentos de programacion" };
Course offline = new OfflineCourse { CourseId = 1505, Tittle = "Curso offline de Programacion I" };
Course hybrid = new HybridCourse { CourseId = 2589, Tittle = "Curso hybrido de fundamentos de programacion / Programacion I" };

Console.WriteLine(online.Tittle);
online.Subscribe(student);


Console.WriteLine(offline.Tittle);
offline.Subscribe(student);


Console.WriteLine(hybrid.Tittle);
hybrid.Subscribe(student);

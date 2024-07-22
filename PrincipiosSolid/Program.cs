using PrincipiosSolid;

Persona persona = new Persona();
EnviarCorreoElectronico enviarCorreo = new EnviarCorreoElectronico(persona, "Dalbert", "dalbert@gmail.com", "Holaa Jose!! hace mucho que no se de ti");

enviarCorreo.Enviar();

ImprimirDatos datos = new ImprimirDatos(persona, "Dalbert", 25, "Calle Principal", "dalbert@gmail.com");
Console.WriteLine(datos.ToString());

namespace PrincipiosSolid
{
    public class EnviarCorreoElectronico
    {
        public string Mensaje { get; set; }

        private readonly Persona persona;

        public EnviarCorreoElectronico(Persona persona, string Nombre, string CorreoElectronico, string Mensaje)
        {
            this.persona = persona;
            this.Mensaje = Mensaje;
            persona.CorreoElectronico = CorreoElectronico;
            persona.Nombre = Nombre;
        }

        public void Enviar()
        {
            Console.WriteLine($"Reply {persona.CorreoElectronico}:{persona.Nombre} has enviado un correo: {Mensaje}");

        }
    }

}

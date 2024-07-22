namespace PrincipiosSolid
{
    public class ImprimirDatos
    {
        private Persona persona;

        public ImprimirDatos(Persona persona, String Nombre, int Edad,
                             String Direccion, String CorreoElectronico)
        {
            this.persona = persona;
            persona.Nombre = Nombre;
            persona.Edad = Edad;
            persona.Direccion = Direccion;
            persona.CorreoElectronico = CorreoElectronico;
        }
        public override string ToString()
        {
            return $"\n\nNombre: {persona.Nombre}\n" +
                   $"Edad: {persona.Edad}\n" +
                   $"Direccion: {persona.Direccion}\n" +
                   $"Correo Electronico: {persona.CorreoElectronico} \n";

        }
    }

}

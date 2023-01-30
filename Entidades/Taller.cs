namespace Entidades
{
    public class Taller<T> where T : IInflable
    {
        public static List<Auto> ObtenerAutos()
        {
            return null;
        }

        public static void RegistrarVehiculo(Vehiculo auto)
        {

        }

        public static bool UtilizarInflador(T dato)
        {
            if (dato is IInflable)
            {
                dato.Inflar(dato.PresionMaxima);
                
            }
            return dato.EstaInflado;

        }

        public static void Reparar(Auto vehiculo)
        {
            vehiculo.Reparar();
        }


    }
}

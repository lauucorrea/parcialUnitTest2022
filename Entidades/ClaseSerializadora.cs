using System.Text.Json;

namespace Entidades
{

    public static class ClaseSerializadora<T>
    {
        public static void SerializarListaJson(List<Vehiculo> lista)
        {
            try
            {

                JsonSerializerOptions opciones = new();
                opciones.WriteIndented = true;
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string rutaVehiculos = Path.Combine(ruta, "vehiculos.json");

                string jsonString = JsonSerializer.Serialize(lista, opciones);

                File.WriteAllText(rutaVehiculos, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void SerializarPelota(IInflable pelota)
        {
            try
            {

                JsonSerializerOptions opciones = new();
                opciones.WriteIndented = true;
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string rutaPelota = Path.Combine(ruta, "pelota.json");

                string jsonString = JsonSerializer.Serialize(pelota, opciones);

                File.WriteAllText(rutaPelota, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

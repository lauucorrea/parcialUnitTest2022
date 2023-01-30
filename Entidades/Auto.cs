using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo, IInflable
    {
        public Auto() : base()
        {

        }
        public Auto(int presionInflado, string patente) : base(presionInflado, 300, patente)
        {

        }

        private void ArreglarMecanica()
        {

        }

        public void Reparar()
        {
        }

        public override void CircularVehiculo()
        {
            this.presionInflado -= 10;
        }
    }
}

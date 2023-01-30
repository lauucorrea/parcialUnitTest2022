namespace Entidades
{
    public class Moto : Vehiculo, IInflable
    {
        bool chequeado;

        public Moto(float presionInflado, string patente) : base(presionInflado, 200, patente)
        {

        }

        public Moto() : base()
        {

        }

        private void DejarDeCircular()
        {
            this.estaInflado = false;
            this.presionInflado = 0;
        }



        public bool EstaInflado { get => base.estaInflado; set => base.estaInflado = value; }
        public bool EstaReparado { get => base.estaReparado; set => base.estaReparado = value; }

        public override void CircularVehiculo()
        {
            this.presionInflado -= 10;
           
        }

        public void Reparar()
        {
            this.estaReparado = true;
        }
    }
}

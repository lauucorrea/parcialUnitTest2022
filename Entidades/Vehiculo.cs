namespace Entidades
{
    public abstract class Vehiculo : IInflable, IVehiculo
    {
        protected string patente;
        protected bool estaInflado;
        protected bool estaReparado;
        protected float presionInflado;
        protected float presionMaxima;

        public Vehiculo()
        {
            estaReparado = false;
            this.estaInflado = false;
        }

        public Vehiculo(float presionInflado, float presionMaxima, string patente) : this()
        {
            this.presionInflado = presionInflado;
            this.presionMaxima = presionMaxima;
            this.patente = patente;
        }


        public float PresionInflado { get => presionInflado; set => presionInflado = value; }
        public bool EstaInflado { get => estaInflado; set => estaInflado = value; }
        public bool EstaReparado { get => estaReparado; set => estaReparado = value; }
        public string Patente { get => patente; set => patente = value; }
        public float PresionMaxima { get => presionMaxima; }

        public abstract void CircularVehiculo();

        public void Inflar(float presionInflado)
        {
            if (EstaInflado == false)
            {
                this.presionInflado += presionInflado;
                if (this.presionInflado == presionMaxima)
                {
                    EstaInflado = true;
                }
                else if(presionInflado > presionMaxima)
                {
                    throw new ExplotaException("Exploto la llanta");
                }
            }
        }

    }
}

namespace Entidades
{
    public class Pelota : IInflable
    {
        bool inflado;
        float presionInflado;

        public Pelota(float presionInflado)
        {
            this.presionInflado = presionInflado;
        }
        public Pelota()
        {
        }

        public bool EstaInflado { get => inflado; set => inflado = value; }
        public float PresionMaxima { get { return 45; } }

        public void Inflar(float presionInflado)
        {
            this.presionInflado += presionInflado;
            if (this.presionInflado == PresionMaxima)
            {
                EstaInflado = true;
            }
            else if(presionInflado > PresionMaxima)
            {
                throw new ExplotaException("Exploto la pelota");
            }

        }
    }
}

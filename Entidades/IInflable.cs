namespace Entidades
{
    public interface IInflable
    {
        public bool EstaInflado { get; set; }
        public float PresionMaxima { get; }
        public void Inflar(float presionInflado);
    }
}

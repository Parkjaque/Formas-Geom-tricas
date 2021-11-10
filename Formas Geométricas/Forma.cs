namespace Formas_Geométricas_Metodos_Abstratos
{
    abstract class Forma
    {

        public Color Color { get; set; }
        public Forma(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}

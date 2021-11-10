namespace Formas_Geométricas_Metodos_Abstratos
{
    class Circulo : Forma
    {
        public double Raio { get; set; }
        public Circulo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
        }
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
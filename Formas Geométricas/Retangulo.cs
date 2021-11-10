namespace Formas_Geométricas_Metodos_Abstratos
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
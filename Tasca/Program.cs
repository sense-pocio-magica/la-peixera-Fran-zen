namespace Tasca;

internal class Program
{
    static void Main(string[] args)
    {
        int[] animals = [10,2,3,2];
        Peixera peixera = new();
        peixera.Inicia(animals);
        for (var i = 1; i <= 100; i++)
        {
            peixera.Ronda();
        }
        //peixera.Resultat();
    }
}
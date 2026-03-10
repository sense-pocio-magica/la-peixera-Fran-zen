namespace Tasca;

public class Peixera
{
    (int x, int y) _estanc = (20,20);
    private int _peix, _tauro, _tortuga, _pop;
    private int _ronda = 0;
    private List<IMarins> _peixos = new();
    private Random rnd = new();
    public void Inicia(int[] animals)
    {
        for (int i = 1; i <= animals[0]; i++)
        {
            new Peix((rnd.Next(_estanc.x), rnd.Next(_estanc.y)), rnd.Next(4), 1);
            new Peix((rnd.Next(_estanc.x), rnd.Next(_estanc.y)),rnd.Next(4), 2);
        }

        for (int i = 0; i < animals[1]; i++)
        {
            new Tauro((rnd.Next(_estanc.x), rnd.Next(_estanc.y)), rnd.Next(4), 1);
            new Tauro((rnd.Next(_estanc.x), rnd.Next(_estanc.y)),rnd.Next(4), 2);
        }

        for (int i = 0; i < animals[2]; i++)
        {
            new Tortuga((rnd.Next(_estanc.x), rnd.Next(_estanc.y)), rnd.Next(4), rnd.Next(3));
        }

        for (int i = 0; i < animals[3]; i++)
        {
            new Pop((rnd.Next(_estanc.x), rnd.Next(_estanc.y)), rnd.Next(4));
        }
    }

    public string Resultat()
    {
        
    };
    
}
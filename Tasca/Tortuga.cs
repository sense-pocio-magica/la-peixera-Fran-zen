namespace Tasca;

public class Tortuga : Animal
{
    public (int x, int y) PosicioInical { get; }
    protected int _direccio; //2 down, 4 left, 6 right, 8 up
    protected int _sexe;

    public Tortuga((int x, int y) posicioInical, int direccio, int sexe) : base(posicioInical, direccio, sexe)
    {
        PosicioInical = posicioInical;
        _direccio = direccio;
        _sexe = sexe;
    }

    public override void Interactuar(Animal altre, List<Animal> nous)
    {
        if (altre is Tortuga a)
        {
            if (Sexe != a.Sexe) nous.Add(new Tortuga((PosicioInical.x, PosicioInical.y),rnd.Next(3),rnd.Next(1,3)));
            else { Viu = false; a.Viu = false; }
        }

    }
}
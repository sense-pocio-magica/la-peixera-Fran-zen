namespace Tasca;

public class Tauro : Animal
{
    private int _tempsvida;

    public Tauro((int x, int y) posicioInical, int direccio, int sexe) : base(posicioInical, direccio, sexe)
    {
        _tempsvida = 75;
    }

    public override void Mou()
    {
        if (_tempsvida > 0)
        {
            base.Mou();
        }
        else Viu = false;
    }

    public override void Interactuar(Animal altre, List<Animal> nous)
    {
        if (altre is Tauro a)
        {
            if (Sexe != a.Sexe) nous.Add(new Tauro((PosicioInical.x, PosicioInical.y),rnd.Next(3),rnd.Next(1,3)));
            else { Viu = false; a.Viu = false; }
        }
        else if (altre is not Tortuga)
        {
            altre.Viu = false;
        }

    }
}
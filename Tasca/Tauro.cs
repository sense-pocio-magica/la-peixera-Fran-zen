namespace Tasca;

public class Tauro : Reproductor
{
    private int _tempsvida;

    public Tauro((int x, int y) posicioInical, int direccio, int sexe) : base(posicioInical, direccio, sexe)
    {
        _tempsvida = 50;
    }

    public override void Mou()
    {
        while (_tempsvida > 0)
        {
            base.Mou();
        }

        Viu = false;
    }
}
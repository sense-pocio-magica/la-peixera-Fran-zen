namespace Tasca;

public class Tauro : Reproductor
{
    private int _tempsvida = 50;

    public Tauro((int x, int y) posicioInical, int direccio, char sexe, int tempsvida) : base(posicioInical, direccio, sexe)
    {
        _tempsvida = tempsvida;
    }
}
namespace Tasca;

public class Tortuga : Reproductor
{
    protected (int x, int y) _PosicioInical;
    protected int _direccio; //2 down, 4 left, 6 right, 8 up
    protected int _sexe;

    public Tortuga((int x, int y) posicioInical, int direccio, int sexe) : base(posicioInical, direccio, sexe)
    {
        _PosicioInical = posicioInical;
        _direccio = direccio;
        _sexe = sexe;
    }
}
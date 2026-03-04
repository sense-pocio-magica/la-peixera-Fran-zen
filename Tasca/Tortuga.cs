namespace Tasca;

public class Tortuga : Reproductor
{
    private (int x, int y) _PosicioInical;
    private int _direccio; //2 down, 4 left, 6 right, 8 up
    private char _sexe;

    public Tortuga((int x, int y) posicioInical, int direccio, char sexe) : base(posicioInical, direccio, sexe)
    {
        _PosicioInical = posicioInical;
        _direccio = direccio;
        _sexe = sexe;
    }
}
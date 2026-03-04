namespace Tasca;

public class Peix : Reproductor
{
    private (int x, int y) _posicioInical;
    private int _direccio; //2 down, 4 left, 6 right, 8 up
    private char _sexe;

    public Peix((int x, int y) posicioInical, int direccio, char sexe) : base(posicioInical, direccio, sexe)
    {
        _posicioInical = posicioInical;
        _direccio = direccio;
        _sexe = sexe;
    }
    
    public void Mou()
    {
        throw new NotImplementedException();
    }

    public void Reprodueix(int direccio1, int direccio2)
    {
        throw new NotImplementedException();
    }
}
namespace Tasca;

public abstract class Animal : IMarins
{
    private (int x, int y) _posicioInical;
    private int _direccio; //2 down, 4 left, 6 right, 8 up
    private char _sexe;
    private bool _viu = true;
    public void Mou()
    {
        
    }

    public Animal((int x, int y) posicioInical, int direccio, char sexe)
    {
        _posicioInical = posicioInical;
        _direccio = direccio;
        _sexe = sexe;
    }
}
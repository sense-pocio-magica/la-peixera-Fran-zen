namespace Tasca;

public abstract class Reproductor: Animal,IReprodueix
{
    protected Reproductor((int x, int y) posicioInical, int direccio, int sexe) : base(posicioInical, direccio, sexe)
    {
    }

    public void Reprodueix(int direccio1, int direccio2)
    {
    }
}
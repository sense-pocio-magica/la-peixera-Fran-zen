namespace Tasca;

public abstract class Animal : IMarins
{
    public Random rnd = new();
    protected (int x, int y) PosicioInical;
    protected int Direccio; //2 down, 4 left, 6 right, 8 up
    protected Genere Sexe;
    public bool Viu { get; set; } = true;

    public virtual void Mou()
    {
        switch (Direccio)
        {
            case 6:
            {
                PosicioInical.x++;
                break;
            }
            case 4:
            {
                PosicioInical.x--;
                break;
            }
            case 2:
            {
                PosicioInical.y++;
                break;
            }
            case 8:
            {
                PosicioInical.y--;
                break;
            }
        }
    }

    public Animal((int x, int y) posicioInical, int direccio, int sexe)
    {
        PosicioInical = posicioInical;
        Direccio = direccio;
        Sexe = (Genere)rnd.Next(1, 3);
    }
    public abstract void Interactuar(Animal altre, List<Animal> nous);
}
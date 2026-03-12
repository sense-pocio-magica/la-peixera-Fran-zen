namespace Tasca;

public class Pop : Animal
{
    public Pop((int x, int y) posicioInical, int direccio) : base(posicioInical, direccio, 0)
    {
    }

    public override void Interactuar(Animal altre, List<Animal> nous)
    {
    
        if (altre is Pop) { PosicioInical.x *= -1; PosicioInical.y *= -1; }
    }
}
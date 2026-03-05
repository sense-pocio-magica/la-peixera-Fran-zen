namespace Tasca;

public class Peix : Reproductor
{
    private (int x, int y) _posicioInical;
    private int _direccio; //2 down, 4 left, 6 right, 8 up
    private int _sexe;

    public Peix((int x, int y) posicioInical, int direccio, int sexe) : base(posicioInical, direccio, sexe)
    {
        _posicioInical = posicioInical;
        _direccio = direccio;
        _sexe = sexe;
    }
    
    public void Mou((int x,int y) estanc)
    {
        switch (_direccio)
        {
            case 6:
            {
                if (PosicioInical.x < estanc.x)
                {
                    _posicioInical.x++;
                }
                else PosicioInical.x = (PosicioInical.x % estanc.x);
                break;
            }
            case 4:
            {
                if (PosicioInical.x > estanc.x)
                {
                    _posicioInical.x--;
                }
                else PosicioInical.x = estanc.x;
                break;
            }
            case 2:
            {
                if (PosicioInical.y < estanc.y)
                {
                    _posicioInical.y++;
                }
                else PosicioInical.y = (PosicioInical.y % estanc.y);
                break;
            }
            case 8:
            {
                if (PosicioInical.y < estanc.y)
                {
                    _posicioInical.y--;
                }
                else PosicioInical.y = estanc.y;
                break;
            }
        }
    }

    public Animal? Reprodueix(int direccio1, int direccio2, Animal p1 ,Animal p2)
    {

        return null;
    }
}

using ContadorManual.Models;

namespace ContadorManual;

public partial class MainPage : ContentPage
{

    private Contador incremento;

    public MainPage()
    {
        InitializeComponent();
        incremento = new Contador();
        this.BindingContext = incremento;
    }

    private void ContadorBoton(object sender, EventArgs E)
    {
        // Obtener el valor entero del Slider
        int valorlinea = (int)Math.Round(LineaIncremento.Value);

        // Contar solo números enteros
        incremento.Contar(valorlinea);

    }

    private void BotonReiniciar(object sender, EventArgs E)
    {
        incremento.Reiniciar();
    }
}


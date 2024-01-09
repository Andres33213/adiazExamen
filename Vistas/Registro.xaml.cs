namespace adiazExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {   //Control de rango
            double monto = Convert.ToDouble(txtMontoInicial.Text);
            if (monto > 1500 || monto < 0)
            {
                DisplayAlert("Alerta", "Rango 0 - 1500", "Cancel");
                txtMontoInicial.Text = "";
            }
        }
        catch (Exception)
        {

        }
    }

    private void btnCalcularPagoMensual_Clicked(object sender, EventArgs e)
    {
        try
        {
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);

            double pagoMensual;

            if (montoInicial == 1500)
            {
                pagoMensual = 0;
            }
            else
            {
                pagoMensual = (1500 - montoInicial) / 4 + 0.04 * 1500;
            }

            txtPagoMensual.Text = pagoMensual.ToString("");
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", "Error al realizar el cálculo", "Ok");
        }

    }


    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = dpFecha.Date.ToString();
        string ciudad = pkCiudades.Items[pkCiudades.SelectedIndex];
        string pais = pkPaises.Items[pkPaises.SelectedIndex];
        double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
        double pagoMensual = (1500 - montoInicial) / 4 + 0.04 * 1500;
        double pagoTotal = montoInicial + pagoMensual * 4;

        DisplayAlert("Resumen", "Nombre: "+nombre.ToString()+"\nApellido: "+apellido.ToString()+"\nEdad: "+edad.ToString()+
            "\nFecha: "+fecha.ToString()+"\nCiudad: "+ciudad.ToString()+"\nPais: "+pais.ToString()+"\nMonto Inicial: "+ montoInicial.ToString()
            +"\nPago Mensual: "+pagoMensual.ToString()+"\nPago Total: "+pagoTotal.ToString(), "Cancel");
    }
}
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

  
}
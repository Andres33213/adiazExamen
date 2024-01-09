using System.Security.Principal;

namespace adiazExamen.Vistas;

public partial class Login : ContentPage
{
    string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] contrasenas = { "uisrael2024", "parcial1", "2024" };
    public Login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;


        bool credencialesCorrectas = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuario && contrasenas[i] == contrasena)
            {
                credencialesCorrectas = true;
                break;
            }
        }

        if (credencialesCorrectas)
        {
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            DisplayAlert("ALERTA", "Usuario/Contraseña incorrectos", "Cancel");
        }
    }

    private void btnAcercaDe_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Informacion del Desarrolador", "Nombre: Andres Diaz \nCurso: 8vo\nParalelo: A", "Cancel");
    }
}
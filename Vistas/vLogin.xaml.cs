namespace aajilaExamen.Vistas;

public partial class vLogin : ContentPage
{
    string[,] usu = {
        { "estudiante2024", "uisrael2024" },
        { "examen1", "parcial1" },
    };
    public vLogin()
	{
		InitializeComponent();
	}

    bool ValidateUser(string username, string password)
    {
        for (int i = 0; i < usu.GetLength(0); i++)
        {
            if (usu[i, 0] == username && usu[i, 1] == password)
            {
                return true;
            }
        }
        return false;
    }
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string username = txtUsuario.Text;
        string password = txtContrasena.Text;

        if (ValidateUser(username, password))
        {
            
            var nextPage = new vRegistro(username);
            nextPage.Username = username;
            Navigation.PushAsync(nextPage);
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña invalidos.", "OK");
        }

    }
}
namespace aajilaExamen.Vistas;

public partial class vResumen : ContentPage
{

	public vResumen(string usuario,String nom, String ape, String ed, String fe, String da, String da1, String no, String p, String mt)
	{
		InitializeComponent();
        usernameLabel.Text = " " + usuario;
        lblNombre.Text = nom;
        lblApellido.Text = ape;
        lblEdad.Text = ed;
        lblFecha.Text = fe;
        lblCiudad.Text = da;
        lblPais.Text = da1;
        lblMonto.Text = no;
        lblMensual.Text = p;
        lblTotal.Text = mt;

    }

    

}
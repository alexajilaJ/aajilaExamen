namespace aajilaExamen.Vistas;

public partial class vRegistro : ContentPage
{
    public string Username { get; set; }
    public vRegistro(string usuario)
	{
		InitializeComponent();
        usernameLabel.Text = "Usuario conectado: " + usuario;
        //BindingContext = this;
    }

    private void btnCalculo_Clicked(object sender, EventArgs e)
    {
        int pag = Convert.ToInt32(txtMonto.Text);
        int resto = 1500 - pag;
        double tota = (resto / 4) + (1500 * 0.04);
        double tot = pag + 4 * tota;
        txtPago.Placeholder = tota.ToString();
        txttotal.Placeholder = tot.ToString();
    }
    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        String nom = txtNombre.Text;
        string ape = txtApellido.Text;
        string ed = txtEdad.Text;
        string fe = dpFecha.Date.ToString();
        string da = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
        string da1 = pkPais.Items[pkPais.SelectedIndex].ToString();
        string no = txtMonto.Text;
        string p = txtPago.Placeholder;
        string mt = txttotal.Placeholder;
        String u = usernameLabel.Text;
        Navigation.PushAsync(new Vistas.vResumen(u,nom,ape,ed,fe,da,da1,no,p,mt));
    }

}
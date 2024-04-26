namespace aajilaExamen.Vistas;

public partial class vRegistro : ContentPage
{
    int pago = 1500;
    public string Username { get; set; }
    public vRegistro()
	{
		InitializeComponent();
        BindingContext = this;
    }

    private void btnCalculo_Clicked(object sender, EventArgs e)
    {
        int pag = Convert.ToInt32(txtMonto.Text);
        int resto = 1500 - pag;
        double tota = (resto / 4) + (1500 * 0.04);
        txtPago.Placeholder = tota.ToString();
    }
    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.vResumen());
    }

}
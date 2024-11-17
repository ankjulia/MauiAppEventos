namespace MauiAppEventos.views;

public partial class eventoscalculados : ContentPage
      
  
{
    public string nome { get; set; }
    public string adultos { get; set; }
    public string criancas { get; set; }
    public string idosos { get; set; }
    public eventoscalculados()
	{
		InitializeComponent();
        BindingContext = this;
       

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      
        try
            {
            Navigation.PopAsync();
        }catch (Exception ex)
        {
            DisplayAlert("OPS", ex.Message, "Ok");
        }

    }
}
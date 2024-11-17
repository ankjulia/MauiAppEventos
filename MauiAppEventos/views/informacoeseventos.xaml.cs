using MauiAppEventos.models;

namespace MauiAppEventos.views;

public partial class informacoeseventos : ContentPage
{
    App propidadesApp;

	public informacoeseventos()
	{

		InitializeComponent();

        propidadesApp = (App)Application.Current;

        pck_local_evento.ItemsSource = propidadesApp.lista_locais;


        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_fim.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_inicio.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_fim.MaximumDate = dtpck_fim.Date.AddYears(2);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
            {
            textos t = new textos
            {
                nomedoevento = txt_nome_evento.Text,
               localselecionado = (local)pck_local_evento.SelectedItem,
               qntadultos = Convert.ToInt32(stp_adultos.Value),
               qntcriancas = Convert.ToInt32 (stp_criancas.Value),
               qntidoso= Convert.ToInt32 (stp_idoso.Value),
               datadeinicio = dtpck_inicio.Date,
               datadefim = dtpck_fim.Date,
            };

          

          await  Navigation.PushAsync(new eventoscalculados()
          {
              BindingContext = t
          });
            


        } catch (Exception ex)
        {
          await  DisplayAlert("OPS", ex.Message, "Ok");
        }
    }
}



using MauiAppEventos.models;

namespace MauiAppEventos
{
    public partial class App : Application
    {
        public List<local> lista_locais = new List<local>
        {
            new local ()
            {
                descricao =  "Chacara",
                valoradultolocal = 140.0,
                valorcriancalocal = 60,
                valoridosolocal = 70
            },
             new local ()
            {
                descricao =  "Salão",
                 valoradultolocal = 130.0,
                valorcriancalocal = 50.0,
                valoridosolocal = 60.0
            },
              new local ()
            {
                descricao =  "Igreja",
                  valoradultolocal = 125.0,
                valorcriancalocal = 45.0,
                valoridosolocal = 55.0
            },
               new local ()
            {
                descricao =  "Boliche",
                  valoradultolocal = 155.0,
                valorcriancalocal = 45.0,
                valoridosolocal = 40.0
            },
                new local ()
            {
                descricao =  "Playgrond",
                  valoradultolocal = 60.0,
                valorcriancalocal = 90.0,
                valoridosolocal = 30.0
            },
                 new local ()
            {
                descricao =  "Chale",
                  valoradultolocal = 150.0,
                valorcriancalocal = 70.0,
                valoridosolocal = 85.0
            }

        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new views.informacoeseventos());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}

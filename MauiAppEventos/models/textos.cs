

namespace MauiAppEventos.models
{
   public class textos
    {
        
        public  local localselecionado{  get; set; }

        public string nomedoevento { get; set; }
       
        public int  qntadultos { get; set; }

        public int qntcriancas { get; set; }

        public int qntidoso { get; set; }
        public DateTime datadeinicio { get; set; }
        public DateTime datadefim { get; set; }

        public int totaldedias 
            {
                get => datadefim.Subtract( datadeinicio).Days;
            }
          
        public double valortotal
        {
            get
            {
                double valor_adultos = qntadultos * localselecionado.valoradultolocal;
               double valor_criancas = qntcriancas * localselecionado.valorcriancalocal;
                double valor_idosos = qntidoso * localselecionado.valoridosolocal;

                double total = (valor_adultos + valor_criancas + valor_idosos) * totaldedias;
                return total;
            }
        }
        
    }
}

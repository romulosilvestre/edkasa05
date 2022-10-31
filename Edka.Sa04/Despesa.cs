using System;

namespace Edka.Sa04
{
    public class Despesa
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public override string ToString()=> $"{Descricao,-10}- - - - - - - - {Valor,9} -{Vencimento:dd/MM/yyyy}";
     }
}

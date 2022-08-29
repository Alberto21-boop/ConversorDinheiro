using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDinheiro;

public class Moeda
{

    public double ValorMoeda { get; set; }
    public string NomeMoeda { get; set; } = default!;
     
    
    public Moeda(string NomeMoeda, double ValorMoeda)
    {
       NomeMoeda = NomeMoeda;
       ValorMoeda = ValorMoeda;
    }
    public override string ToString()
    {
        return NomeMoeda + " " + ValorMoeda;
    }
    

}
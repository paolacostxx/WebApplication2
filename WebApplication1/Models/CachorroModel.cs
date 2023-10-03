using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CachorroModel
    {
        public string Raca { get; set; }
        public string Porte { get; set; }
        public string Nacionalidade { get; set; }
        public string Ano { get; set; }

        public static List<CachorroModel> CriarLista()
        {
            var lista = new List<CachorroModel>();

            lista.Add(new CachorroModel() { Raca = "Border Collie", Porte = "Médio", Nacionalidade = "Escócia", Ano = "10 a 17 anos" });
            lista.Add(new CachorroModel() { Raca = "Pastor Alemão", Porte = "Grande", Nacionalidade = "Alemanha", Ano = "9 a 13 anos" });
            lista.Add(new CachorroModel() { Raca = "Pinsher", Porte = "Pequeno", Nacionalidade = "Alemanha", Ano = "12 a 16 anos" });
            lista.Add(new CachorroModel() { Raca = "Vira lata caramelo", Porte = "Pequeno", Nacionalidade = "Brasil", Ano = "15 anos" });
            lista.Add(new CachorroModel() { Raca = "Pug", Porte = "Pequeno", Nacionalidade = "China", Ano = "12 a 15 anos" });

            return lista;
        }
    }
}

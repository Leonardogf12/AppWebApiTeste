using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebApiTeste.Models
{
    public class Produto
    {
        //CLASSE MODELO DE DOMINIO
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
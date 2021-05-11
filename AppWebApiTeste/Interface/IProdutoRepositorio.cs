using AppWebApiTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebApiTeste.Interface
{
    public interface IProdutoRepositorio
    {
        //METODOS DA INTERFACE
        IEnumerable<Produto> All { get; set; } //retorna todos produtos
        Produto Find(int id); //procura por 1 produto especifico
        void Insert(Produto item); //insere um produto a tabela
        void Update(Produto item); //atualiza algum produto da tabela
        void Delete(int id); //Exclui um produto da tabela
    }
}
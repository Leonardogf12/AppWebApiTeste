using AppWebApiTeste.ADONET;
using AppWebApiTeste.Interface;
using AppWebApiTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebApiTeste.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> _produtos;

        public ProdutoRepositorio()
        {
            InicializaDados();
        }

        private void InicializaDados()
        {
            _produtos = DalHelper.GetProdutos();
        }

        public IEnumerable<Produto> All
        {
            get
            {
                return _produtos;
            }
        }

        

        public void Delete(int id)
        {
            //_produtos.Remove(this.Find(id));
            DalHelper.DeleteProduto(id);
        }

        public Produto Find(int id)
        {
            //return _produtos.FirstOrDefault(item => item.Id == id);
            return DalHelper.GetProduto(id);
        }

        public void Insert(Produto produto)
        {
            //_produtos.Add(item);
            if (produto == null)
            {
                throw new ArgumentNullException("produto");
            }
            DalHelper.InsertProduto(produto);
        }

        public void Update(Produto produto)
        {
            if (produto == null)
            {
                throw new ArgumentNullException("produto");
            }
            DalHelper.UpdateProduto(produto);
        }


        IEnumerable<Produto> IProdutoRepositorio.All { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
using AppWebApiTeste.Interface;
using AppWebApiTeste.Models;
using AppWebApiTeste.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AppWebApiTeste.Controllers
{
    public class ProdutosController : ApiController
    {

        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutosController()
        {
            _produtoRepositorio = new ProdutoRepositorio();
        }

        // GET: api/Produtos
        [System.Web.Http.HttpGet]
        public IEnumerable<Produto> List()
        {
            return _produtoRepositorio.All;
        }

        // GET: api/Produtos/5
        public Produto GetProduto(int id)
        {
            var produto = _produtoRepositorio.Find(id);

            if (produto == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return produto;
        }

        // POST: api/Produtos   
        [System.Web.Http.HttpPost()]
        public void Post([FromBody] Produto produto)
        {
            _produtoRepositorio.Insert(produto);
        }

        // PUT: api/Produtos/5
        [System.Web.Http.HttpPut()]
        public void Put(int id, [FromBody] Produto produto)
        {
            produto.Id = id;
            _produtoRepositorio.Update(produto);
        }

        // DELETE: api/Produtos/5
        [System.Web.Http.HttpDelete()]
        public void Delete(int id)
        {
            _produtoRepositorio.Delete(id);
        }


    }
}
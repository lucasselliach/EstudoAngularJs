using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EstudoAngularJs.Api.ViewModels.Locacao;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Api.Controllers
{
    public class LocacaoController : ApiController
    {
        private readonly ILocacaoService _locacaoService;

        public LocacaoController(ILocacaoService locacaoService)
        {
            _locacaoService = locacaoService;
        }

        // GET: api/Locacao
        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _locacaoService.AdiquireLocacoesAtivas();
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
        
        // GET: api/Locacao/5
        [HttpGet]
        public Task<HttpResponseMessage> Get(Guid id)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _locacaoService.AdiquireLocacao(id);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        // POST: api/Locacao
        [HttpPost]
        public Task<HttpResponseMessage> Post([FromBody] NovoLocacaoViewModel novoLocacaoViewModel)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _locacaoService.RegistrarLocacao(novoLocacaoViewModel.ClienteQueAlocouId, novoLocacaoViewModel.FuncionarioQueAtendeuId, novoLocacaoViewModel.FilmeAlocadoId, novoLocacaoViewModel.TipoLocacao);
                httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                httpResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var task = new TaskCompletionSource<HttpResponseMessage>();
            task.SetResult(httpResponseMessage);
            return task.Task;
        }

        // PUT: api/Locacao/5
        [HttpPut]
        public Task<HttpResponseMessage> Put(Guid id, [FromBody]int tipoLocacao)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _locacaoService.EditarLocacao(id, tipoLocacao);
                httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                httpResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var task = new TaskCompletionSource<HttpResponseMessage>();
            task.SetResult(httpResponseMessage);
            return task.Task;
        }

        // DELETE: api/Locacao/5
        public Task<HttpResponseMessage> Delete(Guid id)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _locacaoService.FinalizarLocacao(id);
                httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                httpResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var task = new TaskCompletionSource<HttpResponseMessage>();
            task.SetResult(httpResponseMessage);
            return task.Task;
        }
    }
}

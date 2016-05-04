using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EstudoAngularJs.Api.ViewModels.Funcionario;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Api.Controllers
{
    public class FuncionarioController : ApiController
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        // GET: api/Funcionario
        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _funcionarioService.AdiquireFuncionarios();
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

        // GET: api/Funcionario/5
        [HttpGet]
        public Task<HttpResponseMessage> Get(Guid id)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _funcionarioService.AdiquireFuncionario(id);
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

        // POST: api/Funcionario
        [HttpPost]
        public Task<HttpResponseMessage> Post([FromBody]FuncionarioViewModel funcionarioViewModel)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _funcionarioService.RegistrarFuncionario(funcionarioViewModel.Nome, funcionarioViewModel.NumeroFuncionario, funcionarioViewModel.DataDeInicio);
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

        // POST: api/Funcionario/AlugouFilme
        [HttpPost]
        public Task<HttpResponseMessage> Post(Guid id)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _funcionarioService.AumentarRankEmQuantidadeDeAlugueisRealizados(id);
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

        // PUT: api/Funcionario/5
        [HttpPut]
        public Task<HttpResponseMessage> Put(Guid id, [FromBody] FuncionarioViewModel funcionarioViewModel)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _funcionarioService.EditarFuncionario(id, funcionarioViewModel.Nome, funcionarioViewModel.NumeroFuncionario, funcionarioViewModel.DataDeInicio);
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

        // DELETE: api/Funcionario/5
        [HttpDelete]
        public Task<HttpResponseMessage> Delete(Guid id)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _funcionarioService.ExcluirFuncionario(id);
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

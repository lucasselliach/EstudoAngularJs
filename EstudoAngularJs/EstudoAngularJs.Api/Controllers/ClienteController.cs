using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EstudoAngularJs.Api.ViewModels.Clientes;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Api.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: api/Cliente
        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _clienteService.AdiquireClientes();
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

        // GET: api/Cliente/5
        [HttpGet]
        public Task<HttpResponseMessage> Get(Guid id)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _clienteService.AdiquireCliente(id);
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

        // POST: api/Cliente
        [HttpPost]
        public Task<HttpResponseMessage> Post([FromBody]NovoClienteViewModel novoClienteViewModel)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _clienteService.RegistrarCliente(novoClienteViewModel.Nome, novoClienteViewModel.Cpf, novoClienteViewModel.Nascimento);
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

        // PUT: api/Cliente/5
        [HttpPut]
        public Task<HttpResponseMessage> Put(Guid id, [FromBody]EditarClienteViewModel editarClienteViewModel)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _clienteService.AtualizaCliente(id, editarClienteViewModel.Nome, editarClienteViewModel.Cpf, editarClienteViewModel.Nascimento);
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

        // DELETE: api/Cliente/5
        [HttpDelete]
        public Task<HttpResponseMessage> Delete(Guid id)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _clienteService.RemoveCliente(id);
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

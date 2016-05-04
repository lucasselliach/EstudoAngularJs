using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EstudoAngularJs.Api.ViewModels.Filme;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Api.Controllers
{
    public class FilmeController : ApiController
    {

        private readonly IFilmeService _filmeService;

        public FilmeController(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        // GET: api/Filme
        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _filmeService.AdiquireFilmes();
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

        // GET: api/Filme/5
        [HttpGet]
        public Task<HttpResponseMessage> Get(Guid id)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _filmeService.AdiquireFilme(id);
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

        // POST: api/Filme
        [HttpPost]
        public Task<HttpResponseMessage> Post([FromBody]FilmeViewModel filmeViewModel)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _filmeService.RegistrarFilme(filmeViewModel.Nome, filmeViewModel.FilmeGeneroId, filmeViewModel.AnoLancamento);
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

        // PUT: api/Filme/5
        [HttpPut]
        public Task<HttpResponseMessage> Put(Guid id, [FromBody]FilmeViewModel filmeViewModel)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _filmeService.EditarFilme(id, filmeViewModel.Nome, filmeViewModel.FilmeGeneroId, filmeViewModel.AnoLancamento);
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

        // DELETE: api/Filme/5
        [HttpDelete]
        public Task<HttpResponseMessage> Delete(Guid id)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _filmeService.ExcluirFilme(id);
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

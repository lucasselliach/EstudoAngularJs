using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EstudoAngularJs.Api.ViewModels;
using EstudoAngularJs.Api.ViewModels.FilmeGenero;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Api.Controllers
{
    public class FilmeGeneroController : ApiController
    {
        private readonly IFilmeGeneroService _filmeGeneroService;

        public FilmeGeneroController(IFilmeGeneroService filmeGeneroService)
        {
            _filmeGeneroService = filmeGeneroService;
        }

        // GET: api/FilmeGenero
        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _filmeGeneroService.AdiquireFilmesGeneros();
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

        // GET: api/FilmeGenero/5
        [HttpGet]
        public Task<HttpResponseMessage> Get(Guid id)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _filmeGeneroService.AdiquireFilmeGeneroById(id);
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

        // POST: api/FilmeGenero
        [HttpPost]
        public Task<HttpResponseMessage> Post([FromBody]FilmeGeneroViewModel filmeGeneroViewModel)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _filmeGeneroService.RegistrarFilmeGenero(filmeGeneroViewModel.Nome);
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
        
        // DELETE: api/FilmeGenero/5
        [HttpDelete]
        public Task<HttpResponseMessage> Delete(Guid id)
        {
            HttpResponseMessage httpResponseMessage;

            try
            {
                _filmeGeneroService.ExcluirFilmeGenero(id);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Kmb.HungryMinds.Models;
using Kmb.HungryMinds.Core;

namespace Kmb.HungryMinds.Controllers
{
    public abstract class CrudController<TRepository, TModel> : ApiController
        where TRepository : IRepository<TModel>
        where TModel : IdentifiedModel
    {
        protected IRepository<TModel> _repository;

        public CrudController(IRepository<TModel> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TModel> GetAll()
        {
            return _repository.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var item = _repository.Get(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        public IHttpActionResult Post(TModel item)
        {
            item = _repository.Add(item);
            return Created<TModel>(Url.Link("DefaultApi", new { id = item.Id }), item);
        }
    }
}
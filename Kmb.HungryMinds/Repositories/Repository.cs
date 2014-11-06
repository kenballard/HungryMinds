using Kmb.HungryMinds.Core;
using Kmb.HungryMinds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kmb.HungryMinds.Repositories
{
    public abstract class Repository<TModel> : IRepository<TModel> 
        where TModel : IdentifiedModel
    {
        protected List<TModel> models = new List<TModel>();
        protected int nextId = 1;

        public IEnumerable<TModel> GetAll()
        {
            return models;
        }

        public TModel Get(int id)
        {
            return models.FirstOrDefault(m => m.Id == id);
        }

        public TModel Add(TModel item)
        {
            if (item == null)
                throw new ModelNullException();
            item.Id = nextId++;
            models.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            models.RemoveAll(m => m.Id == id);
        }

        public void Update(TModel item)
        {
            if (item == null)
                throw new ModelNullException();
            var index = models.FindIndex(m => m.Id == item.Id);
            if (index == -1)
                throw new ModelIdNotFoundException();
            models.RemoveAt(index);
            models.Add(item);
        }

        public class ModelNullException : ArgumentNullException
        {
            public ModelNullException() : base ("item") { }
        }

        public class ModelIdNotFoundException : KeyNotFoundException
        {

        }
    }
}
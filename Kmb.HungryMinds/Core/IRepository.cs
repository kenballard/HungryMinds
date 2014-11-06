using Kmb.HungryMinds.Models;
using System;
namespace Kmb.HungryMinds.Core
{
    public interface IRepository<TModel>
     where TModel : IdentifiedModel
    {
        TModel Add(TModel item);
        TModel Get(int id);
        System.Collections.Generic.IEnumerable<TModel> GetAll();
        void Remove(int id);
        void Update(TModel item);
    }
}

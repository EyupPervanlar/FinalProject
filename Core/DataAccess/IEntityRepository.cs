
using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Core.DataAccess
{
    //generic Constraint.
    //class: referans tipi.
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new (): new'lenebilir olmalı yani burda IEntity doğrudan iptal ettik sadece implemente edilen dallarını alabilir.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
   
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}

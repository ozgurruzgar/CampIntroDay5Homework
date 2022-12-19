using System;
using System.Collections.Generic;
using System.Text;

namespace CampIntroDay5Homework.Abstract
{
    public interface IBaseService<T> where T: IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}

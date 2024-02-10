using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public interface ICrudController<T> where T : class
    {
        void Add(T item);
        void Update(int index);
        void Delete(int index);
    }
}

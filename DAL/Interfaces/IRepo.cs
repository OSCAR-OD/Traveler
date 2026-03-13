using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IRepo<Type, ID, RET>
    {
        RET Create(Type obj);
        List<Type> Read();
        Type Read(ID id);
        RET Update(Type obj);
        bool Delete(ID id);
        object Read(int id);
        object ReadWhere(Func<object, bool> value);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGuardable
    {
        object Select();
        void Update();
        void Update(object o);
        void Update(int id);
        void Create(object o);
        void Delete(object o);
        void Delete(int id);
    }
}

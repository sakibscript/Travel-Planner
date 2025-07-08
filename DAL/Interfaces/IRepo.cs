using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS, ID, RET>
    {
        RET Add(CLASS obj);
        RET Edit(CLASS obj);
        CLASS View(ID id);
        List<CLASS> View();
        bool Delete(ID id);
    }
}

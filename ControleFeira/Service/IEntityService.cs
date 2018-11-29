using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeira.ViewModels
{
    interface IEntityService<T>
    {
        void saveItem(T item);
        List<T> getAll();
        T getItemById(int id);
        void deleteItem(T item);

    }
}

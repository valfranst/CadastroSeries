using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series.Interfaces
{
    public interface IRepositorio<T>
    {

        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T objeto);
        void Excluir(int id);
        void Atualizar(int id, T objeto);
        int ProximoId();



    }
}

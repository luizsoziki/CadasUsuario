using Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class BaseRepository<T>
    {
        protected CadastroContext Context { get; set; }

        public BaseRepository(CadastroContext context)
        {
            this.Context = context;
        }
    }
}

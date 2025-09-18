using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3.Models
{
    public interface IImportable
    {
        bool Importar(string xml);
    }
}

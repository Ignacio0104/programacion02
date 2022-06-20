using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface IBackup
    {
        public void LoadBackup(string path);
        public void SaveBackup(string path);
    }
}

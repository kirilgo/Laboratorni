using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Monitor
    {
        public string Model;
        public int Rozshireniavert;
        public int Rozshireniagoriz;
        public int Iaskravist;
        public int Cina;

        public Monitor(string _model, int _rozshireniavert, int _rozshireniagoriz, int _iaskravist, int _cina)
        {
            Model = _model;
            Rozshireniavert = _rozshireniavert;
            Rozshireniagoriz = _rozshireniagoriz;
            Iaskravist = _iaskravist;
            Cina = _cina;
        }
    }
}

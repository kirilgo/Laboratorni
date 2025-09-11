using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Monitor
    {
        private string Model;
        public int Rozshireniavert;
        public int Rozshireniagoriz;
        public int Iaskravist;
        private int Cina;
        private bool valid = true;
        public Monitor(string _model, int _rozshireniavert, int _rozshireniagoriz, int _iaskravist, int _cina)
        {
            SetModel(_model);
            Rozshireniavert = _rozshireniavert;
            Rozshireniagoriz = _rozshireniagoriz;
            Iaskravist = _iaskravist;
            SetCina(_cina);
        }

        public void SetModel(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                Model = value;
                valid = true;
            }
            else
            {
                Model = "Невідома модель";
                valid = false;
            }
        }
        public string GetModel()
        {
            return Model;
        }

        public void SetCina(int value)
        {
            if (value >= 0)
            {
                Cina = value;
                valid = true;
            }
            else
            {
                Cina = 0;
                valid = false;
            }
        }
        public string GetCina()
        {
            return valid ? $"{Cina} грн" : "Ціна не може бути від’ємною!";
        }
        public override string ToString()
        {
            return $"Модель: {GetModel()}\n" +
                    $"Розширення по вертикалі: {Rozshireniagoriz}\n" +
                    $"Розширення по горизонталі: {Rozshireniavert}\n" +
                    $"Яскравість: {Iaskravist} nit\n" +
                    $"Ціна: {GetCina()} \n";
        }
    }
}



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
        private int Rozshireniavert;
        private int Rozshireniagoriz;
        private int Iaskravist;
        private int Cina;

        public Monitor()
        {
            Model = "Невідома модель";
            Rozshireniavert = 1080;
            Rozshireniagoriz = 1920;
            Iaskravist = 250;
            Cina = 5000;
        }

        public Monitor(string model, int rozshireniavert, int rozshireniagoriz)
        {
            Model = string.IsNullOrEmpty(model) ? "Невідома модель" : model;
            Rozshireniavert = rozshireniavert;
            Rozshireniagoriz = rozshireniagoriz;
            Iaskravist = 250;  
            Cina = 5000;       
        }

        public Monitor(string model, int rozshireniavert, int rozshireniagoriz, int iaskravist, int cina)
        {
            Model = string.IsNullOrEmpty(model) ? "Невідома модель" : model;
            Rozshireniavert = rozshireniavert;
            Rozshireniagoriz = rozshireniagoriz;
            Iaskravist = iaskravist;
            Cina = cina;
        }

        public void Init(string model, int rozshireniavert, int rozshireniagoriz, int iaskravist, int cina)
        {
            Monitor temp = new Monitor(model, rozshireniavert, rozshireniagoriz, iaskravist, cina);
            this.Model = temp.Model;
            this.Rozshireniavert = temp.Rozshireniavert;
            this.Rozshireniagoriz = temp.Rozshireniagoriz;
            this.Iaskravist = temp.Iaskravist;
            this.Cina = temp.Cina;
        }

        public override string ToString()
        {
            return $"Модель: {Model}\n" +
                   $"Розширення по вертикалі: {Rozshireniavert}\n" +
                   $"Розширення по горизонталі: {Rozshireniagoriz}\n" +
                   $"Яскравість: {Iaskravist} nit\n" +
                   $"Ціна: {(Cina >= 0 ? $"{Cina} грн" : "Ціна не може бути від’ємною!")}\n";
        }
    }
}
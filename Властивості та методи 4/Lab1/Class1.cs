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
        private int Cina;
        private int Rozshireniavert;
        private int Rozshireniagoriz;
        private int Iaskravist;
        public string ModelProp
        {
            get { return Model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Model = "Samsung";
                else
                    Model = value;
            }
        }

        public int CinaProp
        {
            get { return Cina; }
            set
            {
                if (value <= 0)
                    Cina = 5000;
                else
                    Cina = value;
            }
        }
        public string Kolir { get; set; }
        public string Vyrobnyk { get; set; }
        public string Format
        {
            get { return Rozshireniagoriz + "x" + Rozshireniavert; }
        }
        public Monitor()
        {
            ModelProp = "Невідома модель";
            Rozshireniavert = 1080;
            Rozshireniagoriz = 1920;
            Iaskravist = 250;
            CinaProp = 5000;
            Kolir = "Чорний";
            Vyrobnyk = "Невідомо";
        }
        public Monitor(string model, int rozshireniavert, int rozshireniagoriz, int iaskravist, int cina)
        {
            ModelProp = model;
            Rozshireniavert = rozshireniavert;
            Rozshireniagoriz = rozshireniagoriz;
            Iaskravist = iaskravist;
            CinaProp = cina;
            Kolir = "Чорний";
            Vyrobnyk = "Невідомо";
        }
        public void ZminytyCinu(int novaCina)
        {
            CinaProp = novaCina;
        }

        public void ZminytyModel(ref string novaModel)
        {
            ModelProp = novaModel;
        }
        public override string ToString()
        {
            return $"Модель: {ModelProp}\n" +
                   $"Розширення по вертикалі: {Rozshireniavert}\n" +
                   $"Розширення по горизонталі: {Rozshireniagoriz}\n" +
                   $"Яскравість: {Iaskravist} nit\n" +
                   $"Ціна: {CinaProp} грн\n" +
                   $"Колір: {Kolir}\n" +
                   $"Де зроблено: {Vyrobnyk}\n" +
                   $"Формат: {Format}\n";
        }
    }
}

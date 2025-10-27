using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    [Serializable]
    public class Monitor : IComparable<Monitor>
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

        public int CompareTo(Monitor other)
        {
            if (other == null) return 1;
            return this.CinaProp.CompareTo(other.CinaProp);
        }

        public override string ToString()
        {
            return $"Модель: {ModelProp} " +
                   $"Вертикаль: {Rozshireniavert} " +
                   $"Горизонталь: {Rozshireniagoriz} " +
                   $"Яскравість: {Iaskravist} " +
                   $"Ціна: {CinaProp} грн " +
                   $"Колір: {Kolir} " +
                   $"Країна виробництва: {Vyrobnyk} " +
                   $"Формат: {Format}";
        }
    }
}
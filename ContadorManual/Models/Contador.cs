using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorManual.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int contar;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Cantidad
        {
            get { return contar; }
            set
            {
                if (value != contar)
                {
                    contar = value;
                    OnPropertyChanged(nameof(Cantidad));
                }
            }
        }

        public Contador()
        {
            Cantidad = 0;

        }

        public void Contar(int d)
        {
            Cantidad = Cantidad + d;
        }

        public void Reiniciar()
        {
            Cantidad = 0; 
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataGridAndMvvm01.Models
{
        public class Car : INotifyPropertyChanged
        {
            private int _price;
            public string Name { get; set; }
            //Свойство, которое будет уведомлять о своём изменении:
            public int Price
            {
                get { return _price; }
                set
                {
                    if (_price != value)
                    {
                        _price = value;
                        OnPropertyChanged("Price");
                    }
                }
            }
            //Реализация интерфейса INotifyPropertyChanged
            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
}

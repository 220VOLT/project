using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DataGridAndMvvm01.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace DataGridAndMvvm01.ViewModel
{
    class ViewModel
    {
        public ICommand ClickCommandEditSelectedObject { get; set; }
        public int SelectedIndex { get; set; }
        public ICommand ClickCommandEditFirstObject { get; set; }
        public ObservableCollection<Car> Cars { get; set; }
        public string NewName { get; set; }
        public int NewPrice { get; set; }
        public ICommand ClickCommand { get; set; }
        public ViewModel()
        {
            ClickCommandEditSelectedObject = new RelayCommand(arg => ClickMethodEditSelectedObject());
            //ClickCommandEditFirstObject = new RelayCommand(arg => ClickMethodEditFirstObject());
            Cars = new ObservableCollection<Car>()
            {
                new Car {Name = "Honda", Price= 30000},
                new Car {Name = "Ford", Price= 15000},
                new Car {Name = "Lada", Price= 5000}
            };
            ClickCommand = new RelayCommand(arg => ClickMethod());
        }

        private void ClickMethod()
        {
            Cars.Add(new Car() { Name = NewName, Price = NewPrice });
        }
        private void ClickMethodEditFirstObject()
        {
            Cars.First().Price *= 2;
        }
   
        //И создаём метод-обработчик:
        private void ClickMethodEditSelectedObject()
        {
            if (SelectedIndex != -1)
            {
                Cars[SelectedIndex].Price *= 2;
            }
        }
    }
}

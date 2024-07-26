using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13E31925597.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string punto1x;
        [ObservableProperty]
        private string punto1y;
        [ObservableProperty]
        private string punto2x;
        [ObservableProperty]
        private string punto2y;
        [ObservableProperty]
        private string distancia;

        [RelayCommand]
        private void CalcularDistancia()
        {
            if (double.TryParse(Punto1x, out double p1x) && double.TryParse(Punto1y, out double p1y) && 
                double.TryParse(Punto2x, out double p2x) && double.TryParse(Punto2y, out double p2y))
            {
                double restaX = p1x - p2x, restaY = p1y - p2y;
                double potencias = Math.Pow(restaX, 2) + Math.Pow(restaY, 2);
                Distancia = "La distancia es : " + Math.Sqrt(potencias);
            }
            else
            {
                Distancia = "Ingrese datos numéricos";
            }
        }
    }
}

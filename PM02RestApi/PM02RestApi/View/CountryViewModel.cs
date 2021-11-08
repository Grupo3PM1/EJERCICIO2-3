using PM02RestApi.Controllers;
using PM02RestApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PM02RestApi.View
{
     /*public class CountryViewModel : ViewModel
    {
        private bool isLoading;

        public bool IsLoading
        {
            get { return isLoading; }

            set { isLoading = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Countries> banderas;

        public ObservableCollection<Countries> Banderas
        {
            get { return banderas; }
            set { banderas = value; OnPropertyChanged(); }
        }

        public async Task LoadCountries()

        {
            IsLoading = true;
            var banderas = await CountriesControllers.GetCountries(); Banderas = new ObservableCollection<Countries>(banderas);
            IsLoading = false;
        }
        }*/
}

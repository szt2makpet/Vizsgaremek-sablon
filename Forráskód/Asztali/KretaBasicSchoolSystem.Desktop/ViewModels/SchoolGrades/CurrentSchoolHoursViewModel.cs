using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Flyhigh.Desktop.Models;
using Flyhigh.Desktop.Service;
using Flyhigh.Desktop.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Flyhigh.Desktop.ViewModels.SchoolGrades
{
    public partial class CurrentSchoolHoursViewModel : BaseViewModelWithAsyncInitialization
    {
        private readonly IGepService? _gepService;


        [ObservableProperty]
        private ObservableCollection<GepAdatok> _gepek = new ObservableCollection<GepAdatok>();

        [ObservableProperty]
        private GepAdatok _selectedGepek;


        public CurrentSchoolHoursViewModel()
        {
            SelectedGepek = new GepAdatok();
        }

        public CurrentSchoolHoursViewModel(IGepService? gepSer)
        {
            SelectedGepek = new GepAdatok();

            _gepService = gepSer;
        }

        [RelayCommand]
        void DoNewStudent()
        {
            SelectedGepek = new GepAdatok();
        }

        public override async Task InitializeAsync()
        {
            if (_gepService is not null)
            {
                List<GepAdatok> GepekS = await _gepService.SelectAllGep();
                Gepek = new ObservableCollection<GepAdatok>(GepekS);
            }
        }



    }
}

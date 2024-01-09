using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using Flyhigh.Desktop.ViewModels.Base;
using Flyhigh.Desktop.ViewModels.ControlPanel;
using Flyhigh.Desktop.ViewModels.SchoolCitizens;
using Flyhigh.Desktop.ViewModels.SchoolSubjects;
using Flyhigh.Desktop.ViewModels.SchoolGrades;

namespace Flyhigh.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;
        private SchoolSubjectsViewModel _schoolSubjectsViewModel;
        private SchoolGradeViewModel _schoolGradeViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
            _schoolSubjectsViewModel = new SchoolSubjectsViewModel();
            _schoolGradeViewModel = new SchoolGradeViewModel();

        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            SchoolCitizensViewModel schoolCitizensViewModel,
            SchoolSubjectsViewModel schoolSubjectsViewModel,
            SchoolGradeViewModel schoolGradeViewModel
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _schoolSubjectsViewModel = schoolSubjectsViewModel;
            _schoolGradeViewModel = schoolGradeViewModel;


            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Kezdőlap";
            Icon=IconChar.Home;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Felhasználók";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolCitizensViewModel;
        }

        [RelayCommand]
        public void ShowSchoolClasses()
        {
            Caption = "Légijáratok";
            Icon = IconChar.Plane;
            CurrentChildView = _schoolGradeViewModel; ;
        }

        [RelayCommand]
        public void ShowSchoolSubjects()
        {
            Caption = "Jegykezelés";
            Icon = IconChar.Ticket;
            CurrentChildView = _schoolSubjectsViewModel;
        }
    }
}

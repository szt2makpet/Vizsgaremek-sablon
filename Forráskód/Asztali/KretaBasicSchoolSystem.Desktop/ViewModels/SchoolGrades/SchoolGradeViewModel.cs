using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Flyhigh.Desktop.Service;
using Flyhigh.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace Flyhigh.Desktop.ViewModels.SchoolGrades
{
    public partial class SchoolGradeViewModel : BaseViewModel
    {
        private CurrentSchoolHoursViewModel _currentSchoolHoursViewModel;
        private TaughtClassesViewModel _taughtClassesViewModel;
        private ClosingSemesterGradeViewModel _closingSemesterGradeViewModel;

        public SchoolGradeViewModel()
        {
            IGepService gepekService = new GepService(null);
            _currentSchoolHoursViewModel = new CurrentSchoolHoursViewModel(gepekService);
            _taughtClassesViewModel = new TaughtClassesViewModel();
            _closingSemesterGradeViewModel = new ClosingSemesterGradeViewModel();

            CurrentChildViewModel = new ClosingSemesterGradeViewModel();
        }

        public SchoolGradeViewModel(
            CurrentSchoolHoursViewModel currentSchoolHoursViewModel,
            TaughtClassesViewModel taughtClassesViewModel,
            ClosingSemesterGradeViewModel closingSemesterGradeViewModel)
        {
            _currentSchoolHoursViewModel = currentSchoolHoursViewModel;
            _taughtClassesViewModel = taughtClassesViewModel;
            _closingSemesterGradeViewModel = closingSemesterGradeViewModel;

            CurrentChildViewModel = new ClosingSemesterGradeViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentChildViewModel;

        [RelayCommand]
        public async Task ShowCurrentSchoolHours()
        {
            await _currentSchoolHoursViewModel.InitializeAsync();
            CurrentChildViewModel = _currentSchoolHoursViewModel;
        }

        [RelayCommand]
        public void ShowTaughtClasses()
        {
            CurrentChildViewModel = _taughtClassesViewModel;
        }

        [RelayCommand]
        public void ShowClosingSemesterGrade()
        {
            CurrentChildViewModel = _closingSemesterGradeViewModel;
        }

    }
}

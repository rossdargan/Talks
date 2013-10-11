using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using Facts.Domain.Entities;
using Facts.Domain.Service;

namespace Facts.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private readonly IFactService _factService;

        public FirstViewModel(Facts.Domain.Service.IFactService factService)
        {
            _factService = factService;
            NextFactCommand = new MvxCommand(NextFactEvent);
            NextFactEvent();
        }

        private async void NextFactEvent()
        {
            var selectedFact = await _factService.GetRandomFact();
            string fact = selectedFact.TheFact;
            Fact = fact;
        }

        private string _fact = "Loading...";
        public string Fact
		{ 
			get { return _fact; }
            set
            {
                _fact = value;
                RaisePropertyChanged("Fact");
            }
		}

        public ICommand NextFactCommand
        {
            get;
            private set;
        }
    }
}

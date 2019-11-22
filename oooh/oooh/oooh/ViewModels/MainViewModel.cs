using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace oooh.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        private string _valor;
        public string Valor
        {
            get { return _valor; }
            set { SetProperty(ref _valor, value); }
        }

        private ICommand _pesquisaCommand;
        public ICommand PesquisaCommand
        {
            get
            {
                return _pesquisaCommand ?? (_pesquisaCommand = new Command(() =>
                {

                    //Aqui vai o que voce quer fazer com a pesquisa
                }));
            }
        }
    }
}

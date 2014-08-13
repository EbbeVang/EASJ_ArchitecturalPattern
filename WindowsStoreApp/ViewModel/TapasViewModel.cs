using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WindowsStoreApp.Annotations;
using WindowsStoreApp.TapasServiceReference;

namespace WindowsStoreApp.ViewModel
{
    class TapasViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<Tapas> _tapasViewListe;

        public ObservableCollection<Tapas> TapasViewListe
        {
            get { return _tapasViewListe; }
            set
            {
                _tapasViewListe = value;
                OnPropertyChanged("TapasViewListe");
            }
        }

        public TapasViewModel()
        {
            TapasServiceClient tapasDataClient = new TapasServiceClient();

            Task<ObservableCollection<Tapas>> allTapasAsync = tapasDataClient.GetAllTapasAsync();
            allTapasAsync.Wait();

            _tapasViewListe = new ObservableCollection<Tapas>(allTapasAsync.Result);
        }




        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}

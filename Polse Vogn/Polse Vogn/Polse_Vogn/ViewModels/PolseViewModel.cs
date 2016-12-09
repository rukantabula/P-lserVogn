using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Polse_Vogn.Models;
using Polse_Vogn.Services;

namespace Polse_Vogn.ViewModels
{
   public class PolseViewModel : INotifyPropertyChanged
    {
        private List<Advert> _advertList;
        //private Advert _companyName;
        private Advert _phoneNumbers;
        private Advert _address;
        private Advert _location;
        private Advert _infoPageLink;

        public List<Advert> AdvertList

        {
            get { return _advertList; }
            set
            {
                _advertList = value; 
                OnPropertyChanged();
            }
        }

        //public Advert companyName
        //{
        //    get { return _companyName; }
        //    set
        //    {
        //        _companyName = value; 
        //        OnPropertyChanged();
        //    }
        //}


        public Advert phoneNumbers
        {
            get { return _phoneNumbers; }
            set
            {
                _phoneNumbers = value; 
                OnPropertyChanged();
            }
        }

        public Advert address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }

        public Advert location
        {
            get { return _location; }
            set
            {
                _location = value; 
                OnPropertyChanged();
            }
        }

        public Advert infoPageLink
        {
            get { return _infoPageLink; }
            set
            {
                _infoPageLink = value;
                OnPropertyChanged();
            }
        }


        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }
        public PolseViewModel()
        {
            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                var polseServices = new PolseServices();

                AdvertList = await polseServices.GetPolseAsync();

            }

            catch (Exception ex)
            {
              
            }
            finally
            {
                IsBusy = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Polse_Vogn.Models;
using Polse_Vogn.Services;

namespace Polse_Vogn.VieModels
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


        private async Task InitializeDataAsync()
        {
            var employeesServices = new PolseServices();

            AdvertList = await employeesServices.GetPolseAsync();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}

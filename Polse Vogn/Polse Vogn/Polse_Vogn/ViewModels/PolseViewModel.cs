using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Polse_Vogn.Models;
using Polse_Vogn.NewResrClient;
using System.Net.Http;
using Android.Util;
using Newtonsoft.Json;
using Plugin.RestClient;
using Newtonsoft.Json.Linq;

namespace Polse_Vogn.ViewModels
{
    public class PolseViewModel : INotifyPropertyChanged
    {
        private List<Advert> _advert;
        //private Advert _companyName;
        private Advert _phoneNumbers;
        private Advert _address;
        private Advert _location;
        private Advert _infoPageLink;

        public List<Advert> Advert

        {
            get { return _advert; }
            set
            {
                _advert = value;
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
        private string _example;

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        public string example
        {
            get
            {
                string k = "hey";
                return k;

            }
            set
            {
                _example = value;
                OnPropertyChanged();
            }
        }

        public PolseViewModel()
        {
            Init();
        }


        private async void Init()
        {

            this.Advert = await GetAsync();
        }

        
                //var polseServices = new NewRestClient<PolseModel>();

                //AdvertList = await polseServices.GetAsync();

            


        private const string WebServiceUrl = "https://api.eniro.com/cs/proximity/basic?profile=rukantabula&key=9010769844804077008&country=dk&version=1.1.3&search_word=p%C3%B8lse&to_list=60&latitude=56.162939&longitude=10.203921000000037&max_distance=1000/";
        public async Task<List<Advert>> GetAsync()
        {
            HttpClient client = new HttpClient();
           // client.MaxResponseContentBufferSize = 256000;
            var uri = new Uri(string.Format(WebServiceUrl, string.Empty));

            var response = await client.GetAsync(uri).ConfigureAwait(false);

            //if (response.IsSuccessStatusCode)
            //{
            var content = await response.Content.ReadAsStringAsync();
            var jsonObj = JObject.Parse(content);
            var listTest = JsonConvert.DeserializeObject<List<Advert>>(jsonObj["adverts"].ToString());
            return JsonConvert.DeserializeObject<List<Advert>>(jsonObj["adverts"].ToString());
            //public async Task<List<PolseListModel>> GetAsync()
            //{
            //    HttpClient client = new HttpClient();
            //    client.MaxResponseContentBufferSize = 256000;
            //    var uri = new Uri(string.Format(WebServiceUrl, string.Empty));

            //    var response = await client.GetAsync(uri).ConfigureAwait(false);

            //    //if (response.IsSuccessStatusCode)
            //    //{
            //    var content = await response.Content.ReadAsStringAsync();
            //        return JsonConvert.DeserializeObject<List<PolseListModel>>(content);

            //return taskModels;

            //}
            //Task<List<PolseModel>> restClient = new Task<List<PolseModel>>;

            //var advertList1 = await restClient.GetAsync();
            //return advertList1;



        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}

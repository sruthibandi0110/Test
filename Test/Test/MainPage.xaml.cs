using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test
{
    public partial class MainPage : ContentPage
    {
        #region Collections
        //List for user data
        public List<Datum> userDataList = new List<Datum>();

        #endregion
        public MainPage()
        {
            InitializeComponent();
            //API call to get the user data
            FetchData();
        }
        #region Methods
        public async void FetchData()
        {
            //Assigning the fetched data to list
            var result = await GetUsers();
            userDataList = new List<Datum>(result.data);
            ListofUsers.ItemsSource = userDataList;
        }
        //Method with call to http client using request provider class and th url provided
        public async Task<UsersModel> GetUsers()
        {
            var _reqProvider = new RequestProvider();
            var builder = new UriBuilder("https://cila-test-api.herokuapp.com/v1/users");
            var uri = builder.ToString();
            var result = await _reqProvider.GetAsync<UsersModel>(uri);
            return result;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhaTrangIzi.ViewModel;
using Xamarin.Forms;

namespace NhaTrangIzi.View
{
    public partial class MainPage : TabbedPage
    {
        MainPageViewModel mainPageViewModel;
        public MainPage()
        {
            mainPageViewModel = new MainPageViewModel();
            var listTabsName = mainPageViewModel.GetListTabs();
            InitializeComponent();
            for (int i = 0; i < listTabsName.Count; i++)
            {
                this.Children.Add(new ItemListPage(listTabsName[i]));
            }
        }
    }
}

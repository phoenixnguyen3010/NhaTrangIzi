using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhaTrangIzi.ViewModel;
using Xamarin.Forms;

namespace NhaTrangIzi.View
{
    public partial class ItemListPage : ContentPage
    {
        public ItemListPage(string title)
        {
            InitializeComponent();
            Title = title;
            BindingContext = new ItemListPageViewModel();
        }
    }
}

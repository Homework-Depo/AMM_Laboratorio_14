using Laboratorio14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductInsert : ContentPage
	{
        public ProductInsert ()
		{
			InitializeComponent ();
			this.BindingContext = new ViewModelProducts();
		}
	}
}


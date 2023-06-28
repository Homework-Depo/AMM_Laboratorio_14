using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Laboratorio14.ViewModels
{
	public class ViewModelProducts: BaseViewModel
	{
        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Product> products;
		public List<Product> Products
		{
			get { return this.products; }
			set { SetValue(ref this.products, value); }
		}

		public ICommand SearchCommand { get; set; }
		public ICommand CreateCommand { get; set; }

		public ViewModelProducts()
		{
			SearchCommand = new Command(() =>
			{
				ProductService service = new ProductService();
				Products = service.GetByText(Filter);
			});

			CreateCommand = new Command(() =>
			{
				ProductService service = new ProductService();
				//service.Create();
			});
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Contracts;
using Client.Sales.Proxies;
using Microsoft.Practices.Prism.Mvvm;

namespace Desktop.ViewModels
{
    public class MainViewViewModel:BindableBase
    {
        public MainViewViewModel()
        {
            SalesClient proxy = new SalesClient();
            var a = proxy.GetProducts();
        }

        private string _content = "My content";

        public string Content
        {
            get { return _content; }
            set { SetProperty<string>(ref _content,value); }
        }
    }
}

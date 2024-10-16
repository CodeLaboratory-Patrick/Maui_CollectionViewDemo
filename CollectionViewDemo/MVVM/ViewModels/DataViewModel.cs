using CollectionViewDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo.MVVM.ViewModels
{
    public class DataViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public DataViewModel()
        {

        }
    }
}

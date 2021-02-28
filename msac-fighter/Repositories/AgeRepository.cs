using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msac_fighter.Models;

namespace msac_fighter.Repositories
{
    public class AgeRepository
    {
        private ObservableCollection<Ages> ages;

        public AgeRepository()
        {
            ages = new ObservableCollection<Ages>
            {
                new Ages {Id=1, Age = "39+"},
                new Ages {Id=2, Age= "18-39" },
                new Ages {Id=3, Age="16-17" },
                new Ages {Id=4, Age="14-15" },
                new Ages {Id=5, Age="12-13" },
                new Ages {Id=6, Age="10-11" },
                new Ages {Id=7, Age="8-9" },
                new Ages {Id=8, Age="6-7" }
            };
        }
        public ObservableCollection<Ages> GetAges()
        {
            return ages;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msac_fighter.Models;

namespace msac_fighter.Repositories
{
    public class WeighRepository
    {
        private ObservableCollection<Weigh> weigh;

        public WeighRepository()
        {
            weigh = new ObservableCollection<Weigh>
            {
                new Weigh {Id=1, WeighCategory= "24" },
                new Weigh {Id=2, WeighCategory= "26"},
                new Weigh {Id=3, WeighCategory= "28" },
                new Weigh {Id=3, WeighCategory="30" },
                new Weigh {Id=3, WeighCategory="35" },
                new Weigh {Id=3, WeighCategory="40" },
                new Weigh {Id=3, WeighCategory="45" },
                new Weigh {Id=3, WeighCategory="50" },
                new Weigh {Id=3, WeighCategory="55" },
                new Weigh {Id=3, WeighCategory="60" },
                new Weigh {Id=3, WeighCategory="65" },
                new Weigh {Id=3, WeighCategory="70" },
                new Weigh {Id=4, WeighCategory="75" },
                new Weigh {Id=4, WeighCategory="80" },
                new Weigh {Id=4, WeighCategory="85" },
                new Weigh {Id=4, WeighCategory="90" },
                new Weigh {Id=4, WeighCategory="95" },
                new Weigh {Id=4, WeighCategory="100" }
            };
        }
        public ObservableCollection<Weigh> GetWeigh()
        {
            return weigh;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSeries.Trakt
{
    public interface ITraktIntegration
    {
        Task<object> SearchShow(string title);
    }
}

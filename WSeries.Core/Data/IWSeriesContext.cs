using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSeries.Core.Model;

namespace WSeries.Core.Data
{
    public interface IWSeriesContext
    {
        Task<List<Show>> SearchShowsAsync(string title);
    }
}

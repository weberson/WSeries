using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WSeries.Core.Data;
using WSeries.Core.Model;

namespace WSeries.Controllers
{
    public class ShowsController : ApiController
    {
        private IWSeriesContext _wSeriesContext;

        public ShowsController()
        {
            _wSeriesContext = new WSeriesContext();    
        }

        public IQueryable<Show> GetShows()
        {
            return _wSeriesContext.SearchShowsAsync("The Big Bang Theory").Result.AsQueryable();
        }
    }
}

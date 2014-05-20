using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WSeries.Core.Model;
using WSeries.Trakt;

namespace WSeries.Core.Data
{
    public class WSeriesContext : IWSeriesContext
    {
        public async Task<List<Show>> SearchShowsAsync(string title)
        {
            var trakt = new TraktIntegration();
            var result = await trakt.SearchShow(title);
            List<Show> shows = JsonConvert.DeserializeObject<List<Show>>((string)result);

            return shows;
        }

        //public IQueryable<Show> Shows
        //{
        //    get
        //    {
        //        return new List<Show>() 
        //        { 
        //            new Show()
        //            {
        //                Title =  "The Big Bang Theory",
        //                Year = 2007,
        //                Url =  "http://trakt.tv/show/the-big-bang-theory",
        //                First_Aired = "1190617200",
        //                Country =  "United States",
        //                Overview =  "What happens when hyperintelligent roommates Sheldon and Leonard meet Penny, a free-spirited beauty moving in next door, and realize they know next to nothing about life outside of the lab. Rounding out the crew are the smarmy Wolowitz, who thinks he's as sexy as he is brainy, and Koothrappali, who suffers from an inability to speak in the presence of a woman.",
        //                Runtime =  20,
        //                Network =  "CBS",
        //                Air_Day =  "Thursday",
        //                Air_Time =  "8:00pm",
        //                Certification =  "TV-PG",
        //                Imdb_ID =  "tt0898266",
        //                TvDb_ID = 80379,
        //                Tvrage_ID =  8511,
        //                Ended =  false,
        //                Images = new Image {
        //                    Poster =  "http://slurm.trakt.us/images/posters/34.68.jpg",
        //                    Fanart =  "http://slurm.trakt.us/images/fanart/34.68.jpg",
        //                    Banner = "http://slurm.trakt.us/images/banners/34.68.jpg"
        //                },
        //                Ratings = new Ratings {
        //                    Percentage =  88,
        //                    Votes =  20260,
        //                    Loved =  18943,
        //                    Hated =  1317
        //                },
        //                Genres = new List<string>() { "Comedy" }
        //            }
        //        }.AsQueryable();
        //    }
        //}
    }
}

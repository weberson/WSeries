using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSeries.Core.Model
{
    public class Show
    {
        public string Title { get; set; }
        
        public int Year { get; set; }

        public string Url { get; set; }

        public string First_Aired { get; set; }

        public string Country { get; set; }

        public string Overview { get; set; }

        public int Runtime { get; set; }

        public string Network { get; set; }

        public string Air_Day { get; set; }

        public string Air_Time { get; set; }

        public string Certification { get; set; }

        public string Imdb_ID { get; set; }

        public int TvDb_ID { get; set; }

        public int Tvrage_ID { get; set; }

        public bool Ended { get; set; }

        public Image Images { get; set; }

        public Ratings Ratings { get; set; }

        public List<string> Genres { get; set; }
    }
}

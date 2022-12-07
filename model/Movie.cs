using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanCustomListFlyoutPanel.model
{
    public class Movie
    {

        public double popularity { get; set; }

        public int vote_count { get; set; }

        public bool  video { get; set; }

        public string poster_path { get; set; }

        public int id { get; set; }

        public bool adult { get; set; }

        public string backdrop_path { get; set; }

        public string original_language { get; set; }

        public string original_title { get; set; }

        public string title { get; set; }

        public double vote_average { get; set; }

        public string overview { get; set; }

        public DateTime release_date { get; set; }
    }
}

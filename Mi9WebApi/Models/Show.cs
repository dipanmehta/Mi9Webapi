using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mi9Project.Models
{
    public class Show
    {

        public Show()
        {

        }
        public String country { get; set; }
        public String description { get; set; }
        public Boolean drm { get; set; }

        public int episodeCount { get; set; }
        public String genre { get; set; }

        public ShowImage image = new ShowImage();
        public String language { get; set;}

        public Episode nextEpisode = new Episode();

        public String primaryColour { get; set; }

        public List<Season> seasons = new List<Season>();

        public String slug { get; set; }
        public String title { get; set; }

        public String tvChannel { get; set; }

    }
}
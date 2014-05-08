using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mi9Project.Models.Repository
{
    public class Mi9PayloadRepository: IPayloadRepository
    {
        public List<Show> processPayload(Payload payload)
        {           
            if(payload != null)
            {
                List<Show> filterShows = (from sh in payload.payload
                                          where sh.drm == true && sh.episodeCount > 0
                                          select sh).ToList<Show>();
                return filterShows;                           
            }
            return null;
        }
    }
}
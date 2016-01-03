﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MALClient.Comm
{
    class AnimeListQuery : Query
    {
        public AnimeListQuery(AnimeListParameters args)
        {
            Request = WebRequest.Create(Uri.EscapeUriString(UriBuilder.GetUri(UriType.AnimeList, args)));
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.Method = "GET";
        }
    }
}

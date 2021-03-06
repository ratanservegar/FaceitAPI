﻿using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Championships : ApiBase, IChampionships
    {
        public Championships(IAuthorizable authorizable) : base(authorizable)
        {

        }

        public ChampionshipDetails GetChampionship(string championship_id)
        {
            return Get<ChampionshipDetails>($"https://open.faceit.com/data/v4/championships/{championship_id}?expanded=organizer,game");
        }

        public Paging<Match> GetMatches(string championship_id, string type = "all", int offset = 0, int limit = 20)
        {
            return Get<Paging<Match>>($"https://open.faceit.com/data/v4/championships/{championship_id}/matches?type={type}&offset={0}&limit={limit}");
        }

        public Paging<ChampionshipSubscription> GetSubscriptions(string championship_id, int offset = 0, int limit = 10)
        {
            return Get<Paging<ChampionshipSubscription>>($"https://open.faceit.com/data/v4/championships/{championship_id}/subscriptions?offset={offset}&limit={limit}");
        }
    }
}

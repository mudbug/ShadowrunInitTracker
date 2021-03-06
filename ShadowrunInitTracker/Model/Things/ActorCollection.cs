﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ShadowrunInitTracker.Model
{
    [Serializable]
    public class ActorCollection : ObservableCollection<Actor>
    {
        public IEnumerable<Actor> GetActorsForPass(int pass)
        {
            return this.Where((a) => a.TurnInitiativePasses >= pass && !a.Delaying);
        }
    }
}

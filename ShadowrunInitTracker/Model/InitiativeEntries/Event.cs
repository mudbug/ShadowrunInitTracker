﻿using System.ComponentModel;

namespace ShadowrunInitTracker.Model
{
    public class Event : InitiativeEntry, INotifyPropertyChanged
    {
        string description;
        public string Description { get { return description; } set { description = value; NotifyPropertyChanged("Description"); } }

        int turn;
        public int Turn { get { return turn; } set { turn = value; NotifyPropertyChanged("Turn"); } }

        int pass;
        public int Pass { get { return pass; } set { pass = value; NotifyPropertyChanged("Pass"); } }

        int phase;
        public int Phase
        {
            get { return phase; }
            set
            {
                phase = value;
                NotifyPropertyChanged("Phase");
                NotifyPropertyChanged("CurrentInitiativePhase");
            }
        }

        public int CurrentInitiativePhase
        {
            get
            {
                return Phase;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

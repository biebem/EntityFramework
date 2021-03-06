﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Data
{
    class Strip
    {
        public int StripID { get; set; }
        public int Nr { get; set; }
        public string Titel { get; set; }
        public Uitgeverij Uitgever { get; set; }
        public Reeks Reeks { get; set; }
        public ICollection<AuteurStrip> AuteursLink { get; set; } = new List<AuteurStrip>();

        public Strip(int nr, string titel)
        {
            Nr = nr;
            Titel = titel;
        }

        public Strip(int nr, string titel, Uitgeverij uitgever, Reeks reeks) : this(nr, titel)
        {
            Uitgever = uitgever;
            Reeks = reeks;
        }

        public void VoegAuteurToe(Auteur auteur) 
        {
            AuteursLink.Add(new AuteurStrip(auteur, this));
        }
    }
}

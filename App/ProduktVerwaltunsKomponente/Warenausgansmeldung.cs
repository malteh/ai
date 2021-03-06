﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Anwendungskern.NullTypenKomponente;

namespace Anwendungskern
{
    namespace ProduktVerwaltungsKomponente
    {
        class Warenausgansmeldung : IWarenausgansmeldung
        {
            public virtual int Id { get; protected set; }
            public virtual DateTime Datum { get; protected set; }
            public virtual int Menge { get; protected set; }
        }

        public class WarenausgansmeldungMap : ClassMap<IWarenausgansmeldung>
        {
            public WarenausgansmeldungMap()
            {
                Id(x => x.Id);
                Id(x => x.Datum);
                Id(x => x.Menge);
            }
        }
    }
}
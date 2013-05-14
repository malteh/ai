﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _0TypenKomponente.TransportInterfaces;
using FluentNHibernate.Mapping;

namespace AuftragVerwaltungKomponente
{
    public class Angebot : IAngebot
    {
        public Angebot() { }
        public virtual Int32 Id { get; private set; }
        public virtual IDictionary<IProdukt, int> Produkte { get; set; }
        public virtual DateTime GültigAb { get; set; }
        public virtual DateTime GültigBis { get; set; }
    }

    public class AngebotMap : ClassMap<Angebot>
    {
        public AngebotMap()
        {
            Id(x => x.Id);
            // TODO: Testen !
            Map(x => x.Produkte);
            Map(x => x.GültigAb);
            Map(x => x.GültigBis);
        }
    }
}

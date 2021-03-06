﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _0TypenKomponente.NummerTypen;
using _0TypenKomponente.EnumTypen;
using _0TypenKomponente.TransportInterfaces;

namespace Transportdienstleister.Models
{
    public class TransportdienstleisterLieferung : ILieferung
    {
        public LieferungNummerTyp LieferungNr { get; private set; }
        public TransportAuftragNummerTyp AuftragNr { get; private set; }
        public DateTime Ausgangsdatum { get; private set; }
        public bool LieferungErfolgt { get; private set; }
        public DateTime Lieferdatum { get; private set; }
        public TransportDienstleister Transportdienstleister { get; private set; }

        public TransportdienstleisterLieferung(LieferungNummerTyp LieferungNr,
            TransportAuftragNummerTyp AuftragNr, DateTime Ausgangsdatum, bool LieferungErfolgt, DateTime Lieferdatum, TransportDienstleister LieferDienstLeister)
        {
            this.LieferungNr = LieferungNr;
            this.AuftragNr = AuftragNr;
            this.Ausgangsdatum = Ausgangsdatum;
            this.LieferungErfolgt = LieferungErfolgt;
            this.Lieferdatum = Lieferdatum;
            this.Transportdienstleister = Transportdienstleister;
        }
    }
}
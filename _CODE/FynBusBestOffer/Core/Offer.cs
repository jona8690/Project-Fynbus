﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
    public class Offer : IComparable
    {
        public int OfferSeqNr;
        public Route Route;
        public int PricePerHour;
        public int RoutePriority;
        public int ContractorPriority;
        public Contractor Contractor;
        public double TotalContractValue { get { return GetTotalContractValue(); } }

        private double GetTotalContractValue()
        {
            return PricePerHour;
        }

        public Offer(int offerseqnr, Route route, int priceperhour, Contractor contractor, int routepriority, int contractorpriority)
        {
            this.OfferSeqNr = offerseqnr;
            this.Route = route;
            this.PricePerHour = priceperhour;
            this.Contractor = contractor;
            this.RoutePriority = routepriority;
            this.ContractorPriority = contractorpriority;
        }
        public override bool Equals(object obj)
        {
            bool result = false;
            Offer offer = (Offer)obj;
            if (this.OfferSeqNr == offer.OfferSeqNr)
            {
                result = true;
            }
            return result;
        }

        public int CompareTo(object obj)
        {
            int result = 0;
            Offer offers = (Offer)obj;

            if (this.TotalContractValue < offers.TotalContractValue)
            {
                result = -1;
            }
            else if (this.TotalContractValue > offers.TotalContractValue)
            {
                result = 1;
            }
            return result;
        }

		public override string ToString() {
			StringWriter Output = new StringWriter();
			Output.WriteLine(OfferSeqNr);

			return Output.ToString();
		}
	}
}

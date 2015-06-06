using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CarsBigDataService
{
    [DataContract]
    public class UserReviewSaveResult
    {
        [DataMember]
        public string ErrorMessage { get; set; }
    }


    [DataContract]
    public class UserReview
    {
        protected bool Equals(UserReview other)
        {
            return string.Equals(Brand, other.Brand) && string.Equals(Type, other.Type) &&
                   YearOfManufacturing == other.YearOfManufacturing &&
                   AverageConsumption.Equals(other.AverageConsumption) && Comfort == other.Comfort &&
                   DrivenKms == other.DrivenKms && YearOfPurchase == other.YearOfPurchase && Garage == other.Garage &&
                   KmsWhenBought == other.KmsWhenBought && Performance == other.Performance &&
                   RunningCost == other.RunningCost && TotalImpression == other.TotalImpression &&
                   Verdict.Equals(other.Verdict) && Relyability == other.Relyability;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((UserReview) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Brand != null ? Brand.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Type != null ? Type.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ YearOfManufacturing.GetHashCode();
                hashCode = (hashCode*397) ^ AverageConsumption.GetHashCode();
                hashCode = (hashCode*397) ^ Comfort;
                hashCode = (hashCode*397) ^ DrivenKms;
                hashCode = (hashCode*397) ^ YearOfPurchase;
                hashCode = (hashCode*397) ^ Garage;
                hashCode = (hashCode*397) ^ KmsWhenBought;
                hashCode = (hashCode*397) ^ Performance;
                hashCode = (hashCode*397) ^ RunningCost;
                hashCode = (hashCode*397) ^ TotalImpression;
                hashCode = (hashCode*397) ^ Verdict.GetHashCode();
                hashCode = (hashCode*397) ^ Relyability;
                return hashCode;
            }
        }

        [DataMember]
        public string Brand
        {
            get;
            set;

        }

        [DataMember]
        public string Type
        {
            get;
            set;

        }

        [DataMember]
        public int? YearOfManufacturing
        {
            get;
            set;

        }

        [DataMember]
        public double? AverageConsumption { get; set; }

        [DataMember]
        public int Comfort { get; set; }

        [DataMember]
        public int DrivenKms { get; set; }

        [DataMember]
        public int YearOfPurchase { get; set; }

        [DataMember]
        public int Garage { get; set; }

        [DataMember]
        public int KmsWhenBought { get; set; }
        
        [DataMember]
        public int Performance { get; set; }

        [DataMember]
        public int RunningCost { get; set; }

        [DataMember]
        public int TotalImpression { get; set; }

        [DataMember]
        public double Verdict { get; set; }

        [DataMember]
        public int Relyability { get; set; }
    }
}

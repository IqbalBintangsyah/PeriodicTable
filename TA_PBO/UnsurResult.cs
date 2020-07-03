using Newtonsoft.Json;

namespace TA_PBO
{
    public class UnsurResult
    {
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "atomicmass")]
        public string AtomicMass { get; set; }
        [JsonProperty(PropertyName = "atomicnumber")]
        public string atomicNumber { get; set; }
        [JsonProperty(PropertyName = "atomicRadius")]
        public string AtomicRadius { get; set; }
        [JsonProperty(PropertyName = "bondingtype")]
        public string BondingType { get; set; }
        [JsonProperty(PropertyName = "electronaffinity")]
        public string ElectronAffinity { get; set; }
        [JsonProperty(PropertyName = "electronegativity")]
        public string ElectroNegativity { get; set; }
        [JsonProperty(PropertyName = "electronicconfiguration")]
        public string ElectronicConfiguration { get; set; }
        [JsonProperty(PropertyName = "ionizationenergy")]
        public string IonizationEnergy { get; set; }
        [JsonProperty(PropertyName = "meltingpoint")]
        public string MeltingPoint { get; set; }
        }
}

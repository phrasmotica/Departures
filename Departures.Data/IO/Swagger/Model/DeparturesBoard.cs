using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DeparturesBoard {
    /// <summary>
    /// Gets or Sets Departures
    /// </summary>
    [DataMember(Name="departures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departures")]
    public List<DepartureItem> Departures { get; set; }

    /// <summary>
    /// Gets or Sets Xmlns
    /// </summary>
    [DataMember(Name="Xmlns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Xmlns")]
    public XmlSerializerNamespaces Xmlns { get; set; }

    /// <summary>
    /// Gets or Sets GeneratedAt
    /// </summary>
    [DataMember(Name="generatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generatedAt")]
    public DateTime? GeneratedAt { get; set; }

    /// <summary>
    /// Gets or Sets LocationName
    /// </summary>
    [DataMember(Name="locationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationName")]
    public string LocationName { get; set; }

    /// <summary>
    /// Gets or Sets Crs
    /// </summary>
    [DataMember(Name="crs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crs")]
    public string Crs { get; set; }

    /// <summary>
    /// Gets or Sets FilterLocationName
    /// </summary>
    [DataMember(Name="filterLocationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterLocationName")]
    public string FilterLocationName { get; set; }

    /// <summary>
    /// Gets or Sets Filtercrs
    /// </summary>
    [DataMember(Name="filtercrs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filtercrs")]
    public string Filtercrs { get; set; }

    /// <summary>
    /// Gets or Sets FilterType
    /// </summary>
    [DataMember(Name="filterType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterType")]
    public string FilterType { get; set; }

    /// <summary>
    /// Gets or Sets NrccMessages
    /// </summary>
    [DataMember(Name="nrccMessages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nrccMessages")]
    public List<NRCCMessage> NrccMessages { get; set; }

    /// <summary>
    /// Gets or Sets PlatformAvailable
    /// </summary>
    [DataMember(Name="platformAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformAvailable")]
    public bool? PlatformAvailable { get; set; }

    /// <summary>
    /// Gets or Sets AreServicesAvailable
    /// </summary>
    [DataMember(Name="areServicesAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "areServicesAvailable")]
    public bool? AreServicesAvailable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeparturesBoard {\n");
      sb.Append("  Departures: ").Append(Departures).Append("\n");
      sb.Append("  Xmlns: ").Append(Xmlns).Append("\n");
      sb.Append("  GeneratedAt: ").Append(GeneratedAt).Append("\n");
      sb.Append("  LocationName: ").Append(LocationName).Append("\n");
      sb.Append("  Crs: ").Append(Crs).Append("\n");
      sb.Append("  FilterLocationName: ").Append(FilterLocationName).Append("\n");
      sb.Append("  Filtercrs: ").Append(Filtercrs).Append("\n");
      sb.Append("  FilterType: ").Append(FilterType).Append("\n");
      sb.Append("  NrccMessages: ").Append(NrccMessages).Append("\n");
      sb.Append("  PlatformAvailable: ").Append(PlatformAvailable).Append("\n");
      sb.Append("  AreServicesAvailable: ").Append(AreServicesAvailable).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

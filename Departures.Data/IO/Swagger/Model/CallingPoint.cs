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
  public class CallingPoint {
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
    /// Gets or Sets St
    /// </summary>
    [DataMember(Name="st", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "st")]
    public string St { get; set; }

    /// <summary>
    /// Gets or Sets Et
    /// </summary>
    [DataMember(Name="et", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "et")]
    public string Et { get; set; }

    /// <summary>
    /// Gets or Sets At
    /// </summary>
    [DataMember(Name="at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "at")]
    public string At { get; set; }

    /// <summary>
    /// Gets or Sets IsCancelled
    /// </summary>
    [DataMember(Name="isCancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCancelled")]
    public bool? IsCancelled { get; set; }

    /// <summary>
    /// Gets or Sets Length
    /// </summary>
    [DataMember(Name="length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "length")]
    public int? Length { get; set; }

    /// <summary>
    /// Gets or Sets DetachFront
    /// </summary>
    [DataMember(Name="detachFront", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detachFront")]
    public bool? DetachFront { get; set; }

    /// <summary>
    /// Gets or Sets Formation
    /// </summary>
    [DataMember(Name="formation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formation")]
    public FormationData Formation { get; set; }

    /// <summary>
    /// Gets or Sets AdhocAlerts
    /// </summary>
    [DataMember(Name="adhocAlerts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adhocAlerts")]
    public List<string> AdhocAlerts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CallingPoint {\n");
      sb.Append("  LocationName: ").Append(LocationName).Append("\n");
      sb.Append("  Crs: ").Append(Crs).Append("\n");
      sb.Append("  St: ").Append(St).Append("\n");
      sb.Append("  Et: ").Append(Et).Append("\n");
      sb.Append("  At: ").Append(At).Append("\n");
      sb.Append("  IsCancelled: ").Append(IsCancelled).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  DetachFront: ").Append(DetachFront).Append("\n");
      sb.Append("  Formation: ").Append(Formation).Append("\n");
      sb.Append("  AdhocAlerts: ").Append(AdhocAlerts).Append("\n");
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

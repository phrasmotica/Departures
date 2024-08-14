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
  public class ServiceLocation {
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
    /// Gets or Sets Via
    /// </summary>
    [DataMember(Name="via", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "via")]
    public string Via { get; set; }

    /// <summary>
    /// Gets or Sets FutureChangeTo
    /// </summary>
    [DataMember(Name="futureChangeTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "futureChangeTo")]
    public string FutureChangeTo { get; set; }

    /// <summary>
    /// Gets or Sets AssocIsCancelled
    /// </summary>
    [DataMember(Name="assocIsCancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assocIsCancelled")]
    public bool? AssocIsCancelled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceLocation {\n");
      sb.Append("  LocationName: ").Append(LocationName).Append("\n");
      sb.Append("  Crs: ").Append(Crs).Append("\n");
      sb.Append("  Via: ").Append(Via).Append("\n");
      sb.Append("  FutureChangeTo: ").Append(FutureChangeTo).Append("\n");
      sb.Append("  AssocIsCancelled: ").Append(AssocIsCancelled).Append("\n");
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

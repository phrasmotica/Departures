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
  public class ArrayOfCallingPoints {
    /// <summary>
    /// Gets or Sets CallingPoint
    /// </summary>
    [DataMember(Name="callingPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callingPoint")]
    public List<CallingPoint> CallingPoint { get; set; }

    /// <summary>
    /// Gets or Sets ServiceType
    /// </summary>
    [DataMember(Name="serviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceType")]
    public string ServiceType { get; set; }

    /// <summary>
    /// Gets or Sets ServiceChangeRequired
    /// </summary>
    [DataMember(Name="serviceChangeRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceChangeRequired")]
    public bool? ServiceChangeRequired { get; set; }

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
      sb.Append("class ArrayOfCallingPoints {\n");
      sb.Append("  CallingPoint: ").Append(CallingPoint).Append("\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
      sb.Append("  ServiceChangeRequired: ").Append(ServiceChangeRequired).Append("\n");
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

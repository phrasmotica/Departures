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
  public class CoachData {
    /// <summary>
    /// Gets or Sets CoachClass
    /// </summary>
    [DataMember(Name="coachClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coachClass")]
    public string CoachClass { get; set; }

    /// <summary>
    /// Gets or Sets Toilet
    /// </summary>
    [DataMember(Name="toilet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toilet")]
    public ToiletAvailabilityType Toilet { get; set; }

    /// <summary>
    /// Gets or Sets Loading
    /// </summary>
    [DataMember(Name="loading", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loading")]
    public int? Loading { get; set; }

    /// <summary>
    /// Gets or Sets LoadingSpecified
    /// </summary>
    [DataMember(Name="loadingSpecified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadingSpecified")]
    public bool? LoadingSpecified { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CoachData {\n");
      sb.Append("  CoachClass: ").Append(CoachClass).Append("\n");
      sb.Append("  Toilet: ").Append(Toilet).Append("\n");
      sb.Append("  Loading: ").Append(Loading).Append("\n");
      sb.Append("  LoadingSpecified: ").Append(LoadingSpecified).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
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

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
  public class FormationData {
    /// <summary>
    /// Gets or Sets LoadingCategory
    /// </summary>
    [DataMember(Name="loadingCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadingCategory")]
    public LoadingCategory LoadingCategory { get; set; }

    /// <summary>
    /// Gets or Sets Coaches
    /// </summary>
    [DataMember(Name="coaches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coaches")]
    public List<CoachData> Coaches { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormationData {\n");
      sb.Append("  LoadingCategory: ").Append(LoadingCategory).Append("\n");
      sb.Append("  Coaches: ").Append(Coaches).Append("\n");
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

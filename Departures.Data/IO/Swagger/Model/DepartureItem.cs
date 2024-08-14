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
  public class DepartureItem {
    /// <summary>
    /// Gets or Sets Service
    /// </summary>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public ServiceItem Service { get; set; }

    /// <summary>
    /// Gets or Sets Crs
    /// </summary>
    [DataMember(Name="crs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crs")]
    public string Crs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DepartureItem {\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
      sb.Append("  Crs: ").Append(Crs).Append("\n");
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

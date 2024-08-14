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
  public class ServiceDetails {
    /// <summary>
    /// Gets or Sets AdhocAlerts
    /// </summary>
    [DataMember(Name="adhocAlerts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adhocAlerts")]
    public List<string> AdhocAlerts { get; set; }

    /// <summary>
    /// Gets or Sets Formation
    /// </summary>
    [DataMember(Name="formation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formation")]
    public FormationData Formation { get; set; }

    /// <summary>
    /// Gets or Sets PreviousCallingPoints
    /// </summary>
    [DataMember(Name="previousCallingPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previousCallingPoints")]
    public List<ArrayOfCallingPoints> PreviousCallingPoints { get; set; }

    /// <summary>
    /// Gets or Sets SubsequentCallingPoints
    /// </summary>
    [DataMember(Name="subsequentCallingPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subsequentCallingPoints")]
    public List<ArrayOfCallingPoints> SubsequentCallingPoints { get; set; }

    /// <summary>
    /// Gets or Sets GeneratedAt
    /// </summary>
    [DataMember(Name="generatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generatedAt")]
    public DateTime? GeneratedAt { get; set; }

    /// <summary>
    /// Gets or Sets ServiceType
    /// </summary>
    [DataMember(Name="serviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceType")]
    public string ServiceType { get; set; }

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
    /// Gets or Sets Operator
    /// </summary>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string Operator { get; set; }

    /// <summary>
    /// Gets or Sets OperatorCode
    /// </summary>
    [DataMember(Name="operatorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operatorCode")]
    public string OperatorCode { get; set; }

    /// <summary>
    /// Gets or Sets Rsid
    /// </summary>
    [DataMember(Name="rsid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rsid")]
    public string Rsid { get; set; }

    /// <summary>
    /// Gets or Sets IsCancelled
    /// </summary>
    [DataMember(Name="isCancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCancelled")]
    public bool? IsCancelled { get; set; }

    /// <summary>
    /// Gets or Sets CancelReason
    /// </summary>
    [DataMember(Name="cancelReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancelReason")]
    public string CancelReason { get; set; }

    /// <summary>
    /// Gets or Sets DelayReason
    /// </summary>
    [DataMember(Name="delayReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delayReason")]
    public string DelayReason { get; set; }

    /// <summary>
    /// Gets or Sets OverdueMessage
    /// </summary>
    [DataMember(Name="overdueMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overdueMessage")]
    public string OverdueMessage { get; set; }

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
    /// Gets or Sets IsReverseFormation
    /// </summary>
    [DataMember(Name="isReverseFormation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isReverseFormation")]
    public bool? IsReverseFormation { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platform")]
    public string Platform { get; set; }

    /// <summary>
    /// Gets or Sets Sta
    /// </summary>
    [DataMember(Name="sta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sta")]
    public string Sta { get; set; }

    /// <summary>
    /// Gets or Sets Eta
    /// </summary>
    [DataMember(Name="eta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eta")]
    public string Eta { get; set; }

    /// <summary>
    /// Gets or Sets Ata
    /// </summary>
    [DataMember(Name="ata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ata")]
    public string Ata { get; set; }

    /// <summary>
    /// Gets or Sets Std
    /// </summary>
    [DataMember(Name="std", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "std")]
    public string Std { get; set; }

    /// <summary>
    /// Gets or Sets Etd
    /// </summary>
    [DataMember(Name="etd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "etd")]
    public string Etd { get; set; }

    /// <summary>
    /// Gets or Sets Atd
    /// </summary>
    [DataMember(Name="atd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "atd")]
    public string Atd { get; set; }

    /// <summary>
    /// Gets or Sets Xmlns
    /// </summary>
    [DataMember(Name="Xmlns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Xmlns")]
    public XmlSerializerNamespaces Xmlns { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceDetails {\n");
      sb.Append("  AdhocAlerts: ").Append(AdhocAlerts).Append("\n");
      sb.Append("  Formation: ").Append(Formation).Append("\n");
      sb.Append("  PreviousCallingPoints: ").Append(PreviousCallingPoints).Append("\n");
      sb.Append("  SubsequentCallingPoints: ").Append(SubsequentCallingPoints).Append("\n");
      sb.Append("  GeneratedAt: ").Append(GeneratedAt).Append("\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
      sb.Append("  LocationName: ").Append(LocationName).Append("\n");
      sb.Append("  Crs: ").Append(Crs).Append("\n");
      sb.Append("  Operator: ").Append(Operator).Append("\n");
      sb.Append("  OperatorCode: ").Append(OperatorCode).Append("\n");
      sb.Append("  Rsid: ").Append(Rsid).Append("\n");
      sb.Append("  IsCancelled: ").Append(IsCancelled).Append("\n");
      sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
      sb.Append("  DelayReason: ").Append(DelayReason).Append("\n");
      sb.Append("  OverdueMessage: ").Append(OverdueMessage).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  DetachFront: ").Append(DetachFront).Append("\n");
      sb.Append("  IsReverseFormation: ").Append(IsReverseFormation).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
      sb.Append("  Sta: ").Append(Sta).Append("\n");
      sb.Append("  Eta: ").Append(Eta).Append("\n");
      sb.Append("  Ata: ").Append(Ata).Append("\n");
      sb.Append("  Std: ").Append(Std).Append("\n");
      sb.Append("  Etd: ").Append(Etd).Append("\n");
      sb.Append("  Atd: ").Append(Atd).Append("\n");
      sb.Append("  Xmlns: ").Append(Xmlns).Append("\n");
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

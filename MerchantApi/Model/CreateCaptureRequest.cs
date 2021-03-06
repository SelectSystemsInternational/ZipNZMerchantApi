/* 
 * Merchant API
 *
 * ZipMoney Merchant API Initial build
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MerchantApi.Model
{
    /// <summary>
    /// CreateCaptureRequest
    /// </summary>
    [DataContract]
    public partial class CreateCaptureRequest :  IEquatable<CreateCaptureRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCaptureRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCaptureRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCaptureRequest" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>/// 
        /// <param name="Amount">Amount can be less than or equal to the previously authorised amount (required).</param>
        public CreateCaptureRequest(string Id = default(string), decimal? Amount = default(decimal?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CreateCaptureRequest and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for CreateCaptureRequest and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
        }

        /// <summary>
        /// The OrderId returned in the create order endpoint
        /// </summary>
        /// <value>OrderId</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// Amount can be less than or equal to the previously authorised amount
        /// </summary>
        /// <value>Amount can be less than or equal to the previously authorised amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCaptureRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateCaptureRequest);
        }

        /// <summary>
        /// Returns true if CreateCaptureRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCaptureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCaptureRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Amount (decimal?) minimum
            if(this.Amount < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.", new [] { "Amount" });
            }

            yield break;
        }
    }

}

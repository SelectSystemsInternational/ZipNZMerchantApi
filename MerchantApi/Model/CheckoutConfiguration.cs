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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace MerchantApi.Model
{
    /// <summary>
    /// Checkout configuration
    /// </summary>
    [DataContract]
    public partial class CheckoutConfiguration :  IEquatable<CheckoutConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutConfiguration" /> class.
        /// </summary>
        /// <param name="RedirectUri">The URI to redirect after the checkout is complete.  This must be provided, even if using in-context checkout.  If using redirection we will automatically redirect to this url with the result and checkoutId.  If using in-context we will not automatically redirect to this URI. (required).</param>
        public CheckoutConfiguration(string RedirectUri = default(string))
        {
            // to ensure "RedirectUri" is required (not null)
            if (RedirectUri == null)
            {
                throw new InvalidDataException("RedirectUri is a required property for CheckoutConfiguration and cannot be null");
            }
            else
            {
                this.RedirectUri = RedirectUri;
            }
        }
        
        /// <summary>
        /// The URI to redirect after the checkout is complete.  This must be provided, even if using in-context checkout.  If using redirection we will automatically redirect to this url with the result and checkoutId.  If using in-context we will not automatically redirect to this URI.
        /// </summary>
        /// <value>The URI to redirect after the checkout is complete.  This must be provided, even if using in-context checkout.  If using redirection we will automatically redirect to this url with the result and checkoutId.  If using in-context we will not automatically redirect to this URI.</value>
        [DataMember(Name="redirect_uri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutConfiguration {\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
            return this.Equals(obj as CheckoutConfiguration);
        }

        /// <summary>
        /// Returns true if CheckoutConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of CheckoutConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
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
                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

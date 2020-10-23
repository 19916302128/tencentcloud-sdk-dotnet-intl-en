/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificateResponse : AbstractModel
    {
        
        /// <summary>
        /// User UIN.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Project ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Certificate source. trustasia: TrustAsia; upload: certificate uploaded by users.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// Certificate type. CA: client certificate; SVR: server certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// Certificate package type. 1: GeoTrust DV SSL CA - G3; 2: TrustAsia TLS RSA CA; 3: Secure Site EV Pro; 4: Secure Site EV; 5: Secure Site OV Pro; 6: Secure Site OV; 7: Secure Site OV wildcard SSL certificate; 8: GeoTrust EV; 9: GeoTrust OV; 10: GeoTrust OV wildcard SSL certificate; 11: TrustAsia DV multi-domain SSL certificate; 12: TrustAsia DV wildcard SSL certificate; 13: TrustAsia OV wildcard SSL certificate (D3); 14: TrustAsia OV SSL certificate (D3); 15: TrustAsia OV multi-domain SSL certificate (D3); 16: TrustAsia EV SSL certificate (D3); 17: TrustAsia EV multi-domain SSL certificate (D3); 18: GlobalSign OV SSL certificate; 19: GlobalSign OV wildcard SSL certificate; 20: GlobalSign EV SSL certificate; 21: TrustAsia OV multi-domain wildcard SSL certificate (D3); 22: GlobalSign OV multi-domain SSL certificate; 23: GlobalSign OV multi-domain wildcard SSL certificate; 24: GlobalSign EV multi-domain SSL certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Name of the certificate issuer.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductZhName")]
        public string ProductZhName{ get; set; }

        /// <summary>
        /// Domain name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Alias.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Certificate status. 0: being reviewed; 1: approved; 2: not approved; 3: expired; 4: DNS record added; 5: OV certificate, to be submitted; 6: order being canceled; 7: cancelled; 8: information submitted, confirmation letter to be uploaded; 9: certificate being revoked; 10: revoked; 11: reissuing; 12: revocation confirmation letter to be uploaded.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Status information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusMsg")]
        public string StatusMsg{ get; set; }

        /// <summary>
        /// Verification type. DNS_AUTO: automatic DNS verification; DNS: manual DNS verification; FILE: verification by file; EMAIL: verification by email.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// Vulnerability scanning status.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulnerabilityStatus")]
        public string VulnerabilityStatus{ get; set; }

        /// <summary>
        /// Time when the certificate takes effect.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertBeginTime")]
        public string CertBeginTime{ get; set; }

        /// <summary>
        /// Time when the certificate expires.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// Validity period of the certificate (unit: month).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// Application time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// Order ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// Extended information of the certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateExtra")]
        public CertificateExtra CertificateExtra{ get; set; }

        /// <summary>
        /// DV authentication information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvAuthDetail")]
        public DvAuthDetail DvAuthDetail{ get; set; }

        /// <summary>
        /// Vulnerability scanning assessment report.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulnerabilityReport")]
        public string VulnerabilityReport{ get; set; }

        /// <summary>
        /// Certificate ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Certificate type name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageTypeName")]
        public string PackageTypeName{ get; set; }

        /// <summary>
        /// Status description.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusName")]
        public string StatusName{ get; set; }

        /// <summary>
        /// Domain names associated with the certificate (including the primary domain name).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }

        /// <summary>
        /// Whether the customer is a VIP customer.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// Whether the certificate is a wildcard certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsWildcard")]
        public bool? IsWildcard{ get; set; }

        /// <summary>
        /// Whether the certificate is a DV certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDv")]
        public bool? IsDv{ get; set; }

        /// <summary>
        /// Whether the vulnerability scanning feature is enabled.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsVulnerability")]
        public bool? IsVulnerability{ get; set; }

        /// <summary>
        /// Whether the certificate can be reissued.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RenewAble")]
        public bool? RenewAble{ get; set; }

        /// <summary>
        /// Submitted data.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubmittedData")]
        public SubmittedData SubmittedData{ get; set; }

        /// <summary>
        /// Whether the certificate can be deployed.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Deployable")]
        public bool? Deployable{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "ProductZhName", this.ProductZhName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusMsg", this.StatusMsg);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "VulnerabilityStatus", this.VulnerabilityStatus);
            this.SetParamSimple(map, prefix + "CertBeginTime", this.CertBeginTime);
            this.SetParamSimple(map, prefix + "CertEndTime", this.CertEndTime);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamObj(map, prefix + "CertificateExtra.", this.CertificateExtra);
            this.SetParamObj(map, prefix + "DvAuthDetail.", this.DvAuthDetail);
            this.SetParamSimple(map, prefix + "VulnerabilityReport", this.VulnerabilityReport);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "PackageTypeName", this.PackageTypeName);
            this.SetParamSimple(map, prefix + "StatusName", this.StatusName);
            this.SetParamArraySimple(map, prefix + "SubjectAltName.", this.SubjectAltName);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "IsWildcard", this.IsWildcard);
            this.SetParamSimple(map, prefix + "IsDv", this.IsDv);
            this.SetParamSimple(map, prefix + "IsVulnerability", this.IsVulnerability);
            this.SetParamSimple(map, prefix + "RenewAble", this.RenewAble);
            this.SetParamObj(map, prefix + "SubmittedData.", this.SubmittedData);
            this.SetParamSimple(map, prefix + "Deployable", this.Deployable);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


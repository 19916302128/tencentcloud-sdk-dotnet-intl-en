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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// Master origin server list
        /// When modifying the origin server, you need to enter the corresponding OriginType.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// Primary origin server type
        /// Input:
        /// `domain`: domain name
        /// `cos`: COS bucket address
        /// `ip`: IP address
        /// `ipv6`: a single IPv6 address
        /// `ip_ipv6`: multiple IPv4 addresses and one IPv6 address
        /// `ip_domain`: both IP addresses and domain names (only available to beta users)
        /// `ipv6_domain`: multiple IPv6 addresses and one domain name
        /// `ip_ipv6_domain`: multiple IPv4 and IPv6 addresses and one domain name
        /// Output: 
        /// `image`: Cloud Infinite origin
        /// `ftp`: FTP origin (disused)
        /// When modifying `Origins`, you need to enter the corresponding `OriginType`.
        /// The IPv6 feature is now only available to beta users. Please submit an application to use this feature.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Host header used when accessing the master origin server. If left empty, the acceleration domain name will be used by default.
        /// If a wildcard domain name is accessed, then the sub-domain name during the access will be used by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// When OriginType is COS, you can specify if access to private buckets is allowed.
        /// Note: to enable this configuration, you need to first grant CDN access to the private bucket.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CosPrivateAccess")]
        public string CosPrivateAccess{ get; set; }

        /// <summary>
        /// Origin-pull protocol configuration
        /// http: forced HTTP origin-pull
        /// follow: protocol follow origin-pull
        /// https: forced HTTPS origin-pull. This only supports origin server port 443 for origin-pull.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginPullProtocol")]
        public string OriginPullProtocol{ get; set; }

        /// <summary>
        /// Backup origin server list
        /// When modifying the backup origin server, you need to enter the corresponding BackupOriginType.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        /// Secondary origin type. Values:
        /// `domain`: domain name
        /// `ip`: IP address
        /// When modifying `BackupOrigins`, you need to enter the corresponding `BackupOriginType`.
        /// The following backup origin servers are only available to beta users. Submit an application if you want to become a beta user.
        /// `ipv6_domain`: multiple IPv6 addresses and one domain name
        /// `ip_ipv6`: multiple IPv4 addresses and one IPv6 address
        /// `ipv6_domain`: multiple IPv6 addresses and one domain name
        /// `ip_ipv6_domain`: multiple IPv4 and IPv6 addresses and one domain name
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupOriginType")]
        public string BackupOriginType{ get; set; }

        /// <summary>
        /// Host header used when accessing the backup origin server. If left empty, the ServerName of master origin server will be used by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupServerName")]
        public string BackupServerName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BasePath")]
        public string BasePath{ get; set; }

        /// <summary>
        /// Origin URL rewrite rule configuration
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PathRules")]
        public PathRule[] PathRules{ get; set; }

        /// <summary>
        /// Path-based origin-pull configurations
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PathBasedOrigin")]
        public PathBasedOriginRule[] PathBasedOrigin{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AdvanceHttps")]
        public AdvanceHttps AdvanceHttps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Origins.", this.Origins);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "CosPrivateAccess", this.CosPrivateAccess);
            this.SetParamSimple(map, prefix + "OriginPullProtocol", this.OriginPullProtocol);
            this.SetParamArraySimple(map, prefix + "BackupOrigins.", this.BackupOrigins);
            this.SetParamSimple(map, prefix + "BackupOriginType", this.BackupOriginType);
            this.SetParamSimple(map, prefix + "BackupServerName", this.BackupServerName);
            this.SetParamSimple(map, prefix + "BasePath", this.BasePath);
            this.SetParamArrayObj(map, prefix + "PathRules.", this.PathRules);
            this.SetParamArrayObj(map, prefix + "PathBasedOrigin.", this.PathBasedOrigin);
            this.SetParamObj(map, prefix + "AdvanceHttps.", this.AdvanceHttps);
        }
    }
}


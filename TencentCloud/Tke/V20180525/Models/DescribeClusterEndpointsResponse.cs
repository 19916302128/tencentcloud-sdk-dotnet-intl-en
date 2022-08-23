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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterEndpointsResponse : AbstractModel
    {
        
        /// <summary>
        /// CA certificate of cluster APIServer
        /// </summary>
        [JsonProperty("CertificationAuthority")]
        public string CertificationAuthority{ get; set; }

        /// <summary>
        /// Public network access address of cluster APIServer
        /// </summary>
        [JsonProperty("ClusterExternalEndpoint")]
        public string ClusterExternalEndpoint{ get; set; }

        /// <summary>
        /// Private network access address of cluster APIServer
        /// </summary>
        [JsonProperty("ClusterIntranetEndpoint")]
        public string ClusterIntranetEndpoint{ get; set; }

        /// <summary>
        /// Domain name of cluster APIServer
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterDomain")]
        public string ClusterDomain{ get; set; }

        /// <summary>
        /// Public network access ACL of cluster APIServer
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterExternalACL")]
        public string[] ClusterExternalACL{ get; set; }

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
            this.SetParamSimple(map, prefix + "CertificationAuthority", this.CertificationAuthority);
            this.SetParamSimple(map, prefix + "ClusterExternalEndpoint", this.ClusterExternalEndpoint);
            this.SetParamSimple(map, prefix + "ClusterIntranetEndpoint", this.ClusterIntranetEndpoint);
            this.SetParamSimple(map, prefix + "ClusterDomain", this.ClusterDomain);
            this.SetParamArraySimple(map, prefix + "ClusterExternalACL.", this.ClusterExternalACL);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


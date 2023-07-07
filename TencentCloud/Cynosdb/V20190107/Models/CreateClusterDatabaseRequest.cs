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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterDatabaseRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Character set
        /// </summary>
        [JsonProperty("CharacterSet")]
        public string CharacterSet{ get; set; }

        /// <summary>
        /// Collation
        /// </summary>
        [JsonProperty("CollateRule")]
        public string CollateRule{ get; set; }

        /// <summary>
        /// Host permissions of the authorized user
        /// </summary>
        [JsonProperty("UserHostPrivileges")]
        public UserHostPrivilege[] UserHostPrivileges{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "CharacterSet", this.CharacterSet);
            this.SetParamSimple(map, prefix + "CollateRule", this.CollateRule);
            this.SetParamArrayObj(map, prefix + "UserHostPrivileges.", this.UserHostPrivileges);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}


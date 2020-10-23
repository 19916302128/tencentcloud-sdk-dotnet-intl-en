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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenameRestoreDatabase : AbstractModel
    {
        
        /// <summary>
        /// Database name. If the `OldName` database does not exist, a failure will be returned.
        /// It can be left empty in offline migration tasks.
        /// </summary>
        [JsonProperty("OldName")]
        public string OldName{ get; set; }

        /// <summary>
        /// New database name. If this parameter is left empty, the restored database will be renamed in the default format. If this parameter is left empty in offline migration tasks, the restored database will be named `OldName`. `OldName` and `NewName` cannot be both empty.
        /// </summary>
        [JsonProperty("NewName")]
        public string NewName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OldName", this.OldName);
            this.SetParamSimple(map, prefix + "NewName", this.NewName);
        }
    }
}


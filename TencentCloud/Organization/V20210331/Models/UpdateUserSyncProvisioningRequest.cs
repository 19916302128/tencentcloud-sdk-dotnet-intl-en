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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserSyncProvisioningRequest : AbstractModel
    {
        
        /// <summary>
        /// Space ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// User synchronization ID.
        /// </summary>
        [JsonProperty("UserProvisioningId")]
        public string UserProvisioningId{ get; set; }

        /// <summary>
        /// User synchronization description.
        /// </summary>
        [JsonProperty("NewDescription")]
        public string NewDescription{ get; set; }

        /// <summary>
        /// Conflict policy. It indicates the handling policy for existence of a user with the same username when CIC users are synchronized to CAM. Valid values: KeepBoth: Keep both, that is, add the _cic suffix to the CIC user's username and then try to create a CAM user with the username when CIC users are synchronized to CAM and a user with the same username already exists in CAM; TakeOver: Replace, that is, directly replace the existing CAM user with the synchronized CIC user when CIC users are synchronized to CAM and a user with the same username already exists in CAM.
        /// </summary>
        [JsonProperty("NewDuplicationStateful")]
        public string NewDuplicationStateful{ get; set; }

        /// <summary>
        /// Deletion policy. It indicates the handling policy for CAM users already synchronized when the CAM user synchronization is deleted. Valid values: Delete: Delete the CAM users already synchronized from CIC to CAM when the CAM user synchronization is deleted; Keep: Keep the CAM users already synchronized from CIC to CAM when the CAM user synchronization is deleted.
        /// </summary>
        [JsonProperty("NewDeletionStrategy")]
        public string NewDeletionStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "UserProvisioningId", this.UserProvisioningId);
            this.SetParamSimple(map, prefix + "NewDescription", this.NewDescription);
            this.SetParamSimple(map, prefix + "NewDuplicationStateful", this.NewDuplicationStateful);
            this.SetParamSimple(map, prefix + "NewDeletionStrategy", this.NewDeletionStrategy);
        }
    }
}


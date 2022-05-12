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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataDisk : AbstractModel
    {
        
        /// <summary>
        /// Data disk type. See [Cloud Disk Types](https://intl.cloud.tencent.com/document/product/362/31636). Valid values:<br><li>`LOCAL_BASIC`: Local disk<br><li>`LOCAL_SSD`: Local SSD disk<br><li>`CLOUD_BASIC`: HDD cloud disk<br><li>`CLOUD_PREMIUM`: Premium cloud storage<br><li>`CLOUD_SSD`: SSD cloud disk<br><li>`CLOUD_HSSD`: Enhanced SSD<br><li>`CLOUD_TSSD`: Tremendous SSD<br><br>The default value should be the same as the `DiskType` field under `SystemDisk`.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Data disk size (in GB). The minimum adjustment increment is 10 GB. The value range varies by data disk type. For more information on limits, see [CVM Instance Configuration](https://intl.cloud.tencent.com/document/product/213/2177?from_cn_redirect=1). The default value is 0, indicating that no data disk is purchased. For more information, see the product documentation.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Data disk snapshot ID, such as `snap-l8psqwnt`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Specifies whether the data disk is terminated along with the termination of the associated CVM instance.  Values: <br><li>`TRUE` (only available for pay-as-you-go cloud disks that are billed by hour) and `FALSE`.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// Data disk encryption. Valid values: <br><li>`TRUE`: Encrypted<br><li>`FALSE`: Not encrypted
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// Cloud disk performance (MB/s). This parameter is used to purchase extra performance for the cloud disk. For details on the feature and limits, see [Enhanced SSD Performance](https://intl.cloud.tencent.com/document/product/362/51896?from_cn_redirect=1#. E5.A2.9E.E5.BC.BA.E5.9E.8B-ssd-.E4.BA.91.E7.A1.AC.E7.9B.98.E9.A2.9D.E5.A4.96 .E6.80.A7.E8.83.BD).
        /// This feature is only available to enhanced SSD (`CLOUD_HSSD`) and tremendous SSD (`CLOUD_TSSD`) disks with a capacity greater than 460 GB.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
        }
    }
}


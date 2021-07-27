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

    public class ModifyLaunchConfigurationAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// Launch configuration ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Valid [image](https://intl.cloud.tencent.com/document/product/213/4940?from_cn_redirect=1) ID in the format of `img-8toqc6s3`. There are four types of images: <br/><li>Public images </li><li>Custom images </li><li>Shared images </li><li>Marketplace images </li><br/>You can obtain the available image IDs in the following ways: <br/><li>For `public images`, `custom images`, and `shared images`, log in to the [console](https://console.cloud.tencent.com/cvm/image?rid=1&imageType=PUBLIC_IMAGE) to query the image IDs; for `marketplace images`, query the image IDs through [Cloud Marketplace](https://market.cloud.tencent.com/list). </li><li>This value can be obtained from the `ImageId` field in the return value of the [DescribeImages API](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1).</li>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// List of instance types. Each type specifies different resource specifications. This list contains up to 10 instance types.
        /// The launch configuration uses `InstanceType` to indicate one single instance type and `InstanceTypes` to indicate multiple instance types. Specifying the `InstanceTypes` field will invalidate the original `InstanceType`.
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// Instance type verification policy which works when InstanceTypes is actually modified. Value range: ALL, ANY. Default value: ANY.
        /// <br><li> ALL: The verification will success only if all instance types (InstanceType) are available; otherwise, an error will be reported.
        /// <br><li> ANY: The verification will success if any instance type (InstanceType) is available; otherwise, an error will be reported.
        /// 
        /// Common reasons why an instance type is unavailable include stock-out of the instance type or the corresponding cloud disk.
        /// If a model in InstanceTypes does not exist or has been discontinued, a verification error will be reported regardless of the value of InstanceTypesCheckPolicy.
        /// </summary>
        [JsonProperty("InstanceTypesCheckPolicy")]
        public string InstanceTypesCheckPolicy{ get; set; }

        /// <summary>
        /// Display name of the launch configuration, which can contain Chinese characters, letters, numbers, underscores, separators ("-"), and decimal points with a maximum length of 60 bytes.
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// Base64-encoded custom data of up to 16 KB. If you want to clear `UserData`, set it to an empty string.
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// Security group to which the instance belongs. This parameter can be obtained from the `SecurityGroupId` field in the response of the [`DescribeSecurityGroups`](https://intl.cloud.tencent.com/document/api/215/15808?from_cn_redirect=1) API.
        /// At least one security group is required for this parameter. The security group specified is sequential.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Information of the public network bandwidth configuration.
        /// When the public outbound network bandwidth is 0 Mbps, assigning a public IP is not allowed. Accordingly, if a public IP is assigned, the new public network outbound bandwidth must be greater than 0 Mbps.
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// Instance billing mode. Valid values:
        /// <br><li>POSTPAID_BY_HOUR: pay-as-you-go hourly
        /// <br><li>SPOTPAID: spot instance
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Parameter setting for the prepaid mode (monthly subscription mode). This parameter can specify the renewal period, whether to set the auto-renewal, and other attributes of the monthly-subscribed instances.
        /// This parameter is required when changing the instance billing mode to monthly subscription. It will be automatically discarded after you choose another billing mode.
        /// This field requires passing in the `Period` field. Other fields that are not passed in will use their default values.
        /// This field can be modified only when the current billing mode is monthly subscription.
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// Market-related options for instances, such as parameters related to spot instances.
        /// This parameter is required when changing the instance billing mode to spot instance. It will be automatically discarded after you choose another instance billing mode.
        /// This field requires passing in the `MaxPrice` field under the `SpotOptions`. Other fields that are not passed in will use their default values.
        /// This field can be modified only when the current billing mode is spot instance.
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// Selection policy of cloud disks. Default value: ORIGINAL. Valid values:
        /// <br><li>ORIGINAL: uses the configured cloud disk type
        /// <br><li>AUTOMATIC: automatically chooses an available cloud disk type
        /// </summary>
        [JsonProperty("DiskTypePolicy")]
        public string DiskTypePolicy{ get; set; }

        /// <summary>
        /// Instance system disk configurations
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// Configuration information of instance data disks.
        /// Up to 11 data disks can be specified and will be collectively modified. Please provide all the new values for the modification.
        /// The default data disk should be the same as the system disk.
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// CVM hostname settings.
        /// This field is not supported for Windows instances.
        /// This field requires passing the `HostName` field. Other fields that are not passed in will use their default values.
        /// </summary>
        [JsonProperty("HostNameSettings")]
        public HostNameSettings HostNameSettings{ get; set; }

        /// <summary>
        /// Settings of CVM instance names. 
        /// If this field is configured in a launch configuration, the `InstanceName` of a CVM created by the scaling group will be generated according to the configuration; otherwise, it will be in the `as-{{AutoScalingGroupName }}` format.
        /// This field requires passing in the `InstanceName` field. Other fields that are not passed in will use their default values.
        /// </summary>
        [JsonProperty("InstanceNameSettings")]
        public InstanceNameSettings InstanceNameSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamSimple(map, prefix + "InstanceTypesCheckPolicy", this.InstanceTypesCheckPolicy);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamSimple(map, prefix + "DiskTypePolicy", this.DiskTypePolicy);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "HostNameSettings.", this.HostNameSettings);
            this.SetParamObj(map, prefix + "InstanceNameSettings.", this.InstanceNameSettings);
        }
    }
}


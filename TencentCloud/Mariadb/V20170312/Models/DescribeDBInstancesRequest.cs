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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries by instance ID or IDs. Instance ID is in the format of `tdsql-ow728lmc`. Up to 100 instances can be queried in one request.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Search field name. Valid values: instancename (search by instance name), vip (search by private IP), all (search by instance ID, instance name, and private IP).
        /// </summary>
        [JsonProperty("SearchName")]
        public string SearchName{ get; set; }

        /// <summary>
        /// Search keyword. Fuzzy search is supported. Multiple keywords should be separated by line breaks (`\n`).
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Queries by project ID
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// Whether to search by VPC
        /// </summary>
        [JsonProperty("IsFilterVpc")]
        public bool? IsFilterVpc{ get; set; }

        /// <summary>
        /// VPC ID, which is valid when `IsFilterVpc` is 1
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID, which is valid when `IsFilterVpc` is 1
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Sort by field. Valid values: projectId, createtime, instancename
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: desc, asc
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }

        /// <summary>
        /// Offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Queries by `OriginSerialId`
        /// </summary>
        [JsonProperty("OriginSerialIds")]
        public string[] OriginSerialIds{ get; set; }

        /// <summary>
        /// Identifies whether to use the `ExclusterType` field. false: no, true: yes
        /// </summary>
        [JsonProperty("IsFilterExcluster")]
        public bool? IsFilterExcluster{ get; set; }

        /// <summary>
        /// Instance cluster type. 1: non-dedicated cluster, 2: dedicated cluster, 0: all
        /// </summary>
        [JsonProperty("ExclusterType")]
        public long? ExclusterType{ get; set; }

        /// <summary>
        /// Filters instances by dedicated cluster ID in the format of `dbdc-4ih6uct9`
        /// </summary>
        [JsonProperty("ExclusterIds")]
        public string[] ExclusterIds{ get; set; }

        /// <summary>
        /// Tag key used in queries
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }

        /// <summary>
        /// Instance types used in filtering. Valid values: 1 (dedicated instance), 2 (primary instance), 3 (disaster recovery instance). Multiple values should be separated by commas.
        /// </summary>
        [JsonProperty("FilterInstanceType")]
        public string FilterInstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "SearchName", this.SearchName);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamSimple(map, prefix + "IsFilterVpc", this.IsFilterVpc);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "OriginSerialIds.", this.OriginSerialIds);
            this.SetParamSimple(map, prefix + "IsFilterExcluster", this.IsFilterExcluster);
            this.SetParamSimple(map, prefix + "ExclusterType", this.ExclusterType);
            this.SetParamArraySimple(map, prefix + "ExclusterIds.", this.ExclusterIds);
            this.SetParamArraySimple(map, prefix + "TagKeys.", this.TagKeys);
            this.SetParamSimple(map, prefix + "FilterInstanceType", this.FilterInstanceType);
        }
    }
}


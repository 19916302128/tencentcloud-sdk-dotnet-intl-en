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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSlowLogTimeSeriesStatsResponse : AbstractModel
    {
        
        /// <summary>
        /// Time range in seconds in histogram.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Number of slow logs in specified time range.
        /// </summary>
        [JsonProperty("TimeSeries")]
        public TimeSlice[] TimeSeries{ get; set; }

        /// <summary>
        /// Instance CPU utilization monitoring data in specified time range.
        /// </summary>
        [JsonProperty("SeriesData")]
        public MonitorMetricSeriesData SeriesData{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArrayObj(map, prefix + "TimeSeries.", this.TimeSeries);
            this.SetParamObj(map, prefix + "SeriesData.", this.SeriesData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


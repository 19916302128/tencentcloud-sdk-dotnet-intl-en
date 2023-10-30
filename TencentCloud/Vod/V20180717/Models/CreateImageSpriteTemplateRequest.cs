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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateImageSpriteTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Sampling type. Valid values:
        /// <li>Percent: by percent.</li>
        /// <li>Time: by time interval.</li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// Sampling interval.
        /// <li>If `SampleType` is `Percent`, sampling will be performed at an interval of the specified percentage.</li>
        /// <li>If `SampleType` is `Time`, sampling will be performed at the specified time interval in seconds.</li>
        /// </summary>
        [JsonProperty("SampleInterval")]
        public ulong? SampleInterval{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RowCount")]
        public ulong? RowCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ColumnCount")]
        public ulong? ColumnCount{ get; set; }

        /// <summary>
        /// <b>The VOD [subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID. If you need to access a resource in a subapplication, set this parameter to the subapplication ID; otherwise, leave it empty.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Name of an image sprite generating template. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Fill type. "Fill" refers to the way of processing a screenshot when its aspect ratio is different from that of the source video. The following fill types are supported:
        /// <li> stretch: stretch. The screenshot will be stretched frame by frame to match the aspect ratio of the source video, which may make the screenshot "shorter" or "longer";</li>
        /// <li>black: fill with black. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with black color blocks.</li>
        /// Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Resolution adaption. Valid values:
        /// <li>open: enabled. In this case, `Width` represents the long side of a video, while `Height` the short side;</li>
        /// <li>close: disabled. In this case, `Width` represents the width of a video, while `Height` the height.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// The image format. Valid values:
        /// <li> jpg</li>
        /// <li> png</li>
        /// <li> webp</li>
        /// Default: jpg
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "SampleInterval", this.SampleInterval);
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "ColumnCount", this.ColumnCount);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Format", this.Format);
        }
    }
}


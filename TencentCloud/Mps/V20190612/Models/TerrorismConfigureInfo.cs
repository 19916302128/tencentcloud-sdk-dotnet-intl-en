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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TerrorismConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// The parameters for detecting sensitive information based on OCR.
        /// </summary>
        [JsonProperty("OcrReviewInfo")]
        public TerrorismOcrReviewTemplateInfo OcrReviewInfo{ get; set; }

        /// <summary>
        /// The parameters for detecting sensitive information in images.
        /// </summary>
        [JsonProperty("ImgReviewInfo")]
        public TerrorismImgReviewTemplateInfo ImgReviewInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "OcrReviewInfo.", this.OcrReviewInfo);
            this.SetParamObj(map, prefix + "ImgReviewInfo.", this.ImgReviewInfo);
        }
    }
}


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

namespace TencentCloud.Dbbrain.V20191016
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbbrain.V20191016.Models;

   public class DbbrainClient : AbstractClient{

       private const string endpoint = "dbbrain.tencentcloudapi.com";
       private const string version = "2019-10-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DbbrainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DbbrainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to get the details of an instance exception diagnosis event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public async Task<DescribeDBDiagEventResponse> DescribeDBDiagEvent(DescribeDBDiagEventRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of an instance exception diagnosis event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public DescribeDBDiagEventResponse DescribeDBDiagEventSync(DescribeDBDiagEventRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of instance diagnosis events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public async Task<DescribeDBDiagHistoryResponse> DescribeDBDiagHistory(DescribeDBDiagHistoryRequest req)
        {
             JsonResponseModel<DescribeDBDiagHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of instance diagnosis events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public DescribeDBDiagHistoryResponse DescribeDBDiagHistorySync(DescribeDBDiagHistoryRequest req)
        {
             JsonResponseModel<DescribeDBDiagHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the slow log statistics histogram.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public async Task<DescribeSlowLogTimeSeriesStatsResponse> DescribeSlowLogTimeSeriesStats(DescribeSlowLogTimeSeriesStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogTimeSeriesStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the slow log statistics histogram.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public DescribeSlowLogTimeSeriesStatsResponse DescribeSlowLogTimeSeriesStatsSync(DescribeSlowLogTimeSeriesStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogTimeSeriesStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get and sort the top slow SQL statements in a specified time period by the aggregation mode of SQL template plus schema.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public async Task<DescribeSlowLogTopSqlsResponse> DescribeSlowLogTopSqls(DescribeSlowLogTopSqlsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTopSqlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogTopSqls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTopSqlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get and sort the top slow SQL statements in a specified time period by the aggregation mode of SQL template plus schema.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public DescribeSlowLogTopSqlsResponse DescribeSlowLogTopSqlsSync(DescribeSlowLogTopSqlsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTopSqlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogTopSqls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTopSqlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

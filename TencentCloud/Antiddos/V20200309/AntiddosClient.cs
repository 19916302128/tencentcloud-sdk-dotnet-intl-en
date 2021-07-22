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

namespace TencentCloud.Antiddos.V20200309
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Antiddos.V20200309.Models;

   public class AntiddosClient : AbstractClient{

       private const string endpoint = "antiddos.tencentcloudapi.com";
       private const string version = "2020-03-09";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AntiddosClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AntiddosClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to bind an EIP to an Anti-DDoS Advanced instance or a specified private IP of an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public async Task<AssociateDDoSEipAddressResponse> AssociateDDoSEipAddress(AssociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<AssociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an EIP to an Anti-DDoS Advanced instance or a specified private IP of an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public AssociateDDoSEipAddressResponse AssociateDDoSEipAddressSync(AssociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<AssociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public async Task<CreateBlackWhiteIpListResponse> CreateBlackWhiteIpList(CreateBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public CreateBlackWhiteIpListResponse CreateBlackWhiteIpListSync(CreateBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance Both single IP instances and multi-IP instances are available. Note that you should wait until the current binding or unbinding completes before using this async API for new operations.
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public async Task<CreateBoundIPResponse> CreateBoundIP(CreateBoundIPRequest req)
        {
             JsonResponseModel<CreateBoundIPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBoundIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBoundIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance Both single IP instances and multi-IP instances are available. Note that you should wait until the current binding or unbinding completes before using this async API for new operations.
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public CreateBoundIPResponse CreateBoundIPSync(CreateBoundIPRequest req)
        {
             JsonResponseModel<CreateBoundIPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBoundIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBoundIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public async Task<CreateDDoSAIResponse> CreateDDoSAI(CreateDDoSAIRequest req)
        {
             JsonResponseModel<CreateDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public CreateDDoSAIResponse CreateDDoSAISync(CreateDDoSAIRequest req)
        {
             JsonResponseModel<CreateDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS region blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<CreateDDoSGeoIPBlockConfigResponse> CreateDDoSGeoIPBlockConfig(CreateDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS region blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public CreateDDoSGeoIPBlockConfigResponse CreateDDoSGeoIPBlockConfigSync(CreateDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<CreateDDoSSpeedLimitConfigResponse> CreateDDoSSpeedLimitConfig(CreateDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<CreateDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public CreateDDoSSpeedLimitConfigResponse CreateDDoSSpeedLimitConfigSync(CreateDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<CreateDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public async Task<CreateDefaultAlarmThresholdResponse> CreateDefaultAlarmThreshold(CreateDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public CreateDefaultAlarmThresholdResponse CreateDefaultAlarmThresholdSync(CreateDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public async Task<CreateIPAlarmThresholdConfigResponse> CreateIPAlarmThresholdConfig(CreateIPAlarmThresholdConfigRequest req)
        {
             JsonResponseModel<CreateIPAlarmThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIPAlarmThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPAlarmThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public CreateIPAlarmThresholdConfigResponse CreateIPAlarmThresholdConfigSync(CreateIPAlarmThresholdConfigRequest req)
        {
             JsonResponseModel<CreateIPAlarmThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIPAlarmThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPAlarmThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure certificates with layer-7 forwarding rules in a batch for SSL testing.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public async Task<CreateL7RuleCertsResponse> CreateL7RuleCerts(CreateL7RuleCertsRequest req)
        {
             JsonResponseModel<CreateL7RuleCertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7RuleCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure certificates with layer-7 forwarding rules in a batch for SSL testing.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public CreateL7RuleCertsResponse CreateL7RuleCertsSync(CreateL7RuleCertsRequest req)
        {
             JsonResponseModel<CreateL7RuleCertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7RuleCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public async Task<CreatePacketFilterConfigResponse> CreatePacketFilterConfig(CreatePacketFilterConfigRequest req)
        {
             JsonResponseModel<CreatePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public CreatePacketFilterConfigResponse CreatePacketFilterConfigSync(CreatePacketFilterConfigRequest req)
        {
             JsonResponseModel<CreatePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public async Task<CreateProtocolBlockConfigResponse> CreateProtocolBlockConfig(CreateProtocolBlockConfigRequest req)
        {
             JsonResponseModel<CreateProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public CreateProtocolBlockConfigResponse CreateProtocolBlockConfigSync(CreateProtocolBlockConfigRequest req)
        {
             JsonResponseModel<CreateProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a domain name for IP scheduling and switching.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public async Task<CreateSchedulingDomainResponse> CreateSchedulingDomain(CreateSchedulingDomainRequest req)
        {
             JsonResponseModel<CreateSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a domain name for IP scheduling and switching.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public CreateSchedulingDomainResponse CreateSchedulingDomainSync(CreateSchedulingDomainRequest req)
        {
             JsonResponseModel<CreateSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public async Task<CreateWaterPrintConfigResponse> CreateWaterPrintConfig(CreateWaterPrintConfigRequest req)
        {
             JsonResponseModel<CreateWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public CreateWaterPrintConfigResponse CreateWaterPrintConfigSync(CreateWaterPrintConfigRequest req)
        {
             JsonResponseModel<CreateWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public async Task<CreateWaterPrintKeyResponse> CreateWaterPrintKey(CreateWaterPrintKeyRequest req)
        {
             JsonResponseModel<CreateWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public CreateWaterPrintKeyResponse CreateWaterPrintKeySync(CreateWaterPrintKeyRequest req)
        {
             JsonResponseModel<CreateWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteBlackWhiteIpListResponse"/></returns>
        public async Task<DeleteBlackWhiteIpListResponse> DeleteBlackWhiteIpList(DeleteBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DeleteBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteBlackWhiteIpListResponse"/></returns>
        public DeleteBlackWhiteIpListResponse DeleteBlackWhiteIpListSync(DeleteBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DeleteBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<DeleteDDoSGeoIPBlockConfigResponse> DeleteDDoSGeoIPBlockConfig(DeleteDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public DeleteDDoSGeoIPBlockConfigResponse DeleteDDoSGeoIPBlockConfigSync(DeleteDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<DeleteDDoSSpeedLimitConfigResponse> DeleteDDoSSpeedLimitConfig(DeleteDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public DeleteDDoSSpeedLimitConfigResponse DeleteDDoSSpeedLimitConfigSync(DeleteDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public async Task<DeletePacketFilterConfigResponse> DeletePacketFilterConfig(DeletePacketFilterConfigRequest req)
        {
             JsonResponseModel<DeletePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public DeletePacketFilterConfigResponse DeletePacketFilterConfigSync(DeletePacketFilterConfigRequest req)
        {
             JsonResponseModel<DeletePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public async Task<DeleteWaterPrintConfigResponse> DeleteWaterPrintConfig(DeleteWaterPrintConfigRequest req)
        {
             JsonResponseModel<DeleteWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public DeleteWaterPrintConfigResponse DeleteWaterPrintConfigSync(DeleteWaterPrintConfigRequest req)
        {
             JsonResponseModel<DeleteWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public async Task<DeleteWaterPrintKeyResponse> DeleteWaterPrintKey(DeleteWaterPrintKeyRequest req)
        {
             JsonResponseModel<DeleteWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public DeleteWaterPrintKeyResponse DeleteWaterPrintKeySync(DeleteWaterPrintKeyRequest req)
        {
             JsonResponseModel<DeleteWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeBlackWhiteIpListResponse> DescribeBlackWhiteIpList(DescribeBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeBlackWhiteIpListResponse"/></returns>
        public DescribeBlackWhiteIpListResponse DescribeBlackWhiteIpListSync(DescribeBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public async Task<DescribeDefaultAlarmThresholdResponse> DescribeDefaultAlarmThreshold(DescribeDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public DescribeDefaultAlarmThresholdResponse DescribeDefaultAlarmThresholdSync(DescribeDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query layer-7 rules matched with certificate IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public async Task<DescribeL7RulesBySSLCertIdResponse> DescribeL7RulesBySSLCertId(DescribeL7RulesBySSLCertIdRequest req)
        {
             JsonResponseModel<DescribeL7RulesBySSLCertIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7RulesBySSLCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7RulesBySSLCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query layer-7 rules matched with certificate IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public DescribeL7RulesBySSLCertIdResponse DescribeL7RulesBySSLCertIdSync(DescribeL7RulesBySSLCertIdRequest req)
        {
             JsonResponseModel<DescribeL7RulesBySSLCertIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7RulesBySSLCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7RulesBySSLCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Advanced instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public async Task<DescribeListBGPIPInstancesResponse> DescribeListBGPIPInstances(DescribeListBGPIPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPIPInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBGPIPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPIPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Advanced instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public DescribeListBGPIPInstancesResponse DescribeListBGPIPInstancesSync(DescribeListBGPIPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPIPInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBGPIPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPIPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Pro instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public async Task<DescribeListBGPInstancesResponse> DescribeListBGPInstances(DescribeListBGPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBGPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Pro instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public DescribeListBGPInstancesResponse DescribeListBGPInstancesSync(DescribeListBGPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBGPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS IP blocklists/allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeListBlackWhiteIpListResponse> DescribeListBlackWhiteIpList(DescribeListBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeListBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS IP blocklists/allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public DescribeListBlackWhiteIpListResponse DescribeListBlackWhiteIpListSync(DescribeListBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeListBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public async Task<DescribeListDDoSAIResponse> DescribeListDDoSAI(DescribeListDDoSAIRequest req)
        {
             JsonResponseModel<DescribeListDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public DescribeListDDoSAIResponse DescribeListDDoSAISync(DescribeListDDoSAIRequest req)
        {
             JsonResponseModel<DescribeListDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<DescribeListDDoSGeoIPBlockConfigResponse> DescribeListDDoSGeoIPBlockConfig(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public DescribeListDDoSGeoIPBlockConfigResponse DescribeListDDoSGeoIPBlockConfigSync(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<DescribeListDDoSSpeedLimitConfigResponse> DescribeListDDoSSpeedLimitConfig(DescribeListDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public DescribeListDDoSSpeedLimitConfigResponse DescribeListDDoSSpeedLimitConfigSync(DescribeListDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of IP alarm threshold configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public async Task<DescribeListIPAlarmConfigResponse> DescribeListIPAlarmConfig(DescribeListIPAlarmConfigRequest req)
        {
             JsonResponseModel<DescribeListIPAlarmConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListIPAlarmConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListIPAlarmConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of IP alarm threshold configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public DescribeListIPAlarmConfigResponse DescribeListIPAlarmConfigSync(DescribeListIPAlarmConfigRequest req)
        {
             JsonResponseModel<DescribeListIPAlarmConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListIPAlarmConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListIPAlarmConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of forwarding listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public async Task<DescribeListListenerResponse> DescribeListListener(DescribeListListenerRequest req)
        {
             JsonResponseModel<DescribeListListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of forwarding listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public DescribeListListenerResponse DescribeListListenerSync(DescribeListListenerRequest req)
        {
             JsonResponseModel<DescribeListListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public async Task<DescribeListPacketFilterConfigResponse> DescribeListPacketFilterConfig(DescribeListPacketFilterConfigRequest req)
        {
             JsonResponseModel<DescribeListPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public DescribeListPacketFilterConfigResponse DescribeListPacketFilterConfigSync(DescribeListPacketFilterConfigRequest req)
        {
             JsonResponseModel<DescribeListPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of protection threshold configurations for AI protection switch, protection level, and CC threshold switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtectThresholdConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtectThresholdConfigResponse"/></returns>
        public async Task<DescribeListProtectThresholdConfigResponse> DescribeListProtectThresholdConfig(DescribeListProtectThresholdConfigRequest req)
        {
             JsonResponseModel<DescribeListProtectThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListProtectThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtectThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of protection threshold configurations for AI protection switch, protection level, and CC threshold switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtectThresholdConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtectThresholdConfigResponse"/></returns>
        public DescribeListProtectThresholdConfigResponse DescribeListProtectThresholdConfigSync(DescribeListProtectThresholdConfigRequest req)
        {
             JsonResponseModel<DescribeListProtectThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListProtectThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtectThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public async Task<DescribeListProtocolBlockConfigResponse> DescribeListProtocolBlockConfig(DescribeListProtocolBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public DescribeListProtocolBlockConfigResponse DescribeListProtocolBlockConfigSync(DescribeListProtocolBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public async Task<DescribeListSchedulingDomainResponse> DescribeListSchedulingDomain(DescribeListSchedulingDomainRequest req)
        {
             JsonResponseModel<DescribeListSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public DescribeListSchedulingDomainResponse DescribeListSchedulingDomainSync(DescribeListSchedulingDomainRequest req)
        {
             JsonResponseModel<DescribeListSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public async Task<DescribeListWaterPrintConfigResponse> DescribeListWaterPrintConfig(DescribeListWaterPrintConfigRequest req)
        {
             JsonResponseModel<DescribeListWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public DescribeListWaterPrintConfigResponse DescribeListWaterPrintConfigSync(DescribeListWaterPrintConfigRequest req)
        {
             JsonResponseModel<DescribeListWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an Anti-DDoS EIP.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public async Task<DisassociateDDoSEipAddressResponse> DisassociateDDoSEipAddress(DisassociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<DisassociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an Anti-DDoS EIP.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public DisassociateDDoSEipAddressResponse DisassociateDDoSEipAddressSync(DisassociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<DisassociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<ModifyDDoSGeoIPBlockConfigResponse> ModifyDDoSGeoIPBlockConfig(ModifyDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public ModifyDDoSGeoIPBlockConfigResponse ModifyDDoSGeoIPBlockConfigSync(ModifyDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<ModifyDDoSSpeedLimitConfigResponse> ModifyDDoSSpeedLimitConfig(ModifyDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public ModifyDDoSSpeedLimitConfigResponse ModifyDDoSSpeedLimitConfigSync(ModifyDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public async Task<ModifyDomainUsrNameResponse> ModifyDomainUsrName(ModifyDomainUsrNameRequest req)
        {
             JsonResponseModel<ModifyDomainUsrNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainUsrName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainUsrNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public ModifyDomainUsrNameResponse ModifyDomainUsrNameSync(ModifyDomainUsrNameRequest req)
        {
             JsonResponseModel<ModifyDomainUsrNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainUsrName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainUsrNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public async Task<ModifyPacketFilterConfigResponse> ModifyPacketFilterConfig(ModifyPacketFilterConfigRequest req)
        {
             JsonResponseModel<ModifyPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public ModifyPacketFilterConfigResponse ModifyPacketFilterConfigSync(ModifyPacketFilterConfigRequest req)
        {
             JsonResponseModel<ModifyPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

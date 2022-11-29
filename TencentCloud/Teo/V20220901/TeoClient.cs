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

namespace TencentCloud.Teo.V20220901
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Teo.V20220901.Models;

   public class TeoClient : AbstractClient{

       private const string endpoint = "teo.tencentcloudapi.com";
       private const string version = "2022-09-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TeoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TeoClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to bind a site to a plan.
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public async Task<BindZoneToPlanResponse> BindZoneToPlan(BindZoneToPlanRequest req)
        {
             JsonResponseModel<BindZoneToPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindZoneToPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindZoneToPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a site to a plan.
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public BindZoneToPlanResponse BindZoneToPlanSync(BindZoneToPlanRequest req)
        {
             JsonResponseModel<BindZoneToPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindZoneToPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindZoneToPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a certificate.
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateRequest"/></param>
        /// <returns><see cref="CheckCertificateResponse"/></returns>
        public async Task<CheckCertificateResponse> CheckCertificate(CheckCertificateRequest req)
        {
             JsonResponseModel<CheckCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a certificate.
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateRequest"/></param>
        /// <returns><see cref="CheckCertificateResponse"/></returns>
        public CheckCertificateResponse CheckCertificateSync(CheckCertificateRequest req)
        {
             JsonResponseModel<CheckCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public async Task<CreateAliasDomainResponse> CreateAliasDomain(CreateAliasDomainRequest req)
        {
             JsonResponseModel<CreateAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public CreateAliasDomainResponse CreateAliasDomainSync(CreateAliasDomainRequest req)
        {
             JsonResponseModel<CreateAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application proxy.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public async Task<CreateApplicationProxyResponse> CreateApplicationProxy(CreateApplicationProxyRequest req)
        {
             JsonResponseModel<CreateApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application proxy.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public CreateApplicationProxyResponse CreateApplicationProxySync(CreateApplicationProxyRequest req)
        {
             JsonResponseModel<CreateApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public async Task<CreateApplicationProxyRuleResponse> CreateApplicationProxyRule(CreateApplicationProxyRuleRequest req)
        {
             JsonResponseModel<CreateApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public CreateApplicationProxyRuleResponse CreateApplicationProxyRuleSync(CreateApplicationProxyRuleRequest req)
        {
             JsonResponseModel<CreateApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Creates a credential for COS origin-pull.
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public async Task<CreateCredentialResponse> CreateCredential(CreateCredentialRequest req)
        {
             JsonResponseModel<CreateCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Creates a credential for COS origin-pull.
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public CreateCredentialResponse CreateCredentialSync(CreateCredentialRequest req)
        {
             JsonResponseModel<CreateCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom error page.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomErrorPageResponse"/></returns>
        public async Task<CreateCustomErrorPageResponse> CreateCustomErrorPage(CreateCustomErrorPageRequest req)
        {
             JsonResponseModel<CreateCustomErrorPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomErrorPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomErrorPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom error page.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomErrorPageResponse"/></returns>
        public CreateCustomErrorPageResponse CreateCustomErrorPageSync(CreateCustomErrorPageRequest req)
        {
             JsonResponseModel<CreateCustomErrorPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomErrorPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomErrorPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a DNS record.
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public async Task<CreateDnsRecordResponse> CreateDnsRecord(CreateDnsRecordRequest req)
        {
             JsonResponseModel<CreateDnsRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDnsRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDnsRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a DNS record.
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public CreateDnsRecordResponse CreateDnsRecordSync(CreateDnsRecordRequest req)
        {
             JsonResponseModel<CreateDnsRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDnsRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDnsRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateIpTableListRequest"/></param>
        /// <returns><see cref="CreateIpTableListResponse"/></returns>
        public async Task<CreateIpTableListResponse> CreateIpTableList(CreateIpTableListRequest req)
        {
             JsonResponseModel<CreateIpTableListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIpTableList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIpTableListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateIpTableListRequest"/></param>
        /// <returns><see cref="CreateIpTableListResponse"/></returns>
        public CreateIpTableListResponse CreateIpTableListSync(CreateIpTableListRequest req)
        {
             JsonResponseModel<CreateIpTableListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIpTableList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIpTableListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancingRequest"/></param>
        /// <returns><see cref="CreateLoadBalancingResponse"/></returns>
        public async Task<CreateLoadBalancingResponse> CreateLoadBalancing(CreateLoadBalancingRequest req)
        {
             JsonResponseModel<CreateLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancingRequest"/></param>
        /// <returns><see cref="CreateLoadBalancingResponse"/></returns>
        public CreateLoadBalancingResponse CreateLoadBalancingSync(CreateLoadBalancingRequest req)
        {
             JsonResponseModel<CreateLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CLS logset.
        /// </summary>
        /// <param name="req"><see cref="CreateLogSetRequest"/></param>
        /// <returns><see cref="CreateLogSetResponse"/></returns>
        public async Task<CreateLogSetResponse> CreateLogSet(CreateLogSetRequest req)
        {
             JsonResponseModel<CreateLogSetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CLS logset.
        /// </summary>
        /// <param name="req"><see cref="CreateLogSetRequest"/></param>
        /// <returns><see cref="CreateLogSetResponse"/></returns>
        public CreateLogSetResponse CreateLogSetSync(CreateLogSetRequest req)
        {
             JsonResponseModel<CreateLogSetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a shipping task.
        /// </summary>
        /// <param name="req"><see cref="CreateLogTopicTaskRequest"/></param>
        /// <returns><see cref="CreateLogTopicTaskResponse"/></returns>
        public async Task<CreateLogTopicTaskResponse> CreateLogTopicTask(CreateLogTopicTaskRequest req)
        {
             JsonResponseModel<CreateLogTopicTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLogTopicTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogTopicTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a shipping task.
        /// </summary>
        /// <param name="req"><see cref="CreateLogTopicTaskRequest"/></param>
        /// <returns><see cref="CreateLogTopicTaskResponse"/></returns>
        public CreateLogTopicTaskResponse CreateLogTopicTaskSync(CreateLogTopicTaskRequest req)
        {
             JsonResponseModel<CreateLogTopicTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLogTopicTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogTopicTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an origin group.
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public async Task<CreateOriginGroupResponse> CreateOriginGroup(CreateOriginGroupRequest req)
        {
             JsonResponseModel<CreateOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an origin group.
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public CreateOriginGroupResponse CreateOriginGroupSync(CreateOriginGroupRequest req)
        {
             JsonResponseModel<CreateOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to purchase a plan for a new site.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public async Task<CreatePlanForZoneResponse> CreatePlanForZone(CreatePlanForZoneRequest req)
        {
             JsonResponseModel<CreatePlanForZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePlanForZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePlanForZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to purchase a plan for a new site.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public CreatePlanForZoneResponse CreatePlanForZoneSync(CreatePlanForZoneRequest req)
        {
             JsonResponseModel<CreatePlanForZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePlanForZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePlanForZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a pre-warming task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public async Task<CreatePrefetchTaskResponse> CreatePrefetchTask(CreatePrefetchTaskRequest req)
        {
             JsonResponseModel<CreatePrefetchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrefetchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrefetchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a pre-warming task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public CreatePrefetchTaskResponse CreatePrefetchTaskSync(CreatePrefetchTaskRequest req)
        {
             JsonResponseModel<CreatePrefetchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrefetchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrefetchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cache purging task.
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public async Task<CreatePurgeTaskResponse> CreatePurgeTask(CreatePurgeTaskRequest req)
        {
             JsonResponseModel<CreatePurgeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePurgeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePurgeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cache purging task.
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public CreatePurgeTaskResponse CreatePurgeTaskSync(CreatePurgeTaskRequest req)
        {
             JsonResponseModel<CreatePurgeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePurgeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePurgeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a replay task for purging or pre-warming URLs.
        /// </summary>
        /// <param name="req"><see cref="CreateReplayTaskRequest"/></param>
        /// <returns><see cref="CreateReplayTaskResponse"/></returns>
        public async Task<CreateReplayTaskResponse> CreateReplayTask(CreateReplayTaskRequest req)
        {
             JsonResponseModel<CreateReplayTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReplayTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplayTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a replay task for purging or pre-warming URLs.
        /// </summary>
        /// <param name="req"><see cref="CreateReplayTaskRequest"/></param>
        /// <returns><see cref="CreateReplayTaskResponse"/></returns>
        public CreateReplayTaskResponse CreateReplayTaskSync(CreateReplayTaskRequest req)
        {
             JsonResponseModel<CreateReplayTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReplayTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplayTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a rule in the rule engine.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a rule in the rule engine.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom block page.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityDropPageRequest"/></param>
        /// <returns><see cref="CreateSecurityDropPageResponse"/></returns>
        public async Task<CreateSecurityDropPageResponse> CreateSecurityDropPage(CreateSecurityDropPageRequest req)
        {
             JsonResponseModel<CreateSecurityDropPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityDropPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityDropPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom block page.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityDropPageRequest"/></param>
        /// <returns><see cref="CreateSecurityDropPageResponse"/></returns>
        public CreateSecurityDropPageResponse CreateSecurityDropPageSync(CreateSecurityDropPageRequest req)
        {
             JsonResponseModel<CreateSecurityDropPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityDropPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityDropPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a site testing task for a specified domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateSpeedTestingRequest"/></param>
        /// <returns><see cref="CreateSpeedTestingResponse"/></returns>
        public async Task<CreateSpeedTestingResponse> CreateSpeedTesting(CreateSpeedTestingRequest req)
        {
             JsonResponseModel<CreateSpeedTestingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSpeedTesting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSpeedTestingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a site testing task for a specified domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateSpeedTestingRequest"/></param>
        /// <returns><see cref="CreateSpeedTestingResponse"/></returns>
        public CreateSpeedTestingResponse CreateSpeedTestingSync(CreateSpeedTestingRequest req)
        {
             JsonResponseModel<CreateSpeedTestingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSpeedTesting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSpeedTestingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to access a new site.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public async Task<CreateZoneResponse> CreateZone(CreateZoneRequest req)
        {
             JsonResponseModel<CreateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to access a new site.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public CreateZoneResponse CreateZoneSync(CreateZoneRequest req)
        {
             JsonResponseModel<CreateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public async Task<DeleteAliasDomainResponse> DeleteAliasDomain(DeleteAliasDomainRequest req)
        {
             JsonResponseModel<DeleteAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public DeleteAliasDomainResponse DeleteAliasDomainSync(DeleteAliasDomainRequest req)
        {
             JsonResponseModel<DeleteAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an application proxy.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public async Task<DeleteApplicationProxyResponse> DeleteApplicationProxy(DeleteApplicationProxyRequest req)
        {
             JsonResponseModel<DeleteApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an application proxy.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public DeleteApplicationProxyResponse DeleteApplicationProxySync(DeleteApplicationProxyRequest req)
        {
             JsonResponseModel<DeleteApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public async Task<DeleteApplicationProxyRuleResponse> DeleteApplicationProxyRule(DeleteApplicationProxyRuleRequest req)
        {
             JsonResponseModel<DeleteApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public DeleteApplicationProxyRuleResponse DeleteApplicationProxyRuleSync(DeleteApplicationProxyRuleRequest req)
        {
             JsonResponseModel<DeleteApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete DNS records in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public async Task<DeleteDnsRecordsResponse> DeleteDnsRecords(DeleteDnsRecordsRequest req)
        {
             JsonResponseModel<DeleteDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete DNS records in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public DeleteDnsRecordsResponse DeleteDnsRecordsSync(DeleteDnsRecordsRequest req)
        {
             JsonResponseModel<DeleteDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancingRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancingResponse"/></returns>
        public async Task<DeleteLoadBalancingResponse> DeleteLoadBalancing(DeleteLoadBalancingRequest req)
        {
             JsonResponseModel<DeleteLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancingRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancingResponse"/></returns>
        public DeleteLoadBalancingResponse DeleteLoadBalancingSync(DeleteLoadBalancingRequest req)
        {
             JsonResponseModel<DeleteLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a shipping task.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogTopicTaskRequest"/></param>
        /// <returns><see cref="DeleteLogTopicTaskResponse"/></returns>
        public async Task<DeleteLogTopicTaskResponse> DeleteLogTopicTask(DeleteLogTopicTaskRequest req)
        {
             JsonResponseModel<DeleteLogTopicTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogTopicTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogTopicTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a shipping task.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogTopicTaskRequest"/></param>
        /// <returns><see cref="DeleteLogTopicTaskResponse"/></returns>
        public DeleteLogTopicTaskResponse DeleteLogTopicTaskSync(DeleteLogTopicTaskRequest req)
        {
             JsonResponseModel<DeleteLogTopicTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogTopicTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogTopicTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an origin group.
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public async Task<DeleteOriginGroupResponse> DeleteOriginGroup(DeleteOriginGroupRequest req)
        {
             JsonResponseModel<DeleteOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an origin group.
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public DeleteOriginGroupResponse DeleteOriginGroupSync(DeleteOriginGroupRequest req)
        {
             JsonResponseModel<DeleteOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete rules from the rule engine.
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public async Task<DeleteRulesResponse> DeleteRules(DeleteRulesRequest req)
        {
             JsonResponseModel<DeleteRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete rules from the rule engine.
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public DeleteRulesResponse DeleteRulesSync(DeleteRulesRequest req)
        {
             JsonResponseModel<DeleteRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a site.
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public async Task<DeleteZoneResponse> DeleteZone(DeleteZoneRequest req)
        {
             JsonResponseModel<DeleteZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a site.
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public DeleteZoneResponse DeleteZoneSync(DeleteZoneRequest req)
        {
             JsonResponseModel<DeleteZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query available shipping entities.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddableEntityListRequest"/></param>
        /// <returns><see cref="DescribeAddableEntityListResponse"/></returns>
        public async Task<DescribeAddableEntityListResponse> DescribeAddableEntityList(DescribeAddableEntityListRequest req)
        {
             JsonResponseModel<DescribeAddableEntityListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddableEntityList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddableEntityListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query available shipping entities.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddableEntityListRequest"/></param>
        /// <returns><see cref="DescribeAddableEntityListResponse"/></returns>
        public DescribeAddableEntityListResponse DescribeAddableEntityListSync(DescribeAddableEntityListRequest req)
        {
             JsonResponseModel<DescribeAddableEntityListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddableEntityList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddableEntityListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of alias domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public async Task<DescribeAliasDomainsResponse> DescribeAliasDomains(DescribeAliasDomainsRequest req)
        {
             JsonResponseModel<DescribeAliasDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAliasDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAliasDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of alias domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public DescribeAliasDomainsResponse DescribeAliasDomainsSync(DescribeAliasDomainsRequest req)
        {
             JsonResponseModel<DescribeAliasDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAliasDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAliasDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of application proxies.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public async Task<DescribeApplicationProxiesResponse> DescribeApplicationProxies(DescribeApplicationProxiesRequest req)
        {
             JsonResponseModel<DescribeApplicationProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of application proxies.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public DescribeApplicationProxiesResponse DescribeApplicationProxiesSync(DescribeApplicationProxiesRequest req)
        {
             JsonResponseModel<DescribeApplicationProxiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query plan options available for purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public async Task<DescribeAvailablePlansResponse> DescribeAvailablePlans(DescribeAvailablePlansRequest req)
        {
             JsonResponseModel<DescribeAvailablePlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailablePlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailablePlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query plan options available for purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public DescribeAvailablePlansResponse DescribeAvailablePlansSync(DescribeAvailablePlansRequest req)
        {
             JsonResponseModel<DescribeAvailablePlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailablePlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailablePlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of bot attackers.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotClientIpListRequest"/></param>
        /// <returns><see cref="DescribeBotClientIpListResponse"/></returns>
        public async Task<DescribeBotClientIpListResponse> DescribeBotClientIpList(DescribeBotClientIpListRequest req)
        {
             JsonResponseModel<DescribeBotClientIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBotClientIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotClientIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of bot attackers.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotClientIpListRequest"/></param>
        /// <returns><see cref="DescribeBotClientIpListResponse"/></returns>
        public DescribeBotClientIpListResponse DescribeBotClientIpListSync(DescribeBotClientIpListRequest req)
        {
             JsonResponseModel<DescribeBotClientIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBotClientIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotClientIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the bot attack data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotDataRequest"/></param>
        /// <returns><see cref="DescribeBotDataResponse"/></returns>
        public async Task<DescribeBotDataResponse> DescribeBotData(DescribeBotDataRequest req)
        {
             JsonResponseModel<DescribeBotDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the bot attack data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotDataRequest"/></param>
        /// <returns><see cref="DescribeBotDataResponse"/></returns>
        public DescribeBotDataResponse DescribeBotDataSync(DescribeBotDataRequest req)
        {
             JsonResponseModel<DescribeBotDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a hit bot security rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeBotHitRuleDetailResponse"/></returns>
        public async Task<DescribeBotHitRuleDetailResponse> DescribeBotHitRuleDetail(DescribeBotHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeBotHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBotHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a hit bot security rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeBotHitRuleDetailResponse"/></returns>
        public DescribeBotHitRuleDetailResponse DescribeBotHitRuleDetailSync(DescribeBotHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeBotHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBotHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query bot attack logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotLogRequest"/></param>
        /// <returns><see cref="DescribeBotLogResponse"/></returns>
        public async Task<DescribeBotLogResponse> DescribeBotLog(DescribeBotLogRequest req)
        {
             JsonResponseModel<DescribeBotLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBotLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query bot attack logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotLogRequest"/></param>
        /// <returns><see cref="DescribeBotLogResponse"/></returns>
        public DescribeBotLogResponse DescribeBotLogSync(DescribeBotLogRequest req)
        {
             JsonResponseModel<DescribeBotLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBotLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a bot managed rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeBotManagedRulesResponse"/></returns>
        public async Task<DescribeBotManagedRulesResponse> DescribeBotManagedRules(DescribeBotManagedRulesRequest req)
        {
             JsonResponseModel<DescribeBotManagedRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBotManagedRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotManagedRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a bot managed rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeBotManagedRulesResponse"/></returns>
        public DescribeBotManagedRulesResponse DescribeBotManagedRulesSync(DescribeBotManagedRulesRequest req)
        {
             JsonResponseModel<DescribeBotManagedRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBotManagedRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotManagedRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the top-ranked bot attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotTopDataRequest"/></param>
        /// <returns><see cref="DescribeBotTopDataResponse"/></returns>
        public async Task<DescribeBotTopDataResponse> DescribeBotTopData(DescribeBotTopDataRequest req)
        {
             JsonResponseModel<DescribeBotTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBotTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the top-ranked bot attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotTopDataRequest"/></param>
        /// <returns><see cref="DescribeBotTopDataResponse"/></returns>
        public DescribeBotTopDataResponse DescribeBotTopDataSync(DescribeBotTopDataRequest req)
        {
             JsonResponseModel<DescribeBotTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBotTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of blocked clients.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientRuleListRequest"/></param>
        /// <returns><see cref="DescribeClientRuleListResponse"/></returns>
        public async Task<DescribeClientRuleListResponse> DescribeClientRuleList(DescribeClientRuleListRequest req)
        {
             JsonResponseModel<DescribeClientRuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClientRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of blocked clients.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientRuleListRequest"/></param>
        /// <returns><see cref="DescribeClientRuleListResponse"/></returns>
        public DescribeClientRuleListResponse DescribeClientRuleListSync(DescribeClientRuleListRequest req)
        {
             JsonResponseModel<DescribeClientRuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClientRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query content management quotas.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public async Task<DescribeContentQuotaResponse> DescribeContentQuota(DescribeContentQuotaRequest req)
        {
             JsonResponseModel<DescribeContentQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContentQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query content management quotas.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public DescribeContentQuotaResponse DescribeContentQuotaSync(DescribeContentQuotaRequest req)
        {
             JsonResponseModel<DescribeContentQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContentQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the DDoS attack data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public async Task<DescribeDDoSAttackDataResponse> DescribeDDoSAttackData(DescribeDDoSAttackDataRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the DDoS attack data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public DescribeDDoSAttackDataResponse DescribeDDoSAttackDataSync(DescribeDDoSAttackDataRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of DDoS attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public async Task<DescribeDDoSAttackEventResponse> DescribeDDoSAttackEvent(DescribeDDoSAttackEventRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of DDoS attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public DescribeDDoSAttackEventResponse DescribeDDoSAttackEventSync(DescribeDDoSAttackEventRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a DDoS attack event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventDetailResponse"/></returns>
        public async Task<DescribeDDoSAttackEventDetailResponse> DescribeDDoSAttackEventDetail(DescribeDDoSAttackEventDetailRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackEventDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a DDoS attack event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventDetailResponse"/></returns>
        public DescribeDDoSAttackEventDetailResponse DescribeDDoSAttackEventDetailSync(DescribeDDoSAttackEventDetailRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackEventDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of DDoS attackers.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceEventResponse"/></returns>
        public async Task<DescribeDDoSAttackSourceEventResponse> DescribeDDoSAttackSourceEvent(DescribeDDoSAttackSourceEventRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackSourceEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackSourceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackSourceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of DDoS attackers.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceEventResponse"/></returns>
        public DescribeDDoSAttackSourceEventResponse DescribeDDoSAttackSourceEventSync(DescribeDDoSAttackSourceEventRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackSourceEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackSourceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackSourceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the top-ranked DDoS attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public async Task<DescribeDDoSAttackTopDataResponse> DescribeDDoSAttackTopData(DescribeDDoSAttackTopDataRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the top-ranked DDoS attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public DescribeDDoSAttackTopDataResponse DescribeDDoSAttackTopDataSync(DescribeDDoSAttackTopDataRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of DDoS blocking data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlockListRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlockListResponse"/></returns>
        public async Task<DescribeDDoSBlockListResponse> DescribeDDoSBlockList(DescribeDDoSBlockListRequest req)
        {
             JsonResponseModel<DescribeDDoSBlockListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of DDoS blocking data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlockListRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlockListResponse"/></returns>
        public DescribeDDoSBlockListResponse DescribeDDoSBlockListSync(DescribeDDoSBlockListRequest req)
        {
             JsonResponseModel<DescribeDDoSBlockListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of large attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSMajorAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSMajorAttackEventResponse"/></returns>
        public async Task<DescribeDDoSMajorAttackEventResponse> DescribeDDoSMajorAttackEvent(DescribeDDoSMajorAttackEventRequest req)
        {
             JsonResponseModel<DescribeDDoSMajorAttackEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSMajorAttackEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSMajorAttackEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of large attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSMajorAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSMajorAttackEventResponse"/></returns>
        public DescribeDDoSMajorAttackEventResponse DescribeDDoSMajorAttackEventSync(DescribeDDoSMajorAttackEventRequest req)
        {
             JsonResponseModel<DescribeDDoSMajorAttackEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSMajorAttackEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSMajorAttackEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the DDoS protection configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public async Task<DescribeDDoSPolicyResponse> DescribeDDoSPolicy(DescribeDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the DDoS protection configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public DescribeDDoSPolicyResponse DescribeDDoSPolicySync(DescribeDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a list of default certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public async Task<DescribeDefaultCertificatesResponse> DescribeDefaultCertificates(DescribeDefaultCertificatesRequest req)
        {
             JsonResponseModel<DescribeDefaultCertificatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a list of default certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public DescribeDefaultCertificatesResponse DescribeDefaultCertificatesSync(DescribeDefaultCertificatesRequest req)
        {
             JsonResponseModel<DescribeDefaultCertificatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get DNS requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsDataRequest"/></param>
        /// <returns><see cref="DescribeDnsDataResponse"/></returns>
        public async Task<DescribeDnsDataResponse> DescribeDnsData(DescribeDnsDataRequest req)
        {
             JsonResponseModel<DescribeDnsDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDnsData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnsDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get DNS requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsDataRequest"/></param>
        /// <returns><see cref="DescribeDnsDataResponse"/></returns>
        public DescribeDnsDataResponse DescribeDnsDataSync(DescribeDnsDataRequest req)
        {
             JsonResponseModel<DescribeDnsDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDnsData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnsDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query DNS records. Paging, sorting and filtering are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public async Task<DescribeDnsRecordsResponse> DescribeDnsRecords(DescribeDnsRecordsRequest req)
        {
             JsonResponseModel<DescribeDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query DNS records. Paging, sorting and filtering are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public DescribeDnsRecordsResponse DescribeDnsRecordsSync(DescribeDnsRecordsRequest req)
        {
             JsonResponseModel<DescribeDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query DNSSEC information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnssecRequest"/></param>
        /// <returns><see cref="DescribeDnssecResponse"/></returns>
        public async Task<DescribeDnssecResponse> DescribeDnssec(DescribeDnssecRequest req)
        {
             JsonResponseModel<DescribeDnssecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDnssec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnssecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query DNSSEC information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnssecRequest"/></param>
        /// <returns><see cref="DescribeDnssecResponse"/></returns>
        public DescribeDnssecResponse DescribeDnssecSync(DescribeDnssecRequest req)
        {
             JsonResponseModel<DescribeDnssecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDnssec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnssecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query detailed domain name configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public async Task<DescribeHostsSettingResponse> DescribeHostsSetting(DescribeHostsSettingRequest req)
        {
             JsonResponseModel<DescribeHostsSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostsSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query detailed domain name configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public DescribeHostsSettingResponse DescribeHostsSettingSync(DescribeHostsSettingRequest req)
        {
             JsonResponseModel<DescribeHostsSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostsSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the verification information of a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public async Task<DescribeIdentificationsResponse> DescribeIdentifications(DescribeIdentificationsRequest req)
        {
             JsonResponseModel<DescribeIdentificationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIdentifications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdentificationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the verification information of a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public DescribeIdentificationsResponse DescribeIdentificationsSync(DescribeIdentificationsRequest req)
        {
             JsonResponseModel<DescribeIdentificationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIdentifications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdentificationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain a list of CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingResponse"/></returns>
        public async Task<DescribeLoadBalancingResponse> DescribeLoadBalancing(DescribeLoadBalancingRequest req)
        {
             JsonResponseModel<DescribeLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain a list of CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingResponse"/></returns>
        public DescribeLoadBalancingResponse DescribeLoadBalancingSync(DescribeLoadBalancingRequest req)
        {
             JsonResponseModel<DescribeLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of logsets.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSetsRequest"/></param>
        /// <returns><see cref="DescribeLogSetsResponse"/></returns>
        public async Task<DescribeLogSetsResponse> DescribeLogSets(DescribeLogSetsRequest req)
        {
             JsonResponseModel<DescribeLogSetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogSets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogSetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of logsets.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSetsRequest"/></param>
        /// <returns><see cref="DescribeLogSetsResponse"/></returns>
        public DescribeLogSetsResponse DescribeLogSetsSync(DescribeLogSetsRequest req)
        {
             JsonResponseModel<DescribeLogSetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogSets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogSetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a shipping task.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTopicTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeLogTopicTaskDetailResponse"/></returns>
        public async Task<DescribeLogTopicTaskDetailResponse> DescribeLogTopicTaskDetail(DescribeLogTopicTaskDetailRequest req)
        {
             JsonResponseModel<DescribeLogTopicTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogTopicTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTopicTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a shipping task.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTopicTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeLogTopicTaskDetailResponse"/></returns>
        public DescribeLogTopicTaskDetailResponse DescribeLogTopicTaskDetailSync(DescribeLogTopicTaskDetailRequest req)
        {
             JsonResponseModel<DescribeLogTopicTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogTopicTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTopicTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of shipping tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTopicTasksRequest"/></param>
        /// <returns><see cref="DescribeLogTopicTasksResponse"/></returns>
        public async Task<DescribeLogTopicTasksResponse> DescribeLogTopicTasks(DescribeLogTopicTasksRequest req)
        {
             JsonResponseModel<DescribeLogTopicTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogTopicTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTopicTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of shipping tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTopicTasksRequest"/></param>
        /// <returns><see cref="DescribeLogTopicTasksResponse"/></returns>
        public DescribeLogTopicTasksResponse DescribeLogTopicTasksSync(DescribeLogTopicTasksRequest req)
        {
             JsonResponseModel<DescribeLogTopicTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogTopicTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTopicTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain a list of origin groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public async Task<DescribeOriginGroupResponse> DescribeOriginGroup(DescribeOriginGroupRequest req)
        {
             JsonResponseModel<DescribeOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain a list of origin groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public DescribeOriginGroupResponse DescribeOriginGroupSync(DescribeOriginGroupRequest req)
        {
             JsonResponseModel<DescribeOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the L7 traffic summary statistics recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public async Task<DescribeOverviewL7DataResponse> DescribeOverviewL7Data(DescribeOverviewL7DataRequest req)
        {
             JsonResponseModel<DescribeOverviewL7DataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewL7Data");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewL7DataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the L7 traffic summary statistics recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public DescribeOverviewL7DataResponse DescribeOverviewL7DataSync(DescribeOverviewL7DataRequest req)
        {
             JsonResponseModel<DescribeOverviewL7DataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewL7Data");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewL7DataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the pre-warming task status.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public async Task<DescribePrefetchTasksResponse> DescribePrefetchTasks(DescribePrefetchTasksRequest req)
        {
             JsonResponseModel<DescribePrefetchTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrefetchTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrefetchTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the pre-warming task status.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public DescribePrefetchTasksResponse DescribePrefetchTasksSync(DescribePrefetchTasksRequest req)
        {
             JsonResponseModel<DescribePrefetchTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrefetchTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrefetchTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Querying the cache purging history
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public async Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Querying the cache purging history
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an intelligent rate limiting rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeRateLimitIntelligenceRuleRequest"/></param>
        /// <returns><see cref="DescribeRateLimitIntelligenceRuleResponse"/></returns>
        public async Task<DescribeRateLimitIntelligenceRuleResponse> DescribeRateLimitIntelligenceRule(DescribeRateLimitIntelligenceRuleRequest req)
        {
             JsonResponseModel<DescribeRateLimitIntelligenceRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRateLimitIntelligenceRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRateLimitIntelligenceRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an intelligent rate limiting rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeRateLimitIntelligenceRuleRequest"/></param>
        /// <returns><see cref="DescribeRateLimitIntelligenceRuleResponse"/></returns>
        public DescribeRateLimitIntelligenceRuleResponse DescribeRateLimitIntelligenceRuleSync(DescribeRateLimitIntelligenceRuleRequest req)
        {
             JsonResponseModel<DescribeRateLimitIntelligenceRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRateLimitIntelligenceRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRateLimitIntelligenceRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the rules in the rule engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public async Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the rules in the rule engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the list of the settings of the rule engine that can be used for request match and their detailed recommended configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public async Task<DescribeRulesSettingResponse> DescribeRulesSetting(DescribeRulesSettingRequest req)
        {
             JsonResponseModel<DescribeRulesSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRulesSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the list of the settings of the rule engine that can be used for request match and their detailed recommended configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public DescribeRulesSettingResponse DescribeRulesSettingSync(DescribeRulesSettingRequest req)
        {
             JsonResponseModel<DescribeRulesSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRulesSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain a managed rule group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupManagedRulesResponse"/></returns>
        public async Task<DescribeSecurityGroupManagedRulesResponse> DescribeSecurityGroupManagedRules(DescribeSecurityGroupManagedRulesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupManagedRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupManagedRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupManagedRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain a managed rule group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupManagedRulesResponse"/></returns>
        public DescribeSecurityGroupManagedRulesResponse DescribeSecurityGroupManagedRulesSync(DescribeSecurityGroupManagedRulesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupManagedRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupManagedRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupManagedRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security protection configuration. You must either specify "ZoneId+Entity" or "TemplateId".
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public async Task<DescribeSecurityPolicyResponse> DescribeSecurityPolicy(DescribeSecurityPolicyRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security protection configuration. You must either specify "ZoneId+Entity" or "TemplateId".
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public DescribeSecurityPolicyResponse DescribeSecurityPolicySync(DescribeSecurityPolicyRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all protected subdomain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyListRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyListResponse"/></returns>
        public async Task<DescribeSecurityPolicyListResponse> DescribeSecurityPolicyList(DescribeSecurityPolicyListRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all protected subdomain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyListRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyListResponse"/></returns>
        public DescribeSecurityPolicyListResponse DescribeSecurityPolicyListSync(DescribeSecurityPolicyListRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query information of all regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRegionsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRegionsResponse"/></returns>
        public async Task<DescribeSecurityPolicyRegionsResponse> DescribeSecurityPolicyRegions(DescribeSecurityPolicyRegionsRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicyRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query information of all regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRegionsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRegionsResponse"/></returns>
        public DescribeSecurityPolicyRegionsResponse DescribeSecurityPolicyRegionsSync(DescribeSecurityPolicyRegionsRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicyRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query user profiling rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPortraitRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPortraitRulesResponse"/></returns>
        public async Task<DescribeSecurityPortraitRulesResponse> DescribeSecurityPortraitRules(DescribeSecurityPortraitRulesRequest req)
        {
             JsonResponseModel<DescribeSecurityPortraitRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPortraitRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPortraitRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query user profiling rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPortraitRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPortraitRulesResponse"/></returns>
        public DescribeSecurityPortraitRulesResponse DescribeSecurityPortraitRulesSync(DescribeSecurityPortraitRulesRequest req)
        {
             JsonResponseModel<DescribeSecurityPortraitRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPortraitRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPortraitRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a security rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRuleIdRequest"/></param>
        /// <returns><see cref="DescribeSecurityRuleIdResponse"/></returns>
        public async Task<DescribeSecurityRuleIdResponse> DescribeSecurityRuleId(DescribeSecurityRuleIdRequest req)
        {
             JsonResponseModel<DescribeSecurityRuleIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityRuleId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityRuleIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a security rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRuleIdRequest"/></param>
        /// <returns><see cref="DescribeSecurityRuleIdResponse"/></returns>
        public DescribeSecurityRuleIdResponse DescribeSecurityRuleIdSync(DescribeSecurityRuleIdRequest req)
        {
             JsonResponseModel<DescribeSecurityRuleIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityRuleId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityRuleIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of L7 dimensional data.
        /// </summary>
        /// <param name="req"><see cref="DescribeSingleL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeSingleL7AnalysisDataResponse"/></returns>
        public async Task<DescribeSingleL7AnalysisDataResponse> DescribeSingleL7AnalysisData(DescribeSingleL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeSingleL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSingleL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSingleL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of L7 dimensional data.
        /// </summary>
        /// <param name="req"><see cref="DescribeSingleL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeSingleL7AnalysisDataResponse"/></returns>
        public DescribeSingleL7AnalysisDataResponse DescribeSingleL7AnalysisDataSync(DescribeSingleL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeSingleL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSingleL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSingleL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the site’s load speed across regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingDetailsRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingDetailsResponse"/></returns>
        public async Task<DescribeSpeedTestingDetailsResponse> DescribeSpeedTestingDetails(DescribeSpeedTestingDetailsRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpeedTestingDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the site’s load speed across regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingDetailsRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingDetailsResponse"/></returns>
        public DescribeSpeedTestingDetailsResponse DescribeSpeedTestingDetailsSync(DescribeSpeedTestingDetailsRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpeedTestingDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of a site test.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingMetricDataRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingMetricDataResponse"/></returns>
        public async Task<DescribeSpeedTestingMetricDataResponse> DescribeSpeedTestingMetricData(DescribeSpeedTestingMetricDataRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingMetricDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpeedTestingMetricData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingMetricDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of a site test.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingMetricDataRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingMetricDataResponse"/></returns>
        public DescribeSpeedTestingMetricDataResponse DescribeSpeedTestingMetricDataSync(DescribeSpeedTestingMetricDataRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingMetricDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpeedTestingMetricData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingMetricDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quota limit on site tests.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingQuotaRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingQuotaResponse"/></returns>
        public async Task<DescribeSpeedTestingQuotaResponse> DescribeSpeedTestingQuota(DescribeSpeedTestingQuotaRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpeedTestingQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quota limit on site tests.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingQuotaRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingQuotaResponse"/></returns>
        public DescribeSpeedTestingQuotaResponse DescribeSpeedTestingQuotaSync(DescribeSpeedTestingQuotaRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpeedTestingQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of L4 traffic data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public async Task<DescribeTimingL4DataResponse> DescribeTimingL4Data(DescribeTimingL4DataRequest req)
        {
             JsonResponseModel<DescribeTimingL4DataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTimingL4Data");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL4DataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of L4 traffic data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public DescribeTimingL4DataResponse DescribeTimingL4DataSync(DescribeTimingL4DataRequest req)
        {
             JsonResponseModel<DescribeTimingL4DataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTimingL4Data");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL4DataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the L7 data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public async Task<DescribeTimingL7AnalysisDataResponse> DescribeTimingL7AnalysisData(DescribeTimingL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeTimingL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTimingL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the L7 data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public DescribeTimingL7AnalysisDataResponse DescribeTimingL7AnalysisDataSync(DescribeTimingL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeTimingL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTimingL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the time-series L7 cached data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public async Task<DescribeTimingL7CacheDataResponse> DescribeTimingL7CacheData(DescribeTimingL7CacheDataRequest req)
        {
             JsonResponseModel<DescribeTimingL7CacheDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTimingL7CacheData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL7CacheDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the time-series L7 cached data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public DescribeTimingL7CacheDataResponse DescribeTimingL7CacheDataSync(DescribeTimingL7CacheDataRequest req)
        {
             JsonResponseModel<DescribeTimingL7CacheDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTimingL7CacheData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL7CacheDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the top-ranked L7 traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public async Task<DescribeTopL7AnalysisDataResponse> DescribeTopL7AnalysisData(DescribeTopL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeTopL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the top-ranked L7 traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public DescribeTopL7AnalysisDataResponse DescribeTopL7AnalysisDataSync(DescribeTopL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeTopL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the cached L7 top-ranked data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public async Task<DescribeTopL7CacheDataResponse> DescribeTopL7CacheData(DescribeTopL7CacheDataRequest req)
        {
             JsonResponseModel<DescribeTopL7CacheDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopL7CacheData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopL7CacheDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the cached L7 top-ranked data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public DescribeTopL7CacheDataResponse DescribeTopL7CacheDataSync(DescribeTopL7CacheDataRequest req)
        {
             JsonResponseModel<DescribeTopL7CacheDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopL7CacheData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopL7CacheDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the WAF attack data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesDataRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesDataResponse"/></returns>
        public async Task<DescribeWebManagedRulesDataResponse> DescribeWebManagedRulesData(DescribeWebManagedRulesDataRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebManagedRulesData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the WAF attack data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesDataRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesDataResponse"/></returns>
        public DescribeWebManagedRulesDataResponse DescribeWebManagedRulesDataSync(DescribeWebManagedRulesDataRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebManagedRulesData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a hit WAF security rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesHitRuleDetailResponse"/></returns>
        public async Task<DescribeWebManagedRulesHitRuleDetailResponse> DescribeWebManagedRulesHitRuleDetail(DescribeWebManagedRulesHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebManagedRulesHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a hit WAF security rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesHitRuleDetailResponse"/></returns>
        public DescribeWebManagedRulesHitRuleDetailResponse DescribeWebManagedRulesHitRuleDetailSync(DescribeWebManagedRulesHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebManagedRulesHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query web attack logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesLogRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesLogResponse"/></returns>
        public async Task<DescribeWebManagedRulesLogResponse> DescribeWebManagedRulesLog(DescribeWebManagedRulesLogRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebManagedRulesLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query web attack logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesLogRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesLogResponse"/></returns>
        public DescribeWebManagedRulesLogResponse DescribeWebManagedRulesLogSync(DescribeWebManagedRulesLogRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebManagedRulesLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CC attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionAttackEventsResponse"/></returns>
        public async Task<DescribeWebProtectionAttackEventsResponse> DescribeWebProtectionAttackEvents(DescribeWebProtectionAttackEventsRequest req)
        {
             JsonResponseModel<DescribeWebProtectionAttackEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionAttackEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionAttackEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CC attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionAttackEventsResponse"/></returns>
        public DescribeWebProtectionAttackEventsResponse DescribeWebProtectionAttackEventsSync(DescribeWebProtectionAttackEventsRequest req)
        {
             JsonResponseModel<DescribeWebProtectionAttackEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionAttackEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionAttackEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of CC attackers.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionClientIpListRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionClientIpListResponse"/></returns>
        public async Task<DescribeWebProtectionClientIpListResponse> DescribeWebProtectionClientIpList(DescribeWebProtectionClientIpListRequest req)
        {
             JsonResponseModel<DescribeWebProtectionClientIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionClientIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionClientIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of CC attackers.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionClientIpListRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionClientIpListResponse"/></returns>
        public DescribeWebProtectionClientIpListResponse DescribeWebProtectionClientIpListSync(DescribeWebProtectionClientIpListRequest req)
        {
             JsonResponseModel<DescribeWebProtectionClientIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionClientIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionClientIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CC protection data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionDataResponse"/></returns>
        public async Task<DescribeWebProtectionDataResponse> DescribeWebProtectionData(DescribeWebProtectionDataRequest req)
        {
             JsonResponseModel<DescribeWebProtectionDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CC protection data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionDataResponse"/></returns>
        public DescribeWebProtectionDataResponse DescribeWebProtectionDataSync(DescribeWebProtectionDataRequest req)
        {
             JsonResponseModel<DescribeWebProtectionDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a hit CC protection rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionHitRuleDetailResponse"/></returns>
        public async Task<DescribeWebProtectionHitRuleDetailResponse> DescribeWebProtectionHitRuleDetail(DescribeWebProtectionHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeWebProtectionHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a hit CC protection rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionHitRuleDetailResponse"/></returns>
        public DescribeWebProtectionHitRuleDetailResponse DescribeWebProtectionHitRuleDetailSync(DescribeWebProtectionHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeWebProtectionHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the top-ranked CC protection data.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionTopDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionTopDataResponse"/></returns>
        public async Task<DescribeWebProtectionTopDataResponse> DescribeWebProtectionTopData(DescribeWebProtectionTopDataRequest req)
        {
             JsonResponseModel<DescribeWebProtectionTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the top-ranked CC protection data.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionTopDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionTopDataResponse"/></returns>
        public DescribeWebProtectionTopDataResponse DescribeWebProtectionTopDataSync(DescribeWebProtectionTopDataRequest req)
        {
             JsonResponseModel<DescribeWebProtectionTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all DDoS mitigation configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeZoneDDoSPolicyResponse"/></returns>
        public async Task<DescribeZoneDDoSPolicyResponse> DescribeZoneDDoSPolicy(DescribeZoneDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeZoneDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all DDoS mitigation configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeZoneDDoSPolicyResponse"/></returns>
        public DescribeZoneDDoSPolicyResponse DescribeZoneDDoSPolicySync(DescribeZoneDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeZoneDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the site configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public async Task<DescribeZoneSettingResponse> DescribeZoneSetting(DescribeZoneSettingRequest req)
        {
             JsonResponseModel<DescribeZoneSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the site configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public DescribeZoneSettingResponse DescribeZoneSettingSync(DescribeZoneSettingRequest req)
        {
             JsonResponseModel<DescribeZoneSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of user sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of user sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download L4 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public async Task<DownloadL4LogsResponse> DownloadL4Logs(DownloadL4LogsRequest req)
        {
             JsonResponseModel<DownloadL4LogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadL4Logs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadL4LogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download L4 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public DownloadL4LogsResponse DownloadL4LogsSync(DownloadL4LogsRequest req)
        {
             JsonResponseModel<DownloadL4LogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadL4Logs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadL4LogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download L7 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public async Task<DownloadL7LogsResponse> DownloadL7Logs(DownloadL7LogsRequest req)
        {
             JsonResponseModel<DownloadL7LogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadL7Logs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadL7LogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download L7 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public DownloadL7LogsResponse DownloadL7LogsSync(DownloadL7LogsRequest req)
        {
             JsonResponseModel<DownloadL7LogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadL7Logs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadL7LogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify ownership of the site.
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public async Task<IdentifyZoneResponse> IdentifyZone(IdentifyZoneRequest req)
        {
             JsonResponseModel<IdentifyZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IdentifyZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdentifyZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify ownership of the site.
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public IdentifyZoneResponse IdentifyZoneSync(IdentifyZoneRequest req)
        {
             JsonResponseModel<IdentifyZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IdentifyZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdentifyZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify alarm configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmConfigRequest"/></param>
        /// <returns><see cref="ModifyAlarmConfigResponse"/></returns>
        public async Task<ModifyAlarmConfigResponse> ModifyAlarmConfig(ModifyAlarmConfigRequest req)
        {
             JsonResponseModel<ModifyAlarmConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify alarm configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmConfigRequest"/></param>
        /// <returns><see cref="ModifyAlarmConfigResponse"/></returns>
        public ModifyAlarmConfigResponse ModifyAlarmConfigSync(ModifyAlarmConfigRequest req)
        {
             JsonResponseModel<ModifyAlarmConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default alarm threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmDefaultThresholdRequest"/></param>
        /// <returns><see cref="ModifyAlarmDefaultThresholdResponse"/></returns>
        public async Task<ModifyAlarmDefaultThresholdResponse> ModifyAlarmDefaultThreshold(ModifyAlarmDefaultThresholdRequest req)
        {
             JsonResponseModel<ModifyAlarmDefaultThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmDefaultThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmDefaultThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default alarm threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmDefaultThresholdRequest"/></param>
        /// <returns><see cref="ModifyAlarmDefaultThresholdResponse"/></returns>
        public ModifyAlarmDefaultThresholdResponse ModifyAlarmDefaultThresholdSync(ModifyAlarmDefaultThresholdRequest req)
        {
             JsonResponseModel<ModifyAlarmDefaultThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmDefaultThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmDefaultThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public async Task<ModifyAliasDomainResponse> ModifyAliasDomain(ModifyAliasDomainRequest req)
        {
             JsonResponseModel<ModifyAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public ModifyAliasDomainResponse ModifyAliasDomainSync(ModifyAliasDomainRequest req)
        {
             JsonResponseModel<ModifyAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public async Task<ModifyAliasDomainStatusResponse> ModifyAliasDomainStatus(ModifyAliasDomainStatusRequest req)
        {
             JsonResponseModel<ModifyAliasDomainStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAliasDomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAliasDomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public ModifyAliasDomainStatusResponse ModifyAliasDomainStatusSync(ModifyAliasDomainStatusRequest req)
        {
             JsonResponseModel<ModifyAliasDomainStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAliasDomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAliasDomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an application proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public async Task<ModifyApplicationProxyResponse> ModifyApplicationProxy(ModifyApplicationProxyRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an application proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public ModifyApplicationProxyResponse ModifyApplicationProxySync(ModifyApplicationProxyRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public async Task<ModifyApplicationProxyRuleResponse> ModifyApplicationProxyRule(ModifyApplicationProxyRuleRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public ModifyApplicationProxyRuleResponse ModifyApplicationProxyRuleSync(ModifyApplicationProxyRuleRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public async Task<ModifyApplicationProxyRuleStatusResponse> ModifyApplicationProxyRuleStatus(ModifyApplicationProxyRuleStatusRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationProxyRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public ModifyApplicationProxyRuleStatusResponse ModifyApplicationProxyRuleStatusSync(ModifyApplicationProxyRuleStatusRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationProxyRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of an application proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public async Task<ModifyApplicationProxyStatusResponse> ModifyApplicationProxyStatus(ModifyApplicationProxyStatusRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationProxyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of an application proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public ModifyApplicationProxyStatusResponse ModifyApplicationProxyStatusSync(ModifyApplicationProxyStatusRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationProxyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify DDoS mitigation configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public async Task<ModifyDDoSPolicyResponse> ModifyDDoSPolicy(ModifyDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify DDoS mitigation configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public ModifyDDoSPolicyResponse ModifyDDoSPolicySync(ModifyDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable high availability for domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyHostRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyHostResponse"/></returns>
        public async Task<ModifyDDoSPolicyHostResponse> ModifyDDoSPolicyHost(ModifyDDoSPolicyHostRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicyHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable high availability for domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyHostRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyHostResponse"/></returns>
        public ModifyDDoSPolicyHostResponse ModifyDDoSPolicyHostSync(ModifyDDoSPolicyHostRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicyHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This example shows you how to modify the status of a default certificate.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultCertificateRequest"/></param>
        /// <returns><see cref="ModifyDefaultCertificateResponse"/></returns>
        public async Task<ModifyDefaultCertificateResponse> ModifyDefaultCertificate(ModifyDefaultCertificateRequest req)
        {
             JsonResponseModel<ModifyDefaultCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDefaultCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This example shows you how to modify the status of a default certificate.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultCertificateRequest"/></param>
        /// <returns><see cref="ModifyDefaultCertificateResponse"/></returns>
        public ModifyDefaultCertificateResponse ModifyDefaultCertificateSync(ModifyDefaultCertificateRequest req)
        {
             JsonResponseModel<ModifyDefaultCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDefaultCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify DNS records.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordResponse"/></returns>
        public async Task<ModifyDnsRecordResponse> ModifyDnsRecord(ModifyDnsRecordRequest req)
        {
             JsonResponseModel<ModifyDnsRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDnsRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDnsRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify DNS records.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordResponse"/></returns>
        public ModifyDnsRecordResponse ModifyDnsRecordSync(ModifyDnsRecordRequest req)
        {
             JsonResponseModel<ModifyDnsRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDnsRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDnsRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the DNSSEC status of a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnssecRequest"/></param>
        /// <returns><see cref="ModifyDnssecResponse"/></returns>
        public async Task<ModifyDnssecResponse> ModifyDnssec(ModifyDnssecRequest req)
        {
             JsonResponseModel<ModifyDnssecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDnssec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDnssecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the DNSSEC status of a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnssecRequest"/></param>
        /// <returns><see cref="ModifyDnssecResponse"/></returns>
        public ModifyDnssecResponse ModifyDnssecSync(ModifyDnssecRequest req)
        {
             JsonResponseModel<ModifyDnssecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDnssec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDnssecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the certificate of a domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public async Task<ModifyHostsCertificateResponse> ModifyHostsCertificate(ModifyHostsCertificateRequest req)
        {
             JsonResponseModel<ModifyHostsCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHostsCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostsCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the certificate of a domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public ModifyHostsCertificateResponse ModifyHostsCertificateSync(ModifyHostsCertificateRequest req)
        {
             JsonResponseModel<ModifyHostsCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHostsCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostsCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingResponse"/></returns>
        public async Task<ModifyLoadBalancingResponse> ModifyLoadBalancing(ModifyLoadBalancingRequest req)
        {
             JsonResponseModel<ModifyLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingResponse"/></returns>
        public ModifyLoadBalancingResponse ModifyLoadBalancingSync(ModifyLoadBalancingRequest req)
        {
             JsonResponseModel<ModifyLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingStatusRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingStatusResponse"/></returns>
        public async Task<ModifyLoadBalancingStatusResponse> ModifyLoadBalancingStatus(ModifyLoadBalancingStatusRequest req)
        {
             JsonResponseModel<ModifyLoadBalancingStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancingStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancingStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingStatusRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingStatusResponse"/></returns>
        public ModifyLoadBalancingStatusResponse ModifyLoadBalancingStatusSync(ModifyLoadBalancingStatusRequest req)
        {
             JsonResponseModel<ModifyLoadBalancingStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancingStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancingStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a shipping task.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogTopicTaskRequest"/></param>
        /// <returns><see cref="ModifyLogTopicTaskResponse"/></returns>
        public async Task<ModifyLogTopicTaskResponse> ModifyLogTopicTask(ModifyLogTopicTaskRequest req)
        {
             JsonResponseModel<ModifyLogTopicTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogTopicTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogTopicTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a shipping task.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogTopicTaskRequest"/></param>
        /// <returns><see cref="ModifyLogTopicTaskResponse"/></returns>
        public ModifyLogTopicTaskResponse ModifyLogTopicTaskSync(ModifyLogTopicTaskRequest req)
        {
             JsonResponseModel<ModifyLogTopicTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogTopicTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogTopicTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an origin group.
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public async Task<ModifyOriginGroupResponse> ModifyOriginGroup(ModifyOriginGroupRequest req)
        {
             JsonResponseModel<ModifyOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an origin group.
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public ModifyOriginGroupResponse ModifyOriginGroupSync(ModifyOriginGroupRequest req)
        {
             JsonResponseModel<ModifyOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a rule in the rule engine.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public async Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a rule in the rule engine.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the priority of a rule in the rule engine.
        /// </summary>
        /// <param name="req"><see cref="ModifyRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyRulePriorityResponse"/></returns>
        public async Task<ModifyRulePriorityResponse> ModifyRulePriority(ModifyRulePriorityRequest req)
        {
             JsonResponseModel<ModifyRulePriorityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRulePriority");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRulePriorityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the priority of a rule in the rule engine.
        /// </summary>
        /// <param name="req"><see cref="ModifyRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyRulePriorityResponse"/></returns>
        public ModifyRulePriorityResponse ModifyRulePrioritySync(ModifyRulePriorityRequest req)
        {
             JsonResponseModel<ModifyRulePriorityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRulePriority");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRulePriorityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the web and bot security configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public async Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the web and bot security configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a managed rule.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityWafGroupPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityWafGroupPolicyResponse"/></returns>
        public async Task<ModifySecurityWafGroupPolicyResponse> ModifySecurityWafGroupPolicy(ModifySecurityWafGroupPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityWafGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityWafGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityWafGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a managed rule.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityWafGroupPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityWafGroupPolicyResponse"/></returns>
        public ModifySecurityWafGroupPolicyResponse ModifySecurityWafGroupPolicySync(ModifySecurityWafGroupPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityWafGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityWafGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityWafGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public async Task<ModifyZoneResponse> ModifyZone(ModifyZoneRequest req)
        {
             JsonResponseModel<ModifyZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public ModifyZoneResponse ModifyZoneSync(ModifyZoneRequest req)
        {
             JsonResponseModel<ModifyZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the CNAME acceleration status.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCnameSpeedUpRequest"/></param>
        /// <returns><see cref="ModifyZoneCnameSpeedUpResponse"/></returns>
        public async Task<ModifyZoneCnameSpeedUpResponse> ModifyZoneCnameSpeedUp(ModifyZoneCnameSpeedUpRequest req)
        {
             JsonResponseModel<ModifyZoneCnameSpeedUpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZoneCnameSpeedUp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneCnameSpeedUpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the CNAME acceleration status.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCnameSpeedUpRequest"/></param>
        /// <returns><see cref="ModifyZoneCnameSpeedUpResponse"/></returns>
        public ModifyZoneCnameSpeedUpResponse ModifyZoneCnameSpeedUpSync(ModifyZoneCnameSpeedUpRequest req)
        {
             JsonResponseModel<ModifyZoneCnameSpeedUpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZoneCnameSpeedUp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneCnameSpeedUpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the site configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public async Task<ModifyZoneSettingResponse> ModifyZoneSetting(ModifyZoneSettingRequest req)
        {
             JsonResponseModel<ModifyZoneSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZoneSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the site configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public ModifyZoneSettingResponse ModifyZoneSettingSync(ModifyZoneSettingRequest req)
        {
             JsonResponseModel<ModifyZoneSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZoneSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the site status.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public async Task<ModifyZoneStatusResponse> ModifyZoneStatus(ModifyZoneStatusRequest req)
        {
             JsonResponseModel<ModifyZoneStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZoneStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the site status.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public ModifyZoneStatusResponse ModifyZoneStatusSync(ModifyZoneStatusRequest req)
        {
             JsonResponseModel<ModifyZoneStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZoneStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To reclaim a site and its associated alias domain names, specify the "ZoneId" field; to reclaim an alias domain name that is already added, specify the "ZoneName" filed.
        /// </summary>
        /// <param name="req"><see cref="ReclaimAliasDomainRequest"/></param>
        /// <returns><see cref="ReclaimAliasDomainResponse"/></returns>
        public async Task<ReclaimAliasDomainResponse> ReclaimAliasDomain(ReclaimAliasDomainRequest req)
        {
             JsonResponseModel<ReclaimAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReclaimAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReclaimAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To reclaim a site and its associated alias domain names, specify the "ZoneId" field; to reclaim an alias domain name that is already added, specify the "ZoneName" filed.
        /// </summary>
        /// <param name="req"><see cref="ReclaimAliasDomainRequest"/></param>
        /// <returns><see cref="ReclaimAliasDomainResponse"/></returns>
        public ReclaimAliasDomainResponse ReclaimAliasDomainSync(ReclaimAliasDomainRequest req)
        {
             JsonResponseModel<ReclaimAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReclaimAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReclaimAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reclaim a site from other users after its ownership is verified.
        /// </summary>
        /// <param name="req"><see cref="ReclaimZoneRequest"/></param>
        /// <returns><see cref="ReclaimZoneResponse"/></returns>
        public async Task<ReclaimZoneResponse> ReclaimZone(ReclaimZoneRequest req)
        {
             JsonResponseModel<ReclaimZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReclaimZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReclaimZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reclaim a site from other users after its ownership is verified.
        /// </summary>
        /// <param name="req"><see cref="ReclaimZoneRequest"/></param>
        /// <returns><see cref="ReclaimZoneResponse"/></returns>
        public ReclaimZoneResponse ReclaimZoneSync(ReclaimZoneRequest req)
        {
             JsonResponseModel<ReclaimZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReclaimZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReclaimZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable a shipping task.
        /// </summary>
        /// <param name="req"><see cref="SwitchLogTopicTaskRequest"/></param>
        /// <returns><see cref="SwitchLogTopicTaskResponse"/></returns>
        public async Task<SwitchLogTopicTaskResponse> SwitchLogTopicTask(SwitchLogTopicTaskRequest req)
        {
             JsonResponseModel<SwitchLogTopicTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchLogTopicTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchLogTopicTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable a shipping task.
        /// </summary>
        /// <param name="req"><see cref="SwitchLogTopicTaskRequest"/></param>
        /// <returns><see cref="SwitchLogTopicTaskResponse"/></returns>
        public SwitchLogTopicTaskResponse SwitchLogTopicTaskSync(SwitchLogTopicTaskRequest req)
        {
             JsonResponseModel<SwitchLogTopicTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchLogTopicTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchLogTopicTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

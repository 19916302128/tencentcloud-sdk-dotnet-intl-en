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

namespace TencentCloud.Tem.V20210701
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tem.V20210701.Models;

   public class TemClient : AbstractClient{

       private const string endpoint = "tem.tencentcloudapi.com";
       private const string version = "2021-07-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TemClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TemClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public async Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="CreateApplicationAutoscalerResponse"/></returns>
        public async Task<CreateApplicationAutoscalerResponse> CreateApplicationAutoscaler(CreateApplicationAutoscalerRequest req)
        {
             JsonResponseModel<CreateApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="CreateApplicationAutoscalerResponse"/></returns>
        public CreateApplicationAutoscalerResponse CreateApplicationAutoscalerSync(CreateApplicationAutoscalerRequest req)
        {
             JsonResponseModel<CreateApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an access policy. 
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationServiceRequest"/></param>
        /// <returns><see cref="CreateApplicationServiceResponse"/></returns>
        public async Task<CreateApplicationServiceResponse> CreateApplicationService(CreateApplicationServiceRequest req)
        {
             JsonResponseModel<CreateApplicationServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an access policy. 
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationServiceRequest"/></param>
        /// <returns><see cref="CreateApplicationServiceResponse"/></returns>
        public CreateApplicationServiceResponse CreateApplicationServiceSync(CreateApplicationServiceRequest req)
        {
             JsonResponseModel<CreateApplicationServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigDataRequest"/></param>
        /// <returns><see cref="CreateConfigDataResponse"/></returns>
        public async Task<CreateConfigDataResponse> CreateConfigData(CreateConfigDataRequest req)
        {
             JsonResponseModel<CreateConfigDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConfigData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigDataRequest"/></param>
        /// <returns><see cref="CreateConfigDataResponse"/></returns>
        public CreateConfigDataResponse CreateConfigDataSync(CreateConfigDataRequest req)
        {
             JsonResponseModel<CreateConfigDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConfigData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate a COS temporary key.
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenRequest"/></param>
        /// <returns><see cref="CreateCosTokenResponse"/></returns>
        public async Task<CreateCosTokenResponse> CreateCosToken(CreateCosTokenRequest req)
        {
             JsonResponseModel<CreateCosTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCosToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate a COS temporary key.
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenRequest"/></param>
        /// <returns><see cref="CreateCosTokenResponse"/></returns>
        public CreateCosTokenResponse CreateCosTokenSync(CreateCosTokenRequest req)
        {
             JsonResponseModel<CreateCosTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCosToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an environment.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public async Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
             JsonResponseModel<CreateEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an environment.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
             JsonResponseModel<CreateEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateLogConfigRequest"/></param>
        /// <returns><see cref="CreateLogConfigResponse"/></returns>
        public async Task<CreateLogConfigResponse> CreateLogConfig(CreateLogConfigRequest req)
        {
             JsonResponseModel<CreateLogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateLogConfigRequest"/></param>
        /// <returns><see cref="CreateLogConfigResponse"/></returns>
        public CreateLogConfigResponse CreateLogConfigSync(CreateLogConfigRequest req)
        {
             JsonResponseModel<CreateLogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a cloud resource.
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public async Task<CreateResourceResponse> CreateResource(CreateResourceRequest req)
        {
             JsonResponseModel<CreateResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a cloud resource.
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public CreateResourceResponse CreateResourceSync(CreateResourceRequest req)
        {
             JsonResponseModel<CreateResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an application.
        ///   - Stop running the current application
        ///   - Delete resources related to the application
        ///   - Delete the application
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public async Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
             JsonResponseModel<DeleteApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an application.
        ///   - Stop running the current application
        ///   - Delete resources related to the application
        ///   - Delete the application
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public DeleteApplicationResponse DeleteApplicationSync(DeleteApplicationRequest req)
        {
             JsonResponseModel<DeleteApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DeleteApplicationAutoscalerResponse"/></returns>
        public async Task<DeleteApplicationAutoscalerResponse> DeleteApplicationAutoscaler(DeleteApplicationAutoscalerRequest req)
        {
             JsonResponseModel<DeleteApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DeleteApplicationAutoscalerResponse"/></returns>
        public DeleteApplicationAutoscalerResponse DeleteApplicationAutoscalerSync(DeleteApplicationAutoscalerRequest req)
        {
             JsonResponseModel<DeleteApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an access policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationServiceRequest"/></param>
        /// <returns><see cref="DeleteApplicationServiceResponse"/></returns>
        public async Task<DeleteApplicationServiceResponse> DeleteApplicationService(DeleteApplicationServiceRequest req)
        {
             JsonResponseModel<DeleteApplicationServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplicationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an access policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationServiceRequest"/></param>
        /// <returns><see cref="DeleteApplicationServiceResponse"/></returns>
        public DeleteApplicationServiceResponse DeleteApplicationServiceSync(DeleteApplicationServiceRequest req)
        {
             JsonResponseModel<DeleteApplicationServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplicationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteIngressRequest"/></param>
        /// <returns><see cref="DeleteIngressResponse"/></returns>
        public async Task<DeleteIngressResponse> DeleteIngress(DeleteIngressRequest req)
        {
             JsonResponseModel<DeleteIngressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteIngressRequest"/></param>
        /// <returns><see cref="DeleteIngressResponse"/></returns>
        public DeleteIngressResponse DeleteIngressSync(DeleteIngressRequest req)
        {
             JsonResponseModel<DeleteIngressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deploy an application.
        /// </summary>
        /// <param name="req"><see cref="DeployApplicationRequest"/></param>
        /// <returns><see cref="DeployApplicationResponse"/></returns>
        public async Task<DeployApplicationResponse> DeployApplication(DeployApplicationRequest req)
        {
             JsonResponseModel<DeployApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deploy an application.
        /// </summary>
        /// <param name="req"><see cref="DeployApplicationRequest"/></param>
        /// <returns><see cref="DeployApplicationResponse"/></returns>
        public DeployApplicationResponse DeployApplicationSync(DeployApplicationRequest req)
        {
             JsonResponseModel<DeployApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the scaling rules of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAutoscalerListRequest"/></param>
        /// <returns><see cref="DescribeApplicationAutoscalerListResponse"/></returns>
        public async Task<DescribeApplicationAutoscalerListResponse> DescribeApplicationAutoscalerList(DescribeApplicationAutoscalerListRequest req)
        {
             JsonResponseModel<DescribeApplicationAutoscalerListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationAutoscalerList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationAutoscalerListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the scaling rules of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAutoscalerListRequest"/></param>
        /// <returns><see cref="DescribeApplicationAutoscalerListResponse"/></returns>
        public DescribeApplicationAutoscalerListResponse DescribeApplicationAutoscalerListSync(DescribeApplicationAutoscalerListRequest req)
        {
             JsonResponseModel<DescribeApplicationAutoscalerListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationAutoscalerList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationAutoscalerListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check the basic information of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfoRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfoResponse"/></returns>
        public async Task<DescribeApplicationInfoResponse> DescribeApplicationInfo(DescribeApplicationInfoRequest req)
        {
             JsonResponseModel<DescribeApplicationInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check the basic information of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfoRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfoResponse"/></returns>
        public DescribeApplicationInfoResponse DescribeApplicationInfoSync(DescribeApplicationInfoRequest req)
        {
             JsonResponseModel<DescribeApplicationInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of application pods.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeApplicationPodsResponse"/></returns>
        public async Task<DescribeApplicationPodsResponse> DescribeApplicationPods(DescribeApplicationPodsRequest req)
        {
             JsonResponseModel<DescribeApplicationPodsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of application pods.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeApplicationPodsResponse"/></returns>
        public DescribeApplicationPodsResponse DescribeApplicationPodsSync(DescribeApplicationPodsRequest req)
        {
             JsonResponseModel<DescribeApplicationPodsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of access policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationServiceListRequest"/></param>
        /// <returns><see cref="DescribeApplicationServiceListResponse"/></returns>
        public async Task<DescribeApplicationServiceListResponse> DescribeApplicationServiceList(DescribeApplicationServiceListRequest req)
        {
             JsonResponseModel<DescribeApplicationServiceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of access policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationServiceListRequest"/></param>
        /// <returns><see cref="DescribeApplicationServiceListResponse"/></returns>
        public DescribeApplicationServiceListResponse DescribeApplicationServiceListSync(DescribeApplicationServiceListRequest req)
        {
             JsonResponseModel<DescribeApplicationServiceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is to query the list of running applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public async Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is to query the list of running applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of all applications in an envrionment.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsStatusRequest"/></param>
        /// <returns><see cref="DescribeApplicationsStatusResponse"/></returns>
        public async Task<DescribeApplicationsStatusResponse> DescribeApplicationsStatus(DescribeApplicationsStatusRequest req)
        {
             JsonResponseModel<DescribeApplicationsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of all applications in an envrionment.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsStatusRequest"/></param>
        /// <returns><see cref="DescribeApplicationsStatusResponse"/></returns>
        public DescribeApplicationsStatusResponse DescribeApplicationsStatusSync(DescribeApplicationsStatusRequest req)
        {
             JsonResponseModel<DescribeApplicationsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query details of a configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataRequest"/></param>
        /// <returns><see cref="DescribeConfigDataResponse"/></returns>
        public async Task<DescribeConfigDataResponse> DescribeConfigData(DescribeConfigDataRequest req)
        {
             JsonResponseModel<DescribeConfigDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query details of a configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataRequest"/></param>
        /// <returns><see cref="DescribeConfigDataResponse"/></returns>
        public DescribeConfigDataResponse DescribeConfigDataSync(DescribeConfigDataRequest req)
        {
             JsonResponseModel<DescribeConfigDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataListRequest"/></param>
        /// <returns><see cref="DescribeConfigDataListResponse"/></returns>
        public async Task<DescribeConfigDataListResponse> DescribeConfigDataList(DescribeConfigDataListRequest req)
        {
             JsonResponseModel<DescribeConfigDataListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigDataList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigDataListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataListRequest"/></param>
        /// <returns><see cref="DescribeConfigDataListResponse"/></returns>
        public DescribeConfigDataListResponse DescribeConfigDataListSync(DescribeConfigDataListRequest req)
        {
             JsonResponseModel<DescribeConfigDataListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigDataList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigDataListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the basic information of an environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentResponse"/></returns>
        public async Task<DescribeEnvironmentResponse> DescribeEnvironment(DescribeEnvironmentRequest req)
        {
             JsonResponseModel<DescribeEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the basic information of an environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentResponse"/></returns>
        public DescribeEnvironmentResponse DescribeEnvironmentSync(DescribeEnvironmentRequest req)
        {
             JsonResponseModel<DescribeEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the environment status.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentStatusRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentStatusResponse"/></returns>
        public async Task<DescribeEnvironmentStatusResponse> DescribeEnvironmentStatus(DescribeEnvironmentStatusRequest req)
        {
             JsonResponseModel<DescribeEnvironmentStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvironmentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the environment status.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentStatusRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentStatusResponse"/></returns>
        public DescribeEnvironmentStatusResponse DescribeEnvironmentStatusSync(DescribeEnvironmentStatusRequest req)
        {
             JsonResponseModel<DescribeEnvironmentStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvironmentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of environments. 
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public async Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of environments. 
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressRequest"/></param>
        /// <returns><see cref="DescribeIngressResponse"/></returns>
        public async Task<DescribeIngressResponse> DescribeIngress(DescribeIngressRequest req)
        {
             JsonResponseModel<DescribeIngressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressRequest"/></param>
        /// <returns><see cref="DescribeIngressResponse"/></returns>
        public DescribeIngressResponse DescribeIngressSync(DescribeIngressRequest req)
        {
             JsonResponseModel<DescribeIngressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of ingress rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressesRequest"/></param>
        /// <returns><see cref="DescribeIngressesResponse"/></returns>
        public async Task<DescribeIngressesResponse> DescribeIngresses(DescribeIngressesRequest req)
        {
             JsonResponseModel<DescribeIngressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIngresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIngressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of ingress rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressesRequest"/></param>
        /// <returns><see cref="DescribeIngressesResponse"/></returns>
        public DescribeIngressesResponse DescribeIngressesSync(DescribeIngressesRequest req)
        {
             JsonResponseModel<DescribeIngressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIngresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIngressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query details of a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogConfigRequest"/></param>
        /// <returns><see cref="DescribeLogConfigResponse"/></returns>
        public async Task<DescribeLogConfigResponse> DescribeLogConfig(DescribeLogConfigRequest req)
        {
             JsonResponseModel<DescribeLogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query details of a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogConfigRequest"/></param>
        /// <returns><see cref="DescribeLogConfigResponse"/></returns>
        public DescribeLogConfigResponse DescribeLogConfigSync(DescribeLogConfigRequest req)
        {
             JsonResponseModel<DescribeLogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to querying the list of log collecting configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribePagedLogConfigListRequest"/></param>
        /// <returns><see cref="DescribePagedLogConfigListResponse"/></returns>
        public async Task<DescribePagedLogConfigListResponse> DescribePagedLogConfigList(DescribePagedLogConfigListRequest req)
        {
             JsonResponseModel<DescribePagedLogConfigListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePagedLogConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePagedLogConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to querying the list of log collecting configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribePagedLogConfigListRequest"/></param>
        /// <returns><see cref="DescribePagedLogConfigListResponse"/></returns>
        public DescribePagedLogConfigListResponse DescribePagedLogConfigListSync(DescribePagedLogConfigListRequest req)
        {
             JsonResponseModel<DescribePagedLogConfigListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePagedLogConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePagedLogConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of ingress rules associated with the application.
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public async Task<DescribeRelatedIngressesResponse> DescribeRelatedIngresses(DescribeRelatedIngressesRequest req)
        {
             JsonResponseModel<DescribeRelatedIngressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRelatedIngresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedIngressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of ingress rules associated with the application.
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public DescribeRelatedIngressesResponse DescribeRelatedIngressesSync(DescribeRelatedIngressesRequest req)
        {
             JsonResponseModel<DescribeRelatedIngressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRelatedIngresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedIngressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a configuration.
        /// </summary>
        /// <param name="req"><see cref="DestroyConfigDataRequest"/></param>
        /// <returns><see cref="DestroyConfigDataResponse"/></returns>
        public async Task<DestroyConfigDataResponse> DestroyConfigData(DestroyConfigDataRequest req)
        {
             JsonResponseModel<DestroyConfigDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyConfigData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyConfigDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a configuration.
        /// </summary>
        /// <param name="req"><see cref="DestroyConfigDataRequest"/></param>
        /// <returns><see cref="DestroyConfigDataResponse"/></returns>
        public DestroyConfigDataResponse DestroyConfigDataSync(DestroyConfigDataRequest req)
        {
             JsonResponseModel<DestroyConfigDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyConfigData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyConfigDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate an environment.
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvironmentRequest"/></param>
        /// <returns><see cref="DestroyEnvironmentResponse"/></returns>
        public async Task<DestroyEnvironmentResponse> DestroyEnvironment(DestroyEnvironmentRequest req)
        {
             JsonResponseModel<DestroyEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate an environment.
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvironmentRequest"/></param>
        /// <returns><see cref="DestroyEnvironmentResponse"/></returns>
        public DestroyEnvironmentResponse DestroyEnvironmentSync(DestroyEnvironmentRequest req)
        {
             JsonResponseModel<DestroyEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="DestroyLogConfigRequest"/></param>
        /// <returns><see cref="DestroyLogConfigResponse"/></returns>
        public async Task<DestroyLogConfigResponse> DestroyLogConfig(DestroyLogConfigRequest req)
        {
             JsonResponseModel<DestroyLogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="DestroyLogConfigRequest"/></param>
        /// <returns><see cref="DestroyLogConfigResponse"/></returns>
        public DestroyLogConfigResponse DestroyLogConfigSync(DestroyLogConfigRequest req)
        {
             JsonResponseModel<DestroyLogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DisableApplicationAutoscalerResponse"/></returns>
        public async Task<DisableApplicationAutoscalerResponse> DisableApplicationAutoscaler(DisableApplicationAutoscalerRequest req)
        {
             JsonResponseModel<DisableApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DisableApplicationAutoscalerResponse"/></returns>
        public DisableApplicationAutoscalerResponse DisableApplicationAutoscalerSync(DisableApplicationAutoscalerRequest req)
        {
             JsonResponseModel<DisableApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="EnableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="EnableApplicationAutoscalerResponse"/></returns>
        public async Task<EnableApplicationAutoscalerResponse> EnableApplicationAutoscaler(EnableApplicationAutoscalerRequest req)
        {
             JsonResponseModel<EnableApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="EnableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="EnableApplicationAutoscalerResponse"/></returns>
        public EnableApplicationAutoscalerResponse EnableApplicationAutoscalerSync(EnableApplicationAutoscalerRequest req)
        {
             JsonResponseModel<EnableApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate the pre-signed download URL for the specified application package.
        /// </summary>
        /// <param name="req"><see cref="GenerateApplicationPackageDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateApplicationPackageDownloadUrlResponse"/></returns>
        public async Task<GenerateApplicationPackageDownloadUrlResponse> GenerateApplicationPackageDownloadUrl(GenerateApplicationPackageDownloadUrlRequest req)
        {
             JsonResponseModel<GenerateApplicationPackageDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateApplicationPackageDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateApplicationPackageDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate the pre-signed download URL for the specified application package.
        /// </summary>
        /// <param name="req"><see cref="GenerateApplicationPackageDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateApplicationPackageDownloadUrlResponse"/></returns>
        public GenerateApplicationPackageDownloadUrlResponse GenerateApplicationPackageDownloadUrlSync(GenerateApplicationPackageDownloadUrlRequest req)
        {
             JsonResponseModel<GenerateApplicationPackageDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateApplicationPackageDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateApplicationPackageDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="ModifyApplicationAutoscalerResponse"/></returns>
        public async Task<ModifyApplicationAutoscalerResponse> ModifyApplicationAutoscaler(ModifyApplicationAutoscalerRequest req)
        {
             JsonResponseModel<ModifyApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="ModifyApplicationAutoscalerResponse"/></returns>
        public ModifyApplicationAutoscalerResponse ModifyApplicationAutoscalerSync(ModifyApplicationAutoscalerRequest req)
        {
             JsonResponseModel<ModifyApplicationAutoscalerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationAutoscaler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationAutoscalerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the basic information of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationInfoResponse"/></returns>
        public async Task<ModifyApplicationInfoResponse> ModifyApplicationInfo(ModifyApplicationInfoRequest req)
        {
             JsonResponseModel<ModifyApplicationInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the basic information of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationInfoResponse"/></returns>
        public ModifyApplicationInfoResponse ModifyApplicationInfoSync(ModifyApplicationInfoRequest req)
        {
             JsonResponseModel<ModifyApplicationInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an access policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationServiceRequest"/></param>
        /// <returns><see cref="ModifyApplicationServiceResponse"/></returns>
        public async Task<ModifyApplicationServiceResponse> ModifyApplicationService(ModifyApplicationServiceRequest req)
        {
             JsonResponseModel<ModifyApplicationServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an access policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationServiceRequest"/></param>
        /// <returns><see cref="ModifyApplicationServiceResponse"/></returns>
        public ModifyApplicationServiceResponse ModifyApplicationServiceSync(ModifyApplicationServiceRequest req)
        {
             JsonResponseModel<ModifyApplicationServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigDataRequest"/></param>
        /// <returns><see cref="ModifyConfigDataResponse"/></returns>
        public async Task<ModifyConfigDataResponse> ModifyConfigData(ModifyConfigDataRequest req)
        {
             JsonResponseModel<ModifyConfigDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConfigData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigDataRequest"/></param>
        /// <returns><see cref="ModifyConfigDataResponse"/></returns>
        public ModifyConfigDataResponse ModifyConfigDataSync(ModifyConfigDataRequest req)
        {
             JsonResponseModel<ModifyConfigDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConfigData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to edit an environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentResponse"/></returns>
        public async Task<ModifyEnvironmentResponse> ModifyEnvironment(ModifyEnvironmentRequest req)
        {
             JsonResponseModel<ModifyEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to edit an environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentResponse"/></returns>
        public ModifyEnvironmentResponse ModifyEnvironmentSync(ModifyEnvironmentRequest req)
        {
             JsonResponseModel<ModifyEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create or update an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyIngressRequest"/></param>
        /// <returns><see cref="ModifyIngressResponse"/></returns>
        public async Task<ModifyIngressResponse> ModifyIngress(ModifyIngressRequest req)
        {
             JsonResponseModel<ModifyIngressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create or update an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyIngressRequest"/></param>
        /// <returns><see cref="ModifyIngressResponse"/></returns>
        public ModifyIngressResponse ModifyIngressSync(ModifyIngressRequest req)
        {
             JsonResponseModel<ModifyIngressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogConfigRequest"/></param>
        /// <returns><see cref="ModifyLogConfigResponse"/></returns>
        public async Task<ModifyLogConfigResponse> ModifyLogConfig(ModifyLogConfigRequest req)
        {
             JsonResponseModel<ModifyLogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogConfigRequest"/></param>
        /// <returns><see cref="ModifyLogConfigResponse"/></returns>
        public ModifyLogConfigResponse ModifyLogConfigSync(ModifyLogConfigRequest req)
        {
             JsonResponseModel<ModifyLogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an application.
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationRequest"/></param>
        /// <returns><see cref="RestartApplicationResponse"/></returns>
        public async Task<RestartApplicationResponse> RestartApplication(RestartApplicationRequest req)
        {
             JsonResponseModel<RestartApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an application.
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationRequest"/></param>
        /// <returns><see cref="RestartApplicationResponse"/></returns>
        public RestartApplicationResponse RestartApplicationSync(RestartApplicationRequest req)
        {
             JsonResponseModel<RestartApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an application pod.
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationPodRequest"/></param>
        /// <returns><see cref="RestartApplicationPodResponse"/></returns>
        public async Task<RestartApplicationPodResponse> RestartApplicationPod(RestartApplicationPodRequest req)
        {
             JsonResponseModel<RestartApplicationPodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartApplicationPod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartApplicationPodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an application pod.
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationPodRequest"/></param>
        /// <returns><see cref="RestartApplicationPodResponse"/></returns>
        public RestartApplicationPodResponse RestartApplicationPodSync(RestartApplicationPodRequest req)
        {
             JsonResponseModel<RestartApplicationPodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartApplicationPod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartApplicationPodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure the rolling update policy for an application.
        /// </summary>
        /// <param name="req"><see cref="RollingUpdateApplicationByVersionRequest"/></param>
        /// <returns><see cref="RollingUpdateApplicationByVersionResponse"/></returns>
        public async Task<RollingUpdateApplicationByVersionResponse> RollingUpdateApplicationByVersion(RollingUpdateApplicationByVersionRequest req)
        {
             JsonResponseModel<RollingUpdateApplicationByVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollingUpdateApplicationByVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollingUpdateApplicationByVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure the rolling update policy for an application.
        /// </summary>
        /// <param name="req"><see cref="RollingUpdateApplicationByVersionRequest"/></param>
        /// <returns><see cref="RollingUpdateApplicationByVersionResponse"/></returns>
        public RollingUpdateApplicationByVersionResponse RollingUpdateApplicationByVersionSync(RollingUpdateApplicationByVersionRequest req)
        {
             JsonResponseModel<RollingUpdateApplicationByVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollingUpdateApplicationByVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollingUpdateApplicationByVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop an application.
        /// </summary>
        /// <param name="req"><see cref="StopApplicationRequest"/></param>
        /// <returns><see cref="StopApplicationResponse"/></returns>
        public async Task<StopApplicationResponse> StopApplication(StopApplicationRequest req)
        {
             JsonResponseModel<StopApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop an application.
        /// </summary>
        /// <param name="req"><see cref="StopApplicationRequest"/></param>
        /// <returns><see cref="StopApplicationResponse"/></returns>
        public StopApplicationResponse StopApplicationSync(StopApplicationRequest req)
        {
             JsonResponseModel<StopApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

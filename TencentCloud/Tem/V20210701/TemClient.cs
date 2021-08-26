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
        /// This API is used to get the list of tenant environments.
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
        /// This API is used to get the list of tenant environments.
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

    }
}

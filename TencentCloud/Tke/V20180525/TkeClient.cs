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

namespace TencentCloud.Tke.V20180525
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tke.V20180525.Models;

   public class TkeClient : AbstractClient{

       private const string endpoint = "tke.tencentcloudapi.com";
       private const string version = "2018-05-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TkeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to add one or more existing instances to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public async Task<AddExistedInstancesResponse> AddExistedInstances(AddExistedInstancesRequest req)
        {
             JsonResponseModel<AddExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add one or more existing instances to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public AddExistedInstancesResponse AddExistedInstancesSync(AddExistedInstancesRequest req)
        {
             JsonResponseModel<AddExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public async Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a scaling group for an existing cluster
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAsGroupRequest"/></param>
        /// <returns><see cref="CreateClusterAsGroupResponse"/></returns>
        public async Task<CreateClusterAsGroupResponse> CreateClusterAsGroup(CreateClusterAsGroupRequest req)
        {
             JsonResponseModel<CreateClusterAsGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a scaling group for an existing cluster
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAsGroupRequest"/></param>
        /// <returns><see cref="CreateClusterAsGroupResponse"/></returns>
        public CreateClusterAsGroupResponse CreateClusterAsGroupSync(CreateClusterAsGroupRequest req)
        {
             JsonResponseModel<CreateClusterAsGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a cluster access port (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public async Task<CreateClusterEndpointResponse> CreateClusterEndpoint(CreateClusterEndpointRequest req)
        {
             JsonResponseModel<CreateClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a cluster access port (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public CreateClusterEndpointResponse CreateClusterEndpointSync(CreateClusterEndpointRequest req)
        {
             JsonResponseModel<CreateClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create an external network access port for the managed cluster (the old way, only the external network port for the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public async Task<CreateClusterEndpointVipResponse> CreateClusterEndpointVip(CreateClusterEndpointVipRequest req)
        {
             JsonResponseModel<CreateClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create an external network access port for the managed cluster (the old way, only the external network port for the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public CreateClusterEndpointVipResponse CreateClusterEndpointVipSync(CreateClusterEndpointVipRequest req)
        {
             JsonResponseModel<CreateClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public async Task<CreateClusterInstancesResponse> CreateClusterInstances(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public CreateClusterInstancesResponse CreateClusterInstancesSync(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster route table.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public async Task<CreateClusterRouteTableResponse> CreateClusterRouteTable(CreateClusterRouteTableRequest req)
        {
             JsonResponseModel<CreateClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster route table.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public CreateClusterRouteTableResponse CreateClusterRouteTableSync(CreateClusterRouteTableRequest req)
        {
             JsonResponseModel<CreateClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster. (Cloud API v3).
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public async Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster. (Cloud API v3).
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete a cluster scaling group
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public async Task<DeleteClusterAsGroupsResponse> DeleteClusterAsGroups(DeleteClusterAsGroupsRequest req)
        {
             JsonResponseModel<DeleteClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete a cluster scaling group
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public DeleteClusterAsGroupsResponse DeleteClusterAsGroupsSync(DeleteClusterAsGroupsRequest req)
        {
             JsonResponseModel<DeleteClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete the cluster access port (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public async Task<DeleteClusterEndpointResponse> DeleteClusterEndpoint(DeleteClusterEndpointRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete the cluster access port (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public DeleteClusterEndpointResponse DeleteClusterEndpointSync(DeleteClusterEndpointRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete the external network access port of the managed cluster (the old way, only the external network port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public async Task<DeleteClusterEndpointVipResponse> DeleteClusterEndpointVip(DeleteClusterEndpointVipRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete the external network access port of the managed cluster (the old way, only the external network port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public DeleteClusterEndpointVipResponse DeleteClusterEndpointVipSync(DeleteClusterEndpointVipRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or more nodes from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public async Task<DeleteClusterInstancesResponse> DeleteClusterInstances(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or more nodes from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public DeleteClusterInstancesResponse DeleteClusterInstancesSync(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster route.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public async Task<DeleteClusterRouteResponse> DeleteClusterRoute(DeleteClusterRouteRequest req)
        {
             JsonResponseModel<DeleteClusterRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster route.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public DeleteClusterRouteResponse DeleteClusterRouteSync(DeleteClusterRouteRequest req)
        {
             JsonResponseModel<DeleteClusterRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete cluster a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public async Task<DeleteClusterRouteTableResponse> DeleteClusterRouteTable(DeleteClusterRouteTableRequest req)
        {
             JsonResponseModel<DeleteClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete cluster a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public DeleteClusterRouteTableResponse DeleteClusterRouteTableSync(DeleteClusterRouteTableRequest req)
        {
             JsonResponseModel<DeleteClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query cluster access port status (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public async Task<DescribeClusterEndpointStatusResponse> DescribeClusterEndpointStatus(DescribeClusterEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query cluster access port status (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public DescribeClusterEndpointStatusResponse DescribeClusterEndpointStatusSync(DescribeClusterEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query cluster open port process status (only supports external ports of the managed cluster)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public async Task<DescribeClusterEndpointVipStatusResponse> DescribeClusterEndpointVipStatus(DescribeClusterEndpointVipStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointVipStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterEndpointVipStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointVipStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query cluster open port process status (only supports external ports of the managed cluster)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public DescribeClusterEndpointVipStatusResponse DescribeClusterEndpointVipStatusSync(DescribeClusterEndpointVipStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointVipStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterEndpointVipStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointVipStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to query information of one or more instances in a cluster. 
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public async Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to query information of one or more instances in a cluster. 
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query one or more cluster route tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public async Task<DescribeClusterRouteTablesResponse> DescribeClusterRouteTables(DescribeClusterRouteTablesRequest req)
        {
             JsonResponseModel<DescribeClusterRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query one or more cluster route tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public DescribeClusterRouteTablesResponse DescribeClusterRouteTablesSync(DescribeClusterRouteTablesRequest req)
        {
             JsonResponseModel<DescribeClusterRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query cluster routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public async Task<DescribeClusterRoutesResponse> DescribeClusterRoutes(DescribeClusterRoutesRequest req)
        {
             JsonResponseModel<DescribeClusterRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query cluster routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public DescribeClusterRoutesResponse DescribeClusterRoutesSync(DescribeClusterRoutesRequest req)
        {
             JsonResponseModel<DescribeClusterRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the key information of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public async Task<DescribeClusterSecurityResponse> DescribeClusterSecurity(DescribeClusterSecurityRequest req)
        {
             JsonResponseModel<DescribeClusterSecurityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterSecurity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSecurityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the key information of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public DescribeClusterSecurityResponse DescribeClusterSecuritySync(DescribeClusterSecurityRequest req)
        {
             JsonResponseModel<DescribeClusterSecurityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterSecurity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSecurityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query clusters list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public async Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query clusters list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query one or more existing node and determine whether they can be added to a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public async Task<DescribeExistedInstancesResponse> DescribeExistedInstances(DescribeExistedInstancesRequest req)
        {
             JsonResponseModel<DescribeExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query one or more existing node and determine whether they can be added to a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public DescribeExistedInstancesResponse DescribeExistedInstancesSync(DescribeExistedInstancesRequest req)
        {
             JsonResponseModel<DescribeExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of route table conflicts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public async Task<DescribeRouteTableConflictsResponse> DescribeRouteTableConflicts(DescribeRouteTableConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteTableConflictsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteTableConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTableConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of route table conflicts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public DescribeRouteTableConflictsResponse DescribeRouteTableConflictsSync(DescribeRouteTableConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteTableConflictsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRouteTableConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTableConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Modify the security policy of the external port of the managed cluster (the old way, only the external port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public async Task<ModifyClusterEndpointSPResponse> ModifyClusterEndpointSP(ModifyClusterEndpointSPRequest req)
        {
             JsonResponseModel<ModifyClusterEndpointSPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterEndpointSP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterEndpointSPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Modify the security policy of the external port of the managed cluster (the old way, only the external port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public ModifyClusterEndpointSPResponse ModifyClusterEndpointSPSync(ModifyClusterEndpointSPRequest req)
        {
             JsonResponseModel<ModifyClusterEndpointSPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterEndpointSP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterEndpointSPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

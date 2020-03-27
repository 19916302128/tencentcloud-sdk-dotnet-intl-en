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

namespace TencentCloud.Tcaplusdb.V20190823
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcaplusdb.V20190823.Models;

   public class TcaplusdbClient : AbstractClient{

       private const string endpoint = "tcaplusdb.tencentcloudapi.com";
       private const string version = "2019-08-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcaplusdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcaplusdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to clear table data based on the specified table information.
        /// </summary>
        /// <param name="req"><see cref="ClearTablesRequest"/></param>
        /// <returns><see cref="ClearTablesResponse"/></returns>
        public async Task<ClearTablesResponse> ClearTables(ClearTablesRequest req)
        {
             JsonResponseModel<ClearTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear table data based on the specified table information.
        /// </summary>
        /// <param name="req"><see cref="ClearTablesRequest"/></param>
        /// <returns><see cref="ClearTablesResponse"/></returns>
        public ClearTablesResponse ClearTablesSync(ClearTablesRequest req)
        {
             JsonResponseModel<ClearTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to select a target table, upload and verify the table modification file, and return the result of whether the table structure is allowed to be modified.
        /// </summary>
        /// <param name="req"><see cref="CompareIdlFilesRequest"/></param>
        /// <returns><see cref="CompareIdlFilesResponse"/></returns>
        public async Task<CompareIdlFilesResponse> CompareIdlFiles(CompareIdlFilesRequest req)
        {
             JsonResponseModel<CompareIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompareIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to select a target table, upload and verify the table modification file, and return the result of whether the table structure is allowed to be modified.
        /// </summary>
        /// <param name="req"><see cref="CompareIdlFilesRequest"/></param>
        /// <returns><see cref="CompareIdlFilesResponse"/></returns>
        public CompareIdlFilesResponse CompareIdlFilesSync(CompareIdlFilesRequest req)
        {
             JsonResponseModel<CompareIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompareIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a backup task.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public async Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a backup task.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TcaplusDB cluster.
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
        /// This API is used to create a TcaplusDB cluster.
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
        /// This API is used to create a table group in a TcaplusDB cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateTableGroupRequest"/></param>
        /// <returns><see cref="CreateTableGroupResponse"/></returns>
        public async Task<CreateTableGroupResponse> CreateTableGroup(CreateTableGroupRequest req)
        {
             JsonResponseModel<CreateTableGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTableGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTableGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a table group in a TcaplusDB cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateTableGroupRequest"/></param>
        /// <returns><see cref="CreateTableGroupResponse"/></returns>
        public CreateTableGroupResponse CreateTableGroupSync(CreateTableGroupRequest req)
        {
             JsonResponseModel<CreateTableGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTableGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTableGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create tables in batches based on the selected IDL file list.
        /// </summary>
        /// <param name="req"><see cref="CreateTablesRequest"/></param>
        /// <returns><see cref="CreateTablesResponse"/></returns>
        public async Task<CreateTablesResponse> CreateTables(CreateTablesRequest req)
        {
             JsonResponseModel<CreateTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create tables in batches based on the selected IDL file list.
        /// </summary>
        /// <param name="req"><see cref="CreateTablesRequest"/></param>
        /// <returns><see cref="CreateTablesResponse"/></returns>
        public CreateTablesResponse CreateTablesSync(CreateTablesRequest req)
        {
             JsonResponseModel<CreateTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a TcaplusDB cluster, which will succeed only after all resources (including table groups and tables) in the cluster are released.
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
        /// This API is used to delete a TcaplusDB cluster, which will succeed only after all resources (including table groups and tables) in the cluster are released.
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
        /// This API is used to delete a target IDL file by specifying the cluster ID and information of the file to be deleted. If the file is associated with a table, deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteIdlFilesRequest"/></param>
        /// <returns><see cref="DeleteIdlFilesResponse"/></returns>
        public async Task<DeleteIdlFilesResponse> DeleteIdlFiles(DeleteIdlFilesRequest req)
        {
             JsonResponseModel<DeleteIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a target IDL file by specifying the cluster ID and information of the file to be deleted. If the file is associated with a table, deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteIdlFilesRequest"/></param>
        /// <returns><see cref="DeleteIdlFilesResponse"/></returns>
        public DeleteIdlFilesResponse DeleteIdlFilesSync(DeleteIdlFilesRequest req)
        {
             JsonResponseModel<DeleteIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a table group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableGroupRequest"/></param>
        /// <returns><see cref="DeleteTableGroupResponse"/></returns>
        public async Task<DeleteTableGroupResponse> DeleteTableGroup(DeleteTableGroupRequest req)
        {
             JsonResponseModel<DeleteTableGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTableGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTableGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a table group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableGroupRequest"/></param>
        /// <returns><see cref="DeleteTableGroupResponse"/></returns>
        public DeleteTableGroupResponse DeleteTableGroupSync(DeleteTableGroupRequest req)
        {
             JsonResponseModel<DeleteTableGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTableGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTableGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to drop a table based on the specified table information.
        /// </summary>
        /// <param name="req"><see cref="DeleteTablesRequest"/></param>
        /// <returns><see cref="DeleteTablesResponse"/></returns>
        public async Task<DeleteTablesResponse> DeleteTables(DeleteTablesRequest req)
        {
             JsonResponseModel<DeleteTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to drop a table based on the specified table information.
        /// </summary>
        /// <param name="req"><see cref="DeleteTablesRequest"/></param>
        /// <returns><see cref="DeleteTablesResponse"/></returns>
        public DeleteTablesResponse DeleteTablesSync(DeleteTablesRequest req)
        {
             JsonResponseModel<DeleteTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the TcaplusDB cluster list, including cluster details.
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
        /// This API is used to query the TcaplusDB cluster list, including cluster details.
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
        /// This API is used to query table description file details.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns><see cref="DescribeIdlFileInfosResponse"/></returns>
        public async Task<DescribeIdlFileInfosResponse> DescribeIdlFileInfos(DescribeIdlFileInfosRequest req)
        {
             JsonResponseModel<DescribeIdlFileInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIdlFileInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdlFileInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query table description file details.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns><see cref="DescribeIdlFileInfosResponse"/></returns>
        public DescribeIdlFileInfosResponse DescribeIdlFileInfosSync(DescribeIdlFileInfosRequest req)
        {
             JsonResponseModel<DescribeIdlFileInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIdlFileInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdlFileInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of regions supported by the TcaplusDB service.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of regions supported by the TcaplusDB service.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the table group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupsResponse"/></returns>
        public async Task<DescribeTableGroupsResponse> DescribeTableGroups(DescribeTableGroupsRequest req)
        {
             JsonResponseModel<DescribeTableGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the table group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupsResponse"/></returns>
        public DescribeTableGroupsResponse DescribeTableGroupsSync(DescribeTableGroupsRequest req)
        {
             JsonResponseModel<DescribeTableGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query table details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public async Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query table details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a table in recycle bin.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns><see cref="DescribeTablesInRecycleResponse"/></returns>
        public async Task<DescribeTablesInRecycleResponse> DescribeTablesInRecycle(DescribeTablesInRecycleRequest req)
        {
             JsonResponseModel<DescribeTablesInRecycleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTablesInRecycle");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesInRecycleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a table in recycle bin.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns><see cref="DescribeTablesInRecycleResponse"/></returns>
        public DescribeTablesInRecycleResponse DescribeTablesInRecycleSync(DescribeTablesInRecycleRequest req)
        {
             JsonResponseModel<DescribeTablesInRecycleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTablesInRecycle");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesInRecycleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query whether the current user is in the whitelist and control whether the user can create TDR-type apps or tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns><see cref="DescribeUinInWhitelistResponse"/></returns>
        public async Task<DescribeUinInWhitelistResponse> DescribeUinInWhitelist(DescribeUinInWhitelistRequest req)
        {
             JsonResponseModel<DescribeUinInWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUinInWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUinInWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query whether the current user is in the whitelist and control whether the user can create TDR-type apps or tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns><see cref="DescribeUinInWhitelistResponse"/></returns>
        public DescribeUinInWhitelistResponse DescribeUinInWhitelistSync(DescribeUinInWhitelistRequest req)
        {
             JsonResponseModel<DescribeUinInWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUinInWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUinInWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a specified cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public async Task<ModifyClusterNameResponse> ModifyClusterName(ModifyClusterNameRequest req)
        {
             JsonResponseModel<ModifyClusterNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a specified cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public ModifyClusterNameResponse ModifyClusterNameSync(ModifyClusterNameRequest req)
        {
             JsonResponseModel<ModifyClusterNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the password of a specified cluster. The backend will allow the TcaplusDB SDK to access databases with both old and new passwords before the old password expires. You cannot submit a new password change request before the old password expires or submit a request to modify the expiration time of the old password after the old password expires.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordResponse"/></returns>
        public async Task<ModifyClusterPasswordResponse> ModifyClusterPassword(ModifyClusterPasswordRequest req)
        {
             JsonResponseModel<ModifyClusterPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the password of a specified cluster. The backend will allow the TcaplusDB SDK to access databases with both old and new passwords before the old password expires. You cannot submit a new password change request before the old password expires or submit a request to modify the expiration time of the old password after the old password expires.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordResponse"/></returns>
        public ModifyClusterPasswordResponse ModifyClusterPasswordSync(ModifyClusterPasswordRequest req)
        {
             JsonResponseModel<ModifyClusterPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a TcaplusDB table group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupNameRequest"/></param>
        /// <returns><see cref="ModifyTableGroupNameResponse"/></returns>
        public async Task<ModifyTableGroupNameResponse> ModifyTableGroupName(ModifyTableGroupNameRequest req)
        {
             JsonResponseModel<ModifyTableGroupNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableGroupName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableGroupNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a TcaplusDB table group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupNameRequest"/></param>
        /// <returns><see cref="ModifyTableGroupNameResponse"/></returns>
        public ModifyTableGroupNameResponse ModifyTableGroupNameSync(ModifyTableGroupNameRequest req)
        {
             JsonResponseModel<ModifyTableGroupNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableGroupName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableGroupNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify table remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableMemosRequest"/></param>
        /// <returns><see cref="ModifyTableMemosResponse"/></returns>
        public async Task<ModifyTableMemosResponse> ModifyTableMemos(ModifyTableMemosRequest req)
        {
             JsonResponseModel<ModifyTableMemosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableMemos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableMemosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify table remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableMemosRequest"/></param>
        /// <returns><see cref="ModifyTableMemosResponse"/></returns>
        public ModifyTableMemosResponse ModifyTableMemosSync(ModifyTableMemosRequest req)
        {
             JsonResponseModel<ModifyTableMemosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableMemos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableMemosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to scale a table.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableQuotasRequest"/></param>
        /// <returns><see cref="ModifyTableQuotasResponse"/></returns>
        public async Task<ModifyTableQuotasResponse> ModifyTableQuotas(ModifyTableQuotasRequest req)
        {
             JsonResponseModel<ModifyTableQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to scale a table.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableQuotasRequest"/></param>
        /// <returns><see cref="ModifyTableQuotasResponse"/></returns>
        public ModifyTableQuotasResponse ModifyTableQuotasSync(ModifyTableQuotasRequest req)
        {
             JsonResponseModel<ModifyTableQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify specified tables in batches based on the selected table definition IDL file.
        /// </summary>
        /// <param name="req"><see cref="ModifyTablesRequest"/></param>
        /// <returns><see cref="ModifyTablesResponse"/></returns>
        public async Task<ModifyTablesResponse> ModifyTables(ModifyTablesRequest req)
        {
             JsonResponseModel<ModifyTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify specified tables in batches based on the selected table definition IDL file.
        /// </summary>
        /// <param name="req"><see cref="ModifyTablesRequest"/></param>
        /// <returns><see cref="ModifyTablesResponse"/></returns>
        public ModifyTablesResponse ModifyTablesSync(ModifyTablesRequest req)
        {
             JsonResponseModel<ModifyTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recover a dropped table from the recycle bin. It will not work for tables to be released due to arrears.
        /// </summary>
        /// <param name="req"><see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns><see cref="RecoverRecycleTablesResponse"/></returns>
        public async Task<RecoverRecycleTablesResponse> RecoverRecycleTables(RecoverRecycleTablesRequest req)
        {
             JsonResponseModel<RecoverRecycleTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverRecycleTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverRecycleTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recover a dropped table from the recycle bin. It will not work for tables to be released due to arrears.
        /// </summary>
        /// <param name="req"><see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns><see cref="RecoverRecycleTablesResponse"/></returns>
        public RecoverRecycleTablesResponse RecoverRecycleTablesSync(RecoverRecycleTablesRequest req)
        {
             JsonResponseModel<RecoverRecycleTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverRecycleTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverRecycleTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to roll back table data.
        /// </summary>
        /// <param name="req"><see cref="RollbackTablesRequest"/></param>
        /// <returns><see cref="RollbackTablesResponse"/></returns>
        public async Task<RollbackTablesResponse> RollbackTables(RollbackTablesRequest req)
        {
             JsonResponseModel<RollbackTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to roll back table data.
        /// </summary>
        /// <param name="req"><see cref="RollbackTablesRequest"/></param>
        /// <returns><see cref="RollbackTablesResponse"/></returns>
        public RollbackTablesResponse RollbackTablesSync(RollbackTablesRequest req)
        {
             JsonResponseModel<RollbackTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload and verify a table creation file and return the definition of tables that are verified to be valid.
        /// </summary>
        /// <param name="req"><see cref="VerifyIdlFilesRequest"/></param>
        /// <returns><see cref="VerifyIdlFilesResponse"/></returns>
        public async Task<VerifyIdlFilesResponse> VerifyIdlFiles(VerifyIdlFilesRequest req)
        {
             JsonResponseModel<VerifyIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload and verify a table creation file and return the definition of tables that are verified to be valid.
        /// </summary>
        /// <param name="req"><see cref="VerifyIdlFilesRequest"/></param>
        /// <returns><see cref="VerifyIdlFilesResponse"/></returns>
        public VerifyIdlFilesResponse VerifyIdlFilesSync(VerifyIdlFilesRequest req)
        {
             JsonResponseModel<VerifyIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

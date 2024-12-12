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

namespace TencentCloud.Omics.V20221128
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Omics.V20221128.Models;

   public class OmicsClient : AbstractClient{

       private const string endpoint = "omics.tencentcloudapi.com";
       private const string version = "2022-11-28";
       private const string sdkVersion = "SDK_NET_3.0.1032";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OmicsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OmicsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create an environment for Tencent Healthcare Omics Platform.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment");
        }

        /// <summary>
        /// This API is used to create an environment for Tencent Healthcare Omics Platform.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a volume.
        /// </summary>
        /// <param name="req"><see cref="CreateVolumeRequest"/></param>
        /// <returns><see cref="CreateVolumeResponse"/></returns>
        public Task<CreateVolumeResponse> CreateVolume(CreateVolumeRequest req)
        {
            return InternalRequestAsync<CreateVolumeResponse>(req, "CreateVolume");
        }

        /// <summary>
        /// This API is used to create a volume.
        /// </summary>
        /// <param name="req"><see cref="CreateVolumeRequest"/></param>
        /// <returns><see cref="CreateVolumeResponse"/></returns>
        public CreateVolumeResponse CreateVolumeSync(CreateVolumeRequest req)
        {
            return InternalRequestAsync<CreateVolumeResponse>(req, "CreateVolume")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the environment.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentResponse"/></returns>
        public Task<DeleteEnvironmentResponse> DeleteEnvironment(DeleteEnvironmentRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentResponse>(req, "DeleteEnvironment");
        }

        /// <summary>
        /// This API is used to delete the environment.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentResponse"/></returns>
        public DeleteEnvironmentResponse DeleteEnvironmentSync(DeleteEnvironmentRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentResponse>(req, "DeleteEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the volume.
        /// </summary>
        /// <param name="req"><see cref="DeleteVolumeRequest"/></param>
        /// <returns><see cref="DeleteVolumeResponse"/></returns>
        public Task<DeleteVolumeResponse> DeleteVolume(DeleteVolumeRequest req)
        {
            return InternalRequestAsync<DeleteVolumeResponse>(req, "DeleteVolume");
        }

        /// <summary>
        /// This API is used to delete the volume.
        /// </summary>
        /// <param name="req"><see cref="DeleteVolumeRequest"/></param>
        /// <returns><see cref="DeleteVolumeResponse"/></returns>
        public DeleteVolumeResponse DeleteVolumeSync(DeleteVolumeRequest req)
        {
            return InternalRequestAsync<DeleteVolumeResponse>(req, "DeleteVolume")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the volume data.
        /// </summary>
        /// <param name="req"><see cref="DeleteVolumeDataRequest"/></param>
        /// <returns><see cref="DeleteVolumeDataResponse"/></returns>
        public Task<DeleteVolumeDataResponse> DeleteVolumeData(DeleteVolumeDataRequest req)
        {
            return InternalRequestAsync<DeleteVolumeDataResponse>(req, "DeleteVolumeData");
        }

        /// <summary>
        /// This API is used to delete the volume data.
        /// </summary>
        /// <param name="req"><see cref="DeleteVolumeDataRequest"/></param>
        /// <returns><see cref="DeleteVolumeDataResponse"/></returns>
        public DeleteVolumeDataResponse DeleteVolumeDataSync(DeleteVolumeDataRequest req)
        {
            return InternalRequestAsync<DeleteVolumeDataResponse>(req, "DeleteVolumeData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the environment list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// This API is used to query the environment list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the run group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRunGroupsRequest"/></param>
        /// <returns><see cref="DescribeRunGroupsResponse"/></returns>
        public Task<DescribeRunGroupsResponse> DescribeRunGroups(DescribeRunGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRunGroupsResponse>(req, "DescribeRunGroups");
        }

        /// <summary>
        /// This API is used to query the run group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRunGroupsRequest"/></param>
        /// <returns><see cref="DescribeRunGroupsResponse"/></returns>
        public DescribeRunGroupsResponse DescribeRunGroupsSync(DescribeRunGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRunGroupsResponse>(req, "DescribeRunGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the run list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRunsRequest"/></param>
        /// <returns><see cref="DescribeRunsResponse"/></returns>
        public Task<DescribeRunsResponse> DescribeRuns(DescribeRunsRequest req)
        {
            return InternalRequestAsync<DescribeRunsResponse>(req, "DescribeRuns");
        }

        /// <summary>
        /// This API is used to query the run list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRunsRequest"/></param>
        /// <returns><see cref="DescribeRunsResponse"/></returns>
        public DescribeRunsResponse DescribeRunsSync(DescribeRunsRequest req)
        {
            return InternalRequestAsync<DescribeRunsResponse>(req, "DescribeRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the table.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// This API is used to query the table.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the table row data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRowsRequest"/></param>
        /// <returns><see cref="DescribeTablesRowsResponse"/></returns>
        public Task<DescribeTablesRowsResponse> DescribeTablesRows(DescribeTablesRowsRequest req)
        {
            return InternalRequestAsync<DescribeTablesRowsResponse>(req, "DescribeTablesRows");
        }

        /// <summary>
        /// This API is used to query the table row data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRowsRequest"/></param>
        /// <returns><see cref="DescribeTablesRowsResponse"/></returns>
        public DescribeTablesRowsResponse DescribeTablesRowsSync(DescribeTablesRowsRequest req)
        {
            return InternalRequestAsync<DescribeTablesRowsResponse>(req, "DescribeTablesRows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the volume list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVolumesRequest"/></param>
        /// <returns><see cref="DescribeVolumesResponse"/></returns>
        public Task<DescribeVolumesResponse> DescribeVolumes(DescribeVolumesRequest req)
        {
            return InternalRequestAsync<DescribeVolumesResponse>(req, "DescribeVolumes");
        }

        /// <summary>
        /// This API is used to query the volume list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVolumesRequest"/></param>
        /// <returns><see cref="DescribeVolumesResponse"/></returns>
        public DescribeVolumesResponse DescribeVolumesSync(DescribeVolumesRequest req)
        {
            return InternalRequestAsync<DescribeVolumesResponse>(req, "DescribeVolumes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query job details.
        /// </summary>
        /// <param name="req"><see cref="GetRunCallsRequest"/></param>
        /// <returns><see cref="GetRunCallsResponse"/></returns>
        public Task<GetRunCallsResponse> GetRunCalls(GetRunCallsRequest req)
        {
            return InternalRequestAsync<GetRunCallsResponse>(req, "GetRunCalls");
        }

        /// <summary>
        /// This API is used to query job details.
        /// </summary>
        /// <param name="req"><see cref="GetRunCallsRequest"/></param>
        /// <returns><see cref="GetRunCallsResponse"/></returns>
        public GetRunCallsResponse GetRunCallsSync(GetRunCallsRequest req)
        {
            return InternalRequestAsync<GetRunCallsResponse>(req, "GetRunCalls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the run details file.
        /// </summary>
        /// <param name="req"><see cref="GetRunMetadataFileRequest"/></param>
        /// <returns><see cref="GetRunMetadataFileResponse"/></returns>
        public Task<GetRunMetadataFileResponse> GetRunMetadataFile(GetRunMetadataFileRequest req)
        {
            return InternalRequestAsync<GetRunMetadataFileResponse>(req, "GetRunMetadataFile");
        }

        /// <summary>
        /// This API is used to get the run details file.
        /// </summary>
        /// <param name="req"><see cref="GetRunMetadataFileRequest"/></param>
        /// <returns><see cref="GetRunMetadataFileResponse"/></returns>
        public GetRunMetadataFileResponse GetRunMetadataFileSync(GetRunMetadataFileRequest req)
        {
            return InternalRequestAsync<GetRunMetadataFileResponse>(req, "GetRunMetadataFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query run details.
        /// </summary>
        /// <param name="req"><see cref="GetRunStatusRequest"/></param>
        /// <returns><see cref="GetRunStatusResponse"/></returns>
        public Task<GetRunStatusResponse> GetRunStatus(GetRunStatusRequest req)
        {
            return InternalRequestAsync<GetRunStatusResponse>(req, "GetRunStatus");
        }

        /// <summary>
        /// This API is used to query run details.
        /// </summary>
        /// <param name="req"><see cref="GetRunStatusRequest"/></param>
        /// <returns><see cref="GetRunStatusResponse"/></returns>
        public GetRunStatusResponse GetRunStatusSync(GetRunStatusRequest req)
        {
            return InternalRequestAsync<GetRunStatusResponse>(req, "GetRunStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import the table file.
        /// </summary>
        /// <param name="req"><see cref="ImportTableFileRequest"/></param>
        /// <returns><see cref="ImportTableFileResponse"/></returns>
        public Task<ImportTableFileResponse> ImportTableFile(ImportTableFileRequest req)
        {
            return InternalRequestAsync<ImportTableFileResponse>(req, "ImportTableFile");
        }

        /// <summary>
        /// This API is used to import the table file.
        /// </summary>
        /// <param name="req"><see cref="ImportTableFileRequest"/></param>
        /// <returns><see cref="ImportTableFileResponse"/></returns>
        public ImportTableFileResponse ImportTableFileSync(ImportTableFileRequest req)
        {
            return InternalRequestAsync<ImportTableFileResponse>(req, "ImportTableFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the volume.
        /// </summary>
        /// <param name="req"><see cref="ModifyVolumeRequest"/></param>
        /// <returns><see cref="ModifyVolumeResponse"/></returns>
        public Task<ModifyVolumeResponse> ModifyVolume(ModifyVolumeRequest req)
        {
            return InternalRequestAsync<ModifyVolumeResponse>(req, "ModifyVolume");
        }

        /// <summary>
        /// This API is used to modify the volume.
        /// </summary>
        /// <param name="req"><see cref="ModifyVolumeRequest"/></param>
        /// <returns><see cref="ModifyVolumeResponse"/></returns>
        public ModifyVolumeResponse ModifyVolumeSync(ModifyVolumeRequest req)
        {
            return InternalRequestAsync<ModifyVolumeResponse>(req, "ModifyVolume")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry the run.
        /// </summary>
        /// <param name="req"><see cref="RetryRunsRequest"/></param>
        /// <returns><see cref="RetryRunsResponse"/></returns>
        public Task<RetryRunsResponse> RetryRuns(RetryRunsRequest req)
        {
            return InternalRequestAsync<RetryRunsResponse>(req, "RetryRuns");
        }

        /// <summary>
        /// This API is used to retry the run.
        /// </summary>
        /// <param name="req"><see cref="RetryRunsRequest"/></param>
        /// <returns><see cref="RetryRunsResponse"/></returns>
        public RetryRunsResponse RetryRunsSync(RetryRunsRequest req)
        {
            return InternalRequestAsync<RetryRunsResponse>(req, "RetryRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to run the application.
        /// </summary>
        /// <param name="req"><see cref="RunApplicationRequest"/></param>
        /// <returns><see cref="RunApplicationResponse"/></returns>
        public Task<RunApplicationResponse> RunApplication(RunApplicationRequest req)
        {
            return InternalRequestAsync<RunApplicationResponse>(req, "RunApplication");
        }

        /// <summary>
        /// This API is used to run the application.
        /// </summary>
        /// <param name="req"><see cref="RunApplicationRequest"/></param>
        /// <returns><see cref="RunApplicationResponse"/></returns>
        public RunApplicationResponse RunApplicationSync(RunApplicationRequest req)
        {
            return InternalRequestAsync<RunApplicationResponse>(req, "RunApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to run the workflow.
        /// </summary>
        /// <param name="req"><see cref="RunWorkflowRequest"/></param>
        /// <returns><see cref="RunWorkflowResponse"/></returns>
        public Task<RunWorkflowResponse> RunWorkflow(RunWorkflowRequest req)
        {
            return InternalRequestAsync<RunWorkflowResponse>(req, "RunWorkflow");
        }

        /// <summary>
        /// This API is used to run the workflow.
        /// </summary>
        /// <param name="req"><see cref="RunWorkflowRequest"/></param>
        /// <returns><see cref="RunWorkflowResponse"/></returns>
        public RunWorkflowResponse RunWorkflowSync(RunWorkflowRequest req)
        {
            return InternalRequestAsync<RunWorkflowResponse>(req, "RunWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate the run group.
        /// </summary>
        /// <param name="req"><see cref="TerminateRunGroupRequest"/></param>
        /// <returns><see cref="TerminateRunGroupResponse"/></returns>
        public Task<TerminateRunGroupResponse> TerminateRunGroup(TerminateRunGroupRequest req)
        {
            return InternalRequestAsync<TerminateRunGroupResponse>(req, "TerminateRunGroup");
        }

        /// <summary>
        /// This API is used to terminate the run group.
        /// </summary>
        /// <param name="req"><see cref="TerminateRunGroupRequest"/></param>
        /// <returns><see cref="TerminateRunGroupResponse"/></returns>
        public TerminateRunGroupResponse TerminateRunGroupSync(TerminateRunGroupRequest req)
        {
            return InternalRequestAsync<TerminateRunGroupResponse>(req, "TerminateRunGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

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

namespace TencentCloud.Redis.V20180412
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Redis.V20180412.Models;

   public class RedisClient : AbstractClient{

       private const string endpoint = "redis.tencentcloudapi.com";
       private const string version = "2018-04-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RedisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RedisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to enable public network access.
        /// </summary>
        /// <param name="req"><see cref="AllocateWanAddressRequest"/></param>
        /// <returns><see cref="AllocateWanAddressResponse"/></returns>
        public async Task<AllocateWanAddressResponse> AllocateWanAddress(AllocateWanAddressRequest req)
        {
             JsonResponseModel<AllocateWanAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateWanAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateWanAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable public network access.
        /// </summary>
        /// <param name="req"><see cref="AllocateWanAddressRequest"/></param>
        /// <returns><see cref="AllocateWanAddressResponse"/></returns>
        public AllocateWanAddressResponse AllocateWanAddressSync(AllocateWanAddressRequest req)
        {
             JsonResponseModel<AllocateWanAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateWanAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateWanAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply a parameter template to instances.
        /// </summary>
        /// <param name="req"><see cref="ApplyParamsTemplateRequest"/></param>
        /// <returns><see cref="ApplyParamsTemplateResponse"/></returns>
        public async Task<ApplyParamsTemplateResponse> ApplyParamsTemplate(ApplyParamsTemplateRequest req)
        {
             JsonResponseModel<ApplyParamsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyParamsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyParamsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply a parameter template to instances.
        /// </summary>
        /// <param name="req"><see cref="ApplyParamsTemplateRequest"/></param>
        /// <returns><see cref="ApplyParamsTemplateResponse"/></returns>
        public ApplyParamsTemplateResponse ApplyParamsTemplateSync(ApplyParamsTemplateRequest req)
        {
             JsonResponseModel<ApplyParamsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyParamsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyParamsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a security group to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a security group to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the role of an instance in a replication group.
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceRoleRequest"/></param>
        /// <returns><see cref="ChangeInstanceRoleResponse"/></returns>
        public async Task<ChangeInstanceRoleResponse> ChangeInstanceRole(ChangeInstanceRoleRequest req)
        {
             JsonResponseModel<ChangeInstanceRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeInstanceRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeInstanceRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the role of an instance in a replication group.
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceRoleRequest"/></param>
        /// <returns><see cref="ChangeInstanceRoleResponse"/></returns>
        public ChangeInstanceRoleResponse ChangeInstanceRoleSync(ChangeInstanceRoleRequest req)
        {
             JsonResponseModel<ChangeInstanceRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeInstanceRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeInstanceRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch with master instance in a replication group.
        /// </summary>
        /// <param name="req"><see cref="ChangeMasterInstanceRequest"/></param>
        /// <returns><see cref="ChangeMasterInstanceResponse"/></returns>
        public async Task<ChangeMasterInstanceResponse> ChangeMasterInstance(ChangeMasterInstanceRequest req)
        {
             JsonResponseModel<ChangeMasterInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeMasterInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeMasterInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch with master instance in a replication group.
        /// </summary>
        /// <param name="req"><see cref="ChangeMasterInstanceRequest"/></param>
        /// <returns><see cref="ChangeMasterInstanceResponse"/></returns>
        public ChangeMasterInstanceResponse ChangeMasterInstanceSync(ChangeMasterInstanceRequest req)
        {
             JsonResponseModel<ChangeMasterInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeMasterInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeMasterInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to promote a replica node group of a multi-AZ deployed instance to master node group or a replica node of a single-AZ deployed instance to master node.
        /// </summary>
        /// <param name="req"><see cref="ChangeReplicaToMasterRequest"/></param>
        /// <returns><see cref="ChangeReplicaToMasterResponse"/></returns>
        public async Task<ChangeReplicaToMasterResponse> ChangeReplicaToMaster(ChangeReplicaToMasterRequest req)
        {
             JsonResponseModel<ChangeReplicaToMasterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeReplicaToMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeReplicaToMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to promote a replica node group of a multi-AZ deployed instance to master node group or a replica node of a single-AZ deployed instance to master node.
        /// </summary>
        /// <param name="req"><see cref="ChangeReplicaToMasterRequest"/></param>
        /// <returns><see cref="ChangeReplicaToMasterResponse"/></returns>
        public ChangeReplicaToMasterResponse ChangeReplicaToMasterSync(ChangeReplicaToMasterRequest req)
        {
             JsonResponseModel<ChangeReplicaToMasterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeReplicaToMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeReplicaToMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to eliminate an instance in the recycle bin immediately.
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public async Task<CleanUpInstanceResponse> CleanUpInstance(CleanUpInstanceRequest req)
        {
             JsonResponseModel<CleanUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CleanUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to eliminate an instance in the recycle bin immediately.
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public CleanUpInstanceResponse CleanUpInstanceSync(CleanUpInstanceRequest req)
        {
             JsonResponseModel<CleanUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CleanUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear the data of a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public async Task<ClearInstanceResponse> ClearInstance(ClearInstanceRequest req)
        {
             JsonResponseModel<ClearInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear the data of a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public ClearInstanceResponse ClearInstanceSync(ClearInstanceRequest req)
        {
             JsonResponseModel<ClearInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable SSL.
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public async Task<CloseSSLResponse> CloseSSL(CloseSSLRequest req)
        {
             JsonResponseModel<CloseSSLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseSSL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseSSLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable SSL.
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public CloseSSLResponse CloseSSLSync(CloseSSLRequest req)
        {
             JsonResponseModel<CloseSSLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseSSL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseSSLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public async Task<CreateInstanceAccountResponse> CreateInstanceAccount(CreateInstanceAccountRequest req)
        {
             JsonResponseModel<CreateInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public CreateInstanceAccountResponse CreateInstanceAccountSync(CreateInstanceAccountRequest req)
        {
             JsonResponseModel<CreateInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public async Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public async Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
             JsonResponseModel<CreateParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
             JsonResponseModel<CreateParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public async Task<DeleteInstanceAccountResponse> DeleteInstanceAccount(DeleteInstanceAccountRequest req)
        {
             JsonResponseModel<DeleteInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public DeleteInstanceAccountResponse DeleteInstanceAccountSync(DeleteInstanceAccountRequest req)
        {
             JsonResponseModel<DeleteInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public async Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
             JsonResponseModel<DeleteParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
             JsonResponseModel<DeleteParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the backup configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public async Task<DescribeAutoBackupConfigResponse> DescribeAutoBackupConfig(DescribeAutoBackupConfigRequest req)
        {
             JsonResponseModel<DescribeAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the backup configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public DescribeAutoBackupConfigResponse DescribeAutoBackupConfigSync(DescribeAutoBackupConfigRequest req)
        {
             JsonResponseModel<DescribeAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download address of a backup RDB (it is in beta test and can be used only after you apply for the eligibility).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public async Task<DescribeBackupUrlResponse> DescribeBackupUrl(DescribeBackupUrlRequest req)
        {
             JsonResponseModel<DescribeBackupUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download address of a backup RDB (it is in beta test and can be used only after you apply for the eligibility).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public DescribeBackupUrlResponse DescribeBackupUrlSync(DescribeBackupUrlRequest req)
        {
             JsonResponseModel<DescribeBackupUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API has been disused. It was used to query the list of Redis instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeCommonDBInstancesResponse"/></returns>
        public async Task<DescribeCommonDBInstancesResponse> DescribeCommonDBInstances(DescribeCommonDBInstancesRequest req)
        {
             JsonResponseModel<DescribeCommonDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCommonDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCommonDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API has been disused. It was used to query the list of Redis instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeCommonDBInstancesResponse"/></returns>
        public DescribeCommonDBInstancesResponse DescribeCommonDBInstancesSync(DescribeCommonDBInstancesRequest req)
        {
             JsonResponseModel<DescribeCommonDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCommonDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCommonDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public async Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view instance sub-account information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public async Task<DescribeInstanceAccountResponse> DescribeInstanceAccount(DescribeInstanceAccountRequest req)
        {
             JsonResponseModel<DescribeInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view instance sub-account information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public DescribeInstanceAccountResponse DescribeInstanceAccountSync(DescribeInstanceAccountRequest req)
        {
             JsonResponseModel<DescribeInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Redis instance backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public async Task<DescribeInstanceBackupsResponse> DescribeInstanceBackups(DescribeInstanceBackupsRequest req)
        {
             JsonResponseModel<DescribeInstanceBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Redis instance backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public DescribeInstanceBackupsResponse DescribeInstanceBackupsSync(DescribeInstanceBackupsRequest req)
        {
             JsonResponseModel<DescribeInstanceBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the DTS task details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public async Task<DescribeInstanceDTSInfoResponse> DescribeInstanceDTSInfo(DescribeInstanceDTSInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceDTSInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDTSInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDTSInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the DTS task details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public DescribeInstanceDTSInfoResponse DescribeInstanceDTSInfoSync(DescribeInstanceDTSInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceDTSInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDTSInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDTSInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public async Task<DescribeInstanceDealDetailResponse> DescribeInstanceDealDetail(DescribeInstanceDealDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDealDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDealDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDealDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public DescribeInstanceDealDetailResponse DescribeInstanceDealDetailSync(DescribeInstanceDealDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDealDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDealDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDealDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeyResponse> DescribeInstanceMonitorBigKey(DescribeInstanceMonitorBigKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public DescribeInstanceMonitorBigKeyResponse DescribeInstanceMonitorBigKeySync(DescribeInstanceMonitorBigKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key size distribution of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeySizeDistResponse> DescribeInstanceMonitorBigKeySizeDist(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKeySizeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key size distribution of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeySizeDistResponse DescribeInstanceMonitorBigKeySizeDistSync(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKeySizeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key type distribution of an instance
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeyTypeDistResponse> DescribeInstanceMonitorBigKeyTypeDist(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKeyTypeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key type distribution of an instance
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeyTypeDistResponse DescribeInstanceMonitorBigKeyTypeDistSync(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKeyTypeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the hot key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public async Task<DescribeInstanceMonitorHotKeyResponse> DescribeInstanceMonitorHotKey(DescribeInstanceMonitorHotKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorHotKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorHotKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorHotKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the hot key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public DescribeInstanceMonitorHotKeyResponse DescribeInstanceMonitorHotKeySync(DescribeInstanceMonitorHotKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorHotKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorHotKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorHotKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the access source information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public async Task<DescribeInstanceMonitorSIPResponse> DescribeInstanceMonitorSIP(DescribeInstanceMonitorSIPRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorSIPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorSIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorSIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the access source information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public DescribeInstanceMonitorSIPResponse DescribeInstanceMonitorSIPSync(DescribeInstanceMonitorSIPRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorSIPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorSIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorSIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the distribution of instance access duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorTookDistResponse> DescribeInstanceMonitorTookDist(DescribeInstanceMonitorTookDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTookDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTookDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTookDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the distribution of instance access duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public DescribeInstanceMonitorTookDistResponse DescribeInstanceMonitorTookDistSync(DescribeInstanceMonitorTookDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTookDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTookDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTookDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an instance access command.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public async Task<DescribeInstanceMonitorTopNCmdResponse> DescribeInstanceMonitorTopNCmd(DescribeInstanceMonitorTopNCmdRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTopNCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an instance access command.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdResponse DescribeInstanceMonitorTopNCmdSync(DescribeInstanceMonitorTopNCmdRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTopNCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instance CPU time.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public async Task<DescribeInstanceMonitorTopNCmdTookResponse> DescribeInstanceMonitorTopNCmdTook(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTopNCmdTook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instance CPU time.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdTookResponse DescribeInstanceMonitorTopNCmdTookSync(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTopNCmdTook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query instance node information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public async Task<DescribeInstanceNodeInfoResponse> DescribeInstanceNodeInfo(DescribeInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query instance node information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public DescribeInstanceNodeInfoResponse DescribeInstanceNodeInfoSync(DescribeInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of parameter modifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public async Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceParamRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of parameter modifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceParamRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of instance parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public async Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of instance parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public async Task<DescribeInstanceSecurityGroupResponse> DescribeInstanceSecurityGroup(DescribeInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public DescribeInstanceSecurityGroupResponse DescribeInstanceSecurityGroupSync(DescribeInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of Cluster Edition instance shards.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public async Task<DescribeInstanceShardsResponse> DescribeInstanceShards(DescribeInstanceShardsRequest req)
        {
             JsonResponseModel<DescribeInstanceShardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of Cluster Edition instance shards.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public DescribeInstanceShardsResponse DescribeInstanceShardsSync(DescribeInstanceShardsRequest req)
        {
             JsonResponseModel<DescribeInstanceShardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the Redis node details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceZoneInfoResponse"/></returns>
        public async Task<DescribeInstanceZoneInfoResponse> DescribeInstanceZoneInfo(DescribeInstanceZoneInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the Redis node details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceZoneInfoResponse"/></returns>
        public DescribeInstanceZoneInfoResponse DescribeInstanceZoneInfoSync(DescribeInstanceZoneInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Redis instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Redis instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query instance maintenance window. The maintenance window specifies a time period during which compatible version upgrade, architecture upgrade, backend maintenance, and other operations can be performed to avoid affecting business.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public async Task<DescribeMaintenanceWindowResponse> DescribeMaintenanceWindow(DescribeMaintenanceWindowRequest req)
        {
             JsonResponseModel<DescribeMaintenanceWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMaintenanceWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaintenanceWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query instance maintenance window. The maintenance window specifies a time period during which compatible version upgrade, architecture upgrade, backend maintenance, and other operations can be performed to avoid affecting business.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public DescribeMaintenanceWindowResponse DescribeMaintenanceWindowSync(DescribeMaintenanceWindowRequest req)
        {
             JsonResponseModel<DescribeMaintenanceWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMaintenanceWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaintenanceWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the parameter template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public async Task<DescribeParamTemplateInfoResponse> DescribeParamTemplateInfo(DescribeParamTemplateInfoRequest req)
        {
             JsonResponseModel<DescribeParamTemplateInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamTemplateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the parameter template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public DescribeParamTemplateInfoResponse DescribeParamTemplateInfoSync(DescribeParamTemplateInfoRequest req)
        {
             JsonResponseModel<DescribeParamTemplateInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamTemplateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of parameter templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public async Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
             JsonResponseModel<DescribeParamTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of parameter templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
             JsonResponseModel<DescribeParamTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable capacity specifications of Redis instances in the specified AZ and instance type. If you are not in the allowlist for the AZ or instance type, you cannot view the details of the capacity specifications. To apply for the eligibility, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public async Task<DescribeProductInfoResponse> DescribeProductInfo(DescribeProductInfoRequest req)
        {
             JsonResponseModel<DescribeProductInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable capacity specifications of Redis instances in the specified AZ and instance type. If you are not in the allowlist for the AZ or instance type, you cannot view the details of the capacity specifications. To apply for the eligibility, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public DescribeProductInfoResponse DescribeProductInfoSync(DescribeProductInfoRequest req)
        {
             JsonResponseModel<DescribeProductInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group information of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupResponse> DescribeProjectSecurityGroup(DescribeProjectSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group information of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public DescribeProjectSecurityGroupResponse DescribeProjectSecurityGroupSync(DescribeProjectSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the slow queries of the proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public async Task<DescribeProxySlowLogResponse> DescribeProxySlowLog(DescribeProxySlowLogRequest req)
        {
             JsonResponseModel<DescribeProxySlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxySlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxySlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the slow queries of the proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public DescribeProxySlowLogResponse DescribeProxySlowLogSync(DescribeProxySlowLogRequest req)
        {
             JsonResponseModel<DescribeProxySlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxySlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxySlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the global replication group.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationGroupRequest"/></param>
        /// <returns><see cref="DescribeReplicationGroupResponse"/></returns>
        public async Task<DescribeReplicationGroupResponse> DescribeReplicationGroup(DescribeReplicationGroupRequest req)
        {
             JsonResponseModel<DescribeReplicationGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the global replication group.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationGroupRequest"/></param>
        /// <returns><see cref="DescribeReplicationGroupResponse"/></returns>
        public DescribeReplicationGroupResponse DescribeReplicationGroupSync(DescribeReplicationGroupRequest req)
        {
             JsonResponseModel<DescribeReplicationGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the records of slow query.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public async Task<DescribeSlowLogResponse> DescribeSlowLog(DescribeSlowLogRequest req)
        {
             JsonResponseModel<DescribeSlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the records of slow query.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public DescribeSlowLogResponse DescribeSlowLogSync(DescribeSlowLogRequest req)
        {
             JsonResponseModel<DescribeSlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task result.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public async Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task result.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public async Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query slow queries of a Tendis instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public async Task<DescribeTendisSlowLogResponse> DescribeTendisSlowLog(DescribeTendisSlowLogRequest req)
        {
             JsonResponseModel<DescribeTendisSlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTendisSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTendisSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query slow queries of a Tendis instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public DescribeTendisSlowLogResponse DescribeTendisSlowLogSync(DescribeTendisSlowLogRequest req)
        {
             JsonResponseModel<DescribeTendisSlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTendisSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTendisSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public async Task<DestroyPostpaidInstanceResponse> DestroyPostpaidInstance(DestroyPostpaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPostpaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPostpaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPostpaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public DestroyPostpaidInstanceResponse DestroyPostpaidInstanceSync(DestroyPostpaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPostpaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPostpaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPostpaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return a monthly subscribed instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public async Task<DestroyPrepaidInstanceResponse> DestroyPrepaidInstance(DestroyPrepaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPrepaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPrepaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrepaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return a monthly subscribed instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public DestroyPrepaidInstanceResponse DestroyPrepaidInstanceSync(DestroyPrepaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPrepaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPrepaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrepaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public async Task<DisableReplicaReadonlyResponse> DisableReplicaReadonly(DisableReplicaReadonlyRequest req)
        {
             JsonResponseModel<DisableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public DisableReplicaReadonlyResponse DisableReplicaReadonlySync(DisableReplicaReadonlyRequest req)
        {
             JsonResponseModel<DisableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a security group from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a security group from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public async Task<EnableReplicaReadonlyResponse> EnableReplicaReadonly(EnableReplicaReadonlyRequest req)
        {
             JsonResponseModel<EnableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public EnableReplicaReadonlyResponse EnableReplicaReadonlySync(EnableReplicaReadonlyRequest req)
        {
             JsonResponseModel<EnableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for purchasing an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public async Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for purchasing an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for scaling an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstanceResponse"/></returns>
        public async Task<InquiryPriceUpgradeInstanceResponse> InquiryPriceUpgradeInstance(InquiryPriceUpgradeInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for scaling an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstanceResponse"/></returns>
        public InquiryPriceUpgradeInstanceResponse InquiryPriceUpgradeInstanceSync(InquiryPriceUpgradeInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to perform a failure simulation.
        /// </summary>
        /// <param name="req"><see cref="KillMasterGroupRequest"/></param>
        /// <returns><see cref="KillMasterGroupResponse"/></returns>
        public async Task<KillMasterGroupResponse> KillMasterGroup(KillMasterGroupRequest req)
        {
             JsonResponseModel<KillMasterGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KillMasterGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillMasterGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to perform a failure simulation.
        /// </summary>
        /// <param name="req"><see cref="KillMasterGroupRequest"/></param>
        /// <returns><see cref="KillMasterGroupResponse"/></returns>
        public KillMasterGroupResponse KillMasterGroupSync(KillMasterGroupRequest req)
        {
             JsonResponseModel<KillMasterGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KillMasterGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillMasterGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manually back up a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public async Task<ManualBackupInstanceResponse> ManualBackupInstance(ManualBackupInstanceRequest req)
        {
             JsonResponseModel<ManualBackupInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManualBackupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualBackupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manually back up a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public ManualBackupInstanceResponse ManualBackupInstanceSync(ManualBackupInstanceRequest req)
        {
             JsonResponseModel<ManualBackupInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManualBackupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualBackupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the Redis password.
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public async Task<ModfiyInstancePasswordResponse> ModfiyInstancePassword(ModfiyInstancePasswordRequest req)
        {
             JsonResponseModel<ModfiyInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModfiyInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModfiyInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the Redis password.
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public ModfiyInstancePasswordResponse ModfiyInstancePasswordSync(ModfiyInstancePasswordRequest req)
        {
             JsonResponseModel<ModfiyInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModfiyInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModfiyInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure automatic backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public async Task<ModifyAutoBackupConfigResponse> ModifyAutoBackupConfig(ModifyAutoBackupConfigRequest req)
        {
             JsonResponseModel<ModifyAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure automatic backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public ModifyAutoBackupConfigResponse ModifyAutoBackupConfigSync(ModifyAutoBackupConfigRequest req)
        {
             JsonResponseModel<ModifyAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public async Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public async Task<ModifyInstanceAccountResponse> ModifyInstanceAccount(ModifyInstanceAccountRequest req)
        {
             JsonResponseModel<ModifyInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public ModifyInstanceAccountResponse ModifyInstanceAccountSync(ModifyInstanceAccountRequest req)
        {
             JsonResponseModel<ModifyInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the parameters of TencentDB for Redis instances
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public async Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
             JsonResponseModel<ModifyInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the parameters of TencentDB for Redis instances
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
             JsonResponseModel<ModifyInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set instance input mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyInstanceReadOnlyResponse"/></returns>
        public async Task<ModifyInstanceReadOnlyResponse> ModifyInstanceReadOnly(ModifyInstanceReadOnlyRequest req)
        {
             JsonResponseModel<ModifyInstanceReadOnlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceReadOnly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceReadOnlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set instance input mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyInstanceReadOnlyResponse"/></returns>
        public ModifyInstanceReadOnlyResponse ModifyInstanceReadOnlySync(ModifyInstanceReadOnlyRequest req)
        {
             JsonResponseModel<ModifyInstanceReadOnlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceReadOnly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceReadOnlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the instance maintenance time. The maintenance time specifies a time period during which compatible version upgrade, architecture upgrade, backend maintenance, and other operations can be performed to avoid affecting business. Note: if the compatible version upgrade or architecture upgrade task has been initiated for an instance, its maintenance time cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public async Task<ModifyMaintenanceWindowResponse> ModifyMaintenanceWindow(ModifyMaintenanceWindowRequest req)
        {
             JsonResponseModel<ModifyMaintenanceWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMaintenanceWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaintenanceWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the instance maintenance time. The maintenance time specifies a time period during which compatible version upgrade, architecture upgrade, backend maintenance, and other operations can be performed to avoid affecting business. Note: if the compatible version upgrade or architecture upgrade task has been initiated for an instance, its maintenance time cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public ModifyMaintenanceWindowResponse ModifyMaintenanceWindowSync(ModifyMaintenanceWindowRequest req)
        {
             JsonResponseModel<ModifyMaintenanceWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMaintenanceWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaintenanceWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the network configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public async Task<ModifyNetworkConfigResponse> ModifyNetworkConfig(ModifyNetworkConfigRequest req)
        {
             JsonResponseModel<ModifyNetworkConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the network configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public ModifyNetworkConfigResponse ModifyNetworkConfigSync(ModifyNetworkConfigRequest req)
        {
             JsonResponseModel<ModifyNetworkConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a parameter template.
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public async Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
             JsonResponseModel<ModifyParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a parameter template.
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
             JsonResponseModel<ModifyParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable SSL.
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public async Task<OpenSSLResponse> OpenSSL(OpenSSLRequest req)
        {
             JsonResponseModel<OpenSSLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenSSL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenSSLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable SSL.
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public OpenSSLResponse OpenSSLSync(OpenSSLRequest req)
        {
             JsonResponseModel<OpenSSLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenSSL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenSSLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable public network access.
        /// </summary>
        /// <param name="req"><see cref="ReleaseWanAddressRequest"/></param>
        /// <returns><see cref="ReleaseWanAddressResponse"/></returns>
        public async Task<ReleaseWanAddressResponse> ReleaseWanAddress(ReleaseWanAddressRequest req)
        {
             JsonResponseModel<ReleaseWanAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseWanAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseWanAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable public network access.
        /// </summary>
        /// <param name="req"><see cref="ReleaseWanAddressRequest"/></param>
        /// <returns><see cref="ReleaseWanAddressResponse"/></returns>
        public ReleaseWanAddressResponse ReleaseWanAddressSync(ReleaseWanAddressRequest req)
        {
             JsonResponseModel<ReleaseWanAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseWanAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseWanAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew an instance.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public async Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew an instance.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset a password.
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public async Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
             JsonResponseModel<ResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset a password.
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
             JsonResponseModel<ResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public async Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deisolate an instance.
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public async Task<StartupInstanceResponse> StartupInstance(StartupInstanceRequest req)
        {
             JsonResponseModel<StartupInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deisolate an instance.
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public StartupInstanceResponse StartupInstanceSync(StartupInstanceRequest req)
        {
             JsonResponseModel<StartupInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to swap the VIPs of instances for instance disaster recovery switch in scenarios where cross-AZ disaster recovery is supported through DTS. After the VIPs of the source and target instances are swapped, the target instance can be written into and the DTS sync task between them will be disconnected.
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public async Task<SwitchInstanceVipResponse> SwitchInstanceVip(SwitchInstanceVipRequest req)
        {
             JsonResponseModel<SwitchInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to swap the VIPs of instances for instance disaster recovery switch in scenarios where cross-AZ disaster recovery is supported through DTS. After the VIPs of the source and target instances are swapped, the target instance can be written into and the DTS sync task between them will be disconnected.
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public SwitchInstanceVipResponse SwitchInstanceVipSync(SwitchInstanceVipRequest req)
        {
             JsonResponseModel<SwitchInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to simulate the failure of a proxy node.
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyRequest"/></param>
        /// <returns><see cref="SwitchProxyResponse"/></returns>
        public async Task<SwitchProxyResponse> SwitchProxy(SwitchProxyRequest req)
        {
             JsonResponseModel<SwitchProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to simulate the failure of a proxy node.
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyRequest"/></param>
        /// <returns><see cref="SwitchProxyResponse"/></returns>
        public SwitchProxyResponse SwitchProxySync(SwitchProxyRequest req)
        {
             JsonResponseModel<SwitchProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade an instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade an instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade compatible instance version (for example, from Redis 2.8 to 4.0), or upgrade instance architecture (for example, from standard architecture to cluster architecture).
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeInstanceVersionResponse"/></returns>
        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersion(UpgradeInstanceVersionRequest req)
        {
             JsonResponseModel<UpgradeInstanceVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeInstanceVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade compatible instance version (for example, from Redis 2.8 to 4.0), or upgrade instance architecture (for example, from standard architecture to cluster architecture).
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeInstanceVersionResponse"/></returns>
        public UpgradeInstanceVersionResponse UpgradeInstanceVersionSync(UpgradeInstanceVersionRequest req)
        {
             JsonResponseModel<UpgradeInstanceVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeInstanceVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade instance proxy version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public async Task<UpgradeProxyVersionResponse> UpgradeProxyVersion(UpgradeProxyVersionRequest req)
        {
             JsonResponseModel<UpgradeProxyVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeProxyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeProxyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade instance proxy version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public UpgradeProxyVersionResponse UpgradeProxyVersionSync(UpgradeProxyVersionRequest req)
        {
             JsonResponseModel<UpgradeProxyVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeProxyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeProxyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade instance minor version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeSmallVersionRequest"/></param>
        /// <returns><see cref="UpgradeSmallVersionResponse"/></returns>
        public async Task<UpgradeSmallVersionResponse> UpgradeSmallVersion(UpgradeSmallVersionRequest req)
        {
             JsonResponseModel<UpgradeSmallVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeSmallVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeSmallVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade instance minor version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeSmallVersionRequest"/></param>
        /// <returns><see cref="UpgradeSmallVersionResponse"/></returns>
        public UpgradeSmallVersionResponse UpgradeSmallVersionSync(UpgradeSmallVersionRequest req)
        {
             JsonResponseModel<UpgradeSmallVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeSmallVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeSmallVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade an instance to support multi-AZ deployment.
        /// </summary>
        /// <param name="req"><see cref="UpgradeVersionToMultiAvailabilityZonesRequest"/></param>
        /// <returns><see cref="UpgradeVersionToMultiAvailabilityZonesResponse"/></returns>
        public async Task<UpgradeVersionToMultiAvailabilityZonesResponse> UpgradeVersionToMultiAvailabilityZones(UpgradeVersionToMultiAvailabilityZonesRequest req)
        {
             JsonResponseModel<UpgradeVersionToMultiAvailabilityZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeVersionToMultiAvailabilityZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeVersionToMultiAvailabilityZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade an instance to support multi-AZ deployment.
        /// </summary>
        /// <param name="req"><see cref="UpgradeVersionToMultiAvailabilityZonesRequest"/></param>
        /// <returns><see cref="UpgradeVersionToMultiAvailabilityZonesResponse"/></returns>
        public UpgradeVersionToMultiAvailabilityZonesResponse UpgradeVersionToMultiAvailabilityZonesSync(UpgradeVersionToMultiAvailabilityZonesRequest req)
        {
             JsonResponseModel<UpgradeVersionToMultiAvailabilityZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeVersionToMultiAvailabilityZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeVersionToMultiAvailabilityZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

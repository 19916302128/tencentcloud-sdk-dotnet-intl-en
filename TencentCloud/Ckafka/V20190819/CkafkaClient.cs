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

namespace TencentCloud.Ckafka.V20190819
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ckafka.V20190819.Models;

   public class CkafkaClient : AbstractClient{

       private const string endpoint = "ckafka.tencentcloudapi.com";
       private const string version = "2019-08-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CkafkaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CkafkaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create ACL policies in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateAclRequest"/></param>
        /// <returns><see cref="BatchCreateAclResponse"/></returns>
        public async Task<BatchCreateAclResponse> BatchCreateAcl(BatchCreateAclRequest req)
        {
             JsonResponseModel<BatchCreateAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchCreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create ACL policies in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateAclRequest"/></param>
        /// <returns><see cref="BatchCreateAclResponse"/></returns>
        public BatchCreateAclResponse BatchCreateAclSync(BatchCreateAclRequest req)
        {
             JsonResponseModel<BatchCreateAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchCreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch modify consumer group offsets.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="BatchModifyGroupOffsetsResponse"/></returns>
        public async Task<BatchModifyGroupOffsetsResponse> BatchModifyGroupOffsets(BatchModifyGroupOffsetsRequest req)
        {
             JsonResponseModel<BatchModifyGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch modify consumer group offsets.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="BatchModifyGroupOffsetsResponse"/></returns>
        public BatchModifyGroupOffsetsResponse BatchModifyGroupOffsetsSync(BatchModifyGroupOffsetsRequest req)
        {
             JsonResponseModel<BatchModifyGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch set topic attributes.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="BatchModifyTopicAttributesResponse"/></returns>
        public async Task<BatchModifyTopicAttributesResponse> BatchModifyTopicAttributes(BatchModifyTopicAttributesRequest req)
        {
             JsonResponseModel<BatchModifyTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch set topic attributes.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="BatchModifyTopicAttributesResponse"/></returns>
        public BatchModifyTopicAttributesResponse BatchModifyTopicAttributesSync(BatchModifyTopicAttributesRequest req)
        {
             JsonResponseModel<BatchModifyTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an ACL policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public async Task<CreateAclResponse> CreateAcl(CreateAclRequest req)
        {
             JsonResponseModel<CreateAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an ACL policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public CreateAclResponse CreateAclSync(CreateAclRequest req)
        {
             JsonResponseModel<CreateAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public async Task<CreateConsumerResponse> CreateConsumer(CreateConsumerRequest req)
        {
             JsonResponseModel<CreateConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public CreateConsumerResponse CreateConsumerSync(CreateConsumerRequest req)
        {
             JsonResponseModel<CreateConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a partition in a topic.
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public async Task<CreatePartitionResponse> CreatePartition(CreatePartitionRequest req)
        {
             JsonResponseModel<CreatePartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a partition in a topic.
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public CreatePartitionResponse CreatePartitionSync(CreatePartitionRequest req)
        {
             JsonResponseModel<CreatePartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CKafka topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public async Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CKafka topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a topic IP allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="CreateTopicIpWhiteListResponse"/></returns>
        public async Task<CreateTopicIpWhiteListResponse> CreateTopicIpWhiteList(CreateTopicIpWhiteListRequest req)
        {
             JsonResponseModel<CreateTopicIpWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopicIpWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicIpWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a topic IP allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="CreateTopicIpWhiteListResponse"/></returns>
        public CreateTopicIpWhiteListResponse CreateTopicIpWhiteListSync(CreateTopicIpWhiteListRequest req)
        {
             JsonResponseModel<CreateTopicIpWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopicIpWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicIpWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a user.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public async Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a user.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an ACL.
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRequest"/></param>
        /// <returns><see cref="DeleteAclResponse"/></returns>
        public async Task<DeleteAclResponse> DeleteAcl(DeleteAclRequest req)
        {
             JsonResponseModel<DeleteAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an ACL.
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRequest"/></param>
        /// <returns><see cref="DeleteAclResponse"/></returns>
        public DeleteAclResponse DeleteAclSync(DeleteAclRequest req)
        {
             JsonResponseModel<DeleteAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a route.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteRequest"/></param>
        /// <returns><see cref="DeleteRouteResponse"/></returns>
        public async Task<DeleteRouteResponse> DeleteRoute(DeleteRouteRequest req)
        {
             JsonResponseModel<DeleteRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a route.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteRequest"/></param>
        /// <returns><see cref="DeleteRouteResponse"/></returns>
        public DeleteRouteResponse DeleteRouteSync(DeleteRouteRequest req)
        {
             JsonResponseModel<DeleteRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the delayed trigger time of route deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTriggerTimeRequest"/></param>
        /// <returns><see cref="DeleteRouteTriggerTimeResponse"/></returns>
        public async Task<DeleteRouteTriggerTimeResponse> DeleteRouteTriggerTime(DeleteRouteTriggerTimeRequest req)
        {
             JsonResponseModel<DeleteRouteTriggerTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRouteTriggerTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTriggerTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the delayed trigger time of route deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTriggerTimeRequest"/></param>
        /// <returns><see cref="DeleteRouteTriggerTimeResponse"/></returns>
        public DeleteRouteTriggerTimeResponse DeleteRouteTriggerTimeSync(DeleteRouteTriggerTimeRequest req)
        {
             JsonResponseModel<DeleteRouteTriggerTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRouteTriggerTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTriggerTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CKafka topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public async Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CKafka topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a topic IP allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="DeleteTopicIpWhiteListResponse"/></returns>
        public async Task<DeleteTopicIpWhiteListResponse> DeleteTopicIpWhiteList(DeleteTopicIpWhiteListRequest req)
        {
             JsonResponseModel<DeleteTopicIpWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopicIpWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicIpWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a topic IP allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="DeleteTopicIpWhiteListResponse"/></returns>
        public DeleteTopicIpWhiteListResponse DeleteTopicIpWhiteListSync(DeleteTopicIpWhiteListRequest req)
        {
             JsonResponseModel<DeleteTopicIpWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopicIpWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicIpWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public async Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate ACLs.
        /// </summary>
        /// <param name="req"><see cref="DescribeACLRequest"/></param>
        /// <returns><see cref="DescribeACLResponse"/></returns>
        public async Task<DescribeACLResponse> DescribeACL(DescribeACLRequest req)
        {
             JsonResponseModel<DescribeACLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate ACLs.
        /// </summary>
        /// <param name="req"><see cref="DescribeACLRequest"/></param>
        /// <returns><see cref="DescribeACLResponse"/></returns>
        public DescribeACLResponse DescribeACLSync(DescribeACLRequest req)
        {
             JsonResponseModel<DescribeACLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppInfoRequest"/></param>
        /// <returns><see cref="DescribeAppInfoResponse"/></returns>
        public async Task<DescribeAppInfoResponse> DescribeAppInfo(DescribeAppInfoRequest req)
        {
             JsonResponseModel<DescribeAppInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAppInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppInfoRequest"/></param>
        /// <returns><see cref="DescribeAppInfoResponse"/></returns>
        public DescribeAppInfoResponse DescribeAppInfoSync(DescribeAppInfoRequest req)
        {
             JsonResponseModel<DescribeAppInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAppInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the AZ list of Ckafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeCkafkaZoneRequest"/></param>
        /// <returns><see cref="DescribeCkafkaZoneResponse"/></returns>
        public async Task<DescribeCkafkaZoneResponse> DescribeCkafkaZone(DescribeCkafkaZoneRequest req)
        {
             JsonResponseModel<DescribeCkafkaZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCkafkaZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCkafkaZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the AZ list of Ckafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeCkafkaZoneRequest"/></param>
        /// <returns><see cref="DescribeCkafkaZoneResponse"/></returns>
        public DescribeCkafkaZoneResponse DescribeCkafkaZoneSync(DescribeCkafkaZoneRequest req)
        {
             JsonResponseModel<DescribeCkafkaZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCkafkaZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCkafkaZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query consumer group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public async Task<DescribeConsumerGroupResponse> DescribeConsumerGroup(DescribeConsumerGroupRequest req)
        {
             JsonResponseModel<DescribeConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query consumer group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public DescribeConsumerGroupResponse DescribeConsumerGroupSync(DescribeConsumerGroupRequest req)
        {
             JsonResponseModel<DescribeConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate consumer groups (simplified).
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public async Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate consumer groups (simplified).
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get consumer group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeGroupInfoResponse"/></returns>
        public async Task<DescribeGroupInfoResponse> DescribeGroupInfo(DescribeGroupInfoRequest req)
        {
             JsonResponseModel<DescribeGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get consumer group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeGroupInfoResponse"/></returns>
        public DescribeGroupInfoResponse DescribeGroupInfoSync(DescribeGroupInfoRequest req)
        {
             JsonResponseModel<DescribeGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the consumer group offset.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeGroupOffsetsResponse"/></returns>
        public async Task<DescribeGroupOffsetsResponse> DescribeGroupOffsets(DescribeGroupOffsetsRequest req)
        {
             JsonResponseModel<DescribeGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the consumer group offset.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeGroupOffsetsResponse"/></returns>
        public DescribeGroupOffsetsResponse DescribeGroupOffsetsSync(DescribeGroupOffsetsRequest req)
        {
             JsonResponseModel<DescribeGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get instance attributes. 
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAttributesResponse"/></returns>
        public async Task<DescribeInstanceAttributesResponse> DescribeInstanceAttributes(DescribeInstanceAttributesRequest req)
        {
             JsonResponseModel<DescribeInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get instance attributes. 
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAttributesResponse"/></returns>
        public DescribeInstanceAttributesResponse DescribeInstanceAttributesSync(DescribeInstanceAttributesRequest req)
        {
             JsonResponseModel<DescribeInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of CKafka instances under a user account.
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
        /// This API is used to get the list of CKafka instances under a user account.
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
        /// This API is used to get instance list details under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDetailRequest"/></param>
        /// <returns><see cref="DescribeInstancesDetailResponse"/></returns>
        public async Task<DescribeInstancesDetailResponse> DescribeInstancesDetail(DescribeInstancesDetailRequest req)
        {
             JsonResponseModel<DescribeInstancesDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get instance list details under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDetailRequest"/></param>
        /// <returns><see cref="DescribeInstancesDetailResponse"/></returns>
        public DescribeInstancesDetailResponse DescribeInstancesDetailSync(DescribeInstancesDetailRequest req)
        {
             JsonResponseModel<DescribeInstancesDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate regions, and can be called only in Guangzhou.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionRequest"/></param>
        /// <returns><see cref="DescribeRegionResponse"/></returns>
        public async Task<DescribeRegionResponse> DescribeRegion(DescribeRegionRequest req)
        {
             JsonResponseModel<DescribeRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate regions, and can be called only in Guangzhou.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionRequest"/></param>
        /// <returns><see cref="DescribeRegionResponse"/></returns>
        public DescribeRegionResponse DescribeRegionSync(DescribeRegionRequest req)
        {
             JsonResponseModel<DescribeRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view route information.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteRequest"/></param>
        /// <returns><see cref="DescribeRouteResponse"/></returns>
        public async Task<DescribeRouteResponse> DescribeRoute(DescribeRouteRequest req)
        {
             JsonResponseModel<DescribeRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view route information.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteRequest"/></param>
        /// <returns><see cref="DescribeRouteResponse"/></returns>
        public DescribeRouteResponse DescribeRouteSync(DescribeRouteRequest req)
        {
             JsonResponseModel<DescribeRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// API domain name: https://ckafka.tencentcloudapi.com
        /// This API is used to get the list of topics in a CKafka instance of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public async Task<DescribeTopicResponse> DescribeTopic(DescribeTopicRequest req)
        {
             JsonResponseModel<DescribeTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// API domain name: https://ckafka.tencentcloudapi.com
        /// This API is used to get the list of topics in a CKafka instance of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public DescribeTopicResponse DescribeTopicSync(DescribeTopicRequest req)
        {
             JsonResponseModel<DescribeTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get topic attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicAttributesRequest"/></param>
        /// <returns><see cref="DescribeTopicAttributesResponse"/></returns>
        public async Task<DescribeTopicAttributesResponse> DescribeTopicAttributes(DescribeTopicAttributesRequest req)
        {
             JsonResponseModel<DescribeTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get topic attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicAttributesRequest"/></param>
        /// <returns><see cref="DescribeTopicAttributesResponse"/></returns>
        public DescribeTopicAttributesResponse DescribeTopicAttributesSync(DescribeTopicAttributesRequest req)
        {
             JsonResponseModel<DescribeTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get topic list details (only for call in the console).
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public async Task<DescribeTopicDetailResponse> DescribeTopicDetail(DescribeTopicDetailRequest req)
        {
             JsonResponseModel<DescribeTopicDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get topic list details (only for call in the console).
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public DescribeTopicDetailResponse DescribeTopicDetailSync(DescribeTopicDetailRequest req)
        {
             JsonResponseModel<DescribeTopicDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search and subscribe the message group information of a topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSubscribeGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicSubscribeGroupResponse"/></returns>
        public async Task<DescribeTopicSubscribeGroupResponse> DescribeTopicSubscribeGroup(DescribeTopicSubscribeGroupRequest req)
        {
             JsonResponseModel<DescribeTopicSubscribeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicSubscribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicSubscribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search and subscribe the message group information of a topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSubscribeGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicSubscribeGroupResponse"/></returns>
        public DescribeTopicSubscribeGroupResponse DescribeTopicSubscribeGroupSync(DescribeTopicSubscribeGroupRequest req)
        {
             JsonResponseModel<DescribeTopicSubscribeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicSubscribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicSubscribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a synced topic replica.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSyncReplicaRequest"/></param>
        /// <returns><see cref="DescribeTopicSyncReplicaResponse"/></returns>
        public async Task<DescribeTopicSyncReplicaResponse> DescribeTopicSyncReplica(DescribeTopicSyncReplicaRequest req)
        {
             JsonResponseModel<DescribeTopicSyncReplicaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicSyncReplica");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicSyncReplicaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a synced topic replica.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSyncReplicaRequest"/></param>
        /// <returns><see cref="DescribeTopicSyncReplicaResponse"/></returns>
        public DescribeTopicSyncReplicaResponse DescribeTopicSyncReplicaSync(DescribeTopicSyncReplicaRequest req)
        {
             JsonResponseModel<DescribeTopicSyncReplicaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicSyncReplica");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicSyncReplicaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query user information.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public async Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query user information.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query messages based on a specified offset position.
        /// </summary>
        /// <param name="req"><see cref="FetchMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageByOffsetResponse"/></returns>
        public async Task<FetchMessageByOffsetResponse> FetchMessageByOffset(FetchMessageByOffsetRequest req)
        {
             JsonResponseModel<FetchMessageByOffsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FetchMessageByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchMessageByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query messages based on a specified offset position.
        /// </summary>
        /// <param name="req"><see cref="FetchMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageByOffsetResponse"/></returns>
        public FetchMessageByOffsetResponse FetchMessageByOffsetSync(FetchMessageByOffsetRequest req)
        {
             JsonResponseModel<FetchMessageByOffsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FetchMessageByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchMessageByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the message list based on an offset.
        /// </summary>
        /// <param name="req"><see cref="FetchMessageListByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageListByOffsetResponse"/></returns>
        public async Task<FetchMessageListByOffsetResponse> FetchMessageListByOffset(FetchMessageListByOffsetRequest req)
        {
             JsonResponseModel<FetchMessageListByOffsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FetchMessageListByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchMessageListByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the message list based on an offset.
        /// </summary>
        /// <param name="req"><see cref="FetchMessageListByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageListByOffsetResponse"/></returns>
        public FetchMessageListByOffsetResponse FetchMessageListByOffsetSync(FetchMessageListByOffsetRequest req)
        {
             JsonResponseModel<FetchMessageListByOffsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FetchMessageListByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchMessageListByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the consumer group (Groups) offset.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="ModifyGroupOffsetsResponse"/></returns>
        public async Task<ModifyGroupOffsetsResponse> ModifyGroupOffsets(ModifyGroupOffsetsRequest req)
        {
             JsonResponseModel<ModifyGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the consumer group (Groups) offset.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="ModifyGroupOffsetsResponse"/></returns>
        public ModifyGroupOffsetsResponse ModifyGroupOffsetsSync(ModifyGroupOffsetsRequest req)
        {
             JsonResponseModel<ModifyGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set instance attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributesResponse"/></returns>
        public async Task<ModifyInstanceAttributesResponse> ModifyInstanceAttributes(ModifyInstanceAttributesRequest req)
        {
             JsonResponseModel<ModifyInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set instance attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributesResponse"/></returns>
        public ModifyInstanceAttributesResponse ModifyInstanceAttributesSync(ModifyInstanceAttributesRequest req)
        {
             JsonResponseModel<ModifyInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the configurations of a prepaid instance, such as disk capacity and bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePreRequest"/></param>
        /// <returns><see cref="ModifyInstancePreResponse"/></returns>
        public async Task<ModifyInstancePreResponse> ModifyInstancePre(ModifyInstancePreRequest req)
        {
             JsonResponseModel<ModifyInstancePreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancePre");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancePreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the configurations of a prepaid instance, such as disk capacity and bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePreRequest"/></param>
        /// <returns><see cref="ModifyInstancePreResponse"/></returns>
        public ModifyInstancePreResponse ModifyInstancePreSync(ModifyInstancePreRequest req)
        {
             JsonResponseModel<ModifyInstancePreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancePre");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancePreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the password.
        /// </summary>
        /// <param name="req"><see cref="ModifyPasswordRequest"/></param>
        /// <returns><see cref="ModifyPasswordResponse"/></returns>
        public async Task<ModifyPasswordResponse> ModifyPassword(ModifyPasswordRequest req)
        {
             JsonResponseModel<ModifyPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the password.
        /// </summary>
        /// <param name="req"><see cref="ModifyPasswordRequest"/></param>
        /// <returns><see cref="ModifyPasswordResponse"/></returns>
        public ModifyPasswordResponse ModifyPasswordSync(ModifyPasswordRequest req)
        {
             JsonResponseModel<ModifyPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributesResponse"/></returns>
        public async Task<ModifyTopicAttributesResponse> ModifyTopicAttributes(ModifyTopicAttributesRequest req)
        {
             JsonResponseModel<ModifyTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributesResponse"/></returns>
        public ModifyTopicAttributesResponse ModifyTopicAttributesSync(ModifyTopicAttributesRequest req)
        {
             JsonResponseModel<ModifyTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send messages through the HTTP access layer.
        /// </summary>
        /// <param name="req"><see cref="SendMessageRequest"/></param>
        /// <returns><see cref="SendMessageResponse"/></returns>
        public async Task<SendMessageResponse> SendMessage(SendMessageRequest req)
        {
             JsonResponseModel<SendMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send messages through the HTTP access layer.
        /// </summary>
        /// <param name="req"><see cref="SendMessageRequest"/></param>
        /// <returns><see cref="SendMessageResponse"/></returns>
        public SendMessageResponse SendMessageSync(SendMessageRequest req)
        {
             JsonResponseModel<SendMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

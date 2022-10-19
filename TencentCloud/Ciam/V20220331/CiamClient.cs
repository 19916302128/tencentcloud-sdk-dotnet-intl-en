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

namespace TencentCloud.Ciam.V20220331
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ciam.V20220331.Models;

   public class CiamClient : AbstractClient{

       private const string endpoint = "ciam.tencentcloudapi.com";
       private const string version = "2022-03-31";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CiamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CiamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create an API for user import task.
        /// </summary>
        /// <param name="req"><see cref="CreateApiImportUserJobRequest"/></param>
        /// <returns><see cref="CreateApiImportUserJobResponse"/></returns>
        public async Task<CreateApiImportUserJobResponse> CreateApiImportUserJob(CreateApiImportUserJobRequest req)
        {
             JsonResponseModel<CreateApiImportUserJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApiImportUserJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiImportUserJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API for user import task.
        /// </summary>
        /// <param name="req"><see cref="CreateApiImportUserJobRequest"/></param>
        /// <returns><see cref="CreateApiImportUserJobResponse"/></returns>
        public CreateApiImportUserJobResponse CreateApiImportUserJobSync(CreateApiImportUserJobRequest req)
        {
             JsonResponseModel<CreateApiImportUserJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApiImportUserJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiImportUserJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a file for user export task.
        /// </summary>
        /// <param name="req"><see cref="CreateFileExportUserJobRequest"/></param>
        /// <returns><see cref="CreateFileExportUserJobResponse"/></returns>
        public async Task<CreateFileExportUserJobResponse> CreateFileExportUserJob(CreateFileExportUserJobRequest req)
        {
             JsonResponseModel<CreateFileExportUserJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFileExportUserJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileExportUserJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a file for user export task.
        /// </summary>
        /// <param name="req"><see cref="CreateFileExportUserJobRequest"/></param>
        /// <returns><see cref="CreateFileExportUserJobResponse"/></returns>
        public CreateFileExportUserJobResponse CreateFileExportUserJobSync(CreateFileExportUserJobRequest req)
        {
             JsonResponseModel<CreateFileExportUserJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFileExportUserJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileExportUserJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a user.
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
        /// This API is used to create a user.
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
        /// This API is used to delete users in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public async Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
             JsonResponseModel<DeleteUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete users in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
             JsonResponseModel<DeleteUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the user information with multiple conditions.
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
        /// This API is used to query the user information with multiple conditions.
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
        /// This API is used to query a user by ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserByIdRequest"/></param>
        /// <returns><see cref="DescribeUserByIdResponse"/></returns>
        public async Task<DescribeUserByIdResponse> DescribeUserById(DescribeUserByIdRequest req)
        {
             JsonResponseModel<DescribeUserByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a user by ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserByIdRequest"/></param>
        /// <returns><see cref="DescribeUserByIdResponse"/></returns>
        public DescribeUserByIdResponse DescribeUserByIdSync(DescribeUserByIdRequest req)
        {
             JsonResponseModel<DescribeUserByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to merge accounts.
        /// </summary>
        /// <param name="req"><see cref="LinkAccountRequest"/></param>
        /// <returns><see cref="LinkAccountResponse"/></returns>
        public async Task<LinkAccountResponse> LinkAccount(LinkAccountRequest req)
        {
             JsonResponseModel<LinkAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LinkAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LinkAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to merge accounts.
        /// </summary>
        /// <param name="req"><see cref="LinkAccountRequest"/></param>
        /// <returns><see cref="LinkAccountResponse"/></returns>
        public LinkAccountResponse LinkAccountSync(LinkAccountRequest req)
        {
             JsonResponseModel<LinkAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LinkAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LinkAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a task.
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public async Task<ListJobsResponse> ListJobs(ListJobsRequest req)
        {
             JsonResponseModel<ListJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a task.
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public ListJobsResponse ListJobsSync(ListJobsRequest req)
        {
             JsonResponseModel<ListJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a specified log.
        /// </summary>
        /// <param name="req"><see cref="ListLogMessageByConditionRequest"/></param>
        /// <returns><see cref="ListLogMessageByConditionResponse"/></returns>
        public async Task<ListLogMessageByConditionResponse> ListLogMessageByCondition(ListLogMessageByConditionRequest req)
        {
             JsonResponseModel<ListLogMessageByConditionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListLogMessageByCondition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLogMessageByConditionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a specified log.
        /// </summary>
        /// <param name="req"><see cref="ListLogMessageByConditionRequest"/></param>
        /// <returns><see cref="ListLogMessageByConditionResponse"/></returns>
        public ListLogMessageByConditionResponse ListLogMessageByConditionSync(ListLogMessageByConditionRequest req)
        {
             JsonResponseModel<ListLogMessageByConditionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListLogMessageByCondition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLogMessageByConditionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of users.
        /// </summary>
        /// <param name="req"><see cref="ListUserRequest"/></param>
        /// <returns><see cref="ListUserResponse"/></returns>
        public async Task<ListUserResponse> ListUser(ListUserRequest req)
        {
             JsonResponseModel<ListUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of users.
        /// </summary>
        /// <param name="req"><see cref="ListUserRequest"/></param>
        /// <returns><see cref="ListUserResponse"/></returns>
        public ListUserResponse ListUserSync(ListUserRequest req)
        {
             JsonResponseModel<ListUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of users by attribute.
        /// </summary>
        /// <param name="req"><see cref="ListUserByPropertyRequest"/></param>
        /// <returns><see cref="ListUserByPropertyResponse"/></returns>
        public async Task<ListUserByPropertyResponse> ListUserByProperty(ListUserByPropertyRequest req)
        {
             JsonResponseModel<ListUserByPropertyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUserByProperty");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserByPropertyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of users by attribute.
        /// </summary>
        /// <param name="req"><see cref="ListUserByPropertyRequest"/></param>
        /// <returns><see cref="ListUserByPropertyResponse"/></returns>
        public ListUserByPropertyResponse ListUserByPropertySync(ListUserByPropertyRequest req)
        {
             JsonResponseModel<ListUserByPropertyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUserByProperty");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserByPropertyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the password for a user.
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
        /// This API is used to reset the password for a user.
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
        /// This API is used to set the password for a user.
        /// </summary>
        /// <param name="req"><see cref="SetPasswordRequest"/></param>
        /// <returns><see cref="SetPasswordResponse"/></returns>
        public async Task<SetPasswordResponse> SetPassword(SetPasswordRequest req)
        {
             JsonResponseModel<SetPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the password for a user.
        /// </summary>
        /// <param name="req"><see cref="SetPasswordRequest"/></param>
        /// <returns><see cref="SetPasswordResponse"/></returns>
        public SetPasswordResponse SetPasswordSync(SetPasswordRequest req)
        {
             JsonResponseModel<SetPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public async Task<UpdateUserResponse> UpdateUser(UpdateUserRequest req)
        {
             JsonResponseModel<UpdateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public UpdateUserResponse UpdateUserSync(UpdateUserRequest req)
        {
             JsonResponseModel<UpdateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the status of a user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public async Task<UpdateUserStatusResponse> UpdateUserStatus(UpdateUserStatusRequest req)
        {
             JsonResponseModel<UpdateUserStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateUserStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the status of a user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public UpdateUserStatusResponse UpdateUserStatusSync(UpdateUserStatusRequest req)
        {
             JsonResponseModel<UpdateUserStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateUserStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

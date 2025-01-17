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

namespace TencentCloud.Hunyuan.V20230901
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Hunyuan.V20230901.Models;

   public class HunyuanClient : AbstractClient{

       private const string endpoint = "hunyuan.tencentcloudapi.com";
       private const string version = "2023-09-01";
       private const string sdkVersion = "SDK_NET_3.0.1003";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HunyuanClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HunyuanClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认每种模型单账号限制并发数为 5 路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionsRequest"/></param>
        /// <returns><see cref="ChatCompletionsResponse"/></returns>
        public Task<ChatCompletionsResponse> ChatCompletions(ChatCompletionsRequest req)
        {
            return InternalRequestAsync<ChatCompletionsResponse>(req, "ChatCompletions");
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认每种模型单账号限制并发数为 5 路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionsRequest"/></param>
        /// <returns><see cref="ChatCompletionsResponse"/></returns>
        public ChatCompletionsResponse ChatCompletionsSync(ChatCompletionsRequest req)
        {
            return InternalRequestAsync<ChatCompletionsResponse>(req, "ChatCompletions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <span style="font-size:1.5em;">注意：本接口将于 5 月 15 日下线；下线后将不再提供文档指引，接口本身可继续调用，建议使用 [hunyuan](https://cloud.tencent.com/document/api/1729/105701) 接入。</span>
        /// 
        /// 腾讯混元大模型（hunyuan-pro）是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认单账号限制并发数为 5 路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        /// </summary>
        /// <param name="req"><see cref="ChatProRequest"/></param>
        /// <returns><see cref="ChatProResponse"/></returns>
        public Task<ChatProResponse> ChatPro(ChatProRequest req)
        {
            return InternalRequestAsync<ChatProResponse>(req, "ChatPro");
        }

        /// <summary>
        /// <span style="font-size:1.5em;">注意：本接口将于 5 月 15 日下线；下线后将不再提供文档指引，接口本身可继续调用，建议使用 [hunyuan](https://cloud.tencent.com/document/api/1729/105701) 接入。</span>
        /// 
        /// 腾讯混元大模型（hunyuan-pro）是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认单账号限制并发数为 5 路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        /// </summary>
        /// <param name="req"><see cref="ChatProRequest"/></param>
        /// <returns><see cref="ChatProResponse"/></returns>
        public ChatProResponse ChatProSync(ChatProRequest req)
        {
            return InternalRequestAsync<ChatProResponse>(req, "ChatPro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <span style="font-size:1.5em;">注意：本接口将于 5 月 15 日下线；下线后将不再提供文档指引，接口本身可继续调用，建议使用 [hunyuan](https://cloud.tencent.com/document/api/1729/105701) 接入。</span>
        /// 
        /// 腾讯混元大模型标准版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认单账号限制并发数为 5 路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        /// </summary>
        /// <param name="req"><see cref="ChatStdRequest"/></param>
        /// <returns><see cref="ChatStdResponse"/></returns>
        public Task<ChatStdResponse> ChatStd(ChatStdRequest req)
        {
            return InternalRequestAsync<ChatStdResponse>(req, "ChatStd");
        }

        /// <summary>
        /// <span style="font-size:1.5em;">注意：本接口将于 5 月 15 日下线；下线后将不再提供文档指引，接口本身可继续调用，建议使用 [hunyuan](https://cloud.tencent.com/document/api/1729/105701) 接入。</span>
        /// 
        /// 腾讯混元大模型标准版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认单账号限制并发数为 5 路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        /// </summary>
        /// <param name="req"><see cref="ChatStdRequest"/></param>
        /// <returns><see cref="ChatStdResponse"/></returns>
        public ChatStdResponse ChatStdSync(ChatStdRequest req)
        {
            return InternalRequestAsync<ChatStdResponse>(req, "ChatStd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元 Embedding 接口，可以将文本转化为高质量的向量数据。
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public Task<GetEmbeddingResponse> GetEmbedding(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding");
        }

        /// <summary>
        /// 腾讯混元 Embedding 接口，可以将文本转化为高质量的向量数据。
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public GetEmbeddingResponse GetEmbeddingSync(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于计算文本对应Token数、字符数。
        /// </summary>
        /// <param name="req"><see cref="GetTokenCountRequest"/></param>
        /// <returns><see cref="GetTokenCountResponse"/></returns>
        public Task<GetTokenCountResponse> GetTokenCount(GetTokenCountRequest req)
        {
            return InternalRequestAsync<GetTokenCountResponse>(req, "GetTokenCount");
        }

        /// <summary>
        /// 该接口用于计算文本对应Token数、字符数。
        /// </summary>
        /// <param name="req"><see cref="GetTokenCountRequest"/></param>
        /// <returns><see cref="GetTokenCountResponse"/></returns>
        public GetTokenCountResponse GetTokenCountSync(GetTokenCountRequest req)
        {
            return InternalRequestAsync<GetTokenCountResponse>(req, "GetTokenCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生图接口基于混元大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个混元生图异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。混元生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanImageJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanImageJobResponse"/></returns>
        public Task<QueryHunyuanImageJobResponse> QueryHunyuanImageJob(QueryHunyuanImageJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanImageJobResponse>(req, "QueryHunyuanImageJob");
        }

        /// <summary>
        /// 混元生图接口基于混元大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个混元生图异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。混元生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanImageJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanImageJobResponse"/></returns>
        public QueryHunyuanImageJobResponse QueryHunyuanImageJobSync(QueryHunyuanImageJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanImageJobResponse>(req, "QueryHunyuanImageJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生图接口基于混元大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个混元生图异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。混元生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanImageJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanImageJobResponse"/></returns>
        public Task<SubmitHunyuanImageJobResponse> SubmitHunyuanImageJob(SubmitHunyuanImageJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanImageJobResponse>(req, "SubmitHunyuanImageJob");
        }

        /// <summary>
        /// 混元生图接口基于混元大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个混元生图异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。混元生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanImageJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanImageJobResponse"/></returns>
        public SubmitHunyuanImageJobResponse SubmitHunyuanImageJobSync(SubmitHunyuanImageJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanImageJobResponse>(req, "SubmitHunyuanImageJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

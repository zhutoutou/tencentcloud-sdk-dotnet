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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatCompletionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称，可选值包括 hunyuan-lite、hunyuan-standard、hunyuan-standard-256K、hunyuan-pro。
        /// 各模型介绍请阅读 [产品概述](https://cloud.tencent.com/document/product/1729/104753) 中的说明。
        /// 
        /// 注意：
        /// 不同的模型计费不同，请根据 [购买指南](https://cloud.tencent.com/document/product/1729/97731) 按需调用。
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 聊天上下文信息。
        /// 说明：
        /// 1. 长度最多为 40，按对话时间从旧到新在数组中排列。
        /// 2. Message.Role 可选值：system、user、assistant。
        /// 其中，system 角色可选，如存在则必须位于列表的最开始。user 和 assistant 需交替出现（一问一答），以 user 提问开始和结束，且 Content 不能为空。Role 的顺序示例：[system（可选） user assistant user assistant user ...]。
        /// 3. Messages 中 Content 总长度不能超过模型输入长度上限（可参考 [产品概述](https://cloud.tencent.com/document/product/1729/104753) 文档），超过则会截断最前面的内容，只保留尾部内容。
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// 流式调用开关。
        /// 说明：
        /// 1. 未传值时默认为非流式调用（false）。
        /// 2. 流式调用时以 SSE 协议增量返回结果（返回值取 Choices[n].Delta 中的值，需要拼接增量数据才能获得完整结果）。
        /// 3. 非流式调用时：
        /// 调用方式与普通 HTTP 请求无异。
        /// 接口响应耗时较长，**如需更低时延建议设置为 true**。
        /// 只返回一次最终结果（返回值取 Choices[n].Message 中的值）。
        /// 
        /// 注意：
        /// 通过 SDK 调用时，流式和非流式调用需用**不同的方式**获取返回值，具体参考 SDK 中的注释或示例（在各语言 SDK 代码仓库的 examples/hunyuan/v20230901/ 目录中）。
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// 流式输出审核开关。
        /// 说明：
        /// 1. 当使用流式输出（Stream 字段值为 true）时，该字段生效。
        /// 2. 输出审核有流式和同步两种模式，**流式模式首包响应更快**。未传值时默认为流式模式（true）。
        /// 3. 如果值为 true，将对输出内容进行分段审核，审核通过的内容流式输出返回。如果出现审核不过，响应中的 FinishReason 值为 sensitive。
        /// 4. 如果值为 false，则不使用流式输出审核，需要审核完所有输出内容后再返回结果。
        /// 
        /// 注意：
        /// 当选择流式输出审核时，可能会出现部分内容已输出，但中间某一段响应中的 FinishReason 值为 sensitive，此时说明安全审核未通过。如果业务场景有实时文字上屏的需求，需要自行撤回已上屏的内容，并建议自定义替换为一条提示语，如 “这个问题我不方便回答，不如我们换个话题试试”，以保障终端体验。
        /// </summary>
        [JsonProperty("StreamModeration")]
        public bool? StreamModeration{ get; set; }

        /// <summary>
        /// 说明：
        /// 1. 影响输出文本的多样性，取值越大，生成文本的多样性越强。
        /// 2. 默认 1.0，取值区间为 [0.0, 1.0]。
        /// 3. 非必要不建议使用，不合理的取值会影响效果。
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 说明：
        /// 1. 较高的数值会使输出更加随机，而较低的数值会使其更加集中和确定。
        /// 2. 默认 1.0，取值区间为 [0.0, 2.0]。
        /// 3. 非必要不建议使用，不合理的取值会影响效果。
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "StreamModeration", this.StreamModeration);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
        }
    }
}


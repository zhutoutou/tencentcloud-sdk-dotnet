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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatasetDetailUnstructuredResponse : AbstractModel
    {
        
        /// <summary>
        /// 已标注数据量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnnotatedTotalCount")]
        public ulong? AnnotatedTotalCount{ get; set; }

        /// <summary>
        /// 没有标注数据量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NonAnnotatedTotalCount")]
        public ulong? NonAnnotatedTotalCount{ get; set; }

        /// <summary>
        /// 过滤数据总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterTotalCount")]
        public ulong? FilterTotalCount{ get; set; }

        /// <summary>
        /// 过滤数据详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterLabelList")]
        public FilterLabelInfo[] FilterLabelList{ get; set; }

        /// <summary>
        /// 数据文本行，默认返回前1000行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RowTexts")]
        public string[] RowTexts{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnnotatedTotalCount", this.AnnotatedTotalCount);
            this.SetParamSimple(map, prefix + "NonAnnotatedTotalCount", this.NonAnnotatedTotalCount);
            this.SetParamSimple(map, prefix + "FilterTotalCount", this.FilterTotalCount);
            this.SetParamArrayObj(map, prefix + "FilterLabelList.", this.FilterLabelList);
            this.SetParamArraySimple(map, prefix + "RowTexts.", this.RowTexts);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


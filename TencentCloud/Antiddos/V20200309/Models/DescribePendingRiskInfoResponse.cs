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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePendingRiskInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否为付费用户，true：付费用户， false：普通用户
        /// </summary>
        [JsonProperty("IsPaidUsr")]
        public bool? IsPaidUsr{ get; set; }

        /// <summary>
        /// 攻击中的资源数量
        /// </summary>
        [JsonProperty("AttackingCount")]
        public long? AttackingCount{ get; set; }

        /// <summary>
        /// 封堵中的资源数量
        /// </summary>
        [JsonProperty("BlockingCount")]
        public long? BlockingCount{ get; set; }

        /// <summary>
        /// 已过期的资源数量
        /// </summary>
        [JsonProperty("ExpiredCount")]
        public long? ExpiredCount{ get; set; }

        /// <summary>
        /// 所有待处理风险事件总数
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsPaidUsr", this.IsPaidUsr);
            this.SetParamSimple(map, prefix + "AttackingCount", this.AttackingCount);
            this.SetParamSimple(map, prefix + "BlockingCount", this.BlockingCount);
            this.SetParamSimple(map, prefix + "ExpiredCount", this.ExpiredCount);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddCustomRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("SortId")]
        public string SortId{ get; set; }

        /// <summary>
        /// 过期时间，单位为秒级时间戳，例如1677254399表示过期时间为2023-02-24 23:59:59. 0表示永不过期
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 策略详情
        /// </summary>
        [JsonProperty("Strategies")]
        public Strategy[] Strategies{ get; set; }

        /// <summary>
        /// 需要添加策略的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 动作类型，1代表阻断，2代表人机识别，3代表观察，4代表重定向
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 如果动作是重定向，则表示重定向的地址；其他情况可以为空
        /// </summary>
        [JsonProperty("Redirect")]
        public string Redirect{ get; set; }

        /// <summary>
        /// WAF实例类型，sparta-waf表示SAAS型WAF，clb-waf表示负载均衡型WAF
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 放行的详情
        /// </summary>
        [JsonProperty("Bypass")]
        public string Bypass{ get; set; }

        /// <summary>
        /// 添加规则的来源，默认为空
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SortId", this.SortId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArrayObj(map, prefix + "Strategies.", this.Strategies);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "Redirect", this.Redirect);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Bypass", this.Bypass);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}


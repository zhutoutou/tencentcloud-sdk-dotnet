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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// 服务开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 服务结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 配额ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuotaId")]
        public ulong? QuotaId{ get; set; }

        /// <summary>
        /// 企业ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }

        /// <summary>
        /// 开通服务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Services")]
        public string[] Services{ get; set; }

        /// <summary>
        /// 工厂配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FactoryQuota")]
        public long? FactoryQuota{ get; set; }

        /// <summary>
        /// 产品配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemQuota")]
        public long? ItemQuota{ get; set; }

        /// <summary>
        /// 溯源码配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrackQuota")]
        public long? TrackQuota{ get; set; }

        /// <summary>
        /// 销售码配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SaleQuota")]
        public long? SaleQuota{ get; set; }

        /// <summary>
        /// 上链配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChainQuota")]
        public long? ChainQuota{ get; set; }

        /// <summary>
        /// 风控配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskQuota")]
        public long? RiskQuota{ get; set; }

        /// <summary>
        /// 溯源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrackType")]
        public long? TrackType{ get; set; }

        /// <summary>
        /// 开通版本 basic standard enterprise
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamArraySimple(map, prefix + "Services.", this.Services);
            this.SetParamSimple(map, prefix + "FactoryQuota", this.FactoryQuota);
            this.SetParamSimple(map, prefix + "ItemQuota", this.ItemQuota);
            this.SetParamSimple(map, prefix + "TrackQuota", this.TrackQuota);
            this.SetParamSimple(map, prefix + "SaleQuota", this.SaleQuota);
            this.SetParamSimple(map, prefix + "ChainQuota", this.ChainQuota);
            this.SetParamSimple(map, prefix + "RiskQuota", this.RiskQuota);
            this.SetParamSimple(map, prefix + "TrackType", this.TrackType);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

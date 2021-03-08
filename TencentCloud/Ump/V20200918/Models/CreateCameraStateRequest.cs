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

namespace TencentCloud.Ump.V20200918.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCameraStateRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团编码
        /// </summary>
        [JsonProperty("GroupCode")]
        public string GroupCode{ get; set; }

        /// <summary>
        /// 广场ID
        /// </summary>
        [JsonProperty("MallId")]
        public ulong? MallId{ get; set; }

        /// <summary>
        /// 场内所有相机的状态值
        /// </summary>
        [JsonProperty("CameraStates")]
        public CameraState[] CameraStates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupCode", this.GroupCode);
            this.SetParamSimple(map, prefix + "MallId", this.MallId);
            this.SetParamArrayObj(map, prefix + "CameraStates.", this.CameraStates);
        }
    }
}

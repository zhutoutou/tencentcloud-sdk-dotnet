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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopL7AnalysisDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 查询的指标，取值有：
        /// <li> l7Flow_outFlux_country：请求的国家；</li>
        /// <li> l7Flow_outFlux_statusCode：请求的状态码；</li>
        /// <li> l7Flow_outFlux_domain：请求域名；</li>
        /// <li> l7Flow_outFlux_url：请求的URL; </li>
        /// <li> l7Flow_outFlux_resourceType：请求的资源类型；</li>
        /// <li> l7Flow_outFlux_sip：客户端的源IP；</li>
        /// <li> l7Flow_outFlux_referers：refer信息；</li>
        /// <li> l7Flow_outFlux_ua_device：设备类型; </li>
        /// <li> l7Flow_outFlux_ua_browser：浏览器类型；</li>
        /// <li> l7Flow_outFlux_us_os：操作系统类型。</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 站点集合，不填默认选择全部站点。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// 查询前多少个数据，最大值为1000，不填默认默认为: 10， 表示查询前top10的数据。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 筛选条件，key可选的值有：
        /// <li>country：国家/地区；</li>
        /// <li>domain：域名；</li>
        /// <li>protocol：协议类型；</li>
        /// <li>resourceType：资源类型；</li>
        /// <li>statusCode：状态码；</li>
        /// <li> browserType：浏览器类型；</li>
        /// <li>deviceType：设备类型；</li>
        /// <li>operatingSystemType：操作系统类型；</li>
        /// <li>tlsVersion：tls版本；</li>
        /// <li>url：url地址；</li>
        /// <li>referer：refer头信息；</li>
        /// <li>ipVersion：ip版本；</li>
        /// <li>tagKey：标签Key；</li>
        /// <li>tagValue：标签Value。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// 查询时间粒度，取值有：
        /// <li>min：1分钟；</li>
        /// <li>5min：5分钟；</li>
        /// <li>hour：1小时；</li>
        /// <li>day：1天。</li>不填将根据开始时间跟结束时间的间距自动推算粒度，具体为：一小时范围内以min粒度查询，两天范围内以5min粒度查询，七天范围内以hour粒度查询，超过七天以day粒度查询。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 数据归属地区，取值有：
        /// <li>overseas：全球（除中国大陆地区）数据；</li>
        /// <li>mainland：中国大陆地区数据。</li>不填将根据用户所在地智能选择地区。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

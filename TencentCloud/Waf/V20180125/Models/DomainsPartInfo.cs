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

    public class DomainsPartInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否开启httpRewrite
        /// </summary>
        [JsonProperty("HttpsRewrite")]
        public ulong? HttpsRewrite{ get; set; }

        /// <summary>
        /// https回源端口
        /// </summary>
        [JsonProperty("HttpsUpstreamPort")]
        public string HttpsUpstreamPort{ get; set; }

        /// <summary>
        /// 是否是cdn
        /// </summary>
        [JsonProperty("IsCdn")]
        public ulong? IsCdn{ get; set; }

        /// <summary>
        /// 是否开启gray
        /// </summary>
        [JsonProperty("IsGray")]
        public ulong? IsGray{ get; set; }

        /// <summary>
        /// 是否是http2
        /// </summary>
        [JsonProperty("IsHttp2")]
        public ulong? IsHttp2{ get; set; }

        /// <summary>
        /// 是否开启websocket
        /// </summary>
        [JsonProperty("IsWebsocket")]
        public ulong? IsWebsocket{ get; set; }

        /// <summary>
        /// 负载均衡
        /// </summary>
        [JsonProperty("LoadBalance")]
        public ulong? LoadBalance{ get; set; }

        /// <summary>
        /// 防御模式
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// 私钥
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// ssl id
        /// </summary>
        [JsonProperty("SSLId")]
        public string SSLId{ get; set; }

        /// <summary>
        /// 回源域名
        /// </summary>
        [JsonProperty("UpstreamDomain")]
        public string UpstreamDomain{ get; set; }

        /// <summary>
        /// 回源类型
        /// </summary>
        [JsonProperty("UpstreamType")]
        public ulong? UpstreamType{ get; set; }

        /// <summary>
        /// 回源ip
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// 服务端口配置
        /// </summary>
        [JsonProperty("Ports")]
        public PortInfo[] Ports{ get; set; }

        /// <summary>
        /// 证书类型
        /// </summary>
        [JsonProperty("CertType")]
        public ulong? CertType{ get; set; }

        /// <summary>
        /// 回源方式
        /// </summary>
        [JsonProperty("UpstreamScheme")]
        public string UpstreamScheme{ get; set; }

        /// <summary>
        /// 日志包
        /// </summary>
        [JsonProperty("Cls")]
        public ulong? Cls{ get; set; }

        /// <summary>
        /// 一级cname
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 是否长连接
        /// </summary>
        [JsonProperty("IsKeepAlive")]
        public ulong? IsKeepAlive{ get; set; }

        /// <summary>
        /// 是否开启主动健康检测，1表示开启，0表示不开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveCheck")]
        public ulong? ActiveCheck{ get; set; }

        /// <summary>
        /// TLS版本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TLSVersion")]
        public long? TLSVersion{ get; set; }

        /// <summary>
        /// 加密套件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ciphers")]
        public long?[] Ciphers{ get; set; }

        /// <summary>
        /// 模版
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CipherTemplate")]
        public long? CipherTemplate{ get; set; }

        /// <summary>
        /// 300s
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyReadTimeout")]
        public long? ProxyReadTimeout{ get; set; }

        /// <summary>
        /// 300s
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxySendTimeout")]
        public long? ProxySendTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HttpsRewrite", this.HttpsRewrite);
            this.SetParamSimple(map, prefix + "HttpsUpstreamPort", this.HttpsUpstreamPort);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamSimple(map, prefix + "IsGray", this.IsGray);
            this.SetParamSimple(map, prefix + "IsHttp2", this.IsHttp2);
            this.SetParamSimple(map, prefix + "IsWebsocket", this.IsWebsocket);
            this.SetParamSimple(map, prefix + "LoadBalance", this.LoadBalance);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
            this.SetParamSimple(map, prefix + "UpstreamDomain", this.UpstreamDomain);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "UpstreamScheme", this.UpstreamScheme);
            this.SetParamSimple(map, prefix + "Cls", this.Cls);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "IsKeepAlive", this.IsKeepAlive);
            this.SetParamSimple(map, prefix + "ActiveCheck", this.ActiveCheck);
            this.SetParamSimple(map, prefix + "TLSVersion", this.TLSVersion);
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "CipherTemplate", this.CipherTemplate);
            this.SetParamSimple(map, prefix + "ProxyReadTimeout", this.ProxyReadTimeout);
            this.SetParamSimple(map, prefix + "ProxySendTimeout", this.ProxySendTimeout);
        }
    }
}

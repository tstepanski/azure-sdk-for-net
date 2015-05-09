// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// DHCPOptions contains an array of DNS servers available to VMs deployed
    /// in the virtual networkStandard DHCP option for a subnet overrides VNET
    /// DHCP options.
    /// </summary>
    public partial class DhcpOptions
    {
        private IList<string> _dnsServers;
        
        /// <summary>
        /// Optional. Gets or sets list of DNS servers IP addresses
        /// </summary>
        public IList<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DhcpOptions class.
        /// </summary>
        public DhcpOptions()
        {
            this.DnsServers = new LazyList<string>();
        }
    }
}

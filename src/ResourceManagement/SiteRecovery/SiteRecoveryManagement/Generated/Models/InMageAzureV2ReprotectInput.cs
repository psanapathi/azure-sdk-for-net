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
using System.Linq;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// InMageAzureV2 reprotection input.
    /// </summary>
    public partial class InMageAzureV2ReprotectInput : ReverseReplicationProviderSpecificInput
    {
        private string _masterTargetId;
        
        /// <summary>
        /// Optional. The master target Id.
        /// </summary>
        public string MasterTargetId
        {
            get { return this._masterTargetId; }
            set { this._masterTargetId = value; }
        }
        
        private string _policyId;
        
        /// <summary>
        /// Optional. The id of the policy to be used for reprotection.
        /// </summary>
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }
        
        private string _processServerId;
        
        /// <summary>
        /// Optional. The Process Server Id.
        /// </summary>
        public string ProcessServerId
        {
            get { return this._processServerId; }
            set { this._processServerId = value; }
        }
        
        private string _runAsAccountId;
        
        /// <summary>
        /// Optional. The id of the run as account to be used for re-protection.
        /// </summary>
        public string RunAsAccountId
        {
            get { return this._runAsAccountId; }
            set { this._runAsAccountId = value; }
        }
        
        private string _storageAccountId;
        
        /// <summary>
        /// Optional. The id of the storage account to be used
        /// </summary>
        public string StorageAccountId
        {
            get { return this._storageAccountId; }
            set { this._storageAccountId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the InMageAzureV2ReprotectInput class.
        /// </summary>
        public InMageAzureV2ReprotectInput()
        {
        }
    }
}

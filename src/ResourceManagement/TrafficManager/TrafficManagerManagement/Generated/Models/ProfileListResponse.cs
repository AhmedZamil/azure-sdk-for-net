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
using Microsoft.Azure;
using Microsoft.Azure.Management.TrafficManager.Models;

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    /// <summary>
    /// The response to a Profile ProfileListAll operation.
    /// </summary>
    public partial class ProfileListResponse : AzureOperationResponse, IEnumerable<Profile>
    {
        private IList<Profile> _profiles;
        
        /// <summary>
        /// Required. Gets or sets information about the Profiles in the
        /// response.
        /// </summary>
        public IList<Profile> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProfileListResponse class.
        /// </summary>
        public ProfileListResponse()
        {
            this.Profiles = new LazyList<Profile>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ProfileListResponse class with
        /// required arguments.
        /// </summary>
        public ProfileListResponse(IList<Profile> profiles)
            : this()
        {
            if (profiles == null)
            {
                throw new ArgumentNullException("profiles");
            }
            this.Profiles = profiles;
        }
        
        /// <summary>
        /// Gets the sequence of Profiles.
        /// </summary>
        public IEnumerator<Profile> GetEnumerator()
        {
            return this.Profiles.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Profiles.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

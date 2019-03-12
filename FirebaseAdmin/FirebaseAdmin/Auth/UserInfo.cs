// Copyright 2019, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Text;
using Google.Apis.Json;
using Newtonsoft.Json;

namespace FirebaseAdmin.Auth
{
    /// <summary>
    /// Contains metadata associated with a Firebase user account. Instances
    /// of this class are immutable and thread safe.
    /// </summary>
    public class UserInfo
    {
        private string uid;

        /// <summary>
        /// Gets the user ID of this user.
        /// </summary>
        [JsonProperty("localId")]
        public string Uid
        {
            get => this.uid;
            private set
            {
                this.uid = value;
            }
        }
    }
}

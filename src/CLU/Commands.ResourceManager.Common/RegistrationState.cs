// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


namespace Microsoft.Azure.Commands.ResourceManager.Common
{
    /// <summary>
    /// Common registration states.
    /// </summary>
    public static partial class RegistrationState
    {
        /// <summary>
        /// The registration state is not specified.
        /// </summary>
        public const string NotSpecified = "NotSpecified";
        
        /// <summary>
        /// The registration state is not registered.
        /// </summary>
        public const string NotRegistered = "NotRegistered";
        
        /// <summary>
        /// The registration state is not Pending.
        /// </summary>
        public const string Pending = "Pending";
        
        /// <summary>
        /// The registration state is Registered.
        /// </summary>
        public const string Registered = "Registered";
    }
}

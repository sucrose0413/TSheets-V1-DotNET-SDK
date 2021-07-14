﻿// *******************************************************************************
// <copyright file="LocationLinkedObjectIds.cs" company="Intuit">
// Copyright (c) 2019 Intuit
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
// *******************************************************************************

namespace Intuit.TSheets.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Mapping of locations to jobcodes.
    /// </summary>
    [JsonObject]
    public class LocationLinkedObjectIds
    {
        /// <summary>
        /// Gets or sets the jobcodes to which this location is linked.
        /// </summary>
        [JsonProperty("jobcodes")]
        public IList<long> Jobcodes { get; set; }
    }
}

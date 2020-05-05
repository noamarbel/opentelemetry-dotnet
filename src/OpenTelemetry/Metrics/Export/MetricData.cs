// <copyright file="MetricData.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
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
// </copyright>

using System;
using System.Collections.Generic;

namespace OpenTelemetry.Metrics.Export
{
    /// <summary>
    /// Defines the abstract base class for Metric data.
    /// Metric data provide a Timestamp, and an optional set of label/value pairs.
    /// </summary>
    public abstract class MetricData
    {
        /// <summary>
        /// Gets or Sets the timestamp for this data object.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets the Metric's labels as key/value pairs.
        /// </summary>
        /// <remarks>As defined in the specification
        /// "A Label is the term used to refer to a key-value
        /// attribute associated with a metric event".</remarks>
        public IEnumerable<KeyValuePair<string, string>> Labels { get; set; }
    }
}

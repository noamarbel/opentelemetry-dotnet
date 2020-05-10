// <copyright file="Int64SummaryData.cs" company="OpenTelemetry Authors">
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

namespace OpenTelemetry.Metrics.Export
{
    /// <summary>
    /// Metric data that encapsulates an Int64 summary Aggregator data,
    /// including the count, sum, min and max of the measured data.
    /// </summary>
    public class Int64SummaryData : MetricData
    {
        /// <summary>
        /// Gets or Sets the number of measurements used for the summary data.
        /// </summary>
        public long Count { get; set; }

        /// <summary>
        /// Gets or Sets the sum represented by this data object.
        /// </summary>
        public long Sum { get; set; }

        /// <summary>
        /// Gets or Sets the minimal value represented within this data object.
        /// </summary>
        public long Min { get; set; }

        /// <summary>
        /// Gets or Sets the maximum value represented within this data object.
        /// </summary>
        public long Max { get; set; }
    }
}

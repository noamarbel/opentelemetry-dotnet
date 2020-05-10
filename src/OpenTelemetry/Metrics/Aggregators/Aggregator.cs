// <copyright file="Aggregator.cs" company="OpenTelemetry Authors">
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

using OpenTelemetry.Metrics.Export;

namespace OpenTelemetry.Metrics.Aggregators
{
    /// <summary>
    /// Abstract base class for aggregations. When derived, allows building different aggregators.
    /// </summary>
    /// <remarks>
    /// <para>A description of aggregators can be found at <see cref="!:https://github.com/open-telemetry/opentelemetry-specification/blob/master/specification/metrics/api.md#aggregations">The open API Specification</see>.</para>
    /// <para>Derived classes should make sure that calls to members of this base class are thread safe.</para>
    /// </remarks>
    /// <typeparam name="T">The type to be aggregated.</typeparam>
    public abstract class Aggregator<T>
        where T : struct
    {
        /// <summary>
        /// Updates the aggregation with a new value.
        /// </summary>
        /// <remarks>The nature if the aggregation performed is defined by deriving classes.</remarks>
        /// <param name="value">The value to be inserted to the aggregation.</param>
        public abstract void Update(T value);

        /// <summary>
        /// checkpoints the current running aggregation  into the class's checkpoint, and starts aggregating again.
        /// </summary>
        public abstract void Checkpoint();

        /// <summary>
        /// Gets the currently aggregated data as an instance of a <see cref="MetricData"/>.
        /// </summary>
        /// <returns>The aggregated data.</returns>
        public abstract MetricData ToMetricData();

        /// <summary>
        /// Gets the Aggregation type, as an <see cref="AggregationType"/>.
        /// </summary>
        /// <returns>The aggregation type.</returns>
        public abstract AggregationType GetAggregationType();
    }
}

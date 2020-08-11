// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The job type. </summary>
    public readonly partial struct SparkJobType : IEquatable<SparkJobType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SparkJobType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SparkJobType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SparkBatchValue = "SparkBatch";
        private const string SparkSessionValue = "SparkSession";

        /// <summary> SparkBatch. </summary>
        public static SparkJobType SparkBatch { get; } = new SparkJobType(SparkBatchValue);
        /// <summary> SparkSession. </summary>
        public static SparkJobType SparkSession { get; } = new SparkJobType(SparkSessionValue);
        /// <summary> Determines if two <see cref="SparkJobType"/> values are the same. </summary>
        public static bool operator ==(SparkJobType left, SparkJobType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkJobType"/> values are not the same. </summary>
        public static bool operator !=(SparkJobType left, SparkJobType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkJobType"/>. </summary>
        public static implicit operator SparkJobType(string value) => new SparkJobType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkJobType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkJobType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

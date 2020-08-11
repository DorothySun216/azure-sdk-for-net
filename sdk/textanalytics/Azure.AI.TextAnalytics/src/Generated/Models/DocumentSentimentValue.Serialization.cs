// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    internal static class DocumentSentimentValueExtensions
    {
        public static string ToSerialString(this DocumentSentimentValue value) => value switch
        {
            DocumentSentimentValue.Positive => "positive",
            DocumentSentimentValue.Neutral => "neutral",
            DocumentSentimentValue.Negative => "negative",
            DocumentSentimentValue.Mixed => "mixed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DocumentSentimentValue value.")
        };

        public static DocumentSentimentValue ToDocumentSentimentValue(this string value)
        {
            if (string.Equals(value, "positive", StringComparison.InvariantCultureIgnoreCase)) return DocumentSentimentValue.Positive;
            if (string.Equals(value, "neutral", StringComparison.InvariantCultureIgnoreCase)) return DocumentSentimentValue.Neutral;
            if (string.Equals(value, "negative", StringComparison.InvariantCultureIgnoreCase)) return DocumentSentimentValue.Negative;
            if (string.Equals(value, "mixed", StringComparison.InvariantCultureIgnoreCase)) return DocumentSentimentValue.Mixed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DocumentSentimentValue value.");
        }
    }
}

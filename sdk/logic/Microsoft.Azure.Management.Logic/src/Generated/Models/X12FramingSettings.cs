// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X12 agreement framing settings.
    /// </summary>
    public partial class X12FramingSettings
    {
        /// <summary>
        /// Initializes a new instance of the X12FramingSettings class.
        /// </summary>
        public X12FramingSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X12FramingSettings class.
        /// </summary>
        /// <param name="dataElementSeparator">The data element
        /// separator.</param>
        /// <param name="componentSeparator">The component separator.</param>
        /// <param name="replaceSeparatorsInPayload">The value indicating
        /// whether to replace separators in payload.</param>
        /// <param name="replaceCharacter">The replacement character.</param>
        /// <param name="segmentTerminator">The segment terminator.</param>
        /// <param name="characterSet">The X12 character set. Possible values
        /// include: 'NotSpecified', 'Basic', 'Extended', 'UTF8'</param>
        /// <param name="segmentTerminatorSuffix">The segment terminator
        /// suffix. Possible values include: 'NotSpecified', 'None', 'CR',
        /// 'LF', 'CRLF'</param>
        public X12FramingSettings(int dataElementSeparator, int componentSeparator, bool replaceSeparatorsInPayload, int replaceCharacter, int segmentTerminator, string characterSet, SegmentTerminatorSuffix segmentTerminatorSuffix)
        {
            DataElementSeparator = dataElementSeparator;
            ComponentSeparator = componentSeparator;
            ReplaceSeparatorsInPayload = replaceSeparatorsInPayload;
            ReplaceCharacter = replaceCharacter;
            SegmentTerminator = segmentTerminator;
            CharacterSet = characterSet;
            SegmentTerminatorSuffix = segmentTerminatorSuffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data element separator.
        /// </summary>
        [JsonProperty(PropertyName = "dataElementSeparator")]
        public int DataElementSeparator { get; set; }

        /// <summary>
        /// Gets or sets the component separator.
        /// </summary>
        [JsonProperty(PropertyName = "componentSeparator")]
        public int ComponentSeparator { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to replace separators in
        /// payload.
        /// </summary>
        [JsonProperty(PropertyName = "replaceSeparatorsInPayload")]
        public bool ReplaceSeparatorsInPayload { get; set; }

        /// <summary>
        /// Gets or sets the replacement character.
        /// </summary>
        [JsonProperty(PropertyName = "replaceCharacter")]
        public int ReplaceCharacter { get; set; }

        /// <summary>
        /// Gets or sets the segment terminator.
        /// </summary>
        [JsonProperty(PropertyName = "segmentTerminator")]
        public int SegmentTerminator { get; set; }

        /// <summary>
        /// Gets or sets the X12 character set. Possible values include:
        /// 'NotSpecified', 'Basic', 'Extended', 'UTF8'
        /// </summary>
        [JsonProperty(PropertyName = "characterSet")]
        public string CharacterSet { get; set; }

        /// <summary>
        /// Gets or sets the segment terminator suffix. Possible values
        /// include: 'NotSpecified', 'None', 'CR', 'LF', 'CRLF'
        /// </summary>
        [JsonProperty(PropertyName = "segmentTerminatorSuffix")]
        public SegmentTerminatorSuffix SegmentTerminatorSuffix { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CharacterSet == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CharacterSet");
            }
        }
    }
}

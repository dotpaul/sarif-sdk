// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// A single file. In some cases, this file might be nested within another file.
    /// </summary>
    [DataContract]
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.19.0.0")]
    public partial class FileData : ISarifNode, IEquatable<FileData>
    {
        /// <summary>
        /// Gets a value indicating the type of object implementing <see cref="ISarifNode" />.
        /// </summary>
        public SarifNodeKind SarifNodeKind
        {
            get
            {
                return SarifNodeKind.FileData;
            }
        }

        /// <summary>
        /// The path to the file within its containing file.
        /// </summary>
        [DataMember(Name = "uri", IsRequired = false, EmitDefaultValue = false)]
        public Uri Uri { get; set; }

        /// <summary>
        /// The offset in bytes of the file within its containing file.
        /// </summary>
        [DataMember(Name = "offset", IsRequired = false, EmitDefaultValue = false)]
        public int Offset { get; set; }

        /// <summary>
        /// The length of the file in bytes.
        /// </summary>
        [DataMember(Name = "length", IsRequired = false, EmitDefaultValue = false)]
        public int Length { get; set; }

        /// <summary>
        /// The MIME type (RFC 2045) of the file.
        /// </summary>
        [DataMember(Name = "mimeType", IsRequired = false, EmitDefaultValue = false)]
        public string MimeType { get; set; }

        /// <summary>
        /// An array of hash objects, each of which specifies a hashed value for the file, along with the name of the algorithm used to compute the hash.
        /// </summary>
        [DataMember(Name = "hashes", IsRequired = false, EmitDefaultValue = false)]
        public IList<Hash> Hashes { get; set; }

        /// <summary>
        /// Key/value pairs that provide additional information about the file.
        /// </summary>
        [DataMember(Name = "properties", IsRequired = false, EmitDefaultValue = false)]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// A set of distinct strings that provide additional information about the file.
        /// </summary>
        [DataMember(Name = "tags", IsRequired = false, EmitDefaultValue = false)]
        public IList<string> Tags { get; set; }

        public override bool Equals(object other)
        {
            return Equals(other as FileData);
        }

        public override int GetHashCode()
        {
            int result = 17;
            unchecked
            {
                if (Uri != null)
                {
                    result = (result * 31) + Uri.GetHashCode();
                }

                result = (result * 31) + Offset.GetHashCode();
                result = (result * 31) + Length.GetHashCode();
                if (MimeType != null)
                {
                    result = (result * 31) + MimeType.GetHashCode();
                }

                if (Hashes != null)
                {
                    foreach (var value_0 in Hashes)
                    {
                        result = result * 31;
                        if (value_0 != null)
                        {
                            result = (result * 31) + value_0.GetHashCode();
                        }
                    }
                }

                if (Properties != null)
                {
                    // Use xor for dictionaries to be order-independent.
                    int xor_0 = 0;
                    foreach (var value_1 in Properties)
                    {
                        xor_0 ^= value_1.Key.GetHashCode();
                        if (value_1.Value != null)
                        {
                            xor_0 ^= value_1.Value.GetHashCode();
                        }
                    }

                    result = (result * 31) + xor_0;
                }

                if (Tags != null)
                {
                    foreach (var value_2 in Tags)
                    {
                        result = result * 31;
                        if (value_2 != null)
                        {
                            result = (result * 31) + value_2.GetHashCode();
                        }
                    }
                }
            }

            return result;
        }

        public bool Equals(FileData other)
        {
            if (other == null)
            {
                return false;
            }

            if (Uri != other.Uri)
            {
                return false;
            }

            if (Offset != other.Offset)
            {
                return false;
            }

            if (Length != other.Length)
            {
                return false;
            }

            if (MimeType != other.MimeType)
            {
                return false;
            }

            if (!Object.ReferenceEquals(Hashes, other.Hashes))
            {
                if (Hashes == null || other.Hashes == null)
                {
                    return false;
                }

                if (Hashes.Count != other.Hashes.Count)
                {
                    return false;
                }

                for (int index_0 = 0; index_0 < Hashes.Count; ++index_0)
                {
                    if (!Object.Equals(Hashes[index_0], other.Hashes[index_0]))
                    {
                        return false;
                    }
                }
            }

            if (!Object.ReferenceEquals(Properties, other.Properties))
            {
                if (Properties == null || other.Properties == null || Properties.Count != other.Properties.Count)
                {
                    return false;
                }

                foreach (var value_0 in Properties)
                {
                    string value_1;
                    if (!other.Properties.TryGetValue(value_0.Key, out value_1))
                    {
                        return false;
                    }

                    if (value_0.Value != value_1)
                    {
                        return false;
                    }
                }
            }

            if (!Object.ReferenceEquals(Tags, other.Tags))
            {
                if (Tags == null || other.Tags == null)
                {
                    return false;
                }

                if (Tags.Count != other.Tags.Count)
                {
                    return false;
                }

                for (int index_1 = 0; index_1 < Tags.Count; ++index_1)
                {
                    if (Tags[index_1] != other.Tags[index_1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        public FileData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class from the supplied values.
        /// </summary>
        /// <param name="uri">
        /// An initialization value for the <see cref="P: Uri" /> property.
        /// </param>
        /// <param name="offset">
        /// An initialization value for the <see cref="P: Offset" /> property.
        /// </param>
        /// <param name="length">
        /// An initialization value for the <see cref="P: Length" /> property.
        /// </param>
        /// <param name="mimeType">
        /// An initialization value for the <see cref="P: MimeType" /> property.
        /// </param>
        /// <param name="hashes">
        /// An initialization value for the <see cref="P: Hashes" /> property.
        /// </param>
        /// <param name="properties">
        /// An initialization value for the <see cref="P: Properties" /> property.
        /// </param>
        /// <param name="tags">
        /// An initialization value for the <see cref="P: Tags" /> property.
        /// </param>
        public FileData(Uri uri, int offset, int length, string mimeType, IEnumerable<Hash> hashes, IDictionary<string, string> properties, IEnumerable<string> tags)
        {
            Init(uri, offset, length, mimeType, hashes, properties, tags);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class from the specified instance.
        /// </summary>
        /// <param name="other">
        /// The instance from which the new instance is to be initialized.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other" /> is null.
        /// </exception>
        public FileData(FileData other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            Init(other.Uri, other.Offset, other.Length, other.MimeType, other.Hashes, other.Properties, other.Tags);
        }

        ISarifNode ISarifNode.DeepClone()
        {
            return DeepCloneCore();
        }

        /// <summary>
        /// Creates a deep copy of this instance.
        /// </summary>
        public FileData DeepClone()
        {
            return (FileData)DeepCloneCore();
        }

        private ISarifNode DeepCloneCore()
        {
            return new FileData(this);
        }

        private void Init(Uri uri, int offset, int length, string mimeType, IEnumerable<Hash> hashes, IDictionary<string, string> properties, IEnumerable<string> tags)
        {
            if (uri != null)
            {
                Uri = new Uri(uri.OriginalString, uri.IsAbsoluteUri ? UriKind.Absolute : UriKind.Relative);
            }

            Offset = offset;
            Length = length;
            MimeType = mimeType;
            if (hashes != null)
            {
                var destination_0 = new List<Hash>();
                foreach (var value_0 in hashes)
                {
                    if (value_0 == null)
                    {
                        destination_0.Add(null);
                    }
                    else
                    {
                        destination_0.Add(new Hash(value_0));
                    }
                }

                Hashes = destination_0;
            }

            if (properties != null)
            {
                Properties = new Dictionary<string, string>(properties);
            }

            if (tags != null)
            {
                var destination_1 = new List<string>();
                foreach (var value_1 in tags)
                {
                    destination_1.Add(value_1);
                }

                Tags = destination_1;
            }
        }
    }
}
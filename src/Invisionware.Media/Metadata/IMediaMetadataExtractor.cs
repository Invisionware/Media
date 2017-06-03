using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Invisionware.Media.Metadata
{
	public interface IMediaMetadataExtractor
	{
		IDictionary<string, IMedaMetadataAttribute> ReadMetadata(Uri imageUri);
		IDictionary<string, IMedaMetadataAttribute> ReadMetadata(Stream inStream);
	}
}

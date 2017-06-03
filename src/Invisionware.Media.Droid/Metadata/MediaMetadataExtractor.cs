using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Invisionware.Media.Metadata;

namespace Invisionware.Media
{
	public class MediaMetadataExtractor : IMediaMetadataExtractor
	{
		public IDictionary<string, IMedaMetadataAttribute> ReadMetadata(Uri imageUri)
		{
			throw new NotImplementedException();
		}

		public IDictionary<string, IMedaMetadataAttribute> ReadMetadata(Stream inStream)
		{
			throw new NotImplementedException();
		}
	}
}

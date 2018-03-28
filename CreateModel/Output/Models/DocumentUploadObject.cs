using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class DocumentUploadObject
	{

		[JsonProperty("henaPostgradIntro")]
		[XmlElement("HenaPostgradIntro")]
		public string HenaPostgradIntro{
			get;
			set;
		}

	}
}


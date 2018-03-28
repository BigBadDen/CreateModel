using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class GenericObject
	{

		[JsonProperty("applicationLoadErrorHeading")]
		[XmlElement("ApplicationLoadErrorHeading")]
		public string ApplicationLoadErrorHeading{
			get;
			set;
		}

		[JsonProperty("applicationLoadErrorMessage")]
		[XmlElement("ApplicationLoadErrorMessage")]
		public string ApplicationLoadErrorMessage{
			get;
			set;
		}

		[JsonProperty("saveApplicationError")]
		[XmlElement("SaveApplicationError")]
		public string SaveApplicationError{
			get;
			set;
		}

		[JsonProperty("regionModalHeader")]
		[XmlElement("RegionModalHeader")]
		public string RegionModalHeader{
			get;
			set;
		}

		[JsonProperty("regionModalIntro")]
		[XmlElement("RegionModalIntro")]
		public string RegionModalIntro{
			get;
			set;
		}

	}
}


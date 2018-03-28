using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class OtherInformationObject
	{

		[JsonProperty("dismissedOrExpelledLabel")]
		[XmlElement("DismissedOrExpelledLabel")]
		public string DismissedOrExpelledLabel{
			get;
			set;
		}

		[JsonProperty("anyOtherInformationLabel")]
		[XmlElement("AnyOtherInformationLabel")]
		public string AnyOtherInformationLabel{
			get;
			set;
		}

	}
}


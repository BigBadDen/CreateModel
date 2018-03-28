using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class ConfirmationObject
	{

		[JsonProperty("henaBody")]
		[XmlElement("HenaBody")]
		public string HenaBody{
			get;
			set;
		}

		[JsonProperty("henaCanadaAddition")]
		[XmlElement("HenaCanadaAddition")]
		public string HenaCanadaAddition{
			get;
			set;
		}

		[JsonProperty("agencyUrnHeader")]
		[XmlElement("AgencyUrnHeader")]
		public string AgencyUrnHeader{
			get;
			set;
		}

		[JsonProperty("agencyUrnHint")]
		[XmlElement("AgencyUrnHint")]
		public string AgencyUrnHint{
			get;
			set;
		}

		[JsonProperty("agencyUrnError")]
		[XmlElement("AgencyUrnError")]
		public string AgencyUrnError{
			get;
			set;
		}

		[JsonProperty("submittingApplicationMessage")]
		[XmlElement("SubmittingApplicationMessage")]
		public string SubmittingApplicationMessage{
			get;
			set;
		}

	}
}


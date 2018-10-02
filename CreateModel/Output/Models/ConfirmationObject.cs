using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class ConfirmationObject
	{

		[JsonProperty("title")]
		[XmlElement("Title")]
		public string Title{
			get;
			set;
		}

		[JsonProperty("body")]
		[XmlElement("Body")]
		public string Body{
			get;
			set;
		}

		[JsonProperty("cancelButton")]
		[XmlElement("CancelButton")]
		public string CancelButton{
			get;
			set;
		}

		[JsonProperty("confirmButton")]
		[XmlElement("ConfirmButton")]
		public string ConfirmButton{
			get;
			set;
		}

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

		[JsonProperty("agencyUrnPlaceholder")]
		[XmlElement("AgencyUrnPlaceholder")]
		public string AgencyUrnPlaceholder{
			get;
			set;
		}

	}
}


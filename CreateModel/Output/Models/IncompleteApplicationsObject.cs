using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class IncompleteApplicationsObject
	{

		[JsonProperty("tableHeadingApplication")]
		[XmlElement("TableHeadingApplication")]
		public string TableHeadingApplication{
			get;
			set;
		}

		[JsonProperty("actionViewDetails")]
		[XmlElement("ActionViewDetails")]
		public string ActionViewDetails{
			get;
			set;
		}

		[JsonProperty("applicationModalTitle")]
		[XmlElement("ApplicationModalTitle")]
		public string ApplicationModalTitle{
			get;
			set;
		}

		[JsonProperty("applicationModalIntro")]
		[XmlElement("ApplicationModalIntro")]
		public string ApplicationModalIntro{
			get;
			set;
		}

		[JsonProperty("applicationModalTableHeadingCaseId")]
		[XmlElement("ApplicationModalTableHeadingCaseId")]
		public string ApplicationModalTableHeadingCaseId{
			get;
			set;
		}

		[JsonProperty("applicationModalTableHeadingCentre")]
		[XmlElement("ApplicationModalTableHeadingCentre")]
		public string ApplicationModalTableHeadingCentre{
			get;
			set;
		}

		[JsonProperty("applicationModalTableHeadingCourse")]
		[XmlElement("ApplicationModalTableHeadingCourse")]
		public string ApplicationModalTableHeadingCourse{
			get;
			set;
		}

		[JsonProperty("applicationModalTableHeadingApplication")]
		[XmlElement("ApplicationModalTableHeadingApplication")]
		public string ApplicationModalTableHeadingApplication{
			get;
			set;
		}

		[JsonProperty("applicationModalActionView")]
		[XmlElement("ApplicationModalActionView")]
		public string ApplicationModalActionView{
			get;
			set;
		}

	}
}


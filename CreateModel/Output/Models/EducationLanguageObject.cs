using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class EducationLanguageObject
	{

		[JsonProperty("previouslyStudiedInUSLabel")]
		[XmlElement("PreviouslyStudiedInUSLabel")]
		public string PreviouslyStudiedInUSLabel{
			get;
			set;
		}

		[JsonProperty("previousUSVisaRefusedLabel")]
		[XmlElement("PreviousUSVisaRefusedLabel")]
		public string PreviousUSVisaRefusedLabel{
			get;
			set;
		}

		[JsonProperty("academicHistoryHint")]
		[XmlElement("AcademicHistoryHint")]
		public string AcademicHistoryHint{
			get;
			set;
		}

		[JsonProperty("addAcademicHistoryButtonLabel")]
		[XmlElement("AddAcademicHistoryButtonLabel")]
		public string AddAcademicHistoryButtonLabel{
			get;
			set;
		}

		[JsonProperty("deleteAcademicHistoryModalTitle")]
		[XmlElement("DeleteAcademicHistoryModalTitle")]
		public string DeleteAcademicHistoryModalTitle{
			get;
			set;
		}

		[JsonProperty("deleteAcademicHistoryModalIntro")]
		[XmlElement("DeleteAcademicHistoryModalIntro")]
		public string DeleteAcademicHistoryModalIntro{
			get;
			set;
		}

		[JsonProperty("deleteAcademicHistoryModalCancelLabel")]
		[XmlElement("DeleteAcademicHistoryModalCancelLabel")]
		public string DeleteAcademicHistoryModalCancelLabel{
			get;
			set;
		}

		[JsonProperty("deleteAcademicHistoryModalDeleteLabel")]
		[XmlElement("DeleteAcademicHistoryModalDeleteLabel")]
		public string DeleteAcademicHistoryModalDeleteLabel{
			get;
			set;
		}

	}
}


using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class CentreSelectionObject
	{

		[JsonProperty("secondaryUniversityDegreeChoiceHENALabel")]
		[XmlElement("SecondaryUniversityDegreeChoiceHENALabel")]
		public string SecondaryUniversityDegreeChoiceHENALabel{
			get;
			set;
		}

		[JsonProperty("secondaryUniversityDegreeChoiceHint")]
		[XmlElement("SecondaryUniversityDegreeChoiceHint")]
		public string SecondaryUniversityDegreeChoiceHint{
			get;
			set;
		}

		[JsonProperty("tertiaryUniversityDegreeChoiceHint")]
		[XmlElement("TertiaryUniversityDegreeChoiceHint")]
		public string TertiaryUniversityDegreeChoiceHint{
			get;
			set;
		}

	}
}


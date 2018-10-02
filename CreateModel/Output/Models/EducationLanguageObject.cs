using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class EducationLanguageObject
	{

		[JsonProperty("sectionLabel")]
		[XmlElement("SectionLabel")]
		public string SectionLabel{
			get;
			set;
		}

		[JsonProperty("takenEnglishLabel")]
		[XmlElement("TakenEnglishLabel")]
		public string TakenEnglishLabel{
			get;
			set;
		}

		[JsonProperty("takenEnglishError")]
		[XmlElement("TakenEnglishError")]
		public string TakenEnglishError{
			get;
			set;
		}

		[JsonProperty("englishTakenLabel")]
		[XmlElement("EnglishTakenLabel")]
		public string EnglishTakenLabel{
			get;
			set;
		}

		[JsonProperty("englishTakenError")]
		[XmlElement("EnglishTakenError")]
		public string EnglishTakenError{
			get;
			set;
		}

		[JsonProperty("recentEducationSectionLabel")]
		[XmlElement("RecentEducationSectionLabel")]
		public string RecentEducationSectionLabel{
			get;
			set;
		}

		[JsonProperty("institutionLabel")]
		[XmlElement("InstitutionLabel")]
		public string InstitutionLabel{
			get;
			set;
		}

		[JsonProperty("institutionPlaceholder")]
		[XmlElement("InstitutionPlaceholder")]
		public string InstitutionPlaceholder{
			get;
			set;
		}

		[JsonProperty("institutionError")]
		[XmlElement("InstitutionError")]
		public string InstitutionError{
			get;
			set;
		}

		[JsonProperty("institutionLocationLabel")]
		[XmlElement("InstitutionLocationLabel")]
		public string InstitutionLocationLabel{
			get;
			set;
		}

		[JsonProperty("institutionLocationPlaceholder")]
		[XmlElement("InstitutionLocationPlaceholder")]
		public string InstitutionLocationPlaceholder{
			get;
			set;
		}

		[JsonProperty("institutionLocationError")]
		[XmlElement("InstitutionLocationError")]
		public string InstitutionLocationError{
			get;
			set;
		}

		[JsonProperty("courseStudiedLabel")]
		[XmlElement("CourseStudiedLabel")]
		public string CourseStudiedLabel{
			get;
			set;
		}

		[JsonProperty("courseStudiedPlaceholder")]
		[XmlElement("CourseStudiedPlaceholder")]
		public string CourseStudiedPlaceholder{
			get;
			set;
		}

		[JsonProperty("courseStudiedError")]
		[XmlElement("CourseStudiedError")]
		public string CourseStudiedError{
			get;
			set;
		}

		[JsonProperty("dateFromToLabel")]
		[XmlElement("DateFromToLabel")]
		public string DateFromToLabel{
			get;
			set;
		}

		[JsonProperty("dateFromToError")]
		[XmlElement("DateFromToError")]
		public string DateFromToError{
			get;
			set;
		}

		[JsonProperty("dateFromLabel")]
		[XmlElement("DateFromLabel")]
		public string DateFromLabel{
			get;
			set;
		}

		[JsonProperty("dateToLabel")]
		[XmlElement("DateToLabel")]
		public string DateToLabel{
			get;
			set;
		}

		[JsonProperty("dateFromToDDPlaceholder")]
		[XmlElement("DateFromToDDPlaceholder")]
		public string DateFromToDDPlaceholder{
			get;
			set;
		}

		[JsonProperty("dateFromToMMPlaceholder")]
		[XmlElement("DateFromToMMPlaceholder")]
		public string DateFromToMMPlaceholder{
			get;
			set;
		}

		[JsonProperty("dateFromToYYYYPlaceholder")]
		[XmlElement("DateFromToYYYYPlaceholder")]
		public string DateFromToYYYYPlaceholder{
			get;
			set;
		}

		[JsonProperty("previouslyStudiedInUkLabel")]
		[XmlElement("PreviouslyStudiedInUkLabel")]
		public string PreviouslyStudiedInUkLabel{
			get;
			set;
		}

		[JsonProperty("previouslyStudiedInUkError")]
		[XmlElement("PreviouslyStudiedInUkError")]
		public string PreviouslyStudiedInUkError{
			get;
			set;
		}

		[JsonProperty("requireVisaLabel")]
		[XmlElement("RequireVisaLabel")]
		public string RequireVisaLabel{
			get;
			set;
		}

		[JsonProperty("requireVisaError")]
		[XmlElement("RequireVisaError")]
		public string RequireVisaError{
			get;
			set;
		}

		[JsonProperty("visaTypeLabel")]
		[XmlElement("VisaTypeLabel")]
		public string VisaTypeLabel{
			get;
			set;
		}

		[JsonProperty("visaTypeError")]
		[XmlElement("VisaTypeError")]
		public string VisaTypeError{
			get;
			set;
		}

		[JsonProperty("previousUKVisaRefusedLabel")]
		[XmlElement("PreviousUKVisaRefusedLabel")]
		public string PreviousUKVisaRefusedLabel{
			get;
			set;
		}

		[JsonProperty("previousUKVisaRefusedError")]
		[XmlElement("PreviousUKVisaRefusedError")]
		public string PreviousUKVisaRefusedError{
			get;
			set;
		}

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

		[JsonProperty("visaTypesLabel")]
		[XmlElement("VisaTypesLabel")]
		public string VisaTypesLabel{
			get;
			set;
		}

		[JsonProperty("courseStudiedHenaLabel")]
		[XmlElement("CourseStudiedHenaLabel")]
		public string CourseStudiedHenaLabel{
			get;
			set;
		}

		[JsonProperty("courseStudiedHenaPlaceholder")]
		[XmlElement("CourseStudiedHenaPlaceholder")]
		public string CourseStudiedHenaPlaceholder{
			get;
			set;
		}

		[JsonProperty("institutionHint")]
		[XmlElement("InstitutionHint")]
		public string InstitutionHint{
			get;
			set;
		}

		[JsonProperty("previouslyStudiedInANZLabel")]
		[XmlElement("PreviouslyStudiedInANZLabel")]
		public string PreviouslyStudiedInANZLabel{
			get;
			set;
		}

		[JsonProperty("previousANZVisaRefusedLabel")]
		[XmlElement("PreviousANZVisaRefusedLabel")]
		public string PreviousANZVisaRefusedLabel{
			get;
			set;
		}

		[JsonProperty("currentVisaLabel")]
		[XmlElement("CurrentVisaLabel")]
		public string CurrentVisaLabel{
			get;
			set;
		}

		[JsonProperty("currentVisaInstructions")]
		[XmlElement("CurrentVisaInstructions")]
		public string CurrentVisaInstructions{
			get;
			set;
		}

		[JsonProperty("currentVisaTypeLabel")]
		[XmlElement("CurrentVisaTypeLabel")]
		public string CurrentVisaTypeLabel{
			get;
			set;
		}

		[JsonProperty("breachedVisaConditionsLabel")]
		[XmlElement("BreachedVisaConditionsLabel")]
		public string BreachedVisaConditionsLabel{
			get;
			set;
		}

	}
}


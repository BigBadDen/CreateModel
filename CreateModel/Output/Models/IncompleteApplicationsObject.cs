using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class IncompleteApplicationsObject
	{

		[JsonProperty("tableHeadingName")]
		[XmlElement("TableHeadingName")]
		public string TableHeadingName{
			get;
			set;
		}

		[JsonProperty("tableHeadingEmail")]
		[XmlElement("TableHeadingEmail")]
		public string TableHeadingEmail{
			get;
			set;
		}

		[JsonProperty("tableHeadingModified")]
		[XmlElement("TableHeadingModified")]
		public string TableHeadingModified{
			get;
			set;
		}

		[JsonProperty("tableHeadingExpires")]
		[XmlElement("TableHeadingExpires")]
		public string TableHeadingExpires{
			get;
			set;
		}

		[JsonProperty("tableHeadingAction")]
		[XmlElement("TableHeadingAction")]
		public string TableHeadingAction{
			get;
			set;
		}

		[JsonProperty("actionContinueLabel")]
		[XmlElement("ActionContinueLabel")]
		public string ActionContinueLabel{
			get;
			set;
		}

		[JsonProperty("actionDeleteLabel")]
		[XmlElement("ActionDeleteLabel")]
		public string ActionDeleteLabel{
			get;
			set;
		}

		[JsonProperty("heading")]
		[XmlElement("Heading")]
		public string Heading{
			get;
			set;
		}

		[JsonProperty("intro")]
		[XmlElement("Intro")]
		public string Intro{
			get;
			set;
		}

		[JsonProperty("expiringApplicantsSingleHint")]
		[XmlElement("ExpiringApplicantsSingleHint")]
		public string ExpiringApplicantsSingleHint{
			get;
			set;
		}

		[JsonProperty("expiringApplicantsMultipleHint")]
		[XmlElement("ExpiringApplicantsMultipleHint")]
		public string ExpiringApplicantsMultipleHint{
			get;
			set;
		}

		[JsonProperty("deleteDialogTitle")]
		[XmlElement("DeleteDialogTitle")]
		public string DeleteDialogTitle{
			get;
			set;
		}

		[JsonProperty("deleteDialogIntro")]
		[XmlElement("DeleteDialogIntro")]
		public string DeleteDialogIntro{
			get;
			set;
		}

		[JsonProperty("deleteDialogCancel")]
		[XmlElement("DeleteDialogCancel")]
		public string DeleteDialogCancel{
			get;
			set;
		}

		[JsonProperty("deleteDialogConfirm")]
		[XmlElement("DeleteDialogConfirm")]
		public string DeleteDialogConfirm{
			get;
			set;
		}

		[JsonProperty("incompleteTabLabel")]
		[XmlElement("IncompleteTabLabel")]
		public string IncompleteTabLabel{
			get;
			set;
		}

		[JsonProperty("incompleteIntro")]
		[XmlElement("IncompleteIntro")]
		public string IncompleteIntro{
			get;
			set;
		}

		[JsonProperty("incompleteNoApplicantsMessage")]
		[XmlElement("IncompleteNoApplicantsMessage")]
		public string IncompleteNoApplicantsMessage{
			get;
			set;
		}

		[JsonProperty("submittedTabLabel")]
		[XmlElement("SubmittedTabLabel")]
		public string SubmittedTabLabel{
			get;
			set;
		}

		[JsonProperty("submittedIntro")]
		[XmlElement("SubmittedIntro")]
		public string SubmittedIntro{
			get;
			set;
		}

		[JsonProperty("submittedNoApplicantsMessage")]
		[XmlElement("SubmittedNoApplicantsMessage")]
		public string SubmittedNoApplicantsMessage{
			get;
			set;
		}

		[JsonProperty("tableHeadingSubmitted")]
		[XmlElement("TableHeadingSubmitted")]
		public string TableHeadingSubmitted{
			get;
			set;
		}

		[JsonProperty("tableHeadingStatus")]
		[XmlElement("TableHeadingStatus")]
		public string TableHeadingStatus{
			get;
			set;
		}

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

		[JsonProperty("tableHeadingRegion")]
		[XmlElement("TableHeadingRegion")]
		public string TableHeadingRegion{
			get;
			set;
		}

		[JsonProperty("tableHeadingURN")]
		[XmlElement("TableHeadingURN")]
		public string TableHeadingURN{
			get;
			set;
		}

	}
}


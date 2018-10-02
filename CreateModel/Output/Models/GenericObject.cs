using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class GenericObject
	{

		[JsonProperty("headingLabel")]
		[XmlElement("HeadingLabel")]
		public string HeadingLabel{
			get;
			set;
		}

		[JsonProperty("progressBarCompletedLabel")]
		[XmlElement("ProgressBarCompletedLabel")]
		public string ProgressBarCompletedLabel{
			get;
			set;
		}

		[JsonProperty("progressBarSaveLabel")]
		[XmlElement("ProgressBarSaveLabel")]
		public string ProgressBarSaveLabel{
			get;
			set;
		}

		[JsonProperty("progressBarSavingLabel")]
		[XmlElement("ProgressBarSavingLabel")]
		public string ProgressBarSavingLabel{
			get;
			set;
		}

		[JsonProperty("progressBarSubmitLabel")]
		[XmlElement("ProgressBarSubmitLabel")]
		public string ProgressBarSubmitLabel{
			get;
			set;
		}

		[JsonProperty("countryMissingSelectionError")]
		[XmlElement("CountryMissingSelectionError")]
		public string CountryMissingSelectionError{
			get;
			set;
		}

		[JsonProperty("notificationEnrolmentAge")]
		[XmlElement("NotificationEnrolmentAge")]
		public string NotificationEnrolmentAge{
			get;
			set;
		}

		[JsonProperty("sectionNextLabel")]
		[XmlElement("SectionNextLabel")]
		public string SectionNextLabel{
			get;
			set;
		}

		[JsonProperty("sectionPreviousLabel")]
		[XmlElement("SectionPreviousLabel")]
		public string SectionPreviousLabel{
			get;
			set;
		}

		[JsonProperty("submittedConfirmationHeading")]
		[XmlElement("SubmittedConfirmationHeading")]
		public string SubmittedConfirmationHeading{
			get;
			set;
		}

		[JsonProperty("submittedConfirmationIntro")]
		[XmlElement("SubmittedConfirmationIntro")]
		public string SubmittedConfirmationIntro{
			get;
			set;
		}

		[JsonProperty("submittedConfirmationStartApplicationLabel")]
		[XmlElement("SubmittedConfirmationStartApplicationLabel")]
		public string SubmittedConfirmationStartApplicationLabel{
			get;
			set;
		}

		[JsonProperty("submittedConfirmationMyApplicationsLabel")]
		[XmlElement("SubmittedConfirmationMyApplicationsLabel")]
		public string SubmittedConfirmationMyApplicationsLabel{
			get;
			set;
		}

		[JsonProperty("unknownAgentHeading")]
		[XmlElement("UnknownAgentHeading")]
		public string UnknownAgentHeading{
			get;
			set;
		}

		[JsonProperty("unknownAgentIntro")]
		[XmlElement("UnknownAgentIntro")]
		public string UnknownAgentIntro{
			get;
			set;
		}

		[JsonProperty("validatorMessageEmptySpace")]
		[XmlElement("ValidatorMessageEmptySpace")]
		public string ValidatorMessageEmptySpace{
			get;
			set;
		}

		[JsonProperty("headerBackToPortalText")]
		[XmlElement("HeaderBackToPortalText")]
		public string HeaderBackToPortalText{
			get;
			set;
		}

		[JsonProperty("headerLogoutText")]
		[XmlElement("HeaderLogoutText")]
		public string HeaderLogoutText{
			get;
			set;
		}

		[JsonProperty("headerAgentPortalText")]
		[XmlElement("HeaderAgentPortalText")]
		public string HeaderAgentPortalText{
			get;
			set;
		}

		[JsonProperty("footerConnectWithUsLabel")]
		[XmlElement("FooterConnectWithUsLabel")]
		public string FooterConnectWithUsLabel{
			get;
			set;
		}

		[JsonProperty("validatorMessageInvalidCharacter")]
		[XmlElement("ValidatorMessageInvalidCharacter")]
		public string ValidatorMessageInvalidCharacter{
			get;
			set;
		}

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

		[JsonProperty("headerExitApplication")]
		[XmlElement("HeaderExitApplication")]
		public string HeaderExitApplication{
			get;
			set;
		}

	}
}


using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class DocumentUploadObject
	{

		[JsonProperty("sectionLabel")]
		[XmlElement("SectionLabel")]
		public string SectionLabel{
			get;
			set;
		}

		[JsonProperty("intro")]
		[XmlElement("Intro")]
		public string Intro{
			get;
			set;
		}

		[JsonProperty("introANZ")]
		[XmlElement("IntroANZ")]
		public string IntroANZ{
			get;
			set;
		}

		[JsonProperty("submittingDocumentsLabel")]
		[XmlElement("SubmittingDocumentsLabel")]
		public string SubmittingDocumentsLabel{
			get;
			set;
		}

		[JsonProperty("submittingDocumentsError")]
		[XmlElement("SubmittingDocumentsError")]
		public string SubmittingDocumentsError{
			get;
			set;
		}

		[JsonProperty("certificatesLabel")]
		[XmlElement("CertificatesLabel")]
		public string CertificatesLabel{
			get;
			set;
		}

		[JsonProperty("IELTSLabel")]
		[XmlElement("IELTSLabel")]
		public string IELTSLabel{
			get;
			set;
		}

		[JsonProperty("passportLabel")]
		[XmlElement("PassportLabel")]
		public string PassportLabel{
			get;
			set;
		}

		[JsonProperty("otherLabel")]
		[XmlElement("OtherLabel")]
		public string OtherLabel{
			get;
			set;
		}

		[JsonProperty("visaLabel")]
		[XmlElement("VisaLabel")]
		public string VisaLabel{
			get;
			set;
		}

		[JsonProperty("completePackageLabel")]
		[XmlElement("CompletePackageLabel")]
		public string CompletePackageLabel{
			get;
			set;
		}

		[JsonProperty("dragDropLabel")]
		[XmlElement("DragDropLabel")]
		public string DragDropLabel{
			get;
			set;
		}

		[JsonProperty("dragOverLabel")]
		[XmlElement("DragOverLabel")]
		public string DragOverLabel{
			get;
			set;
		}

		[JsonProperty("uploadingMessage")]
		[XmlElement("UploadingMessage")]
		public string UploadingMessage{
			get;
			set;
		}

		[JsonProperty("uploadingSuccess")]
		[XmlElement("UploadingSuccess")]
		public string UploadingSuccess{
			get;
			set;
		}

		[JsonProperty("uploadInvalidError")]
		[XmlElement("UploadInvalidError")]
		public string UploadInvalidError{
			get;
			set;
		}

		[JsonProperty("uploadDuplicateFile")]
		[XmlElement("UploadDuplicateFile")]
		public string UploadDuplicateFile{
			get;
			set;
		}

		[JsonProperty("uploadError")]
		[XmlElement("UploadError")]
		public string UploadError{
			get;
			set;
		}

		[JsonProperty("documentDeleteDialogTitle")]
		[XmlElement("DocumentDeleteDialogTitle")]
		public string DocumentDeleteDialogTitle{
			get;
			set;
		}

		[JsonProperty("documentDeleteDialogIntro")]
		[XmlElement("DocumentDeleteDialogIntro")]
		public string DocumentDeleteDialogIntro{
			get;
			set;
		}

		[JsonProperty("documentDeleteDialogCancel")]
		[XmlElement("DocumentDeleteDialogCancel")]
		public string DocumentDeleteDialogCancel{
			get;
			set;
		}

		[JsonProperty("documentDeleteDialogConfirm")]
		[XmlElement("DocumentDeleteDialogConfirm")]
		public string DocumentDeleteDialogConfirm{
			get;
			set;
		}

		[JsonProperty("validatingFiles")]
		[XmlElement("ValidatingFiles")]
		public string ValidatingFiles{
			get;
			set;
		}

		[JsonProperty("uploadDocumentsDialogTitle")]
		[XmlElement("UploadDocumentsDialogTitle")]
		public string UploadDocumentsDialogTitle{
			get;
			set;
		}

		[JsonProperty("uploadDocumentsDialogIntro")]
		[XmlElement("UploadDocumentsDialogIntro")]
		public string UploadDocumentsDialogIntro{
			get;
			set;
		}

		[JsonProperty("uploadDocumentsDialogConfirmLabel")]
		[XmlElement("UploadDocumentsDialogConfirmLabel")]
		public string UploadDocumentsDialogConfirmLabel{
			get;
			set;
		}

		[JsonProperty("uploadErrorMessage")]
		[XmlElement("UploadErrorMessage")]
		public string UploadErrorMessage{
			get;
			set;
		}

		[JsonProperty("deleteErrorMessage")]
		[XmlElement("DeleteErrorMessage")]
		public string DeleteErrorMessage{
			get;
			set;
		}

		[JsonProperty("henaPostgradIntro")]
		[XmlElement("HenaPostgradIntro")]
		public string HenaPostgradIntro{
			get;
			set;
		}

	}
}


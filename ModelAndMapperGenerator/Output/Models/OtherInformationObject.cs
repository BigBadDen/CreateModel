using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class OtherInformationObject
	{

		[JsonProperty("sectionLabel")]
		[XmlElement("SectionLabel")]
		public string SectionLabel{
			get;
			set;
		}

		[JsonProperty("requiresAccomodationLabel")]
		[XmlElement("RequiresAccomodationLabel")]
		public string RequiresAccomodationLabel{
			get;
			set;
		}

		[JsonProperty("requiresAccomodationError")]
		[XmlElement("RequiresAccomodationError")]
		public string RequiresAccomodationError{
			get;
			set;
		}

		[JsonProperty("requiresTransferLabel")]
		[XmlElement("RequiresTransferLabel")]
		public string RequiresTransferLabel{
			get;
			set;
		}

		[JsonProperty("requiresTransferError")]
		[XmlElement("RequiresTransferError")]
		public string RequiresTransferError{
			get;
			set;
		}

		[JsonProperty("requiresInsuranceLabel")]
		[XmlElement("RequiresInsuranceLabel")]
		public string RequiresInsuranceLabel{
			get;
			set;
		}

		[JsonProperty("requiresInsuranceError")]
		[XmlElement("RequiresInsuranceError")]
		public string RequiresInsuranceError{
			get;
			set;
		}

		[JsonProperty("medicalSpecialNeedsLabel")]
		[XmlElement("MedicalSpecialNeedsLabel")]
		public string MedicalSpecialNeedsLabel{
			get;
			set;
		}

		[JsonProperty("medicalSpecialNeedsError")]
		[XmlElement("MedicalSpecialNeedsError")]
		public string MedicalSpecialNeedsError{
			get;
			set;
		}

		[JsonProperty("criminalConvictionsLabel")]
		[XmlElement("CriminalConvictionsLabel")]
		public string CriminalConvictionsLabel{
			get;
			set;
		}

		[JsonProperty("criminalConvictionsError")]
		[XmlElement("CriminalConvictionsError")]
		public string CriminalConvictionsError{
			get;
			set;
		}

		[JsonProperty("additionalNotesLabel")]
		[XmlElement("AdditionalNotesLabel")]
		public string AdditionalNotesLabel{
			get;
			set;
		}

		[JsonProperty("accommodationDialogTitle")]
		[XmlElement("AccommodationDialogTitle")]
		public string AccommodationDialogTitle{
			get;
			set;
		}

		[JsonProperty("accommodationDialogIntro")]
		[XmlElement("AccommodationDialogIntro")]
		public string AccommodationDialogIntro{
			get;
			set;
		}

		[JsonProperty("accommodationDialogConfirmLabel")]
		[XmlElement("AccommodationDialogConfirmLabel")]
		public string AccommodationDialogConfirmLabel{
			get;
			set;
		}

		[JsonProperty("preferredAccommodationLabel")]
		[XmlElement("PreferredAccommodationLabel")]
		public string PreferredAccommodationLabel{
			get;
			set;
		}

		[JsonProperty("preferredAccommodationError")]
		[XmlElement("PreferredAccommodationError")]
		public string PreferredAccommodationError{
			get;
			set;
		}

		[JsonProperty("roomTypeLabel")]
		[XmlElement("RoomTypeLabel")]
		public string RoomTypeLabel{
			get;
			set;
		}

		[JsonProperty("roomTypeError")]
		[XmlElement("RoomTypeError")]
		public string RoomTypeError{
			get;
			set;
		}

		[JsonProperty("transferAirportDetailsLabel")]
		[XmlElement("TransferAirportDetailsLabel")]
		public string TransferAirportDetailsLabel{
			get;
			set;
		}

		[JsonProperty("transferAirportDetailsError")]
		[XmlElement("TransferAirportDetailsError")]
		public string TransferAirportDetailsError{
			get;
			set;
		}

		[JsonProperty("privateBathroomLabel")]
		[XmlElement("PrivateBathroomLabel")]
		public string PrivateBathroomLabel{
			get;
			set;
		}

		[JsonProperty("privateBathroomError")]
		[XmlElement("PrivateBathroomError")]
		public string PrivateBathroomError{
			get;
			set;
		}

		[JsonProperty("cateringTypeLabel")]
		[XmlElement("CateringTypeLabel")]
		public string CateringTypeLabel{
			get;
			set;
		}

		[JsonProperty("cateringTypeError")]
		[XmlElement("CateringTypeError")]
		public string CateringTypeError{
			get;
			set;
		}

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

		[JsonProperty("requiresInsuranceNoNote")]
		[XmlElement("RequiresInsuranceNoNote")]
		public string RequiresInsuranceNoNote{
			get;
			set;
		}

		[JsonProperty("requiresAccomodationANZLabel")]
		[XmlElement("RequiresAccomodationANZLabel")]
		public string RequiresAccomodationANZLabel{
			get;
			set;
		}

		[JsonProperty("requiresInsuranceANZLabel")]
		[XmlElement("RequiresInsuranceANZLabel")]
		public string RequiresInsuranceANZLabel{
			get;
			set;
		}

		[JsonProperty("requiresInsuranceNoANZNote")]
		[XmlElement("RequiresInsuranceNoANZNote")]
		public string RequiresInsuranceNoANZNote{
			get;
			set;
		}

		[JsonProperty("insuranceCoverLevelLabel")]
		[XmlElement("InsuranceCoverLevelLabel")]
		public string InsuranceCoverLevelLabel{
			get;
			set;
		}

	}
}


using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class ContactDetailsObject
	{

		[JsonProperty("sectionLabel")]
		[XmlElement("SectionLabel")]
		public string SectionLabel{
			get;
			set;
		}

		[JsonProperty("studentEmailLabel")]
		[XmlElement("StudentEmailLabel")]
		public string StudentEmailLabel{
			get;
			set;
		}

		[JsonProperty("studentEmailPlaceholder")]
		[XmlElement("StudentEmailPlaceholder")]
		public string StudentEmailPlaceholder{
			get;
			set;
		}

		[JsonProperty("studentEmailError")]
		[XmlElement("StudentEmailError")]
		public string StudentEmailError{
			get;
			set;
		}

		[JsonProperty("studentConfirmEmailLabel")]
		[XmlElement("StudentConfirmEmailLabel")]
		public string StudentConfirmEmailLabel{
			get;
			set;
		}

		[JsonProperty("studentConfirmEmailPlaceholder")]
		[XmlElement("StudentConfirmEmailPlaceholder")]
		public string StudentConfirmEmailPlaceholder{
			get;
			set;
		}

		[JsonProperty("studentConfirmEmailError")]
		[XmlElement("StudentConfirmEmailError")]
		public string StudentConfirmEmailError{
			get;
			set;
		}

		[JsonProperty("primaryTelLabel")]
		[XmlElement("PrimaryTelLabel")]
		public string PrimaryTelLabel{
			get;
			set;
		}

		[JsonProperty("primaryTelPlaceholder")]
		[XmlElement("PrimaryTelPlaceholder")]
		public string PrimaryTelPlaceholder{
			get;
			set;
		}

		[JsonProperty("primaryTelError")]
		[XmlElement("PrimaryTelError")]
		public string PrimaryTelError{
			get;
			set;
		}

		[JsonProperty("secondaryTelLabel")]
		[XmlElement("SecondaryTelLabel")]
		public string SecondaryTelLabel{
			get;
			set;
		}

		[JsonProperty("secondaryTelPlaceholder")]
		[XmlElement("SecondaryTelPlaceholder")]
		public string SecondaryTelPlaceholder{
			get;
			set;
		}

		[JsonProperty("secondaryTelError")]
		[XmlElement("SecondaryTelError")]
		public string SecondaryTelError{
			get;
			set;
		}

		[JsonProperty("parentAltContactSectionLabel")]
		[XmlElement("ParentAltContactSectionLabel")]
		public string ParentAltContactSectionLabel{
			get;
			set;
		}

		[JsonProperty("parentFamilyNameLabel")]
		[XmlElement("ParentFamilyNameLabel")]
		public string ParentFamilyNameLabel{
			get;
			set;
		}

		[JsonProperty("parentFamilyNamePlaceholder")]
		[XmlElement("ParentFamilyNamePlaceholder")]
		public string ParentFamilyNamePlaceholder{
			get;
			set;
		}

		[JsonProperty("parentFamilyNameError")]
		[XmlElement("ParentFamilyNameError")]
		public string ParentFamilyNameError{
			get;
			set;
		}

		[JsonProperty("parentGivenNameLabel")]
		[XmlElement("ParentGivenNameLabel")]
		public string ParentGivenNameLabel{
			get;
			set;
		}

		[JsonProperty("parentGivenNamePlaceholder")]
		[XmlElement("ParentGivenNamePlaceholder")]
		public string ParentGivenNamePlaceholder{
			get;
			set;
		}

		[JsonProperty("parentGivenNameError")]
		[XmlElement("ParentGivenNameError")]
		public string ParentGivenNameError{
			get;
			set;
		}

		[JsonProperty("sameHomeAddressAsStudentLabel")]
		[XmlElement("SameHomeAddressAsStudentLabel")]
		public string SameHomeAddressAsStudentLabel{
			get;
			set;
		}

		[JsonProperty("addressLine1Label")]
		[XmlElement("AddressLine1Label")]
		public string AddressLine1Label{
			get;
			set;
		}

		[JsonProperty("addressLine1Placeholder")]
		[XmlElement("AddressLine1Placeholder")]
		public string AddressLine1Placeholder{
			get;
			set;
		}

		[JsonProperty("addressLine1Error")]
		[XmlElement("AddressLine1Error")]
		public string AddressLine1Error{
			get;
			set;
		}

		[JsonProperty("addressLine2Label")]
		[XmlElement("AddressLine2Label")]
		public string AddressLine2Label{
			get;
			set;
		}

		[JsonProperty("addressLine2Placeholder")]
		[XmlElement("AddressLine2Placeholder")]
		public string AddressLine2Placeholder{
			get;
			set;
		}

		[JsonProperty("cityLabel")]
		[XmlElement("CityLabel")]
		public string CityLabel{
			get;
			set;
		}

		[JsonProperty("cityPlaceholder")]
		[XmlElement("CityPlaceholder")]
		public string CityPlaceholder{
			get;
			set;
		}

		[JsonProperty("stateLabel")]
		[XmlElement("StateLabel")]
		public string StateLabel{
			get;
			set;
		}

		[JsonProperty("statePlaceholder")]
		[XmlElement("StatePlaceholder")]
		public string StatePlaceholder{
			get;
			set;
		}

		[JsonProperty("countryLabel")]
		[XmlElement("CountryLabel")]
		public string CountryLabel{
			get;
			set;
		}

		[JsonProperty("countryPlaceholder")]
		[XmlElement("CountryPlaceholder")]
		public string CountryPlaceholder{
			get;
			set;
		}

		[JsonProperty("countryError")]
		[XmlElement("CountryError")]
		public string CountryError{
			get;
			set;
		}

		[JsonProperty("postalLabel")]
		[XmlElement("PostalLabel")]
		public string PostalLabel{
			get;
			set;
		}

		[JsonProperty("postalPlaceholder")]
		[XmlElement("PostalPlaceholder")]
		public string PostalPlaceholder{
			get;
			set;
		}

		[JsonProperty("parentPrimaryTelLabel")]
		[XmlElement("ParentPrimaryTelLabel")]
		public string ParentPrimaryTelLabel{
			get;
			set;
		}

		[JsonProperty("parentPrimaryTelPlaceholder")]
		[XmlElement("ParentPrimaryTelPlaceholder")]
		public string ParentPrimaryTelPlaceholder{
			get;
			set;
		}

		[JsonProperty("parentPrimaryTelError")]
		[XmlElement("ParentPrimaryTelError")]
		public string ParentPrimaryTelError{
			get;
			set;
		}

		[JsonProperty("parentEmailLabel")]
		[XmlElement("ParentEmailLabel")]
		public string ParentEmailLabel{
			get;
			set;
		}

		[JsonProperty("parentEmailPlaceholder")]
		[XmlElement("ParentEmailPlaceholder")]
		public string ParentEmailPlaceholder{
			get;
			set;
		}

		[JsonProperty("parentEmailError")]
		[XmlElement("ParentEmailError")]
		public string ParentEmailError{
			get;
			set;
		}

		[JsonProperty("confirmParentEmailLabel")]
		[XmlElement("ConfirmParentEmailLabel")]
		public string ConfirmParentEmailLabel{
			get;
			set;
		}

		[JsonProperty("confirmParentEmailPlaceholder")]
		[XmlElement("ConfirmParentEmailPlaceholder")]
		public string ConfirmParentEmailPlaceholder{
			get;
			set;
		}

		[JsonProperty("confirmParentEmailError")]
		[XmlElement("ConfirmParentEmailError")]
		public string ConfirmParentEmailError{
			get;
			set;
		}

		[JsonProperty("relationshipLabel")]
		[XmlElement("RelationshipLabel")]
		public string RelationshipLabel{
			get;
			set;
		}

		[JsonProperty("relationshipPlaceholder")]
		[XmlElement("RelationshipPlaceholder")]
		public string RelationshipPlaceholder{
			get;
			set;
		}

		[JsonProperty("relationshipError")]
		[XmlElement("RelationshipError")]
		public string RelationshipError{
			get;
			set;
		}

		[JsonProperty("relationshipOtherLabel")]
		[XmlElement("RelationshipOtherLabel")]
		public string RelationshipOtherLabel{
			get;
			set;
		}

		[JsonProperty("relationshipOtherPlaceholder")]
		[XmlElement("RelationshipOtherPlaceholder")]
		public string RelationshipOtherPlaceholder{
			get;
			set;
		}

		[JsonProperty("relationshipOtherError")]
		[XmlElement("RelationshipOtherError")]
		public string RelationshipOtherError{
			get;
			set;
		}

		[JsonProperty("recommendCareGiver")]
		[XmlElement("RecommendCareGiver")]
		public string RecommendCareGiver{
			get;
			set;
		}

	}
}


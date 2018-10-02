using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class StudentDetailsObject
	{

		[JsonProperty("sectionLabel")]
		[XmlElement("SectionLabel")]
		public string SectionLabel{
			get;
			set;
		}

		[JsonProperty("titleLabel")]
		[XmlElement("TitleLabel")]
		public string TitleLabel{
			get;
			set;
		}

		[JsonProperty("familyNameLabel")]
		[XmlElement("FamilyNameLabel")]
		public string FamilyNameLabel{
			get;
			set;
		}

		[JsonProperty("familyNamePlaceholder")]
		[XmlElement("FamilyNamePlaceholder")]
		public string FamilyNamePlaceholder{
			get;
			set;
		}

		[JsonProperty("familyNameError")]
		[XmlElement("FamilyNameError")]
		public string FamilyNameError{
			get;
			set;
		}

		[JsonProperty("givenNameLabel")]
		[XmlElement("GivenNameLabel")]
		public string GivenNameLabel{
			get;
			set;
		}

		[JsonProperty("givenNamePlaceholder")]
		[XmlElement("GivenNamePlaceholder")]
		public string GivenNamePlaceholder{
			get;
			set;
		}

		[JsonProperty("givenNameError")]
		[XmlElement("GivenNameError")]
		public string GivenNameError{
			get;
			set;
		}

		[JsonProperty("genderLabel")]
		[XmlElement("GenderLabel")]
		public string GenderLabel{
			get;
			set;
		}

		[JsonProperty("genderError")]
		[XmlElement("GenderError")]
		public string GenderError{
			get;
			set;
		}

		[JsonProperty("dobLabel")]
		[XmlElement("DobLabel")]
		public string DobLabel{
			get;
			set;
		}

		[JsonProperty("dobError")]
		[XmlElement("DobError")]
		public string DobError{
			get;
			set;
		}

		[JsonProperty("dobDDPlaceholder")]
		[XmlElement("DobDDPlaceholder")]
		public string DobDDPlaceholder{
			get;
			set;
		}

		[JsonProperty("dobMMPlaceholder")]
		[XmlElement("DobMMPlaceholder")]
		public string DobMMPlaceholder{
			get;
			set;
		}

		[JsonProperty("dobYYYYPlaceholder")]
		[XmlElement("DobYYYYPlaceholder")]
		public string DobYYYYPlaceholder{
			get;
			set;
		}

		[JsonProperty("nationalityLabel")]
		[XmlElement("NationalityLabel")]
		public string NationalityLabel{
			get;
			set;
		}

		[JsonProperty("nationalityPlaceholder")]
		[XmlElement("NationalityPlaceholder")]
		public string NationalityPlaceholder{
			get;
			set;
		}

		[JsonProperty("nationalityError")]
		[XmlElement("NationalityError")]
		public string NationalityError{
			get;
			set;
		}

		[JsonProperty("dualCitizenshipLabel")]
		[XmlElement("DualCitizenshipLabel")]
		public string DualCitizenshipLabel{
			get;
			set;
		}

		[JsonProperty("dualCitizenshipError")]
		[XmlElement("DualCitizenshipError")]
		public string DualCitizenshipError{
			get;
			set;
		}

		[JsonProperty("dualCitizenshipCountryLabel")]
		[XmlElement("DualCitizenshipCountryLabel")]
		public string DualCitizenshipCountryLabel{
			get;
			set;
		}

		[JsonProperty("dualCitizenshipCountryPlaceholder")]
		[XmlElement("DualCitizenshipCountryPlaceholder")]
		public string DualCitizenshipCountryPlaceholder{
			get;
			set;
		}

		[JsonProperty("dualCitizenshipCountryError")]
		[XmlElement("DualCitizenshipCountryError")]
		public string DualCitizenshipCountryError{
			get;
			set;
		}

		[JsonProperty("countryOfBirthLabel")]
		[XmlElement("CountryOfBirthLabel")]
		public string CountryOfBirthLabel{
			get;
			set;
		}

		[JsonProperty("countryOfBirthPlaceholder")]
		[XmlElement("CountryOfBirthPlaceholder")]
		public string CountryOfBirthPlaceholder{
			get;
			set;
		}

		[JsonProperty("countryOfBirthError")]
		[XmlElement("CountryOfBirthError")]
		public string CountryOfBirthError{
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

		[JsonProperty("postalError")]
		[XmlElement("PostalError")]
		public string PostalError{
			get;
			set;
		}

		[JsonProperty("livesAtAddressLabel")]
		[XmlElement("LivesAtAddressLabel")]
		public string LivesAtAddressLabel{
			get;
			set;
		}

		[JsonProperty("livesAtAddressError")]
		[XmlElement("LivesAtAddressError")]
		public string LivesAtAddressError{
			get;
			set;
		}

		[JsonProperty("altAddressLine1Label")]
		[XmlElement("AltAddressLine1Label")]
		public string AltAddressLine1Label{
			get;
			set;
		}

		[JsonProperty("altAddressLine1Placeholder")]
		[XmlElement("AltAddressLine1Placeholder")]
		public string AltAddressLine1Placeholder{
			get;
			set;
		}

		[JsonProperty("altAddressLine1Error")]
		[XmlElement("AltAddressLine1Error")]
		public string AltAddressLine1Error{
			get;
			set;
		}

		[JsonProperty("altAddressLine2Label")]
		[XmlElement("AltAddressLine2Label")]
		public string AltAddressLine2Label{
			get;
			set;
		}

		[JsonProperty("altAddressLine2Placeholder")]
		[XmlElement("AltAddressLine2Placeholder")]
		public string AltAddressLine2Placeholder{
			get;
			set;
		}

		[JsonProperty("altCityLabel")]
		[XmlElement("AltCityLabel")]
		public string AltCityLabel{
			get;
			set;
		}

		[JsonProperty("altCityPlaceholder")]
		[XmlElement("AltCityPlaceholder")]
		public string AltCityPlaceholder{
			get;
			set;
		}

		[JsonProperty("altStateLabel")]
		[XmlElement("AltStateLabel")]
		public string AltStateLabel{
			get;
			set;
		}

		[JsonProperty("altStatePlaceholder")]
		[XmlElement("AltStatePlaceholder")]
		public string AltStatePlaceholder{
			get;
			set;
		}

		[JsonProperty("altCountryLabel")]
		[XmlElement("AltCountryLabel")]
		public string AltCountryLabel{
			get;
			set;
		}

		[JsonProperty("altCountryPlaceholder")]
		[XmlElement("AltCountryPlaceholder")]
		public string AltCountryPlaceholder{
			get;
			set;
		}

		[JsonProperty("altCountryError")]
		[XmlElement("AltCountryError")]
		public string AltCountryError{
			get;
			set;
		}

		[JsonProperty("altPostalLabel")]
		[XmlElement("AltPostalLabel")]
		public string AltPostalLabel{
			get;
			set;
		}

		[JsonProperty("altPostalPlaceholder")]
		[XmlElement("AltPostalPlaceholder")]
		public string AltPostalPlaceholder{
			get;
			set;
		}

		[JsonProperty("altPostalError")]
		[XmlElement("AltPostalError")]
		public string AltPostalError{
			get;
			set;
		}

		[JsonProperty("minimumAgeError")]
		[XmlElement("MinimumAgeError")]
		public string MinimumAgeError{
			get;
			set;
		}

		[JsonProperty("weChatIdLabel")]
		[XmlElement("WeChatIdLabel")]
		public string WeChatIdLabel{
			get;
			set;
		}

		[JsonProperty("weChatIdPlaceholder")]
		[XmlElement("WeChatIdPlaceholder")]
		public string WeChatIdPlaceholder{
			get;
			set;
		}

		[JsonProperty("weChatIdError")]
		[XmlElement("WeChatIdError")]
		public string WeChatIdError{
			get;
			set;
		}

		[JsonProperty("isStudentAustralianAboriginalOrTorresStraitIslander")]
		[XmlElement("IsStudentAustralianAboriginalOrTorresStraitIslander")]
		public string IsStudentAustralianAboriginalOrTorresStraitIslander{
			get;
			set;
		}

		[JsonProperty("doesStudentHaveRelativesLivingInAustralia")]
		[XmlElement("DoesStudentHaveRelativesLivingInAustralia")]
		public string DoesStudentHaveRelativesLivingInAustralia{
			get;
			set;
		}

		[JsonProperty("doesStudentHaveRelativesLivingInPerth")]
		[XmlElement("DoesStudentHaveRelativesLivingInPerth")]
		public string DoesStudentHaveRelativesLivingInPerth{
			get;
			set;
		}

		[JsonProperty("relativesCityLabel")]
		[XmlElement("RelativesCityLabel")]
		public string RelativesCityLabel{
			get;
			set;
		}

		[JsonProperty("relativesCityPlaceholder")]
		[XmlElement("RelativesCityPlaceholder")]
		public string RelativesCityPlaceholder{
			get;
			set;
		}

		[JsonProperty("relativesCityError")]
		[XmlElement("RelativesCityError")]
		public string RelativesCityError{
			get;
			set;
		}

	}
}


using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace StudyGroup.DataAPI.Models.AgentApplicationForm
{

	public class StudentDetailsObject
	{

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

	}
}


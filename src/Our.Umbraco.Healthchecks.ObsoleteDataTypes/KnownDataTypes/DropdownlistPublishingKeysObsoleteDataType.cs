using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.HealthChecks.ObsoleteDataTypes.KnownDataTypes
{
	public class DropdownlistPublishingKeysObsoleteDataType : IObsoleteDataType
	{
		public string Alias => "Umbraco.DropdownlistPublishingKeys";
		public bool CanConvert => false;
		public void Convert(string name) => throw new NotImplementedException();
	}
}

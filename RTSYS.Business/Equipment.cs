using System;
using System.Xml.Linq;

public class Equipment : Entity
{

	public string vendor { get; set; }
	public Equipment()
	{
        if (string.IsNullOrEmpty(vendor)) throw new ArgumentNullException("vendor name equipment");

    }


}

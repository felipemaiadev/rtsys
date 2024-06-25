using System;

public class Machine : Entity
{

	public string machineName { get; set; }

	public Machine(string machineName)
	{
		if (machineName == null) throw new ArgumentException("Machine name cannot be null");
	}

	

}



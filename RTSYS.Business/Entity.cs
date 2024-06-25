using System;

public abstract class Entity
{
	public Guid uid { get; set; }
	
	public Entity()
	{
			uid = Guid.NewGuid();
	}
}

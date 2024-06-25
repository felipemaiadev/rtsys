using System;

public class TagGroup : Entity
{


	public TagGroup(IEnumerable<Tag> TagList)
	{
		if (TagList == null) throw new ArgumentException("Parameter cannot be null", nameof(TagList));

		//if (TagList.Count == 0) throw new ArgumentException("TagList have at least one element", nameof(TagList));
    }
}

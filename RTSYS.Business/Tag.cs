using System;

public class Tag : Entity
{

    public string name { get; set; }
    public string description { get; set; }
    public int groupid { get; set; }

    public Tag()
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

        if (string.IsNullOrEmpty(description)) throw new ArgumentNullException("description");
    }

}

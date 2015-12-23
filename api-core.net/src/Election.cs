using System.Collections.Generic;

public class Election
{
	public string id { get; set; }
	public List<Vote> votes { get; set; }
	
	/*the constructed votes is a list of Vote, Vote represents a class*/ 
	public Election()
	{
		votes = new List<Vote>();
	}
}

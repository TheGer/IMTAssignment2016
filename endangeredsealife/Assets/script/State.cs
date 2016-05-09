using System.Collections;
using System.Collections.Generic;

public static class State {
	public static List<int> Scores = new List<int>();
	public static int CurrentLevel;

	public static bool IsLastLevel = false;

	public static int CurrentScore
	{
		get
		{
			if (Scores.Count > 0)
				return Scores [Scores.Count - 1];
			return 0;
		}
		set
		{
			Scores [Scores.Count - 1] = value;
		}
	}

	public static int TotalScore
	{
		get
		{
			int total = 0;
			foreach (int score in Scores)
				total += score;
			return total;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData {

	public int level;
	public int score;


	public playerInfo (Player p) {

		level = p.level;
		score = p.score;		
	}

	
}

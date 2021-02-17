using System.Collections;
using System.Collections.Generic;
using Unity Engine;

public class Player : MonoBehavior {

	public int level;
	public int score;

	public void SavePlayer() {
		SaveSystem.SavePlayer(this);
	}

	public void LoadPlayer() {
		PlayerData data = SaveSystem.LoadPlayer();

		level = data.level;
		score = data.score;	
	}
}

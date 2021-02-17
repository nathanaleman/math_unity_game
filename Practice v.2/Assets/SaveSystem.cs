using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity Engine;

public static class SaveSystem {
	
	public static void SavePlayer(Player p) {
		
		BinaryFormatter format = new BinaryFormatter();
		string path = Application.persistentDataPath + "/player.pdf";
		FileStream stream = new FileStream(path, FileMode.Create);
		
		PlayerData data = new PlayerData(p);

		format.Serialize(stream, data);
		stream.Close();
	}

	public static PlayerData LoadPlayer() {

		string path = Application.persistentDataPath + "/player.png";
		
		if(File.Exists(path)) {
			BinaryFormatter format = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);
			PlayerData data = formatter.Deserialize(stream) as PlayerData;
			stream.Close();
			return data;
		}
		else {
			Debug.LogError("Save file not found in " + path);
			return null;
		}
	}
}
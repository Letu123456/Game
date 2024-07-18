using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;



public static class SaveLoadManage
{

    public static string game_data_path = Application.persistentDataPath + "/gamedata.dev";
    public static void SaveGame(ShipMovement movement, ShootAbleDameRecei damage, ItemLooter looter, Shield shield)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(game_data_path, FileMode.Create);
        GameData data = new GameData(movement, damage, looter, shield);
        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Saved to "+game_data_path);

    }


    public static GameData LoadGame()
    {
        if (File.Exists(game_data_path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(game_data_path, FileMode.Open);
            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("Saved file not found");
            return null;
        }
    }
}

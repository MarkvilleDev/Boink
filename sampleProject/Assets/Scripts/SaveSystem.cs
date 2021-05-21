using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer (Player player)
    {
        for (int i = 0; i < player.man.Length; i++)
        {
            Debug.Log(player.man[i]);
        }

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.savedData";
        FileStream stream = new FileStream(path, FileMode.Create);

        playerData data = new playerData(player);

        formatter.Serialize(stream, data);

        Debug.Log("successfully saved");
        stream.Close();
    }

    public static playerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.savedData";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            playerData data = formatter.Deserialize(stream) as playerData;

            for (int i = 0; i < data.levels.Length; i++)
            {
                Debug.Log(data.levels[i]);
            }

            stream.Close();
            Debug.Log("successfully loaded");
            return data;
        }
        else
        {
            Debug.Log("no file :(");
            return null;
        }

    }

}

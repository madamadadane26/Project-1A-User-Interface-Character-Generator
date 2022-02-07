using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GenerateCharJSON : CS583.Player_Manager
{
    //load created character in JSON output
    public void generateJsonChar()
    {
        string json = File.ReadAllText(Application.dataPath + "/saveFile.json");
        PlayerInfo loadedPlayerdata = JsonUtility.FromJson<PlayerInfo>(json);
        Debug.Log(json);

    }

}

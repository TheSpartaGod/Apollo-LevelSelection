using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; 
using System.Runtime.Serialization.Formatters.Binary; 

public class SaveSystem : MonoBehaviour
{
    //CALL THIS FUNCTION UNTUK SAVE DATA LEVEL
    public static void SaveLevelData(LevelSelectionController controller) {
        //create binary formatter
        BinaryFormatter formatter = new BinaryFormatter();

        //determine path to save
        string path = Application.persistentDataPath + "/poloData.fun";

        //open new file stream
        FileStream stream = new FileStream(path, FileMode.Create);

        //create new player data from parameter
        PlayerData data = new PlayerData(controller);

        //serialize into binary using formatter
        formatter.Serialize(stream, data);

        //close da mf stream
        stream.Close(); 
    }
    
    //CALL THIS FUNCTION UNTUK LOAD LEVEL DATA
    public static PlayerData LoadLevelData()
    {
        //check filepath
        string path = Application.persistentDataPath + "/poloData.fun";

        //check if file is in filepath
        if (File.Exists(path))
        {
            //create binary formatter
            BinaryFormatter formatter = new BinaryFormatter();
            //open file from path using file stream
            FileStream stream = new FileStream(path, FileMode.Open);
            //set player data from stream
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            //close the motherfuckin stream
            stream.Close();
            //return the data
            return data;
        }
        else
        {
            Debug.Log($"Data not found");
            return null;




        }
    }
    // Start is called before the first frame update
   
}

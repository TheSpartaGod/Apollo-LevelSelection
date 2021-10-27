using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionController : MonoBehaviour
{
    //i would like a break
    // Start is called before the first frame update
    public GameObject[] levels;
   // public int[,] levelContainer;
    public List<LevelItem> items = new List<LevelItem>(); 

    void Awake()
    {
        for (int i = 0; i < levels.Length;  i++) {
            items.Add(levels[i].GetComponent<LevelItem>()); 
}
        Debug.Log("Loading..."); 

        loadLevels();
        
    }
    private void loadLevels()
    {
        // items[2].data.starCount = 2; 


        //TODO: Load data from binary here



        // int[] tempContainer = SaveSystem.LoadLevelData().levelFlatContainer;

        //reconstruct level data
        /*    levelContainer = new int[data.levelAmount, data.attributeCount];
            int write = 0;
            for (int i = 0; i < data.levelAmount; i++)
            {
                for (int j = 0; j < data.attributeCount; j++)
                {

                    levelContainer[i,j] = tempContainer[write++];
                }
            }
            debug2DArray(levelContainer); */
        //ConstructLevelData(data.levelAmount, data.attributeCount, tempContainer); 
        // 1st box = levels, 2nd box = attribute


        //    print(levelContainer); 
        //load the levels from dataPlayerData data = SaveSystem.LoadLevelData();
        
        PlayerData data = SaveSystem.LoadLevelData();
        GameObject lvl = new GameObject();
        for (int i = 0; i < levels.Length; i++) {
            lvl = levels[i];
            lvl.GetComponent<LevelItem>().data = generateDummy(i+1);
            //lvl.GetComponent<LevelItem>().data = data.levelData[i];
            // lvl.GetComponent<LevelItem>().data.starCount = items[i].data.starCount;
            /*  lvl.GetComponent<LevelItem>().levelCount = levelContainer[i,0];
              lvl.GetComponent<LevelItem>().starCount = levelContainer[i,2];*/

        }
        
    }
    private void debug2DArray(int[,] rawNodes)
    {
        int rowLength = rawNodes.GetLength(0);
        int colLength = rawNodes.GetLength(1);
        string arrayString = "";
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                arrayString += string.Format("{0} ", rawNodes[i, j]);
            }
            arrayString += System.Environment.NewLine + System.Environment.NewLine;
        }

        Debug.Log(arrayString);
    }
 
    private void saveLevels() {
        SaveSystem.SaveLevelData(this); 
    }

     LevelItemContainer generateDummy(int idCount) {
        //generate dummy
            LevelItemContainer data = new LevelItemContainer(idCount+1);

        return data; 
          
        
        
        
       /* levelContainer = new int[,]{ 
            { 1, 2000, 2 }, 
            { 2, 420, 3} , 
            { 3, 11900, 3 }, 
            { 4, 2400, 1 }, 
            { 5, 5700, 0 } };*/
         //initialize isi attribute, nanti kalo udah load dari binary aja
        
    }
    
  
   
}

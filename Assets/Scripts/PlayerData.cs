using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    //array 2d gabisa di serialize, jadi gw pisah
    public int[] levelFlatContainer;
   //saat ini baru level container aja, ntar bisa diadd2
    public int levelAmount; //buat kalo nambahin level pas development
    public int attributeCount;
    public List<LevelItemContainer> levelData = new List<LevelItemContainer>(); 
    public PlayerData(LevelSelectionController controller) {
        for (int i = 0; i < controller.items.Count; i++) {
            levelData.Add(controller.items[i].data); 
        } 
      //  int containerLength = controller.levelContainer.GetUpperBound(0); 
      //  int containerWidth = controller.levelContainer.GetUpperBound(1);
      /*  levelFlatContainer = new int[containerLength * containerWidth];

        //flatten arraynya biar bisa di serialize
        int write = 0;
        for (int i = 0; i < containerLength; i++) {
            for (int j = 0; j < containerWidth; j++) {
                levelFlatContainer[write++] = controller.levelContainer[i,j];
            }
        
        
        }
        levelAmount = controller.levels.Length;
        attributeCount = containerLength;*/
      
    }
    

    

}

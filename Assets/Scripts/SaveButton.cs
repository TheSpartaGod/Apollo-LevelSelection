using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    // Start is called before the first frame update
    public LevelSelectionController controller; 
    private void OnMouseDown()
    {
        Debug.Log("Saving Data...."); 
        SaveSystem.SaveLevelData(controller); 
    }

    // Update is called once per frame

}

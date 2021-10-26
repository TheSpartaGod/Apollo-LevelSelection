using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LevelItemContainer {
   

    public bool isUnlocked;
    public int levelCount; // actual level title
    public int levelScore;
    public int starCount;
    public int score;
    public int highScore;
    public int maxScore;

    public char song;
    public int bpm;
    public string[] songMelodies;
    public int[] segmentMelodies;
    public LevelItemContainer(int levelCount)
    {
        this.levelCount = levelCount; 
        isUnlocked = false;
        levelScore = 0;
        starCount = 0;
        score = 0;
        highScore = 0;
        maxScore = 0;
        song = 'b';
        bpm = 0;
        songMelodies = new string[14];
        segmentMelodies = new int[14];


    }
}
public class LevelItem : MonoBehaviour
{
    // Start is called before the first frame update
    public LevelItemContainer data;

    public Text levelText;
    public GameObject[] goldStars;


    void Start()
    {
        levelText.text = data.levelCount.ToString();
        //buat fill stars berdasarkan pencapaian
        for (int i = 3; i > data.starCount; i--) {
            goldStars[i-1].SetActive(false); 
        }
        
        
   
    }
    private void OnMouseDown()
    {
        //TODO: view level details
        Debug.Log($"Pressed level {data.levelCount}");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class askHighScore : MonoBehaviour{ //attached to requestScore 

    public Text narrative;
    public Text personalBest;
    public Text highScores;

    //put this elsewhere so it's after game ends  
    IEnumerator Start(){
        //leaderboard
        WWW allBest = new WWW("http://localhost/MD_Game/highscore.php");
        yield return allBest;
        string allBestString = allBest.text;
        highScores.text = "Highest Scores: \n" + allBestString;
   
    }

    //when view scores button pressed
    public void requestScore(){ 
        //story narrative disappears
        narrative.enabled = false;

        //scores appear
        personalBest.enabled = true; 
        highScores.enabled = true;

    }

}

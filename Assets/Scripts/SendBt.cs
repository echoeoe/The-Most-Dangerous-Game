using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendBt : MonoBehaviour{

public Text sendBtText; //button
public Text usernameField; //textfield
public Text messageToUser; //text
public Text narrative; //story narrative
public Text scorekeeper;
public GameObject backgroundPane; 
public GameObject sendbutton; 
public GameObject usernameFieldO;
public GameObject reqhighscore; 
public Text personalBest; 
public Text highScores;
public GameObject player;
public GameObject enemy;
public Text currentScore;
public Text invalid;

public int clickCount = 0; 
public string userinput; 

//for time control
public bool canGetPB;

//if button pressed and textfield contains something, save that something as a string, change button to "Begin" and change text "Who are you" to
//story narrative  
    void Awake() //
    {
    //display error username
    invalid.enabled = false;

    //bool false
    canGetPB = false;

     //make narrative invisible
     narrative.enabled = false;

     //make score invisible
     scorekeeper.enabled = false;
     currentScore.enabled = false; //

     //request high score button invisible
     reqhighscore.SetActive(false);

     //make personal best invisible
     personalBest.enabled = false;
     highScores.enabled = false;
    }

public void TextChange(){
    if(string.IsNullOrWhiteSpace(usernameField.text) == false && clickCount == 0){ //check contains not null / whitespace - if valid username 
        
        clickCount = 1; //been successfully clicked ONCE - to reuse button
        sendBtText.text = "Begin"; 
        
        // //save userinput as string
        userinput = usernameField.text; 

        //can get "personal best" boolean set to true
        canGetPB = true;

        //make original text disappear (who are you?) + input box
        messageToUser.enabled = false;
        usernameFieldO.SetActive(false); 

        //make narrative text visible
        narrative.enabled = true; 

        //make [request high score button] appear
        reqhighscore.SetActive(true);

        invalid.enabled = false;

    }
    else if (clickCount == 1){ //if pressed button = Begin (start game)
    //make invisible: black pane, text narrative (Message), sendButton, scoreRequestButton  
    narrative.enabled = false;
    backgroundPane.SetActive(false);
    sendbutton.SetActive(false);
    reqhighscore.SetActive(false);
    personalBest.enabled = false;
    highScores.enabled = false;
    invalid.enabled = false;

    currentScore.enabled = false;
    
    //make score visible
    scorekeeper.enabled = true;

    //move player and enemy to safe locations
    enemy.transform.position = new Vector3(0f, 1f, 0f);
    player.transform.position = new Vector3(-3f, 1f, 4f);

    //make player and enemy active again
    enemy.SetActive(true);
    player.SetActive(true);

    }
    else{
        invalid.enabled = true;
    }
    
}

}

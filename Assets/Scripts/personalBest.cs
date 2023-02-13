using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class personalBest : MonoBehaviour{ // attached to enemy
    //take username from other object, get personal high scores, display in Text, 
    public SendBt SB; //to reference SendBt script for canGetPB bool
    public Text scoreDisplay;
    public GameObject btnWithName;
    string queryResult; //to hold query result
    string username;
    int count = 0;
    
    //can make it trigger on collision or on hitting view scores button
    //trigger on collision - attach to enemy below

    // private void OnCollisionEnter(Collision collision){
    // if (collision.collider.CompareTag("Player")){
    //     Refresh(form);

    //     }
    // }

    // void Update(){
        
    // }


    IEnumerator Start(){

        while(SB.canGetPB is false){
            yield return new WaitForSeconds(2);
            
        }

        StartCoroutine(GetData());
        
        // //this retrieval needs to happen AFTER username is assigned - -- - 
        // username = btnWithName.GetComponent<SendBt>().userinput;
        // //username = "d";

        // //make the form
        // WWWForm form = new WWWForm();
        // form.AddField("usernamePost", username);

        // WWW myBest = new WWW("http://localhost/MD_Game/PersonalScore.php", form); //WWW myBest, use the form
        // yield return myBest; //wait for WWW to download
        // string queryResult = myBest.text; //query result in myBest.text, put in queryResult string
        // scoreDisplay.text = "Personal Best: \n" + queryResult; //put result string in display
        
    }

     IEnumerator GetData(){

             
        
        //this retrieval needs to happen AFTER username is assigned - -- - 
        username = btnWithName.GetComponent<SendBt>().userinput;
        //username = "d";

        //make the form
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);

        WWW myBest = new WWW("http://localhost/MD_Game/PersonalScore.php", form); //WWW myBest, use the form
        yield return myBest; //wait for WWW to download
        string queryResult = myBest.text; //query result in myBest.text, put in queryResult string
        scoreDisplay.text = "Personal Best: \n" + queryResult; //put result string in display

        // while(true == true){
        //     yield return myBest;
        //     queryResult = myBest.text; //query result in myBest.text, put in queryResult string
        //     scoreDisplay.text = "Personal Best: " + count + "\n" + queryResult; //put result string in display
        //     yield return new WaitForSeconds(5);
        //     count++;

        // }
        
         
        

     }


}

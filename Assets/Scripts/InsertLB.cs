using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertLB : MonoBehaviour  
{

//attach to enemy to trigger on collision with player, signal end game,
//add player's current score to leaderboard - add to database

//object for getting username
public GameObject sendbtn_lb;

//get username
string username_lb;

//get score
int score_lb;

private void OnCollisionEnter(Collision collision){
if (collision.collider.CompareTag("Player")){ 
        
        score_lb = GameObject.Find("Enemy").GetComponent<Enemy>().scoreValue;
        username_lb = sendbtn_lb.GetComponent<SendBt>().userinput;

        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username_lb);
        form.AddField("scorePost", score_lb);
        WWW www = new WWW("http://localhost/MD_Game/InsertLB.php", form);


    }
}

void Start()
{
        
}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertPB : MonoBehaviour  
{

//attach to enemy to trigger on collision with player, signal end game,
//add player's current score to leaderboard - add to database

//object for getting username
public GameObject sendbtn_pb;

//get username
string username_pb;

//get score
int score_pb;

private void OnCollisionEnter(Collision collision){
if (collision.collider.CompareTag("Player")){ 
        
        score_pb = GameObject.Find("Enemy").GetComponent<Enemy>().scoreValue;
        username_pb = sendbtn_pb.GetComponent<SendBt>().userinput;

        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username_pb);
        form.AddField("scorePost", score_pb);
        WWW www = new WWW("http://localhost/MD_Game/InsertPB.php", form);


    }
}

void Start()
{
        
}


}

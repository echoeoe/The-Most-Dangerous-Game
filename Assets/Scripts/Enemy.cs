using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour{
    public Transform player;
    public GameObject Player;
    public Text scorekeeper;
    public int scoreValue = 0; 
    public GameObject enemy;
    public GameObject background; 
    public Text personalBest; 
    public Text highScore; 
    float speed = 1f;
    public GameObject playButton; //aka SendButton
    int xval;
    int yval;
    int zval;
    public Text gameScore; 
    int spawnCount;

void Start(){

}

void Update(){
    if (Player != null && Player.activeSelf && background.activeSelf == false){
    transform.LookAt(player.transform);
    transform.position += transform.forward * speed * Time.deltaTime;
    }
}

private void OnCollisionEnter(Collision collision){ // enemy hits player - RESET
        if (collision.collider.CompareTag("Player")){

            //reset speed
            speed = 1f; 

            //display current score in larger text, assign value 
            gameScore.text = "Game Over. \nCurrent Score: " + scoreValue;
            gameScore.enabled = true; //current score

            //score disappear and reset
            scorekeeper.enabled = false; 
            scoreValue = 0;
            scorekeeper.text = "Score: " + scoreValue;

            //Destroy(Player.gameObject);
            Player.SetActive(false);

            //GAME OVER - show current score, personal best, all-time bests 
            //black background reappears
            background.SetActive(true); 
            
            //bests reappear
            personalBest.enabled = true;
            highScore.enabled = true;

            //play button reappears
            playButton.SetActive(true);
            
        }

        if (collision.collider.CompareTag("leafTrap")){ // enemy hits trap
            Destroy(collision.gameObject); //destroy leaf trap
            enemy.SetActive(false);
            scoreValue += 50;

            //increase speed
            if (scoreValue < 650){
                speed += (float)0.50;
            }
            scorekeeper.text = "Score: " + scoreValue;
            
            //enemy reappears elsewhere - choose 3 set locations to spawn b/c random can lead to spawning on player unless distance, etc
            //spawn counts 0, 1, and 2

            if(spawnCount == 0){
                transform.position = new Vector3(-10f, 1f, 0f); //enemy when 0
                spawnCount += 1;
            }
            else if (spawnCount == 1){
                transform.position = new Vector3(7f, 1f, 0f); //enemy when 1
                spawnCount += 1;
            }
            else{
                transform.position = new Vector3(-2f, 1f, 0f); //enemy when 2
                spawnCount = 0;
            }

            
            enemy.SetActive(true);

            //remove high score counter, replace b/c Unity doesn't allow editor to change font size 
            highScore.enabled = false; //score tracker
            

        }

    }

}

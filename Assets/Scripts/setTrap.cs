using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setTrap : MonoBehaviour{

public GameObject leafTrap;
public Transform player;
public GameObject playerObj;
public GameObject background;
//bool trapCrafted;

    void Start(){ 
        //StartCoroutine(makeTrap());
    }

    /*IEnumerator makeTrap(){
        while(player == true){
            yield return new WaitForSeconds(2);
            trapCrafted = true;
            
        }
    }*/

    void Update(){

            if (Input.GetButtonDown("spacebar") && (background.activeSelf == false)){ //&& trapCrafted == true
                GameObject clone = Instantiate(leafTrap, player.position + new Vector3(0f, 0.5f, 0f), player.rotation);
                Destroy(clone, 3);

                //used up a trap
                //trapCrafted = false;
                }

            }
            
    }

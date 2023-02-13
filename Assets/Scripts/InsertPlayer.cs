using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsertPlayer : MonoBehaviour
//attach to sendbutton
// add the username from the field to the database by calling insert when send button pressed
{
    //variables needed:___
    public Text buttonText; //of send button
    public Text tfInput; //what's in textfield


    void Start()
    {

    }

    //connect to send button pressed -- if text of the button after clicking says "Begin" so it's currently "Send"
    public void CreatePlayer(){ //insert after inputting username
        if (buttonText.text == "Begin"){
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", tfInput.text);
        WWW www = new WWW("http://localhost/MD_Game/InsertUser.php", form);
        }    
    }

}

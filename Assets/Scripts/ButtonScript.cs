using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // This script help to access the buttons of Social Media

    public void button_click_LinkedIn()
    {
        Application.OpenURL("#");  //Replace # with the URL of your LinkedIn Profile
    }
    public void button_click_Snap()
    {
        Application.OpenURL("#");  //Replace # with the URL of your Snapchat Profile
    }
    public void button_click_Youtube()
    {
        Application.OpenURL("#");  //Replace # with the URL of your Youtube Profile
    }
    public void button_click_Instagram()
    {
        Application.OpenURL("#");  //Replace # with the URL of your Instagram Profile
    }

    // Now attach this file to Social Media (Parent) Object. 
    // Further add them to the respective OnClick().
    
}

using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    GUISkin guiSkin;
    bool isPaused = false;
    public string Level;

    public void OnGUI()
    {
        // Set up gui skin
        GUI.skin = guiSkin;

        if (isPaused)
        {
            // To Continue the game
            if (GUI.Button(new Rect((Screen.width) / 2.5f, 150, 150, 70), "Continue"))
            {
                print("Continue");
                Time.timeScale = 1.0f;
                isPaused = false;
            }

            // To restart the game
            if (GUI.Button(new Rect((Screen.width) / 2.5f, 250, 150, 70), "Restart"))
            {
                print("Restart");
                Application.LoadLevel(Level);
                Time.timeScale = 1.0f;
                isPaused = false;
            }

            // Go back to Map
            if (GUI.Button(new Rect((Screen.width) / 2.5f, 350, 150, 70), "Back to Map"))
            {
                print("Back to Map");
                Application.LoadLevel("map_layout");
            }

            //Quit the entire game 
            if (GUI.Button(new Rect((Screen.width) / 2.5f, 450, 150, 70), "Quit"))
            {
                print("Quit!");
                Application.Quit();
            }
        }
    }

    void Start()
    {

    }

    void Update()
    {
        //If 'p' key is down, and NOT paused, pause the game
        if (Input.GetKeyDown("p") && !isPaused)
        {
            print("Paused"); Time.timeScale = 0.0f; isPaused = true;
        }
        //Else if 'p' key is down and IS paused, unpause the game
        else if (Input.GetKeyDown("p") && isPaused)
        {
            print("Unpaused"); Time.timeScale = 1.0f; isPaused = false;
        }
    }

}

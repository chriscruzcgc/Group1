using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!levelLoaded)
            {
                levelLoaded = true;
                Application.LoadLevel(levelToLoad);
            }
        }

    }

    public bool levelLoaded = false;
    public string levelToLoad;
}

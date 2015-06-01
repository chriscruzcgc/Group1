using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour 
{
    /// <summary>
    /// helper function that will be attached to a go in the scene
    /// reference the public function in the OnClick eventlist
    /// </summary>
    /// <param name="lvl">
    /// the lvl to be loaded
    /// </param>
    public void LoadLevel(string lvl)
    {
        try
        {
            Application.LoadLevel(lvl);
        }
        catch
        {
            print("could not load lvl.. is it in build settings?");
        }
    }
<<<<<<< HEAD

    public void QuitGame()
    {
        Application.Quit();
        print("Quit");
    }

    public void MapScene()
    {
        Application.LoadLevel("map_layout");
    }

	public void Level1()
	{
		Application.LoadLevel ("FallingOpening");
	}

	public void StartLevel1()
	{
		Application.LoadLevel("Falling");
        ScoreManager.instance.Score = 0;

	}

    public void DarknessGame()
    {
        Application.LoadLevel("DarknessScene");
    }
=======
>>>>>>> chuwilliamson/master
}

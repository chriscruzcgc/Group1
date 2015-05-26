using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour 
{
    public void MainMenu()
    {
        Application.LoadLevel("Menu");
    }

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
}

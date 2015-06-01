using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour 
{
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
}

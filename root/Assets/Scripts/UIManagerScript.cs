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
}

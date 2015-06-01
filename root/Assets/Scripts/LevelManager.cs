using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LevelManager : MonoBehaviour {
    private Stack<string> _levelStack = new Stack<string>();
    private string _currentLevel;
    
    
	// Use this for initialization
	void Start () {
	
	}
	void OnLevelWasLoaded(int index)
    {
        _currentLevel = Application.loadedLevelName;
        print("current level is " + _currentLevel);
        _levelStack.Push(_currentLevel);
        Debug.Log("load scene data");
        //Application.Getlevel
        //_levels.Push(index);//"Darknessscene"
    }

    void Transition()
    {
        _currentLevel = _levelStack.Pop();
        string _previousLevel = _levelStack.Peek();
        Application.LoadLevel(_previousLevel);
    }
    void RestartGame()
    {
        _levelStack.Clear();
        Application.LoadLevel(0);
    }

    
	// Update is called once per frame
	void Update () {
	  
	}


}

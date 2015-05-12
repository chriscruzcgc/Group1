using UnityEngine;
using System.Collections;

public class ScoreManager : Singleton<ScoreManager> 
{ 
    //private score.
    //this is the score that is local to the scoremanager
    private float _score;

    //this is the score that we expose to everyone.
    public float Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
        }
    }
}

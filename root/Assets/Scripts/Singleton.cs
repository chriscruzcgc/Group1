using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<T>();
                DontDestroyOnLoad(_instance.gameObject);

            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this.gameObject.GetComponent<T>();
            DontDestroyOnLoad(_instance);
        }
        else
        {
            if (this != _instance)
                Destroy(this.gameObject);
        }
    }
}

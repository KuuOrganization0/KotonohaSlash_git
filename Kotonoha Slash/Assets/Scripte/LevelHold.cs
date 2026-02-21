using UnityEngine;

public class LevelHold : MonoBehaviour
{
  
    static public float levelspeed;
    private void Awake()
    {
       
        DontDestroyOnLoad(gameObject);
    }


}

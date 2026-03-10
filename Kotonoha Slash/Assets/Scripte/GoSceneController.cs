using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoSceneController : MonoBehaviour
{
      
    public void GoGame()
    {
        SceneManager.LoadScene(1);

    }

    public void SetSyoku()
    {
        LevelHold.levelspeed = 0.4f;
    }
    public void SetTyuku()
    {
        LevelHold.levelspeed = 0.7f;
    }
    public void SetJoku()
    {
        LevelHold.levelspeed = 1f;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GoMeny()
    {
        SceneManager.LoadScene(0);
    }
    public void GoScore()
    {
        SceneManager.LoadScene(2);
    }


    public void GoLevelSet() 
    {
        SceneManager.LoadScene(3);
    }
}

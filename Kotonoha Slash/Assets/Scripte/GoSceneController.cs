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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GoMeny()
    {
        SceneManager.LoadScene(0);
    }
    public void GoScore()
    {
        SceneManager.LoadScene(2);
    }

    public void GoSetumei()
    {
        SceneManager.LoadScene(3);
    }
}

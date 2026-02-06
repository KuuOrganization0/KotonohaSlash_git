using UnityEngine;

public class SEController : MonoBehaviour
{
    public AudioClip[] audioclip;
    AudioSource audiosource;
    static public SEController seController;  //シングルトン用
                                     
    private void Awake()
    {

        audiosource = GetComponent<AudioSource>();
        if (seController != null) //重複しないようにする
        {
            Destroy(gameObject);
            return;   //このreturnが重要。これがないと破壊するオブジェクトのBGMControllerを代入してしまう
        }
        seController = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CallSE(int SEnumber)
    {
        audiosource.clip = audioclip[SEnumber];
        audiosource.Play();
    }
}

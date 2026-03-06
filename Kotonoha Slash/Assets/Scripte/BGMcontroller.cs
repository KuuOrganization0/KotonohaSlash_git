using UnityEngine;

public class BGMcontroller : MonoBehaviour
{
    public AudioClip[] audioclip;
    public AudioSource audiosource;
    static public BGMcontroller BGMController;  //シングルトン用
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    private void Awake()
    {
      
        audiosource = GetComponent<AudioSource>();
        if (BGMController != null) //重複しないようにする
        {
            Destroy(gameObject);
            return;   //このreturnが重要。これがないと破壊するオブジェクトのBGMControllerを代入してしまう
        }
        BGMController = this;  
        DontDestroyOnLoad(gameObject);
    }
 
  

    public void ChangeBGM(int BGMnumber)
    {
        audiosource.clip = audioclip[BGMnumber];
        audiosource.Play();
    }
    // Update is called once per frame

}

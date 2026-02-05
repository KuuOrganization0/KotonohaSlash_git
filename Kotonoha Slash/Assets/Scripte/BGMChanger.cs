using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMChanger : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.sceneLoaded += ChageBGM; //シーンが変わったときに起動するロールバック関数に登録
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= ChageBGM; //このオブジェクトが破壊されたときにロールバック関数から削除
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void ChageBGM(Scene scene,LoadSceneMode loadSceneMode)
    {
        
        switch (scene.name)
        {
            case "MenyScene":
                BGMcontroller.BGMController.ChangeBGM(0); break;
            case "GameScene":
                BGMcontroller.BGMController.ChangeBGM(1); break;
            case "ScoreScene":
                BGMcontroller.BGMController.ChangeBGM(2); break;
        }

    }


    // Update is called once per frame
   
}

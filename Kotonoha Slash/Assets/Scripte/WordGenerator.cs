using UnityEngine;
using UnityEngine.UIElements;

public class WordGenerator : MonoBehaviour
{
    public Object[] Plas;
    public Object[] Minas;
    float temp = 0;
    float span = 0.3f;
    Quaternion rotate = Quaternion.identity;　//回転なし
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    
    void Generate()
    {
        int rp = Random.Range(0, Plas.Length ); //どのプラスワードを生むか
        int rm = Random.Range(0, Minas.Length ); //どのマイナスワードを生むか
        int probability = Random.Range(1, 10); //プラスとマイナスを生む確率
        int x = Random.Range(-4,5);  // ランダムに生み出す場所を決める
         Vector3 spon = new Vector3(x, 6, 0);  //生み出す場所


        if (probability <= 3)
        {
            Instantiate(Plas[rp], spon,rotate);//プラスを生む
        }
        else { 
            Instantiate(Minas[rm],spon,rotate);//マイナスを生む
        }
    }

    // Update is called once per frame
    void Update()
    {
        
       
        temp += Time.deltaTime;

        if(temp > span)
        {
            temp = 0;
            Generate();
        }

    }
}

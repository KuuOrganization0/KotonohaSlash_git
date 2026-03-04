using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class RankingController : MonoBehaviour
{
    TMP_Text TextMeshPro; //TextMeshProはTMP_Textを継承している派生先なので、TMP_Textを使う
    PlayerController PlayerController;
    public static int[,] LevelRanking = new int[3,3]; //0行目は初級、1行目は中級、2行目は上級のランキングを保存する
    public static int Rank1;
    public static int Rank2;
    public static int Rank3;
    public int Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (LevelHold.levelspeed == 0.4f)
        {
            Rank1 = LevelRanking[0,0];
            Rank2 = LevelRanking[0,1];
            Rank3 = LevelRanking[0,2];
        }
        else if (LevelHold.levelspeed == 0.7f)
        {
            Rank1 = LevelRanking[1, 0];
            Rank2 = LevelRanking[1, 1];
            Rank3 = LevelRanking[1, 2];
        }
        else if (LevelHold.levelspeed == 1f)
        {
            Rank1 = LevelRanking[2, 0];
            Rank2 = LevelRanking[2, 1];
            Rank3 = LevelRanking[2, 2];
        }

        TextMeshPro = GetComponent<TMP_Text>();
        PlayerController = GetComponent<PlayerController>();

        Score = PlayerController.MinasCount * 1000 + PlayerController.PlasCount * -500;

        if (Rank1 <= Score)
        {
            Rank3 = Rank2;
            Rank2 = Rank1;

            Rank1 = Score;

        }
        else if (Rank2 <= Score && Rank1 > Score)
        {
            Rank3 = Rank2;
            Rank2 = Score;
        }
        else if (Rank3 <= Score && Rank2 > Score)
        {
            Rank3 = Score;
        }


        if (LevelHold.levelspeed == 0.4f)
        {
            LevelRanking[0, 0] = Rank1;
            LevelRanking[0, 1] = Rank2;
            LevelRanking[0, 2] = Rank3;
        }
        else if (LevelHold.levelspeed == 0.7f)
        {
            LevelRanking[1, 0] = Rank1;
            LevelRanking[1, 1] = Rank2;
            LevelRanking[1, 2] = Rank3;
        }
        else if (LevelHold.levelspeed == 1f)
        { 
            LevelRanking[2, 0] = Rank1;
            LevelRanking[2, 1] = Rank2;
            LevelRanking[2, 2] = Rank3;
        }
    }

    // Update is called once per frame
   

  public int GiveRank1()
    {
        if( LevelHold.levelspeed == 0.4f)
        {
            return LevelRanking[0, 0];
        }
        else if (LevelHold.levelspeed == 0.7f)
        {
            return LevelRanking[1, 0];
        }
        else if (LevelHold.levelspeed == 1f)
        {
            return LevelRanking[2, 0];
        }
        else
        {
            return 0;
        }
        
       
    }

    public int GiveRank2()
    {
        if (LevelHold.levelspeed == 0.4f)
        {
            return LevelRanking[0, 1];
        }
        else if (LevelHold.levelspeed == 0.7f)
        {
            return LevelRanking[1, 1];
        }
        else if (LevelHold.levelspeed == 1f)
        {
            return LevelRanking[2, 1];
        }
        else
        {
            return 0;
        }
    }

    public int GiveRank3()
    {
        if (LevelHold.levelspeed == 0.4f)
        {
            return LevelRanking[0, 2];
        }
        else if (LevelHold.levelspeed == 0.7f)
        {
            return LevelRanking[1, 2];
        }
        else if (LevelHold.levelspeed == 1f)
        {
            return LevelRanking[2, 2];
        }
        else
        {
            return 0;
        }
    }
}

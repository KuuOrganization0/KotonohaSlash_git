using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class RankingController : MonoBehaviour
{
    TMP_Text TextMeshPro; //TextMeshPro‚ÍTMP_Text‚ğŒp³‚µ‚Ä‚¢‚é”h¶æ‚È‚Ì‚ÅATMP_Text‚ğg‚¤
    PlayerController PlayerController;
    public static int Rank1;
    public static int Rank2;
    public static int Rank3;
    public int Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
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

    }

    // Update is called once per frame
   

  public int GiveRank1()
    {
        return Rank1;
    }

    public int GiveRank2()
    {
        return Rank2;
    }

    public int GiveRank3()
    {
        return Rank3;
    }
}

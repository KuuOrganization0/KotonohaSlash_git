using TMPro;
using UnityEngine;

public class Rank1Controller : MonoBehaviour
{
    TMP_Text TextMeshPro; //TextMeshPro‚ÍTMP_Text‚ğŒp³‚µ‚Ä‚¢‚é”h¶æ‚È‚Ì‚ÅATMP_Text‚ğg‚¤
    RankingController controller;
    int Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextMeshPro = GetComponent<TMP_Text>();
        controller = GetComponent<RankingController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = controller.Score;
        TextMeshPro.text = Score.ToString() + "“_";
    }
}

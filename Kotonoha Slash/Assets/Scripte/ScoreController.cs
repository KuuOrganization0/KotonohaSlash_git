using TMPro;
using UnityEngine;



public class ScoreController : MonoBehaviour
{
    TMP_Text TextMeshPro; //TextMeshPro‚ÍTMP_Text‚ğŒp³‚µ‚Ä‚¢‚é”h¶æ‚È‚Ì‚ÅATMP_Text‚ğg‚¤

    PlayerController PlayerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextMeshPro = GetComponent<TMP_Text>();
        PlayerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        int PlasCount = PlayerController.PlasCount * -500;
        int MinasCount = PlayerController.MinasCount * 1000;

        int TextScore = PlasCount + MinasCount;
        TextMeshPro.text = TextScore.ToString() + "“_";

    }
}

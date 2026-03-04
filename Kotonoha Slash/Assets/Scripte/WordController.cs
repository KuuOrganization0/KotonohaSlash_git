using UnityEngine;

public class WordController : MonoBehaviour
{
    static public WordController wordController;
    BoxCollider2D box;
    public GameObject Changed;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
       Rigidbody2D ri =  GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        float speed = Random.Range(1.0f, 2.0f);
        ri.gravityScale = LevelHold.levelspeed / speed;
        box.isTrigger = true;

    }

   public void Change()
    {
        Instantiate(Changed,this.transform.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

 
    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }

    }
}

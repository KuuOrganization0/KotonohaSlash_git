using UnityEngine;

public class ChangedWordController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }
    }
}

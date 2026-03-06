using UnityEngine;
using UnityEngine.UI;

public class BGMVolumeController : MonoBehaviour
{
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
   

    public void ChangeVolume()
    {
        BGMcontroller.BGMController.audiosource.volume = slider.value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMaster : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Slider _sensitivitySlider;
    [SerializeField] public AudioListener _listener;

    public float userMouseSpeed = 0.1f;




    // Start is called before the first frame update
    void Start()
    {
        _sensitivitySlider.onValueChanged.AddListener((v) =>
        {
            _textSlider.text = v.ToString("0.00");
            userMouseSpeed = v;
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

}

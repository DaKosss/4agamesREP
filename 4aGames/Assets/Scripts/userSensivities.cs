using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Vector2 sensitivityUser = new Vector2(0.5f, 0.5f);
//Vector2 mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X") * sensitivityUser.x,
//                                        Input.GetAxisRaw("Mouse Y") * sensitivityUser.y);



public class userSensivities : MonoBehaviour
{

    [SerializeField] private Slider _sensitivitySlider;
    [SerializeField] private Text _textSlider;

    public float userMouseSpeed = 2.5f;
    private int _sensitivity = 1;



    // Start is called before the first frame update
    void Start()
    {
        _sensitivitySlider.value = SystemCursor.GetCurrentSensitivity();
        _textSlider.text = SystemCursor.GetCurrentSensitivity().ToString("0.0");
        _sensitivitySlider.onValueChanged.AddListener((v) =>
        {
            _textSlider.text = v.ToString("0.0");
            userMouseSpeed = v;
            _sensitivity = (int)v;
            SystemCursor.SetSensitivity(_sensitivity);
        });

    }

    public void resetSens()
    {
        SystemCursor.ResetSensitivity(10);
        _sensitivitySlider.value = SystemCursor.GetGlobalSensitivity();
        _textSlider.text = SystemCursor.GetCurrentSensitivity().ToString("0.0");
    }

}

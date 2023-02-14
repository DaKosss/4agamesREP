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

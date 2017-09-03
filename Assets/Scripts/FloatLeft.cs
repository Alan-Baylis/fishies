using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatLeft : MonoBehaviour {

    public Image One;
    public Image Two;

    public float Speed;

    void Start()
    {
        One.rectTransform.localPosition = new Vector3(0, 0, 0);
        Two.rectTransform.localPosition = new Vector3(2048, 0, 0);
    }

	void Update () {
        One.rectTransform.localPosition += Vector3.left * Speed * Time.deltaTime;
        if (One.rectTransform.localPosition.x <= -2048)
        {
            One.rectTransform.localPosition = new Vector3(2048, One.rectTransform.localPosition.y, One.rectTransform.localPosition.z);
        }
        Two.rectTransform.localPosition += Vector3.left * Speed * Time.deltaTime;
        if (Two.rectTransform.localPosition.x <= -2048)
        {
            Two.rectTransform.localPosition = new Vector3(2048, Two.rectTransform.localPosition.y, Two.rectTransform.localPosition.z);
        }
	}
}

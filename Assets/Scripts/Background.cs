using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform[] layerBackground;
    public Rect[] _rect;

    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            layerBackground[i] = gameObject.transform.GetChild(i);
            _rect[i] = layerBackground[i].GetComponent<SpriteRenderer>().sprite.rect;
            float scale = Mathf.Max(Screen.width / _rect[i].width, Screen.height / _rect[i].height);
            layerBackground[i].transform.localScale = new Vector3(scale, scale, 1.0f);
        }

    }
}

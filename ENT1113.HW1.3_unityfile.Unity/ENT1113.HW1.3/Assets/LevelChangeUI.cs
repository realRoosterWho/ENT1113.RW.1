using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;

public class LevelChangeUI : MonoBehaviour
{

    public Transform PlayerTransform;
    public Transform CameraTransform;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshPro>().text = "Level " + GameManager.Instance.LevelChange.ToString();
        this.transform.position = PlayerTransform.position + offset;
        this.transform.rotation = CameraTransform.rotation;
    }
}

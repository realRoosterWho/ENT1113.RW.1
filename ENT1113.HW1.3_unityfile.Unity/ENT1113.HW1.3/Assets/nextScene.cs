using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    
    public string scenename;
    // Start is called before the first frame update
    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scenename);
        }
    }
}

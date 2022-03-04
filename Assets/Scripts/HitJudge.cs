using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitJudge : MonoBehaviour
{
    GameObject menuManagerGameObject;
    // Start is called before the first frame update
    void Start()
    {
        menuManagerGameObject = GameObject.Find("MenuManagerCanvas(Clone)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("SceneFinish");
            menuManagerGameObject.transform.Find("UI/FinishMenu").gameObject.SetActive(true);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletTemplate;
    GameObject bulletCopy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shot(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Shot(int num)
    {for (int i = 0; i < num; i++) {
            yield return new WaitForSeconds (1f);
            bulletCopy = Instantiate(bulletTemplate, transform.position, transform.rotation);
            bulletCopy.GetComponent<Element>().direction = Vector3.back;
            if (i == 4) i = 0;
        }
    }
}

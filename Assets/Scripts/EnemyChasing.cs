using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasing : MonoBehaviour
{
    public Transform PlayerPoint;
    public Transform Goal;
    float moveSpeed = 1f;
    Vector3 direction;
    
    public void Update()
    {
        if (PlayerPoint != null)
        {
            direction = (PlayerPoint.position - this.transform.position).normalized;
            if (PlayerPoint.position != Goal.position)
            {
                this.transform.Translate(direction * moveSpeed * Time.deltaTime);
                if (Vector3.Distance(this.transform.position, PlayerPoint.position)<0.01f)
                {
                    this.transform.position = PlayerPoint.position;
                }
            }
        }
        
    }
}

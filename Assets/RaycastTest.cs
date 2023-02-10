using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] LayerMask mask;

    private void Start()
    {
        //We don't want the raycast to collide with the object collider that it starts from
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, 100, mask );

        if(hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * 100, Color.green);
        }
    }
}

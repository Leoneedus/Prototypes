using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject hitedTarget = null;
    public GameObject hammer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            CheckTouch(Input.mousePosition);
        }
        if(hitedTarget != null)
        {
            if(hitedTarget.tag == "Enemy")
            {
                Instantiate(hammer, hitedTarget.transform.position, Quaternion.identity);
                hitedTarget = null;
            }
        }
        
    }

    private void CheckTouch(Vector3 pos)
    {
        Ray ray = Camera.main.ScreenPointToRay(pos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            hitedTarget = hit.collider.gameObject;
        }
    }
}

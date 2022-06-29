using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauEnemic : MonoBehaviour
{
    [SerializeField] private float _velEnemic = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posEnemic = transform.position;
        posEnemic = new Vector2(posEnemic.x, posEnemic.y - _velEnemic * Time.deltaTime);
        transform.position = posEnemic;

        Vector2 minPos = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        if (transform.position.y < minPos.y)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilJugador : MonoBehaviour
{
    [SerializeField] float _velProjectil = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posProjectil = transform.position;

        posProjectil = new Vector2(posProjectil.x, posProjectil.y + _velProjectil * Time.deltaTime);
        transform.position = posProjectil;

        Vector2 maxPosProjectil = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        if (transform.position.y > maxPosProjectil.y) {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    [SerializeField] private float _velNau = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector2 movimentInput = new Vector2(inputX, inputY).normalized;

        MoureNau(movimentInput);
    }

    private void MoureNau(Vector2 movimentInput)
    {
        Vector2 novaPos = transform.position;
        novaPos += movimentInput * _velNau * Time.deltaTime;

        transform.position = novaPos;
    }
}

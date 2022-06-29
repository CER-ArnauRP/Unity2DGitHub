using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    [SerializeField] private float _velNau = 8f;

    [SerializeField] GameObject _cano1;
    [SerializeField] GameObject _cano2;
    [SerializeField] GameObject ProjectilPrefab;

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

        DispararProjectils();
    }

    private void DispararProjectils()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject projectil1 = Instantiate(ProjectilPrefab);
            projectil1.transform.position = _cano1.transform.position;

            GameObject projectil2 = Instantiate(ProjectilPrefab);
            projectil2.transform.position = _cano2.transform.position;
        }
    }

    private void MoureNau(Vector2 movimentInput)
    {
        // Comprovacions límits pantalla:
        // ==============================
        Vector2 minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        minPantalla.x += 0.65f;
        maxPantalla.x -= 0.65f;
        minPantalla.y += 0.65f;
        maxPantalla.y -= 0.65f;

        Vector2 novaPos = transform.position;
        novaPos += movimentInput * _velNau * Time.deltaTime;

        novaPos.x = Mathf.Clamp(novaPos.x, minPantalla.x, maxPantalla.x);
        novaPos.y = Mathf.Clamp(novaPos.y, minPantalla.y, maxPantalla.y);

        transform.position = novaPos;
    }
}

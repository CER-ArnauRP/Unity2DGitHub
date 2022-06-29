using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemics : MonoBehaviour
{
    [SerializeField] private GameObject EnemicPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarEnemic", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerarEnemic()
    {
        Vector2 cantonadaInfEsq = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 cantonadaSupDre = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject enemic = Instantiate(EnemicPrefab);
        enemic.transform.position = new Vector2(
            Random.Range(cantonadaInfEsq.x, cantonadaSupDre.x), 
            cantonadaSupDre.y
        );
    }
}

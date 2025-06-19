using UnityEngine;

public class Porta : MonoBehaviour
{
    [SerializeField] public Vector3 portaAberta;
    [SerializeField] public Vector3 portaFechada;

    [SerializeField] public float velocidadePorta;

    public bool estaAberta;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = portaAberta;
        estaAberta = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (estaAberta)
        {
            if (transform.position != portaAberta)
            {
                if (Vector3.Distance(transform.position, portaAberta) <= 0.5f)
                {
                    transform.position = portaAberta;
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, portaAberta, velocidadePorta * Time.deltaTime);
                }
            }
        }
        else
        {
            if (transform.position != portaFechada)
            {
                if (Vector3.Distance(transform.position, portaFechada) <= 0.5f)
                {
                    transform.position = portaFechada;
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, portaFechada, velocidadePorta * Time.deltaTime);
                }
            }
        }
    }
}

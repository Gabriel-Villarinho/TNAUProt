using UnityEngine;
using UnityEngine.AI;

public class SistemaAlien : MonoBehaviour
{
    [SerializeField] public NavMeshAgent NMA;
    [SerializeField] public GameObject[] Alvos;
    public float temporizadorJS = 20f;
    public float tempoJS = 25f;
    [SerializeField] public GameObject telaGO;

    Alien aliens;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aliens = new Alien(0, 4, 4, 3, 4, 20, 6, 7, telaGO);
        NMA = GetComponent<NavMeshAgent>();
        aliens.telaGamerOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


        if (aliens.temporizador <= 0)
        {
            aliens.randomizado = Random.Range(1, 22);
            if(aliens.randomizado <= aliens.dificuldade)
            {
                if (Vector3.Distance(transform.position, Alvos[aliens.local].transform.position) <= 0.5f)
                {

                    if (Alvos[aliens.local].GetComponent<MovimentacaoAlien>().estaPorta)
                    {
                        if (Alvos[aliens.local].GetComponent<MovimentacaoAlien>().porta.estaAberta == true)
                        {
                            if(temporizadorJS <= 0)
                            {
                                aliens.Atacar();
                                Debug.Log("Perdeu");
                            }
                            temporizadorJS -= Time.deltaTime;
                            aliens.local = Alvos.Length - 1;
                        }
                        else
                        {
                            temporizadorJS = tempoJS;
                            aliens.local = 1;
                        }
                    }
                    else
                    {
                        aliens.local++;
                        if (aliens.local >= Alvos.Length)
                        {
                            aliens.local = 0;
                        }
                    }
                }
            }

            //Debug.Log(aliens.randomizado);
            aliens.temporizador = aliens.tempo;
        }
        else
        {
            aliens.temporizador -= Time.deltaTime;
        }
            NMA.destination = Alvos[aliens.local].transform.position;

    }
}

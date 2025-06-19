using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMngr : MonoBehaviour
{
    public float timer;
    public int fimNoite = 6;
    public string relogio;
    public float multiplicaTempo = 1f;
    public bool venceu;

    public GameObject telaVitoria;

    public TextMeshProUGUI textoRelogio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        telaVitoria.SetActive(false);
        relogio = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (!venceu)
        {
            timer += Time.deltaTime * multiplicaTempo;

            var horas = Mathf.FloorToInt(timer / 60);
            var minutos = Mathf.FloorToInt(timer - horas * 60);

            if (horas >= 6)
            {
                Time.timeScale = 0;
                telaVitoria.SetActive(true);
                venceu = true;
            }

            if (horas == 0)
            {
                horas = 12;
            }

            relogio = string.Format("{0:00}:{1:00}", horas, minutos);


            textoRelogio.text = relogio;
            //Debug.Log(relogio);
        }



    }

    public void JogarDNV()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaCam : MonoBehaviour
{
    public GameObject[] Cameras1;
    public GameObject cameraPrincipal;
    public GameObject uiCam;
    public float coolDown;
    public float tempoCoolDown = 0.5f;

    CameraJogo cameraJogo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraJogo = new CameraJogo(true, false, false, 1, Cameras1, cameraPrincipal, uiCam, coolDown, tempoCoolDown);
        Time.timeScale = 1;
        for (int i = 0; i < Cameras1.Length; i++)
        {
            Cameras1[i].SetActive(false);
        }
        cameraPrincipal.SetActive(true);
        uiCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cameraJogo.statusCam = !cameraJogo.statusCam;
            cameraJogo.AtivaCam();
        }

        cameraJogo.Intervalo();

    }

    public void VaParaCamBotao(int progressao)
    {
        Cameras1[cameraJogo.camAtual].SetActive(false);
        cameraJogo.camAtual = progressao;
        cameraJogo.AtivaCam();

    }


    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

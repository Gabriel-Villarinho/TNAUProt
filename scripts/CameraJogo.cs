using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class CameraJogo
{
    public bool statusCam;
    public bool audio;
    public bool flash;
    public int camAtual;
    public float coolDown;
    public float tempoCD;
    public GameObject[] Cameras;
    public GameObject cameraPrincipal;
    public GameObject uiCam;

    public CameraJogo( bool statusCam, bool audio, bool flash, int camAtual, GameObject[] Cameras, GameObject cameraPrincipal, GameObject uiCam, float coolDown, float tempoCD)
    {
        this.statusCam = statusCam;
        this.audio = audio;
        this.flash = flash;
        this.camAtual = camAtual;
        this.Cameras = Cameras;
        this.cameraPrincipal = cameraPrincipal; 
        this.uiCam = uiCam;
        this.coolDown = coolDown;
        this.tempoCD = tempoCD;
    }

    public void AtivaCam()
    {
        if (this.statusCam)
        {
            Cameras[this.camAtual].SetActive(true);
            uiCam.SetActive(true);
            cameraPrincipal.SetActive(false);
        }
        else
        {
            Cameras[this.camAtual].SetActive(false);
            uiCam.SetActive(false);
            cameraPrincipal.SetActive(true);
        }
    }

    public void VaParaCam(int progressao)
    {
        Cameras[this.camAtual].SetActive(false);
        this.camAtual = progressao;
        this.AtivaCam();

    }

    public void Intervalo()
    {
        if (coolDown <= 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                Cameras[this.camAtual].SetActive(false);
                this.camAtual++;
                if (this.camAtual >= Cameras.Length)
                {
                    this.camAtual = 0;
                }
                VaParaCam(this.camAtual);
                coolDown = tempoCD;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                Cameras[this.camAtual].SetActive(false);
                this.camAtual--;
                if (this.camAtual < 0)
                {
                    this.camAtual = Cameras.Length - 1;
                }
                VaParaCam(this.camAtual);
                coolDown = tempoCD;
            }
        }
        else
        {
            coolDown -= Time.deltaTime;
        }
    }

    public void AtivaAudio(bool audio)
    {
        if (audio == false)
        {
            audio = true;
        }
        else
        {
            audio = false;
        }
    }

    public void AtivaFlash(bool flash)
    {
        if (flash == false)
        {
            flash = true;
        }
        else
        {
            flash = false;
        }
    }


}
using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class Alien
{
    public int local;
    public float temporizador;
    public float tempo;
    public int identificador;
    public int habilidade;
    public int dificuldade;
    public int som;
    public float randomizado;
    public GameObject telaGamerOver;

    public Alien(int local, float temporizador,float tempo, int identificador, int habilidade, int dificuldade, int som, float randomizado, GameObject telaGamerOver)
    {
        this.local = local;
        this.temporizador = temporizador;
        this.tempo = tempo;
        this.identificador = identificador;
        this.habilidade = habilidade;
        this.dificuldade = dificuldade;
        this.som = som;
        this.randomizado = randomizado;
        this.telaGamerOver = telaGamerOver;
    }

    public void SelecionaAlien(int identificador)
    {
        ;
    }

    /*public void Movimentacao()
    {




        while (temporizador == true) 
        {
            randomizado = Mathf.FloorToInt(Random.Range(1, 22));
            Debug.Log(randomizado);
            if (randomizado <= dificuldade)
            {
                local++;
            }
            yield return new WaitForSeconds(10);
        }

    } */ 

    public void ExeHab(Vector3 localizacao, int habilidade)
    {
        
    }

    public void Atacar()
    {
        Time.timeScale = 0;
        telaGamerOver.SetActive(true);
    }
}

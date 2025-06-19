using UnityEditor.Rendering;
using UnityEngine;

public class Personagem
{
    public int vida;
    public bool lanterna;
    public int pilha;

    public Personagem(int vida, bool lanterna, int pilha)
    {
        this.vida = vida;
        this.lanterna = lanterna;
        this.pilha = pilha;
    }


    public void AcionaPainel(bool statusPainel)
    {
        if (statusPainel == false)
        {
            statusPainel = true;
        }
        else
        {
            statusPainel = false;
        }
    }

    public void LigaLanterna(int pilha, bool lanterna)
    {
        if ((pilha > 0) & (lanterna == false))
        {
            lanterna = true;
            
        }
    }

    public void TrocarPilha(int pilha)
    {
        if (pilha == 0)
        {
            pilha = 5;
        }
    }

    public void PerderVida(int vida)
    {
        vida = 0;
    }
}

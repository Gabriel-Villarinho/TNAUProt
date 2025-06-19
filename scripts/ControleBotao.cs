using UnityEngine;

public class ControleBotao : MonoBehaviour
{
    [SerializeField] public Porta porta;


    public void OnMouseDown()
    {
        porta.estaAberta = !porta.estaAberta;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

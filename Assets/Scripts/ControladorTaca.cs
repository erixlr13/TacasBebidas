using UnityEngine;

public class ControladorTaca : MonoBehaviour
{
    public string tipo;
    public ControladorFase geral;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            geral.PegarTaca(gameObject);

            Debug.Log(tipo);
        }
      
    }

}

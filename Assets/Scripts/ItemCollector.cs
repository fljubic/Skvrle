using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int pineapples = 0;
    [SerializeField] private AudioSource sakupljanje;
    [SerializeField] private Text pineappleText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ananas"))
        {
            sakupljanje.Play();
            Destroy(collision.gameObject);
            pineapples++;
            pineappleText.text = "Pineapples: " + pineapples;
        }
    }
}

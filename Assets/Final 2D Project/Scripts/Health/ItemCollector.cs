using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Banana = 0;

    [SerializeField] private Text BananaText;

    //[SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Banana"))
        {
            //collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            Banana++;
            BananaText.text = "Banana: " + Banana;
        }
    }
}

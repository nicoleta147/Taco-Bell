using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int tacos = 0;
    [SerializeField] private Text tacosText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Taco"))
        {
            collectionSoundEffect.Play();
            collectionSoundEffect.time = 0.1f;
            Destroy(collision.gameObject);
            tacos++;
            tacosText.text = "Score: " + tacos;
            Debug.Log("Taco:" + tacos);
        }
    }
}

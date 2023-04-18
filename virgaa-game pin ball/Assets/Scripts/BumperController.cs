using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier = 2f; // deklarasi variabel multiplier dan menginisialisasi nilainya
    public Color color;

    public AudioManager1 audioManager;
    public VfxManager vfxManager;

    private Renderer renderer;
    private Animator animator;

    private void Start(){
        renderer = GetComponent<Renderer>();
        animator= GetComponent<Animator>();

        renderer.material.color=color;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier; // menggunakan variabel multiplier yang sudah dideklarasikan dan diinisialisasi

            animator.SetTrigger("hit");

            audioManager.PlaySFX(collision.transform.position);

            vfxManager.PlayVFX(collision.transform.position);

        }
    }
}

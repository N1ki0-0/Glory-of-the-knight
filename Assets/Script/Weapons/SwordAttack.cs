using UnityEngine;
using System.Collections;

public class SwordAttack : BaseWeaponAttack
{
    public Animation atkAnimation;
    public bool attacking = false;

    public AudioClip attackSound; 
    private AudioSource audioSource;

    // Use this for initialization
    new void Start()
    {
        base.Start();
        attacking = false;
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    protected override void StartAttack()
    {
        base.StartAttack();
        if (attacking) return;

        this.attacking = true;
        atkAnimation.Play();

        if (attackSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(attackSound); 
        }
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
        if (this.attacking)
        {
            this.attacking = atkAnimation.isPlaying;
        }
        else
        {
            atkAnimation.Stop();
        }
    }
}

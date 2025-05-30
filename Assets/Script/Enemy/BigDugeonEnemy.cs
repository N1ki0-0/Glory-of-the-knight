using UnityEngine;
using System.Collections;

public class BigDugeonEnemy : BaseEnemy
{


    // Use this for initialization
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    protected override void OnDie()
    {
        // Появление огня
        if (fireEffectPrefab != null)
        {
            GameObject fire = Instantiate(fireEffectPrefab, transform.position, Quaternion.identity);
            Destroy(fire, fireEffectDuration);
        }

        base.OnDie(); // вызывает стандартное поведение (score + Destroy)
    }
}

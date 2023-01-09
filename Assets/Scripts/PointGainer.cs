using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGainer : MonoBehaviour
{
    public int gain = 1;
    int getting;
    public ParticleSystem particles;


    public void Gainer()
    {
        // particles.transform.position
        getting = int.Parse(MoneyBehaviour.Cash);
        getting = getting + gain;
        MoneyBehaviour.Cash = getting.ToString();
        this.transform.position = new Vector2(this.transform.position.x + 2000, this.transform.position.y);
        particles.transform.position = new Vector2(particles.transform.position.x - 2000, particles.transform.position.y);
        particles.Play();
        StartCoroutine(ActivingCircle.deactiveAfter(gameObject, 10, false));
        // ActivingCircle.deactiveAfter(particles, 1, false);

        // Destroy(gameObject);
    }
}

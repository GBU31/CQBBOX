using UnityEngine;

public class Bullet_Logic : MonoBehaviour
{
    // public string animationStateName; // Assign the name of the animation state in the inspector

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Bullet hit an enemy!");

            Animator enemyAnimator = collision.gameObject.GetComponent<Animator>();
            enemyAnimator.enabled = false;
        }
        else
        {
           // Debug.Log("Bullet hit something other than an enemy!");
        }
    }
}

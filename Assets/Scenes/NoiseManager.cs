using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NoiseManager : MonoBehaviour
{
    public Slider noiseSlider;
    public Transform monster;
    public Animator monsterAnimator;
    public float currentNoise = 0f;
    public AudioSource monsterAudio;
    public AudioClip screamClip;

    private bool isChasing = false;
    private bool isAttacking = false;
    
    void Update()
    {
        if (isAttacking) return;

        if (isChasing)
        {
            if (monster != null)
            {
                
                monster.LookAt(new Vector3(transform.position.x, monster.position.y, transform.position.z));

                float distance = Vector3.Distance(transform.position, monster.position);

                if (distance > 1.2f)
                {
                    monster.position = Vector3.MoveTowards(monster.position, transform.position, 15f * Time.deltaTime);
                }
                else
                {

                isChasing = false;
                isAttacking = true;
                GetComponent<PlayerMovement>().enabled = false;
                GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
                
                monster.LookAt(new Vector3(transform.position.x, monster.position.y, transform.position.z));
                

                if (monsterAnimator != null)
                {
                    monsterAnimator.Play("attack1");
                }

                Invoke("RestartGame", 1.5f);
            }
        }
        return;
        }

        currentNoise -= 5f * Time.deltaTime;

        bool isMoving = Input.GetAxisRaw("Horizontal") !=0 || Input.GetAxisRaw("Vertical") != 0;
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        if (isMoving)
        {
            if (isRunning)
            currentNoise += 55f * Time.deltaTime;
            else
            currentNoise += 25f * Time.deltaTime;
        }

        if  (Input.GetKeyDown(KeyCode.Space))
        {
            currentNoise += 10f;
        }

        if (monster != null)
        {
            float dist = Vector3.Distance(transform.position, monster.position);
            if (dist < 6f && isMoving)
            {
                currentNoise += 40f * Time.deltaTime;
            }
        }

        currentNoise = Mathf.Clamp(currentNoise, 0f, 100f);

        if (noiseSlider != null)
        noiseSlider.value = currentNoise;

        if (currentNoise >= 100f && !isChasing)
        {
            if (monsterAudio != null)
            {
                monsterAudio.Stop();
                if (screamClip != null)
                {
                    monsterAudio.PlayOneShot(screamClip);
                }
            }
            
            isChasing = true;
            monster.position = transform.position + transform.forward * 1.5f;
            monster.LookAt(transform);
            
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    }
        

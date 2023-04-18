using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyReferrence;

    private GameObject spawnedEnemy;

    [SerializeField] private Transform leftSide, rightSide;

    private int randomIndex;

    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnMonster()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, enemyReferrence.Length);
            randomSide = Random.Range(0, 2);
            spawnedEnemy = Instantiate(enemyReferrence[randomIndex]);
            //left side
            if (randomSide == 0)
            {
                spawnedEnemy.transform.position = leftSide.position;
                spawnedEnemy.GetComponent<Enemy>().moveSpeed = Random.Range(4, 10);
            }
            else
            {
                //right side;
                spawnedEnemy.transform.position = rightSide.position;
                spawnedEnemy.GetComponent<Enemy>().moveSpeed = -Random.Range(4, 10);
                spawnedEnemy.transform.localScale = new Vector3(-1f, 1f, 1f);
                
            }
        }
    }
}

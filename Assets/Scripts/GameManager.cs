/*
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject blockPrefab;
    public GameObject player;
    public float moveSpeed;
    public Transform spawnPoint;
    public float spawnRate;
    public float maxX;

    bool gameStarted = false;
    bool alternate = false;
    public GameObject tapText;
    public TextMeshProUGUI scoreText;

    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartGame();
        }

        if (gameStarted)
        {
            // Move the player upwards
            MovePlayer();

            // Move the camera (representing the screen) upwards
            MoveCamera();

            // Spawn new blocks
            //SpawnBlock();
        }
    }

    private void StartGame()
    {
        tapText.SetActive(false);
        gameStarted = true;
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }

    private void SpawnBlock()
    {
        float adjustedSpawnY = CalculateAdjustedSpawnY();
        float spawnX = Random.Range(-maxX, maxX);
        Vector3 spawnPos = new Vector3(spawnX, adjustedSpawnY, 0f);

        Instantiate(blockPrefab, spawnPos, Quaternion.identity);

        score++;
        scoreText.text = score.ToString();
    }

    private float CalculateAdjustedSpawnY()
    {
        // Calculate the Y position for spawning based on the screen movement
        float screenHeight = Camera.main.orthographicSize * 2;
        float adjustedSpawnY = Camera.main.transform.position.y + screenHeight / 2;

        return adjustedSpawnY;
    }

    private void MovePlayer()
    {
        // Move the player upwards
        if(alternate)
            player.transform.position += Vector3.up * moveSpeed * Time.deltaTime*0.5f;
        else
            player.transform.position += Vector3.up * moveSpeed * Time.deltaTime*1.5f;
        alternate = !alternate;
    }

    private void MoveCamera()
    {   
        // Move the camera (representing the screen) upwards
        Camera.main.transform.position += Vector3.up * moveSpeed * Time.deltaTime; 
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject blockPrefab;
    public GameObject blockPrefab2;
    public GameObject player;
    public float moveSpeed;
    public Transform spawnPoint;
    public float spawnRate;
    public float spawnRat2;
    public float maxX;

    bool gameStarted = false;
    bool alternate = false;
    public GameObject tapText;
    public TextMeshProUGUI scoreText;

    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartGame();
        }

        if (gameStarted)
        {
            // Move the player upwards
            MovePlayer();

            // Move the camera (representing the screen) upwards
            MoveCamera();

            // Spawn new blocks
            //SpawnBlock();
        }
    }

    private void StartGame()
    {
        tapText.SetActive(false);
        gameStarted = true;
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
        InvokeRepeating("NewSpawn", 1.0f, spawnRat2);
    }

    private void SpawnBlock()
    {
        float adjustedSpawnY = CalculateAdjustedSpawnY();
        float spawnX = Random.Range(-maxX, maxX);
        Vector3 spawnPos = new Vector3(spawnX, adjustedSpawnY, 0f);

        Instantiate(blockPrefab, spawnPos, Quaternion.identity);

        score++;
        scoreText.text = score.ToString();
    }

    private void NewSpawn()
    {
        float adjustedSpawnY = CalculateAdjustedSpawnY();
        float spawnX = Random.Range(-maxX, maxX);
        Vector3 spawnPos = new Vector3(spawnX, adjustedSpawnY, 0f);

        Instantiate(blockPrefab2, spawnPos, Quaternion.identity);

        score++;
        scoreText.text = score.ToString();
    }

    private float CalculateAdjustedSpawnY()
    {
        // Calculate the Y position for spawning based on the screen movement
        float screenHeight = Camera.main.orthographicSize * 2;
        float adjustedSpawnY = Camera.main.transform.position.y + screenHeight / 2;

        return adjustedSpawnY;
    }

    private void MovePlayer()
    {
        // Move the player upwards
        //if (alternate)
        //  player.transform.position += Vector3.up * moveSpeed * Time.deltaTime * 0.5f;
        //else
        //   player.transform.position += Vector3.up * moveSpeed * Time.deltaTime * 1.5f;
        //alternate = !alternate;
        player.transform.position += Vector3.up * moveSpeed * Time.deltaTime;

    }

    private void MoveCamera()
    {
        // Move the camera (representing the screen) upwards
        Camera.main.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }
}
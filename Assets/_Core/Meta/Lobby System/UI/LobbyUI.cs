using UnityEngine;

public class LobbyUI : MonoBehaviour
{
    public GameObject MenuCanvas;
    public GameObject CampaignCanvas;
    public GameObject LocalGameCanvas;
    public GameObject MultiplayerCanvas;

    public bool isFirstTime = true; // Если true, то это первый запуск игры

    public static LobbyUI Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        CampaignCanvas.SetActive(false);
        LocalGameCanvas.SetActive(false);
        MultiplayerCanvas.SetActive(false);
        MenuCanvas.SetActive(true);
    }

    void Start()
    {
        if (isFirstTime)
        {
            // Здесь можно добавить код, который будет выполняться только при первом запуске игры
            Debug.Log("Первый запуск игры!");
            isFirstTime = false; // Устанавливаем false, чтобы не выполнять этот код снова
        }
    }
}

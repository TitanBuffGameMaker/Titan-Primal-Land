using UnityEngine;

public static class GameConstants
{
    // Network
    public const string NETWORK_SCENE = "NetworkScene";
    
    // Player
    public const string PLAYER_PREFAB = "DurangoPlayer";
    public const string PLAYER_SPAWN_POINT = "PlayerSpawnPoint";
    
    // Authentication
    public const string PLAYFAB_TITLE_ID = "YOUR_PLAYFAB_TITLE_ID";
    public const string PLAYFAB_DEV_SECRET = "YOUR_PLAYFAB_DEV_SECRET";
    
    // Game Settings
    public const float BASE_MOVE_SPEED = 5f;
    public const float BASE_JUMP_FORCE = 10f;
    public const float GROUND_CHECK_DISTANCE = 0.1f;
    
    // Tags & Layers
    public const string GROUND_TAG = "Ground";
    public const string PLAYER_TAG = "Player";
}
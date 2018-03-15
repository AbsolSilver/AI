﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {
        // Switches to next level when called
        public void NextLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        // Restarts elements in the level (without destroying)
        public void RestartLevel()
        {
            // Grab all FollowEnemy game objects from scene\
            FollowEnemy[] followEnemies = FindObjectsOfType<FollowEnemy>();
            // For each enemy in 'followEnemies' array
            foreach (var enemy in followEnemies)
            {
                // Reset each enemy
                enemy.Reset();
            }

            // Grab all PatrolEnemy game objects from scene
            PatrolEnemy[] patrolEnemies = FindObjectsOfType<PatrolEnemy>();
            // For each enemy in 'followEnemies' array
            foreach (var enemy in patrolEnemies)
            {
                // Reset each enemy
                enemy.Reset();
            }

            // Get the player form the scene
            Player player = FindObjectOfType<Player>();
            // Reset the player
            player.Reset();
        }
    }
}



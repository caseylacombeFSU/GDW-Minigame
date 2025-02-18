# GDW-Minigame


Title: Against the Flow

In this game you avoid the red barrier objects and shoot the blue ball objects.  If you get hit by a barrier or a ball makes it past you, you lose.

Controls: WASD movement
          Space to shoot

Use WASD or the arrow keys to avoid the red barrier objects and those same movement keys in conjunction with the space bar to shoot the blue ball objects.


Dev Log:
  Created a road object
  Added player object
  Added enemy objects
  Created enemy prefabs
  Attached camera to player
  Created projectile object
  Created projectile prefab
  Wrote script for player movement
  Wrote script for enemy and projectile movement
  Wrote script for enemy spawner
  Created an empty object for the enemy spawner
  Wrote collision scripts for each enemy
    Used tags to determine which collisions can trigger each enemy
  Wrote an object destruction script for if an object goes out of bounds
  Added to the object destuction script that if a ball object makes it past the player the player is destroyed
  Created materials for each of the primative objects
  Created stripe objects to make the road more fleshed out
  Added a Scoreboard UI and wrote script to update it

All assets used were created by me.  All of them are unity primatives with matte color material applied

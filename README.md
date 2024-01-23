Doofus Adventure Game

Backstory:
Meet our character Doofus, a cube that loves exploring green platforms called Pulpits. The catch? Pulpits don't last long and disappear within seconds. Doofus has set a challenge to walk on at least 50 Pulpits. 

Characters/Props:
Doofus: The main character (a simple cube will work too).
Pulpit: A green metallic 9x9 platform where Doofus walks.

<h1>A. Prefabs</h1>
<h2>1. Pulpit</h2>
<p>This the platform prefab which stores the general size of the floor. As we need to spawn several floors, we would need this prefab to spwan platforms of exact size</p>

<h2>2. Score</h2>
<p>Score is an empty object which is used for tiggering an event. Here this Score object surrounds the floor like a wall and when doofus collides with it, the score increases.</p>

<h1>B. Scripts Used</h1>
<h2>1. Movement.cs</h2>
<p>The code gives movement to the Game object to which it attaches. It takes input as keyboard press(up,down,left right,w,d,a,s) to shift the position of a charater a particular position</p>

<h2>2. Spawning.cs</h2>
<p>The code takes a platfrom prefab, stores its postion in a vector, generates a vector based on the 4-direction(any of the 4 side is selected as the next position for the spawned platform) and instantiates a platform at the position calculated using sum of random vector and the previous vector position. This script also destroys an already existing platform after a desired time.</p>

<h2>3. Destroying.cs</h2>
<p>To handle an edge case, I have used this script.</p>

<h2>4. GameOver.cs</h2>
<p>After adding an empty object in the form of huge cube below the platform, we can use OnCollision function to trigger a certain event like 'Game Over'. Hence this script helps in identifying those collisions and if found, redirecting to another scene.</p>

<h1>C. Scenes</h1>
<h2>1. Game scene</h2>
<p>This scene is the first scene which loads up whenever the game starts. Here we have added all our working code to generate platforms and move the cube. This scence contains an object which triggers GameOver Scene</p>
<h2>1. GameOver scene</h2>
<p>The game over scene loads when doofus falls. This scene generates a canvas, shwoing the game over text and restart button. Once clicked, the game restarts from the start. This is done with the help of the script GameOver.cs</p>

<h1>D. Edge Case</h1>
<p>The Spawning.cs shifts the current position of a prefab Pulpit thus leading to the Doofus falling instantly as the first platform gets destroys before the new one emerges. This can be solved by using another Pulpit and timing it in such a way that it only disappears after the next one emerges.This is achieved using Destroying.cs</p>

<h1>Links</h1>
Here's the link to the video, where doofus has to move onto platfrom which appears randomly around any of the 4 directions, which dofus was originally-
https://drive.google.com/file/d/1ojZysWXCZaMUAXjejlbInt1djUjHWNTw/view?usp=sharing

Here's the video where I have added the restart button - 
https://drive.google.com/file/d/1Hki4S49wX7jqJZDOaqP_hc_7smo84Fo0/view?usp=sharing

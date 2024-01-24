<h1>Doofus Adventure Game</h1>

Backstory:
Meet our character Doofus, a cube that loves exploring green platforms called Pulpits. The catch? Pulpits don't last long and disappear within seconds. Doofus has set a challenge to walk on at least 50 Pulpits. 

<h1>Links</h1>
<h3>1. The first video which shows movement of doofus and random generation(any 4 direction) of Pulpit(max 2 floors stay at a time)</h3>
https://drive.google.com/file/d/1ojZysWXCZaMUAXjejlbInt1djUjHWNTw/view?usp=sharing

<h3>2. Second part where I have added the GameOver Scene with Restart button</h3>
https://drive.google.com/file/d/1Hki4S49wX7jqJZDOaqP_hc_7smo84Fo0/view?usp=sharing

<h3>3. In this video, I have added scores. The value increases when Doofus moves onto it and resets when the game is over.</h3>
https://drive.google.com/file/d/1CDqgyClp0Z-gcK38p0cimOkcw0CsDOaV/view?usp=sharing

<h3>4. The final project with all the components - </h3>
https://drive.google.com/file/d/1pmlfBhWZZDKpiII4JS4tNEzoBBfRAFYJ/view?usp=sharing

<h2>Items used - Prefab, references, tags, OnTriggerEnter, scenes, SerializeField, TextMeshPro, deltaTime, Instantiate and Destroy, Canvas and 2-d text, Scripts </h2>
<h1>A. Prefabs</h1>
<h2>1. Pulpit</h2>
<p>This is the platform prefab which stores the general size and color of the floor. As we need to spawn several floors, we would need this prefab to spwan same platforms.</p>

<h2>2. ScorePlatfrom</h2>
<p>An empty transparent cube which stays on top of each Pulpit. This acts as a triggerObject which on triggerEnter increases the score. It also gets destroyed after some time, for each platform, so that the movement of Doofus does not affect the scores. Its given the tag 'ScoreObject' to check for triggers in Score increase.cs</p>

<h2>3. TimeCard</h2>
<p>The time card is a 3D TextMeshPro which contains the time text. Its placed correctly onto the Pulpit.</p>


<h1>B. Scripts Used</h1>
<h2>1. Movement.cs</h2>
<p>The code gives movement to the Game object to which it attaches. It takes input as keyboard press(up,down,left right,w,d,a,s) to shift the position of a charater a particular position</p>

<h2>2. Spawning.cs</h2>
<p>The code takes a platfrom prefab, stores its postion in a vector, generates a vector based on the 4-direction(any of the 4 side is selected as the next position for the spawned platform) and instantiates Pulpit, ScorePlatform and TimeCard at the position calculated using random vector and the previous vector position. This script also destroys all these objects after the desired time.</p>

<h2>3. Destroying.cs</h2>
<p>Destroys any game aboject after some time.</p>

<h2>4. GameOver.cs</h2>
<p>After adding an empty object in the form of huge cube below the platform, we can use OnCollision function to trigger a certain event like 'Game Over'. Hence this script helps in identifying those collisions and if found, redirecting to another scene.</p>

<h2>5. TimeScript.cs</h2>
<p>This scripts takes start time and keeps on 'updating' it. This updated time is then used to calulate seconds and miliseconds. Finally makes changes to the TimeCard text. This script is generated everytime when the TimeCard is called in Spawning.cs helping in creating seperate countdowns for seperate Pulpits</p>

<h2>6. Score increase.cs</h2>
<p>It updates the score value by 1 onTrigger with ScorePlatform</p>

<h1>C. Scenes</h1>
<h2>1. Game scene</h2>
<p>This scene is the first scene which loads up whenever the game starts. Here we have added all our working code to generate platforms and move the cube. This scence contains an object which triggers GameOver Scene</p>
<h2>2. GameOver scene</h2>
<p>The game over scene loads when doofus falls. This scene generates a canvas, shwoing the game over text and restart button. Once clicked, the game restarts from the start. This is done with the help of the script GameOver.cs</p>

<h1>D. Edge Cases</h1>
<p>1. The Spawning.cs shifts the current position of a prefab Pulpit thus leading to the Doofus falling instantly as the first platform gets destroys before the new one emerges. This can be solved by using another Pulpit and timing it in such a way that it only disappears after the next one emerges.This is achieved using Destroying.cs</p>
<p>2. The most complex part was adding time. After hours of thinking, the best way I could find was creating a TimeScript, attaching it to a text object. Now call this object accordingly. This would always call the TimeScript.cs, thus creating multiple time countdowns.</p>
<p>3. To make sure that if a player moves in and out of a Pulpit it shouldn't just increase the score, I have used an empty inivisble object which instantiates along with the platform and destroys after 1ms(the next platform emerges in 2.5 s). This makes sure that the Dufus increses the score only once while antering</p>



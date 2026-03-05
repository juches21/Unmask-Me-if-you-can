<h1>🥊 Unmasked </h1>
<img src="https://github.com/juches21/Juches21-images/blob/c8b0540a08a150461607ba037311a468117ce768/Unmasked.png" alt="CH1 Manager Logo">
<hr>
<p><strong>Unmasked</strong> is a game developed in <strong>Unity</strong> in the Global Game Jam 2026 with a Mask theme </p>
<hr>
<a href="https://juan-chovi.itch.io/unmask" target="blank"><img align="center" src="https://img.shields.io/badge/Itch.io-FA5C5C?style=for-the-badge&logo=itchdotio&logoColor=white" alt="unsimpledev"  /></a>
<hr>
<h2>📖 Description</h2>
<p><em>A fast-paced arena combat game where players face waves of enemies, perform punches, and activate powerful Finisher moves.</em></p>
<p>The game combines reflex-based mini-games, dynamic enemy waves, and immersive visual feedback to create a challenging arcade experience.</p>
https://github.com/juches21/Juches21-images/blob/c8b0540a08a150461607ba037311a468117ce768/Unmasked.png
<h2>🎮 Gameplay Loop</h2>
<ol>
    <li><strong>Enemy Waves:</strong> Enemies spawn in waves using the <span class="code">Spawn</span> system. Each enemy is managed by <span class="code">FighterNormal</span> and only moves when hitting a trigger (<span class="code">Run</span>).</li>
    <li><strong>Player Interaction:</strong>
        <ul>
            <li>Click enemies to perform punches (<span class="code">Manager.Punch()</span>, <span class="code">Punch.cs</span>)</li>
            <li>Defeated enemies increase score and build the Finisher meter (<span class="code">Masks_Health.cs</span>)</li>
            <li>Finisher becomes available after enough points (<span class="code">Manager.ScoreFinisher &gt;= 15</span>)</li>
        </ul>
    </li>
    <li><strong>Finisher Mechanics:</strong> Activating the Finisher spawns visual effects (<span class="code">SphereFinisher.cs</span>) and triggers a special attack animation (<span class="code">Manager.Finisher()</span>).</li>
    <li><strong>Mini-Game Challenges:</strong> Tap/resistance mini-games (<span class="code">Tap.cs</span>) test reflexes and timing.</li>
    <li><strong>Round and Endgame Flow:</strong> Manager coordinates rounds, UI, videos, and game end sequences.</li>
</ol>
<h2>🎮 Gameplay / Screenshots</h2>

<img src="https://github.com/juches21/Juches21-images/blob/2072f6e9ffb4168e09a6196c127ec4a390f84564/Capturaun1.PNG" alt="Screenshot 1">
<img src="https://github.com/juches21/Juches21-images/blob/2072f6e9ffb4168e09a6196c127ec4a390f84564/Capturaun2.PNG" alt="Screenshot 2">
<img src="https://github.com/juches21/Juches21-images/blob/2072f6e9ffb4168e09a6196c127ec4a390f84564/Capturaun3.PNG" alt="Screenshot 3">

<hr>
<h2>🧠 Architecture / How It Works</h2>

<h3>Manager.cs</h3>
<p><strong>Central game controller.</strong> Coordinates score, player attacks, Finisher, round flow, and UI updates. Uses a Singleton pattern for global access.</p>

<h3>Spawn.cs</h3>
<p>Controls enemy wave spawning and difficulty scaling.</p>

<h3>FighterNormal.cs</h3>
<p>Controls enemy AI, movement, and attacks.</p>

<h3>Punch.cs</h3>
<p>Handles the punch object spawned when the player hits an enemy.</p>

<h3>Masks_Health.cs</h3>
<p>Visual player feedback system using stacked masks.</p>

<h3>Tap.cs</h3>
<p>Controls mini-game mechanics for tap/resistance challenges.</p>

<h3>UI.cs</h3>
<p>Manages pause menu, scene transitions, and video sequences.</p>

<h3>CameraMove.cs</h3>
<p>Smoothly moves the camera between two points for cutscenes or gameplay events.</p>

<h3>Crowds.cs</h3>
<p>Populates the environment with crowd objects that look toward the arena.</p>

<h3>Run.cs</h3>
<p>Activates enemy movement when entering a trigger zone.</p>

<h3>SphereFinisher.cs</h3>
<p>Handles the visual effect of the Finisher move by scaling a sphere.</p>

<h2>⚙ Architecture Overview</h2>
<pre>
Manager (core system)
│
├── Spawn (enemy waves)
├── FighterNormal (enemy AI)
├── Punch (player attack)
├── Masks_Health (player status visualization)
├── Tap (mini-game)
├── CameraMove (camera transitions)
├── Crowds (environment population)
├── Run (enemy activation trigger)
└── SphereFinisher (Finisher visual effect)
</pre>



<h2>🎯 Key Features</h2>
<ul>
    <li>Procedural enemy waves with difficulty scaling</li>
    <li>Player punch mechanics with score and Finisher integration</li>
    <li>Tap/resistance mini-games to challenge reflexes</li>
    <li>Visual health and Finisher feedback (Masks & Sphere effects)</li>
    <li>Dynamic camera movements and crowd population for immersion</li>
    <li>Full UI control including pause, intro videos, and transitions</li>
</ul>

# DeadlockRecreation

(This readme was for Lab3. you dont need to read this for the final submission, but I havent gotten the grade back so im not going to remove it).  






Lab 3 Breakdown Ethan Harder 100877874
In scene:
https://youtu.be/yucvVJGXQjs

(Isolation)
https://youtu.be/qL0Zk3TZlRU

Directions:
The scene is the MapCleanup scene.
Relevant assets are within the “Shaders”/ “Ability Explosion”
(it contains a few now unused parts from testing, i think i got them all in a junk folder)

Optimization:
I made a few different textures for this, and none needed to be massive, so I realized I could combine a few to save texture size without too much pixelation/loss.  
<img width="2048" height="2048" alt="VFXTextureProduction_BallTexture" src="https://github.com/user-attachments/assets/ccdb23d1-b264-40ea-b336-37ad6c2f4969" />
<img width="512" height="512" alt="ScruffleVFX_random_fragment" src="https://github.com/user-attachments/assets/23cb4c01-4979-4ac1-8d79-24829f4119eb" />
<img width="512" height="512" alt="QuarterRest" src="https://github.com/user-attachments/assets/c1942649-0ba1-4c82-aefd-68d57a5fb5ea" />
<img width="512" height="512" alt="ShockRaw" src="https://github.com/user-attachments/assets/91d7abd8-3589-45c2-b545-f796f22f3414" />  
I combined these four to the size that one of them was previously:  
<img width="512" height="512" alt="combinesTex" src="https://github.com/user-attachments/assets/8c55a1e1-e6dd-4d7a-be7c-c0ae01a2b17a" />  

And added flipbook functionality to my material so i could select them.

Layer 1: Sigil
This quarter note sigil is meant to try and start a music motif for all the related abilities you would use. It has a gradient inside it for a nice detail, and is eroded by a seperate mask.  
<img width="300" height="300" alt="image" src="https://github.com/user-attachments/assets/45f65b2e-d3ad-46e6-af65-2193819b08e3" />  
The ability can technically change colours, but this an many other stick to a HDR orange to keep things harmonious.  
Main parameters are the corrision strength, the flipbook input, the colour, and a power modifier that helps exxagerate the gradiant in the texture.

Layer 2: dome  
Two domes stacked with swirling textures, trying to create a little bit of chaos in an otherwise perfectly circular start. uses a colour multiplier and size manipulation to imply the charging and detonation during release.  
<img width="858" height="692" alt="image" src="https://github.com/user-attachments/assets/9ed4dde8-1d53-40f6-be44-40c9463371f3" />
Main parameters messed with are size, colour alpha, and tiling speeds.  

Layer 3: wave  
This one is shamelessly added because i love when they use it on deadlock abilities. it conveys strength to the attack, adds more motion near the ground to imply hitbox size, and uses a custom cylinder and parameters to make the twist at the height i wanted.  
<img width="902" height="454" alt="image" src="https://github.com/user-attachments/assets/5ee415aa-dc13-419d-9675-0e9b8ee47644" />  
Main parameters were a set of floats I use to modify the height of the texture (and the others from layer 2)

Layer 4: Shockwave stills
These are maybe my weakest addition. I really like the idea of them in theory, but im not sure if my texture holds up. i made them transparent so the large size wouldnt impact visibilty. I like the tone (and had fun sneaking more music symbols in).  
<img width="927" height="506" alt="image" src="https://github.com/user-attachments/assets/18c70b31-2b28-4383-a0da-aa868b55e598" />

Layer 5: ground impact (and the coloured one)
a combination of darker sprites on the ground imply damage to the floor as caused by the attack. adds impact and gravitas, and helps the ability feel heavier and not vanish as fast while still implying the attack timings
<img width="688" height="349" alt="image" src="https://github.com/user-attachments/assets/dac3fa89-1ad9-4f0c-8137-4a277cb7da2b" />
Important parameters were the corrosion values, the colours (a muted black that is juuust slightly orange), and delay timing on spawn.

Layer 6: all the explosion stuff
These additional components add some lingering qualities like layer 5, but also impact and some more movement, which is nice since the effect is mainly stationary.
<img width="823" height="594" alt="image" src="https://github.com/user-attachments/assets/9ea3b55d-43e7-4129-866e-99ecd670a506" />  
The notes wiggle a bit with some sine wave manipulation, and the rest all radially burst from the center with variable size, speeds, and angular velocity.  










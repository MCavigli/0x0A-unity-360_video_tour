# 0x0A. Unity - 360 Video

Welcome! This 360 degree video is a virtual tour of the Holberton San Francisco campus.

![](https://imgur.com/bvYmNgy.png)

This 360 video is meant to be experienced with an **Oculus Quest**. Please load the APK file found in the **Builds directory** onto your Quest. For information on how to do this please check out [this website](https://uploadvr.com/sideloading-quest-how-to/).

## How to use this app

Once it's playing, you can tour the SF Holberton campus and interact with the virtual buttons by looking directly at them and pressing the A button on the right controller. A circular indicator will appear when you are looking directly at a button that you are able to interact with.

![](https://i.imgur.com/Z3SlyQX.png) : Button to travel between rooms.

![](https://i.imgur.com/5E9fjoJ.png?1) : Button to view more information.

Here is a map of the tour. Users begin in the living room:
![](https://i.imgur.com/hGYfWo0.png)

## Some info

This virtual tour was made with Unity. I mapped the 360 video from each room on the inside of a sphere GameObject. When you move to a different room it deactivates the video of the room you leave and activates the video for the room you're going to.

![](https://i.imgur.com/eYdtF4T.png)

Music used in project: [Tech Live by Kevin MacLeod](https://incompetech.filmmusic.io/song/4463-tech-live/)

### Final thoughts

This was my first foray into developing for virtual reality. It was a difficult experience but nice to see an actual project come together in the end. Getting the 360 video to map on the inside of the spheres was my biggest challenge.

I think there could be a better way to build this project rather than moving the camera to the "sort of" center of each sphere. I may come back to this project later when I have time and make it more efficient.

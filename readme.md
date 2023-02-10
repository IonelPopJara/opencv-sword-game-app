# Unity OpenCV Sword Game App

This is an app developed in `.NET` to function as interface with the
[Unity OpenCV Sword Game](https://github.com/IonelPopJara/opencv-sword-game).

It uses `image processing` and `serial communication` to send data to the main game.

If you want a preview of this game, you can watch this video.
[I Made a Motion Controlled Game using a Stick](https://youtu.be/l1oq7TMTVK0)
## Image Processing

In simple terms, the image processing for this application has 3 steps.

1. Color Mask

First we create a _color mask_ to select a specific color as the tracking component.

<p aling='center'><img src='resources\0-sc-color-mask.png'></p>

```txt
For optimal results, the tracker object should have good contrast with the background. In the final test of the game, I used an orange ball as a tracker.
```

2. Median Blur

<p aling='center'><img src='resources\1-sc-median-blur.png'></p>

Since the tracking method is not really precise, the _median blur_ will smooth some imperfections in the tracker. This also helps to improve the tracking if the camera quality is not good enough.

3. Getting Coordinates and Final Product

<p aling='center'><img src='resources\2-sc-final-product.png'></p>

Once we have a clear tracker image, we can draw a square around the object and send its position via `serial communication` to the game app.

## In-Game

<p aling='center'><img src='resources\sc-game.png'></p>

For more screenshots and examples, refer to the game project repo. 

[Unity OpenCV Sword Game](https://github.com/IonelPopJara/opencv-sword-game).

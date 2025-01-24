# Jump Jump @ Kinect
*A somatosensory replica of WeChat‘s popular mini game **[跳一跳](https://zh.wikipedia.org/wiki/%E8%B7%B3%E4%B8%80%E8%B7%B3)***

---

Final Project of ***Design of the Somatosensory Interactive Virtual System*** @ *Spring 2023*,
an incredible course taught by [Prof. Haiyan Ma](https://ieeexplore.ieee.org/author/450192396385734)

---

⚠️ WARNING: This project uses a modifed version of [Kinect v2 Examples with MS-SDK](https://assetstore.unity.com/packages/tools/integration/kinect-v2-examples-with-ms-sdk-18708#description), which is a paid package in Unity Asset Store thus has been removed from the source code.

🙋 Contact the author for more information about the modification if you want to replicate the repo.

---

## 🎥 See the Demo We Presented on Class
https://github.com/user-attachments/assets/d8453c23-ac9d-4afa-8766-b3edb803c07c

## 🎮 Play with Kinect (Windows only)
- Install [Kinect for Windows SDK v2.0](https://www.microsoft.com/en-us/download/details.aspx?id=44561).
- Connect Kinect Hardware to your PC.
- Start the player, your posture will display on **Buttom Right** corner once detected.
- Wave **Left or Right** with **Any Hand** to start (and restart) the game.
- Squat down to accumulate strength, stand up to release the littel bottle.
- Extra credit for accurate hit.
## 🔨 Try in debug Mode (Universal)
- Open the project.
- Select DebugCam in *Hierarchy*, set it's *Culling Mask* to *UI*.
- You should see debug menu on screen. Press *Switch Debug* to turn on debug mode.
- Press *match-80* to simulate a matched squat-down pose, *match-40* to simulate the stand-up pose. 
- Now you can control the game without somatosensory hardware.

## 🔗 Refrences
- **Unity-JumpJump:** An Unity implementation of **跳一跳**, [Github](https://github.com/MetaZhi/Unity-JumpJump)
- **Kinect v2 Examples with MS-SDK:** An awesome package for developing Kinect Apps with Unity, [Unity Asset Store](https://assetstore.unity.com/packages/tools/integration/kinect-v2-examples-with-ms-sdk-18708#description)

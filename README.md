肥肥14 VR模组 for 国服 (XIVR for CN)  
***警告 - 可能导致癫痫*** 
**如果你有光敏性癫痫, 请勿游玩该模组. 当VR模式启用后桌面的游戏窗口画面会频繁闪烁.** (VR头显内不会闪烁.)

*时空之门由我操控!*

**XIVR** 是一个开源项目, 目标是为广受好评的日本 MMORPG 增加VR支持, 其免费试玩时长不会有限制. 该开源模组仅调用游戏自带函数, 并不包含版权所有元素. 并且, 据我们了解, 该模组不会被检测并可以在正式服务器游玩, 使用该模组会违反用户许可协议. 请自行承担风险; 我们不会对可能造成的损伤负责.

XIVR 当前还在 **Alpha阶段**. 该插件目前以最低可行状态公布, 用于吸引用户兴趣以及吸引更多的开发者来参与. 所有代码开源, 并且我们愿意合并新功能! 如果你感兴趣的话, 请联系我们!

Notes: 

• **The initial release is aimed at regular controller and motion controller players**. It can still be played with mouse and keyboard if you use the interact key (by default, Numpad 0) instead of the mouse to activate objects. Selecting objects in the world using the mouse has been disabled due to misalignment between the VR rendering and the mouse placement in the VR UI. 

• Currently, 3D is based on alternate eye rendering (AER). To hit a constant 90 FPS, **a strong GPU (RTX 3070+) is recommended**. For the optimal viewing experience, **it is highly recommended to set the game to windowed mode with the same per-eye resolution as your headset**. You can check the per-eye resolution in your SteamVR settings. Should the resolution surpass the limits of your display, it can be manually set by changing the `ScreenWidth` and `ScreenHeight` settings in FFXIV.cfg, normally located in the `Documents/My Games/Final Fantasy XIV - A Realm Reborn` folder.

**• Install Instructions •**
1. Download and install XIVLauncher from https://github.com/goatcorp/FFXIVQuickLauncher
2. On the start screen hover over the red dalamud icon on the left hand side and click on settings
3. Navigate to the Experimental tab and enable "Get plugin testing builds", and save and close
4. Using the same method as 2. open the installer and select "All Plugins" on the left side and search for "xivr" in the search box
5. Install the "XIVR" plugin from the list by selecting Install.

**• Features •**

**3D rendering & 6DOF Head Tracking:** 
3D is based on alternate eye rendering (AER) with an accurate projection matrix. (Including support for headsets without parallel projection, like Pimax.) 
Headtracking is *completely independent from the in game camera*, and the camera can be operated like usual in both first and third person.

**Floating UI:** 
UI is rendered inside the world in 3D, on a floating curved screen. The distance and scale can be adjusted via chat commands.

**Motion Controller Support (optional):** 
Remapping of the Xbox controller buttons and analogue sticks, as well as keyboard functions such as the F-keys, Esc, Scroll Up/Down and more, will be available using the Steam VR remapping feature. 
Controller based locomotion is also supported in first person mode; you can point the left controller in the direction you want to go. 
(The initial release will only include a profile for the Index Controllers. If you create a new controller mapping for a different controller, please share it in the Flat2VR Discord! We'll try to include them in future updates.)

**Camera Offset Adjustments:** 
Adjust the XY location of the camera to your liking! This is great if you prefer an over-the-shoulder view to being directly behind your character.

**Smart Auto-Enable:**
If you're running SteamVR when the game is started, it'll automatically boot into VR mode. If SteamVR isn't running, the game will boot into flatscreen mode like normal!

**Emergency Floating Screen:** 
You can switch the game into desktop mode on a floating screen at will. This is useful in various circumstances; for example, to make the beast tribe daily sniping minigame easier. It can be toggled via chat commands or macros.(By default, the floating screen always activates in cutscenes to avoid seeing broken scenes. This can be disabled in the settings.) 

**Vertical and Horizontal Snap Turning (optional):** 
Allows you to shift the camera by a fixed degree both vertically and horizontally. Supported on the analogue sticks of both motion and regulars controllers, as well as macros and/or via chat commands. 

**Automatic horizon correction (toggle):**  
When horizon correction is active, moving the camera vertically while in third person will adjust the angle of the VR view automatically. While the position of the camera changes, the relative angle to the horizon remains the same, significantly decreasing motion sickness.

**Macro support:**
Many options can be set via chat input and/or macros!

**And more!**
Dozens of other small fixes to make the game more comfortable in VR.

**• List of chat/macro commands •**

`/xivr` opens the VR settings

`/xivr on` enables VR

`/xivr off` disables VR

`/xivr recenter` recenters the camera

`/xivr screen` renders the game in 2D on a floating screen whenever you need it (sniping minigame, etc)

`/xivr uiz [amount]` sets the distance from the floating screen, where [amount] is a positive or negative value. The default is a value of 0.

`/xivr uiscale [amount]`  sets the sets the size of the floating screen,  where [amount] is a positive or negative value. The default is a value of 1.

`/xivr uireset` resets the distance and size of the floating screen

`/xivr conloc` enables controller locomotion (aka onward locomotion) for first person

`/xivr horizon` makes it so the camera angle is corrected if rotated vertically so the horizon never changes, preventing vr sickness

`/xivr hsnap` enables horizontal snap turning via analogue sticks

`/xivr vsnap` enables vertical snap turning via analogue sticks

`/xivr snapanglex [degrees]` sets the amount of degrees for horizontal snap turning using the analogue stick, where [degrees] is a positive number

`/xivr snapangley [degrees]` sets the amount of degrees for vertical snap turning using the analogue stick, where [degrees] is a positive number

`/xivr rotatex [degrees]` immediate X axis snap turning, where [degrees] is a positive or negative number

`/xivr rotatey [degrees]` immediate Y axis snap turning, where [degrees] is a positive or negative number

`/xivr offsetx [amount]` moves the camera directly along the X axis, where [amount] is a positive or negative value. This can be used for an over-the-shoulder view. 

`/xivr offsety [amount]` moves the camera directly along the Y axis, where [amount] is a positive or negative value. This can be used for an over-the-shoulder view.

**• Planned Updates •**

**Advanced Motion Controller Support:** 
UI interaction with VR motion controllers; pointing at the UI with the controller acting as a laser pointer, allowing you to click and drag. Motion controller based targeting; point at a NPC or item inside the game world to target them.

**Immersion view (experimental):** 
If enabled, the head of your player character will be hidden, and the camera will be repositioned within the head. This allows you to see the world like your character would! Currently, it's only really usable for immersion and screenshotting: it's not meant for gameplay in its current state.

**Automatic Resolution Adjustment:** 
Applies the resolution of your headset to FF14's windowed mode resolution, even if it's beyond the limits of what your display supports.

**Additional Safety Features:** 
Vignette etc.

**• Recruiting Developers for... •**

**IK:** We have full access to the memory locations of the bones and their associated scaling. We can also hide body parts like the legs and the head at will. One could modify these values in real time based on controller and headset location to implement IK, or to improve the immersion mode by hiding arms and legs to have a floating torso in first person.

**Shader-based 3D:** Currently, we use alternate eye rendering (AER) to support 3D. This makes it hard to hit a stable 90 FPS in VR, as the real framerate of the game is cut in half to accommodate rendering for each eye. By modifying the shaders to output in 3D, we could significantly speed up the game in VR and make it run on weaker hardware.

**• Known Issues •**

**Flickering Shadows:** 
In certain scenes, shadows might flicker at the very edge of the view.

**Unable to interact with world objects via clicking the mouse:** 
Clicking inside the world is disabled, as what's displayed under your mouse and what your mouse selects in-world aren't aligned. Please use the interact button instead, which by default is mapped to Numpad 0.

**Misaligned dynamic UI elements:** 
Certain UI elements, like *chat bubbles* and *floating combat text*, are misaligned between the two eyes. This is because of how the UI works: we intercept the UI after the name plates finish rendering, and redirect the rest to our own texture. Unfortunately, these UI elements are rendered last. If possible, we might disable them or redirect them to a static location in a future update.

**3D UI elements wont display correctly:** 
3D UI elements like the adventurer plate and the gear preview screen will display incorrectly.

**imgUI does not display in the headset**
The popular menu system imgUI used by many other plugins does not display correctly in the headset. To view imgUI based menus in the headset please use `/xivr screen`

**Certain objects display incorrectly**
The purple wall in front of a boss room appears different in both eyes.

**Ground targeted attacks are hard to aim**
Because the camera moves between the two eyes the ground aoe location will also move by the same amount. To alleviate this issue you can either make macros for those attacks to redirect them to your self or your target via `/ac "action name"  <t>` for target or `<me>` for your own character, or use `/xivr screen`

**On certain headsets the floating screen might appear stretched**
This issue has been reported by a tester using the Valve Index.

**VR controllers only work if a controller is detected**
Motion controllers only work if the game detects a controller of any kind, this can be a Xbox controller or even a racing steering wheel.

**UI is not displaying in the headset**
This can randomly occur when starting VR mode, in this case please use `/xivr uireset`

**• Changelog •**

v0.0.0.2 released now installing via the repo should work again

v0.0.0.3 released now the UI should no longer hide randomly, if you have downloaded a previous version please delete \AppData\Roaming\XIVLauncher\pluginConfigs\ xivr.json should the error have been saved in the file

v0.0.0.4 released, "band aid edition" Fix cross-eyed world via `/xivr swapeyes` and ui via `/xivr swapeyesui`  If your normal (non vr) controller isnt working please try `/xivr motcontoggle`

v0.0.5 experimental release  
Fixed floating UI scaling curvature bug  
Fixed shadow glitching at edge of vision  
Changes to loading order if it crashed previously please try this and report back  
If started from the title screen settings will auto apply if started from the game please run `/xivr loadcon` after starting vr

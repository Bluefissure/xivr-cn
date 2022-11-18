肥肥14 VR模组 for 国服 (XIVR for CN)  
***警告 - 可能导致癫痫*** 
**如果你有光敏性癫痫, 请勿游玩该模组. 当VR模式启用后桌面的游戏窗口画面会频繁闪烁.** (VR头显内不会闪烁.)

*时空之门由我操控!*

**XIVR** 是一个开源项目, 目标是为广受好评的日本 MMORPG 增加VR支持, 其免费试玩时长不会有限制. 该开源模组仅调用游戏自带函数, 并不包含版权所有元素. 并且, 据我们了解, 该模组不会被检测并可以在正式服务器游玩, 使用该模组会违反用户许可协议. 请自行承担风险; 我们不会对可能造成的损伤负责.

XIVR 当前还在 **Alpha阶段**. 该插件目前以最低可行状态公布, 用于吸引用户兴趣以及吸引更多的开发者来参与. 所有代码开源, 并且我们愿意合并新功能! 如果你感兴趣的话, 请联系我们!

Notes: 

• **初始发布为面向普通控制器和VR手柄的玩家**. 如果你使用交互按键的话还是可以用键鼠游玩的 (默认按键为Numpad 0), 但你无法使用鼠标来选中对象. 鼠标选中对象由于VR内UI与鼠标真实坐标的不一致而被禁用. 

• 当前, 3D 是基于双眼交替渲染方案来渲染的 (AER). 要保持 90 FPS, **你需要一个强力的 GPU (RTX 3070+)**. 为保证良好体验, **十分推荐将游戏设置为窗口模式并将窗口分辨率设置为与你的头显渲染分辨率一致**. 你可以在SteamVR设置里看到头显的单眼渲染分辨率. 如果头显渲染分辨率超过了显示器支持的最大分辨率, 你可以在FFXIV.cfg里手动设置 `ScreenWidth` 和 `ScreenHeight` 参数, 该文件通常在 `Documents/My Games/Final Fantasy XIV - A Realm Reborn` 文件夹内.

**• 安装指南 •**
1. 从 https://github.com/goatcorp/FFXIVQuickLauncher 下载并安装XIVLauncher
2. 在标题界面的左侧使用鼠标悬浮Dalamud图标并选中Dalamud设置
3. 进入测试版标签栏并点击 "获取测试版插件", 点击保存并关闭
4. 使用第2步的方法打开插件安装器并在左侧选择 "所有插件" 并在搜索栏输入 "xivr" 进行搜索
5. 在插件列表内选中 "XIVR" 插件并点击安装.
6. PS: 国服没有, 请自行编译
**• 功能 •**

**3D 渲染 & 6DOF 头部追踪:** 
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

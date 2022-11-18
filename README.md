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
3D 基于双眼交替渲染 (AER) 并附带精确的投影矩阵. (且支持不带有平行投影的头显, 如 Pimax.) 
头部追踪是 *完全独立于游戏相机的*, 且相机能够正常以第一人称或第三人称操作.

**悬浮 UI:** 
UI 是覆盖于 3D 世界上的, 于一个弯曲的平面上. 距离和缩放可通过聊天指令调整.

**VR手柄支持 (可选):** 
重新映射了XBOX控制器的按钮和摇杆, 以及键盘的按键如F键, Esc, 上下滚动及更多, 使用 Steam VR 重新映射的功能即可使用. 
基于控制器的 Locomotion 也同样在第一人称中支持; 你可以将左控制器指向你想去的方向来移动. 
(初始发行版只会发布基于 Index 控制器的按键映射. 如果你为其他类型的控制器创建了映射预设, 可以在 Flat2VR Discord 上分享! 我们将会在未来更新中加入.)

**相机偏移调整:** 
按照你的意愿调整相机的XY轴! 如果你更喜欢越肩第三人称而不是呆在人物的头后边的话.

**智能自动启用:**
如果你在游戏启动前启动了Steam VR, 会自动进入VR模式. 若 SteamVR 未在运行, 游戏将会照常载入平面屏幕模式!

**紧急平面屏幕:** 
你可以将游戏画面切换为正常的平面屏幕模式并在VR视角内以悬浮屏幕显示. 在一些情况下会很好用; 例如, 让金碟飞行员射击小游戏更简单一些. 可通过指令或宏来开关.(默认情况下, 悬浮平面屏幕将会在过场动画中启用以防止看到崩坏的过场动画. 可在设置中禁用.) 

**Vertical and Horizontal Snap Turning (optional):** 
Allows you to shift the camera by a fixed degree both vertically and horizontally. Supported on the analogue sticks of both motion and regulars controllers, as well as macros and/or via chat commands. 

**Automatic horizon correction (toggle):**  
When horizon correction is active, moving the camera vertically while in third person will adjust the angle of the VR view automatically. While the position of the camera changes, the relative angle to the horizon remains the same, significantly decreasing motion sickness.

**宏支持:**
许多选项可通过宏或指令操作!

**还有更多!**
一些小的修改来让VR体验更舒服.

**• 指令/宏指令一览 •**

`/xivr` 打开VR设置

`/xivr on` 启用 VR

`/xivr off` 禁用 VR

`/xivr recenter` 重新置中相机

`/xivr screen` 在你需要的时候以悬浮屏幕形式渲染平面游戏画面 (射击小游戏等)

`/xivr uiz [amount]` 设置悬浮屏幕的距离, [amount] 可以是正值或负值. 默认值为 0.

`/xivr uiscale [amount]`  设置悬浮屏幕的缩放, [amount] 可以是正值或负值. 默认值为 1.

`/xivr uireset` 重设悬浮屏幕的距离与缩放

`/xivr conloc` 为第一人称启用控制器的 Locomotion 功能

`/xivr horizon` 修正垂直旋转时的相机视角使得地平线不会变动, 防止3D眩晕

`/xivr hsnap` 启用摇杆的水平快速旋转功能

`/xivr vsnap` 启用摇杆的垂直快速旋转功能

`/xivr snapanglex [degrees]` 设置每次水平快速旋转的程度, [degrees] 为正值

`/xivr snapangley [degrees]` 设置每次垂直快速旋转的程度, [degrees] 为正值

`/xivr rotatex [degrees]` 快速X轴旋转, [degrees] 可以为正值或负值

`/xivr rotatey [degrees]` 快速Y轴旋转, [degrees] 可以为正值或负值

`/xivr offsetx [amount]` 让相机基于X轴偏移, [amount] 可以为正值或负值. 可用于越肩视角. 

`/xivr offsety [amount]` 让相机基于Y轴偏移, [amount] 可以为正值或负值. 可用于越肩视角. 

**• 更新计划 •**

**高级VR手柄支持:** 
使用VR手柄来与UI进行交互; 利用类似激光笔的方式来用手柄操作UI, 允许你点击拖动. 基于VR控制器的选中对象; 允许通过瞄准 NPC 或世界内物件来选中对象.

**沉浸视角 (实验性):** 
若启用, 你的游戏角色的头会被停止渲染, 而相机将会固定在头上. 可让你以角色的视角来观察世界! 当前, 该功能仅适用于沉浸以及截图: 不适合用于进行正常游玩.

**自动调整分辨率:** 
自动将头显渲染分辨率应用到 FF14 的窗口模式分辨率, 即使超出了你的显示器最大分辨率.

**额外安全措施:** 
安全区域显示等.

**• 寻找开发人员... •**

**IK:** We have full access to the memory locations of the bones and their associated scaling. We can also hide body parts like the legs and the head at will. One could modify these values in real time based on controller and headset location to implement IK, or to improve the immersion mode by hiding arms and legs to have a floating torso in first person.

**Shader-based 3D:** Currently, we use alternate eye rendering (AER) to support 3D. This makes it hard to hit a stable 90 FPS in VR, as the real framerate of the game is cut in half to accommodate rendering for each eye. By modifying the shaders to output in 3D, we could significantly speed up the game in VR and make it run on weaker hardware.

**• 已知问题 •**

**闪烁的阴影:** 
在特定场景下, 阴影可能会在边缘闪烁.

**无法使用鼠标来选中对象:** 
Clicking inside the world is disabled, as what's displayed under your mouse and what your mouse selects in-world aren't aligned. Please use the interact button instead, which by default is mapped to Numpad 0.

**动态UI元素不对齐:** 
Certain UI elements, like *chat bubbles* and *floating combat text*, are misaligned between the two eyes. This is because of how the UI works: we intercept the UI after the name plates finish rendering, and redirect the rest to our own texture. Unfortunately, these UI elements are rendered last. If possible, we might disable them or redirect them to a static location in a future update.

**3D UI 元素无法正常显示:** 
3D UI 元素如冒险者名牌和调查界面无法正常显示.

**IMGUI 无法在VR内正常显示**
被很多插件使用的IMGUI无法在头显内正常渲染. 要在头显内查看基于IMGUI的菜单请使用指令 `/xivr screen`

**特定对象渲染不正常**
Boss房前的紫色墙双眼渲染不同.

**地面目标模式太难瞄准**
Because the camera moves between the two eyes the ground aoe location will also move by the same amount. To alleviate this issue you can either make macros for those attacks to redirect them to your self or your target via `/ac "action name"  <t>` for target or `<me>` for your own character, or use `/xivr screen`

**特定头显的悬浮屏幕会发生拉伸**
该问题由一位使用 Valve Index 头显的测试者提出.

**VR 控制器只有在连接手柄后才能使用**
VR 控制器只有在连接手柄后才能使用, 可以是XBOX控制器甚至是方向盘.

**UI 没有显示出来**
启动VR模式时会随缘发生, 若发生可使用 `/xivr uireset` 指令

**• 更新日志 •**

v0.0.0.2 released now installing via the repo should work again

v0.0.0.3 released now the UI should no longer hide randomly, if you have downloaded a previous version please delete \AppData\Roaming\XIVLauncher\pluginConfigs\ xivr.json should the error have been saved in the file

v0.0.0.4 released, "band aid edition" Fix cross-eyed world via `/xivr swapeyes` and ui via `/xivr swapeyesui`  If your normal (non vr) controller isnt working please try `/xivr motcontoggle`

v0.0.5 experimental release  
Fixed floating UI scaling curvature bug  
Fixed shadow glitching at edge of vision  
Changes to loading order if it crashed previously please try this and report back  
If started from the title screen settings will auto apply if started from the game please run `/xivr loadcon` after starting vr

# 总结
## 1.安装
1 如果只是游玩，请下载安装包————“游戏.zip”（Windows 64位）。
2 如果是想对游戏进行修改，请先移步到：https://unity.cn/
下载unity游戏引擎，如果想对游戏代码，脚本进行修改
请自行配置Csharp运行环境并下载相应的IDE（推荐Visual Studio Code，记得加入与unity模块）。
并打包下载文件夹“游戏github”。
## 2.FAQ
1.我的unity在将包导入后scene的canves不能将所有的画面包括。
       我们人为设置scene中的canves的x设为了900，根据个人硬件软件的不同，可能需要自行设置。

2.吃豆人第一次玩的时候会出现卡墙穿墙的问题。
      这个是碰撞设置问题，目前正在修复，在第二条命，第三条命时不会出现此bug。

3.吃豆人这款游戏规则？
     老板有三次机会，目标是干掉20个程序员，程序员在修复bug时候可以被干掉，在没有修复bug时候不能被干掉，
老板可以通过给钱的方式，在短时间内可以忽视是否修复bug而直接干掉程序员。
如果所有的bug被修复同时老板没有钱就会被程序员追死。游戏结束。

4.找不同规则
    目前设计有三关，第一关是一处图形不同需要点击不同即可通关，第二关是一个逻辑错误需要点击两处才可通关， 第三关是代码格式错误，共11处点击即可通关。
   每个点击处根据图像显示将点击区域大小设置不同，可能会出现点击有时候不灵的情况，
   在unity运行界面会提示已点击的个数，可通过注释掉代码来将显示去掉。

5.怎样进入不同的选择？
   在开始的时候通过点击不同的图片，进入到不同的路线（老板/程序员），老板路线中包含吃豆人游戏，程序员路线中包含找不同游戏。

6.程序员的界面怎样使用？
     点击屏幕中的电脑屏幕，即可进入到电脑中，
    电脑软件目前设定好的有c（进入找不同游戏），音乐（可以播放音乐），其他的界面目前没有设计好。
    场景的切换主要是通过脚本的跳转来进行的。
## 3.NEWS
v0.01bate1：由于是第一次做游戏，基本全套都是现学先写的，所以有很多不成熟的地方，
同时因为没钱也没水平，导致所有的素材全部来源于网络，如果有侵权，请与我们联系
1601684622@qq.com
huoyanlieniao@163.com
magic77kid@qq.com
我们会尽快删除的，其次就是这个开源游戏是我们的一个开源项目作业，
所以不一定会继续做下去，如果能继续写下去的话，日后可能会加入更多的游戏玩法等
（开始我们计划了超级多的东西，现在这个版本不及计划中的千分之一）。
最后欢迎大佬们对我们进行批评和指导（最好能加入我们QAQ）。
## 4.代码库
历史代码库：https://github.com/srx-2000/game
现代码库：https://github.com/srx-2000/open_source_game

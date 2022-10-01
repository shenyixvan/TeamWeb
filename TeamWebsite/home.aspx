<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="TeamWebsite.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="Css/Home (2).css"/>
    <title>首页</title>
     <link rel="shortcut icon" href="image/团队信息/1.ico"/>
    <script type="text/javascript">
        var len = document.getElementsByName("i");
        var pos = 0;
        function changeimage() {
            len[pos].style.display = "none";
            pos++;
            if (pos === len.length - 1) pos = 0;
            len[pos].style.display = block;
        }
        setInterval("changeimage()", 3000);
    </script>
    <script type="text/javascript">
        function selectChange() {
            let myselect = document.getElementById('info_lz');
            let index = myselect.selectedIndex;
            let op = myselect.options[index].value;
            let box = document.getElementById('xk');
            if (op == '物理成绩') {
                box.style.display = 'block';
            }
            else {
                box.style.display = 'none';
            }
        }

    </script>

</head>
<body>
<div class="frame">
    <header>
        <nav>
            <div class="zzcx-1">
                <span>众</span>
                <span>智</span>
                <span>创</span>
                <span>新</span>
            </div>
            <div class="blank"></div>
            <ul>
                <li><a href="#a1" class="sec">简介</a></li>
                <li><a href="#a2" class="sec">荣誉墙</a></li>
                <li><a href="#a3" class="sec">成员</a></li>
                <li><a href="#a4" class="sec">风采</a></li>
                <li><a href="#a5" class="sec">报名</a></li>
            </ul>
        </nav>
    </header>

    <a id="a1"></a><br/>

                                                                
    <div class="logo"><img class="logoimg" src="Image\团队信息\logo.png"></div>



    <div class="zzcx-2">
        <h1 class="title">
            <span>众</span><span>智</span><span>创</span><span>新</span>
        </h1> 
    </div>
    <br/>
    <br/>
    <hr>
                                                                               




    <div class="title-1">简介</div>
                                                                                   




    <div>
        <div class="intro">
            <label>
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp众智创新团队隶属于辽宁工业大学电气工程学院，成立于2016年，是我校在校本科生组建而成的创新团队。同时，团队是“西门子杯”中国智能制造挑战赛设在辽宁工业大学的Campus HUB学习中心。<br>
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp团队在吴峰老师的带领下，为学生提供学习空间。团队成员团结一致，为团队的发展贡献着自己的力量。团队主要学习基于西门子PLC延伸的各类知识与技能。在理论知识的基础上注重提高学生专业实践能力，养成创新思维，加强团队合作精神。<br>
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp随着团队的发展，培养方向也在不断拓宽，现设有多个培养方向，每个方向学习的内容各不相同，却又互相联系，学生可根据自身特点自行选择。团队不仅满足学生多元化的学习需求，也为团队成员提供了充分的发展空间。<br>
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp在北京、天津、深圳、沈阳、大连等城市，都有从团队走出去的毕业生。他们或读研读博，或成为研发工程师，都在自己的岗位上秉承着团队的精神，将所学的知识回馈给社会。<br>
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp团队理念：积力之所举，则无不胜也；众智之所为，则无不成也。
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<button onclick="javascript:window.location.href='#a5'">点击加入我们</button><br>
            <br>
            </label>    
        </div>
    </div>
    <br/><br/><br/><br/><br/><br/><br/><br/>




    <a id="a2"></a>


    <div class="b ryqtitle"><a class="ryqh" style="letter-spacing: 10px;">荣誉墙</a></div>
    <div class="ryq">
        <div class="txtbox">
            <p>&#8195&#8195团队成立至今（截止2021年8月），通过老师和同学们的不懈努力，共获得包括国家特等奖在内的国家级奖励13项，赛区特等奖在内的赛区奖励23项，省特等奖在内的省级奖励12项（按照参赛小组获得的最高奖项计算）。这些成绩的取得不仅锻炼了队员的实践能力，还磨砺了他们战胜苦难的坚强意志。在这些荣誉的背后是团队每位成员的辛勤付出，每件作品都是团队智慧的结晶，都凝结着成员们的心血，承载着他们的希望。</p>
            <p>&#8195&#8195人生在世，不如意者十有八九。得到的结果或许不是你所期望的，但在此过程中，你一并收获与经历的事物才是最珍贵的。
                欢笑过，哭泣过，体会过，彻悟过，经历过......这些是比结果更大的收获。</p>
            <p>（只展示部分2019-2021年的比赛证书）</p>
        </div>
         <div class="zsbox">
            <img class="zs" src="Image/2019年国赛证书/陈子健-国一.png">
            <img class="zs" src="Image/2019年国赛证书/胡立峰-国一.png">
            <img class="zs" src="Image/2019年国赛证书/蒋忠禹-国一.png">
            <img class="zs" src="Image/2019年国赛证书/李文阳-国一.png">
            <img class="zs" src="Image/2019年国赛证书/孙浩钧-国特.png">
            <img class="zs" src="Image/2019年国赛证书/王隽鹏-国一.png">
            <img class="zs" src="Image/2020年证书/陈子健-国二.png">
            <img class="zs" src="Image/2020年证书/胡立峰-国一.png">
            <img class="zs" src="Image/2020年证书/姜铭叡-省一.png">
            <img class="zs" src="Image/2020年证书/姚小龙-省一.png"> 
            <img class="zs" src="Image/2021年证书/董秋莹-省一.png">
            <img class="zs" src="Image/2021年证书/郭永晟-省一.png">
            <img class="zs" src="Image/2021年证书/姜铭睿-省特.png">
            <img class="zs" src="Image/2021年证书/刘雨欣-省一.jpg">
            <img class="zs" src="Image/2021年证书/王永乐-省特.jpg">
            <img class="zs" src="Image/2021年证书/王志强-省特.png">
            <img class="zs" src="Image/2021年证书/杨善鹏-省一.png">
            <img class="zs" src="Image/2021年证书/董洪林-国二.png">
         </div>
    </div>

    <a id="a3"></a><br/><br/>

  
  <div class="b"><a class="ryqh" style="letter-spacing: 10px;">团队成员</a></div>
  
    <div id="teacher" class="cybox">
        <div class="cy-top">指&#32导&#32教&#32师</div>
            <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label>
         <div class="cy">
            <img src="Image/团队成员/老师/老师.png">
            <h3>吴峰</h3>
            <p>只问耕耘，不问收获。</p>
          </div>
    </div>
    <div id="13chengyuan" class="cybox">
        <div class="cy-top">13级团队成员</div>
      
            <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label>
        
        <div class="cy">
            <img src="Image/团队成员/13级/13-宫会彬.png">
            <h3>宫会彬</h3>
            <p>星光不问远行人，</p>
            <p>时光不负有心人。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/13级/13-韩韬.png">
            <h3>韩   韬</h3>
            <p>勤奋的人是时间的主人，</p>
            <p>懒惰的人是时间的奴隶。</p>
          </div>
    </div>
    <div id="14chengyuan" class="cybox">
        <div class="cy-top">14级团队成员</div>
      
            <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label>
        
        <div class="cy">
            <img src="Image/团队成员/14级/14-李友堂.png">
            <h3>李友堂</h3>
            <p>每一次选择都是一个开始，一个转变，一个机会，付诸于行动和努力就有机会成就伟大！</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-李佳茜.png">
            <h3>李佳茜</h3>
            <p>从零开始。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-李泽亨.png">
            <h3>李泽亨</h3>
            <p>成功不是将来才有的，而是从决定去做的那一刻起，持续积累而成。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-李思宇.png">
            <h3>李思宇</h3>
            <p>不走捷径。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-冯越.png">
            <h3>冯   越</h3>
            <p>保持谦虚，保持热爱。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-杜华军.png">
            <h3>杜华军</h3>
            <p>努力，奋斗，拼搏。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-付联杰.png">
            <h3>付联杰</h3>
            <p>永不言弃。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-商昌林.png">
            <h3>商昌林</h3>
            <p>只为成功找方法，</p>
            <p>不为失败找借口。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-张亮.png">
            <h3>张   亮</h3>
            <p>坚持就是胜利。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-张展明.png">
            <h3>张展明</h3>
            <p>机会只提供给那些早已做好充分准备的人。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/14级/14-孟凡强.png">
            <h3>孟凡强</h3>
            <p>太阳每天都是新的，</p>
            <p>你是否每天都在努力。</p>
          </div>
    </div>
    <div id="15chengyuan" class="cybox">
        <div class="cy-top">15级团队成员</div>
      
            <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label>
        
        <div class="cy">
            <img src="Image/团队成员/15级/15-傅恩卿.png">
            <h3>傅恩卿</h3>
            <p>不为短期利益牺牲未来。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/15级/15-金锐.png">
            <h3>金锐</h3>
            <p>学以致用，融汇贯通，惜时刻苦，对新知识永远保持热情。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/15级/15-韦大云.png">
            <h3>韦大云</h3>
            <p>所谓万丈深渊,</p>
            <p>下去,也是前程万里。</p>
          </div>                
    </div>
    <div id="16chengyuan" class="cybox">
        <div class="cy-top">16级团队成员</div>
        <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label>
        
      <div class="cy">
            <img src="Image/团队成员/16级/16-白春皓.png">
            <h3>白春皓</h3>
          <p>如果你想拥有你从未有过的东西 ,那么你必须去做你从未做过的事情。</p>
        </div>
         <div class="cy"> 
              <img src="Image/团队成员/16级/16-蒋忠禹.png">
            <h3>蒋忠禹</h3>
            <p>业精于勤，荒于嬉；</p>
             <p>行成于思，毁于随。</p>
          </div>
         <div class="cy">
            <img src="Image/团队成员/16级/16-董艺铭.png">
            <h3>董艺铭</h3>
            <p>踏破千山，纵然将鞋磨穿，</p>
            <p>迎日落再登攀。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/16级/16-李文阳.png">
          <h3>李文阳</h3>
          <p>不忘初心，方得始终；</p>
          <p>越努力，越幸运。</p>
           </div>
        <div class="cy">
             <img src="Image/团队成员/16级/16-罗迪.png">
            <h3>罗迪</h3>
            <p>心中壮志常在，</p>
            <p>脚下须臾不息。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/16级/16-王浩.png">
            <h3>王浩</h3>
            <p>道阻且长，行则将至；</p>
            <p>行而不辍，未来可期。</p>
          </div>
        <div class="cy">
             <img src="Image/团队成员/16级/16-皮佳艳.png">
            <h3>皮佳艳</h3>
            <p>自信是成功的第一诀窍。</p>
          </div>
    </div>
    <div id="17chengyuan" class="cybox">
         <div class="cy-top">17级团队成员</div>
      <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label>
      
        <div class="cy">
             <img src="Image/团队成员/17级/17-李苏庆.png">
            <h3>李苏庆</h3>
            <p>功不唐捐，玉汝于成。</p>
        </div>
        <div class="cy">
            <img src="Image/团队成员/17级/17-李万兴.png">
              <h3>李万兴</h3>
            <p>世上无难事，只要肯攀登。</p>
             </div>
        <div class="cy">
            <img src="Image/团队成员/17级/17-孙浩钧.png">
            <h3>孙浩钧</h3>
            <p>不要在该奋斗的年龄选择安逸。</p>
          </div>
    </div>
    <div id="18chengyuan" class="cybox">
        <div class="cy-top">18级团队成员</div>
        <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label>
        
        <div class="cy">
            <img src="Image/团队成员/18级/18-陈子健.jpg">
            <h3>陈子健</h3>
            <p>热爱，是没有理由的。我们在追寻答案的过程中，就已经活成了答案本身。</p>
          </div>
        <div class="cy">
            <img src="Image/团队成员/18级/18-郭永晟.jpg">
            <h3>郭永晟</h3>
            <p>有些人想成功，有些人渴望成功，有些人努力实现成功。。</p>
        </div>
          <div class="cy">
            <img src="Image/团队成员/18级/18-胡立峰.jpg">
            <h3>胡立峰</h3>
            <p>遇到事情不能坐以待毙。</p>
        </div>
        <div class="cy">
            <img src="Image/团队成员/18级/18-王隽鹏.png">
            <h3>王隽鹏</h3>
            <p>你的热爱，</p>
            <p>终将美好。</p>
        </div>
        <div class="cy">
            <img src="Image/团队成员/18级/18-杨善鹏.png">
            <h3>杨善鹏</h3>
            <p>当你面前有两条路时，</p>
            <p>走最难的路。</p>
        </div>
    </div>
    <div id="19chengyuan" class="cybox">
        <div class="cy-top">19级团队成员</div>
        <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label> 
        <div class="cy">
            <img src="Image/团队成员/19级/19-董洪林.jpg">
            <h3>董洪林</h3>
            <p>人生没有如果，命运没有假设，</p>
            <p>既然已成既然，何必再说何必。</p>
        </div>
        <div class="cy"> 
            <img src="Image/团队成员/19级/19-董秋莹.jpg">
            <h3>董秋莹</h3>
            <p>脚下的路自己走过才知道，</p>
            <p>勤奋是走向成功的通行证。</p>
        </div>
        <div class="cy">
            <img src="Image/团队成员/19级/19-姜铭叡.jpg">
            <h3>姜铭叡</h3>
            <p>苦心人天不负，卧薪尝胆，</p>
            <p>三千越甲可吞吴。</p>
        </div>
        <div class="cy">
            <img src="Image/团队成员/19级/19-李天济.jpg">
            <h3>李天济</h3>
            <p>一个人总有一天必须扛起他应担负的所有责任。</p>
        </div>
        <div class="cy">
            <img src="Image/团队成员/19级/19-汤海祺.jpg">
            <h3>汤海祺</h3>
            <p>没有伞的孩子必须努力奔跑。</p>
        </div>
=
        <div class="cy">
            <img src="Image/团队成员/19级/19-王志强.jpg">
            <h3>王志强</h3>
            <p>自是少年 ，韶华倾负。</p>
        </div>
        <div class="cy">
            <img src="Image/团队成员/19级/19-姚小龙.jpg">
            <h3>姚小龙</h3>
            <p>记着自己永远是那颗太阳，你发出光不仅照热你，也照热别人。</p>
        </div>
        <div class="cy">
            <img src="Image/团队成员/19级/19-冷维.jpg">
            <h3>冷维</h3>
            <p>成功与不成功之间有时距离很短。</p>
        </div>
    </div>
    <div id="20chengyuan" class="cybox">
        <div class="cy-top">20级团队成员</div>
        <input type="checkbox" id="cycheck" class="cy-check"><label>展开</label>
          <div class="cy">
            <img src="Image/团队成员/20级/20-杨镇源.jpg">
              <h3>杨镇源</h3>
              <p>福兮祸所依，</p>
              <p>祸兮福所倚。</p>
          </div>
          <div class="cy">
            <img src="Image/团队成员/20级/20-王永乐.jpg">
              <h3>王永乐</h3>
              <p>不经历巨大的困难，</p>
              <p>不会有伟大的事业。</p>
          </div>
          <div class="cy">
            <img src="Image/团队成员/20级/20-刘雨欣.jpg">
              <h3>刘雨欣</h3>
              <p>成为更好的人，</p>
              <p>这是新的约定。</p>
          </div>
          <div class="cy">
            <img src="Image/团队成员/20级/20-李德龙.jpg">
              <h3>李德龙</h3>
              <p>暗自伤心,不如立即行动。<br/><br/><br/></p>
          </div>
          <div class="cy">
            <img src="Image/团队成员/20级/20-沈逸轩.jpg">
              <h3>沈逸轩</h3>
              <p>任何限制，</p>
              <p>由自己的内心开始。</p>
          </div>
          
</div>
  <br/><br/><br/><br/><br/>






  <a id="a4"></a><br/><br/>


  <div class="b"><a class="ryqh" style="letter-spacing: 10px;">团队风采</a></div>
  <div class="fcbox">
    <div class="fc">
        <img src="Image/团队风采/电气工程合影.JPG">
        <p style="margin-left: 35%;">2021电气工程学院合影</p>
    </div>
    <div class="fc">
        <img src="Image/团队风采/比赛现场.jpg">
        <p style="margin-left: 32%;">2021西门子杯比赛现场</p>
    </div>
    <div class="fc">
        <img src="Image/团队风采/20宣讲会2.JPG">
        <p style="margin-left: 35%;">2020宣讲会现场</p>
    </div>
    <div class="fc">
        <img src="Image/团队风采/20宣讲会.JPG">
        <p style="margin-left: 35%;">2020宣讲活动</p>
    </div>
    <div class="fc">
        <img src="Image/团队风采/21辽沈纪念馆合影.JPG">
        <p style="margin-left: 35%;">2021辽沈纪念馆合影</p>
    </div>
    <div class="fc">
        <img src="Image/团队风采/21元旦晚会.JPG">
        <p style="margin-left: 35%;">2021元旦晚会</p>
    </div>
    <div class="fc">
        <img src="Image/团队风采/配水池合影.JPG">
        <p style="margin-left: 35%;">2020配水池合影</p>
    </div>
    <div class="fc">
        <img src="Image/团队风采/吃瓜.png">
      <p style="margin-left: 40%;">吃瓜</p>
    </div>
    <div class="fc">
        <img src="Image/团队风采/21西门子杯省赛 .jpg">
        <p style="margin-left: 38%;">西门子杯省赛合影</p>
    </div>
</div>


<a id="a5"></a>

<div class="haibao"><img src="Image\团队信息\海报.png"/></div>




<div class="sign-in">
    <div class="sign-in-txt">
        <b>招新原则：</b><br/>
            1.热爱工业自动化技术，对工业控制领域感兴趣并具有一定的创新精神<br/>
            2.团队意识强、积极上进、品行端正、艰苦朴素、耐心细心<br/>
            3.最重要的一点：态度决定一切<br/>
            <b>报名方式：</b><br/>
            1.在下方表单中填写相关信息并提交<br/>
            2.微信搜索“众智创新团队报名”或扫描下方二维码进入小程序，在“报名”界面提交相关信息<br/>
            <img class="ewm" src="Image/团队信息/微信小程序二维码.jpg" height="100px" width="100px"/><br/>
            <b>报名时间：2021.10.13——2021.10.25</b><br/>
            <b>选拔流程：</b><br/>
            1.初选：报名后进行笔试、面试选出部分人员进入下一阶段选拔<br/>
            2.考核：通过初选阶段的同学进入团队学习相关知识，定期进行考核，根据日常表现和每期考核成绩择优录取<br/>
            <b>只要你有想法，有态度，想要更进一步，想要大学过得精彩，众智创新团队欢迎你！</b><br/>
    </div>
    <div>
         <form runat="server" onkeydown="if(event.keyCode==13){return false;}">
                    <div runat="server" id="info" style="display:none">
                    <div class="baoming-con">
                    	<label>学&#8195&#8195号</label>
                        <asp:TextBox CssClass="bm" ID="info_number" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="baoming-con">
                    	<label>姓&#8195&#8195名</label>
                        <asp:TextBox CssClass="bm" ID="info_name" runat="server"></asp:TextBox>
                    </div>
                    <div class="baoming-con">
                        <label>性&#8195&#8195别</label>
                        <asp:DropDownList CssClass="bm" ID="info_sex" runat="server" >
                            <asp:ListItem class="optionbgc">男</asp:ListItem>
                            <asp:ListItem class="optionbgc">女</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="baoming-con">
                    	<label>手机号码</label>
                        <asp:TextBox CssClass="bm" ID="info_mobile" runat="server"></asp:TextBox>
                    </div>
                    <div class="baoming-con">
                        <label>专业班级</label>
                      
                        <asp:TextBox CssClass="bm" ID="info_majorclass" runat="server"></asp:TextBox> 
                        
                    </div>
                    <div class="baoming-con">
                        <label>住&#8195&#8195址</label>
                      <asp:TextBox CssClass="bm" ID="info_address" runat="server" placeholder="如“辽宁锦州古塔区”"></asp:TextBox>
                    </div>
                    <div class="baoming-con">
                        <label>数学成绩</label>
                        <asp:TextBox CssClass="bm" ID="info_math" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                  <div class="baoming-con">
                        <label>语文成绩</label>
                        <asp:TextBox CssClass="bm" ID="info_chinese" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                         <div class="baoming-con">
                    	<label>英语成绩 </label>
                        <asp:TextBox CssClass="bm" ID="info_english" runat="server" TextMode="Number"></asp:TextBox>
                
                         <div class="baoming-con">
                <select class="bm" type="text" list="lz" ID="info_lz" name="info_lz" runat="server" onchange="selectChange()">
                    <option class="optionbgc">物理成绩</option>
                    <option class="optionbgc">理综成绩</option>
                </select>
                        <asp:TextBox CssClass="bm" ID="info_physics" runat="server"  TextMode="Number" ></asp:TextBox>
                    </div>
                       </div>
                         <div class="baoming-con" id="xk">
                    	<label>两科选课总成绩</label>
                        <asp:TextBox CssClass="bm" ID="info_two" runat="server" TextMode="Number" ></asp:TextBox>
                    </div>
                    </div>
                    <div class="baoming-btn">
                    <div id="bm_submit"  runat="server" style="display:none">
                        <input type="button" class="bm" value="确认提交" runat="server" onserverclick="Bm_submit_Click"/>
                    </div>

                    <div id="tongzhi" runat="server" style="display:none">
                        <p>您已报名，请及时关注招新群通知，等待笔试</p>
                    </div>

                    <div id="look_button" runat="server" style="display:none">
                        <input type="button" value="查看信息" runat="server" onserverclick="Look_button_Click"/>
                    </div>

                    <div id="amend_button" runat="server" style="display:none">
                        <input type="button" value="修改信息" runat="server" onserverclick="Amend_button_Click"/>
                    </div>

                    <div id="affirm_button" runat="server" style="display:none">
                        <input type="button" value="确认修改" runat="server" onserverclick="Affirm_button_Click"/>
                    </div>
                    
                    <div id="admin_button" runat="server" style="display:none">
                        <input type="button" value="管理员按钮" runat="server" onserverclick="Admin_button_Click"/>
                    </div>
                    </div>
                </form>
                <div id="tishi" runat="server" style="display:none">
                    <p>根据用户名分析，您不符合报名要求!</p>
                </div>  
                 </div>
            </div>
        </div>
    <br/><br/><br/><br/><br/>
</body>
</html>
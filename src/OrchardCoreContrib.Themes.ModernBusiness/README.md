# The Modern Business Theme
Learning to build an OrchardCore theme by using liquid template to implement [Modern Business](https://startbootstrap.com/templates/modern-business/) theme of Start Bootstrap.

## Repository
Feel free to checkout the latest updates in my main [repository](https://github.com/jwu-au/ModernBusiness.OrchardCore) for the theme. I will do synchonization to the **OrchardCoreContrib.Themes** constantly.

## Motivation
Orchard project is one of my favour open source projects captured my daily attentions recently. Back to many years ago I did one project using OC1 in which I found that the learning curve is very long, but I did enjoy my time spending on it as I learned not only the Orchard itself, but also the architecture design, coding skills and etc. I believe there are many people are like me that having passions on finding better way of implementing even a small piece of code, such as the Orchard team and its contributors.

OrchardCore (aka OC2), which is based on the latest .net core framework, brings lots of new designs and features, and I started my exploration again. I started my learning from browsing a couple of Orchard videos in [Lombiq's youtube channcel](https://www.youtube.com/channel/UCDVUxCz2RvkgTbA0wAYKwRA), I then went throught the [Orchard-Training-Demo-Module](https://github.com/Lombiq/Orchard-Training-Demo-Module/tree/orchard-core) to understand some concepts in OrcharcCore. During the development of this theme project, I relied a lot on the offical [documentations](https://docs.orchardcore.net/), and followed the Orchard's __buildin themes__. Last but not least, I asked questions in the community, [Github Issues](https://github.com/OrchardCMS/OrchardCore/issues) and [Gitter](https://gitter.im/OrchardCMS/OrchardCore?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge).

OrchardCore is still under development (RC2 is approaching), and sometime you may find information is a bit loose/too much. To implmentment a theme is one of starting points of using OrchardCore, and it is a way to put everything together. I choosed Modern Business theme because it may covers more scenarios than a real theme involves. As a learning material, it is enought I think. I searched around and found there is none fully completed implementation of the Modern Business theme working with the latest version of OrchardCore. And this can be the one, which, I hope, can also help with your learning of OrchardCore.

## Features
The Modern Business theme includes 17 HTML pages. All features in these pages are implemented. And of course this is currently my version of implementations, and if you have better way/suggestion for any thing, give me a shout (PRs, Issues).

## My Targets
1. A liquid based theme in OrchardCore (not Razor, neither Headless).
1. As a theme, write less C# code as possible.
1. Working with the latest OrchardCore in **dev** branch. 
1. The looking is the same as the original theme as much as possible.

## Moving Foward
1. Looking for better way to deal with each scenarios in the theme including below:
  * Better way to deal with Breadcrumbs.
  * Styling of flow parts such as the contact form.
2. Writing blogs or recording videos to have a better demo.

## How to start?
1. Check out the latst OrchardCore source code.
1. Check out this project under the **src\OrchardCore.Themes** folder, and name the folder **TheModernBusinessTheme**.
1. Modify **src\OrchardCore\OrchardCore.Application.Cms.Targets\OrchardCore.Application.Cms.Targets.csproj** and add below line.
```xml
<ProjectReference Include="..\..\OrchardCore.Themes\TheModernBusinessTheme\TheModernBusinessTheme.csproj" PrivateAssets="none" />
```
4. Compile and run **src\OrchardCore.Cms.Web** web project.
1. Setup the website using the "Modern Business" recipe.



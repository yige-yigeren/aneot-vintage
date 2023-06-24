# Another End of Terra (AnEot) for Vintage Devices

A fanmade literary journal based on mobile game *Arknights*, redesigned for vintage devices.

## Build Instructions

- Clone the repository locally

- Make sure .NET 7 SDK is available on your computer

- Run `dotnet run` command in `src` folder

> Notice for static web site
>
> By default, static web site will be generated in `src/StaticWebSite` folder
>
> If you want to change it, use the following method to do that (ordered by the priority)
>	- Use *command line argument*:
> ```dotnet run --StaticWebSiteOutputPath "YOUR PATH"```
> - Set *environment variables* named ```StaticWebSiteOutputPath```: set it in ```launchSettings.json``` or in your command line interface
> 
> - Add ```StaticWebSiteOutputPath``` in *appsettings.json*
> ```
> {
>	......
>  "StaticWebSiteOutputPath": "YOUR PATH"
>	......
> }
> ```
>  If you just want to generate static files and don't want to start the website, use ```dotnet run -- static-only```

Enjoy~

## About Us

If there are any errors in the website or you have any comments,

You can open a new issue.

<!-- This is not an official project yet, so we remove the following notice temporarily -->

<!--
If you would like to join us,

Please use the email address [TCA_doc@163.com](mailto:TCA_doc@163.com) Contact us.

*Note that for security reasons we do not accept submissions from non-collaborators*
-->

## About copyright

We only grant you the right to save and share as is. At the same time you must comply with the following requirements:

**Attribution** — You must give appropriate credit, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.

**Non Commercial** — You may not use the material for commercial purposes.

**No Derivatives** — If you remix, transform, or build upon the material, you may not distribute the modified material.

**Refuse to train the model** — It shall not be used for any purpose artificial intelligence generation model training, including but not limited to personal, scientific research, teaching and commercial applications.

We reserve all rights not granted to you, and if you violate the above requirements, we will withdraw all rights granted to you.

**Copyright © 2022-2023 All Rights Reserved**
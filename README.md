[![Download](https://img.shields.io/github/v/release/ic3w0lf22/Roblox-Account-Manager)](https://github.com/ic3w0lf22/Roblox-Account-Manager/releases/latest)
[![Latest Downloads](https://img.shields.io/github/downloads/ic3w0lf22/Roblox-Account-Manager/latest/total)](https://github.com/ic3w0lf22/Roblox-Account-Manager/releases)
[![Discord](https://img.shields.io/discord/871845273800957982?label=Discord)](https://discord.gg/MsEH7smXY8)
![License](https://img.shields.io/github/license/ic3w0lf22/Roblox-Account-Manager)

<!-- BEGIN LATEST DOWNLOAD BUTTON -->
[![Download zip](https://custom-icon-badges.herokuapp.com/badge/-Download-blue?style=for-the-badge&logo=download&logoColor=white "Download")](https://github.com/ic3w0lf22/Roblox-Account-Manager/releases/download/3.6.1/Roblox.Account.Manager.3.6.1.zip)
<!-- END LATEST DOWNLOAD BUTTON -->

[Click here to view Roblox Account Manager features](https://github.com/ic3w0lf22/Roblox-Account-Manager/blob/master/README.md#features)

# Fork
This is a forked version of the original Roblox Account Manager, I think the original maintainer is making the project going to the wrong path, so I have decided to maintain a new version of this account manager myself.

As I am starting out, pull requests are welcomed.

## Note
There are a few things that I will want to change remove or added in this fork.

### Things that I am going to remove
- [ ] Removing donate button
- [ ] Removing all features for exploiting
### Things that I am going to add
- [ ] Adding more features will be available in the developer API
- [ ] Adding support for using multiple accounts in account utilities
### Things that I am going to change
- [ ] Changing function returns in the Account class, instead of returning a `boolean` and showing a message box, I will return a string and use the string to show a message box [here is an example](https://github.com/ProGenshinImpactPlayer/Roblox-Account-Manager/commit/cd470a2d2aa58fed96ac211d0d0dd389d9e43603)
# Roblox Account Manager
Application that allows you to add multiple accounts into one application allowing you to easily play on alt accounts without having to change accounts

Useful for games that require grinding off other players, or storage accounts that hold in game items or currency, or just to have multiple accounts that you can easily find and use.

You are welcome to edit the code and create pull requests if it'll benefit this project.

Multiple Roblox Instances is built into the account manager but [must be manually enabled](https://github.com/ProGenshinImpactPlayer/Roblox-Account-Manager/blob/master/README.md#q-how-do-i-enable-multi-roblox).

Report bugs to the issues section

# WARNING
If someone asks you to generate an "rbx-player link", **DO NOT** do it, they can use these to join any game using your account, or even launch roblox studio with one of your games. They can do many things in game such as spend your robux or even do things that can get your account terminated. **USE THESE FEATURES AT YOUR OWN RISK**

# Extra Features
Extra features can be enabled by setting DevMode=false to DevMode=true in RAMSettings.ini
Beware of the risks that you are taking if you accidentally send something to someone.

If you ever want a friend to join a game using your account, make sure you have the PlaceId and JobId correctly entered, then right click an account, and click "Copy rbx-player link", DO NOT do this if someone asks you for it.

# Download
To install this, head over to the [Releases](https://github.com/ProGenshinImpactPlayer/Roblox-Account-Manager/releases) section and download the rar file at the very top, once downloaded, extract the files into a folder on your desktop and run RBX Alt Manager.exe.

If the application isn't starting or not working, make sure to install the [Latest .NET Framework](https://dotnet.microsoft.com/download/dotnet-framework).
Still having issues? Download and install [vcredist](https://aka.ms/vs/16/release/vc_redist.x86.exe)

# Developer API
To view the documentation, [click here](https://ic3w0lf22.gitbook.io/roblox-account-manager/).
Change the webserver port if you are planning on using any dangerous functions!
Be careful executing random scripts when having dangerous settings enabled.
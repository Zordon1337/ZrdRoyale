# ClashRoyale (2017)
[![clash royale](https://img.shields.io/badge/Clash%20Royale-1.9.2-brightred.svg?style=flat")](https://clash-royale.en.uptodown.com/android/download/1632865)
[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

-----------------------------------------
## ✔What was added/changed in this fork✔
1. Fixed DB(before fixing saving players progress always failed due to non existing column)<br /> 
2. Only admins can use chat commands(add gems, trophies etc)<br/> 
3. Fixed chests not removing gems after buying<br/>
4. Discord webhook logging(players connections,disconnections, battle logs etc)
5. fixed bug where player after arena 7 were playing on wrong arena for example player on arena 9 was playing on frozen peak which is map from arena 8
6. Gems and gold rewards after win.
7. Now server is more customizable without recompiling it, now you can edit:
``` 
Minimum Trophies and Maximum Trophies after Win
Default amount of gems and gold
Gems and gold rewards after win
Admins
```

# TODO ✅
```
Fix trophies after winning
fix free chests bug on arena 10
Remake README.md
```
## Clash royale server for version 1.9.2/1.9.3 written in .NET


## Battles
The server supports battles, for those a patched client is neccessary.

[See the wiki for a tutorial](https://github.com/retroroyale/ClashRoyale/wiki/Patch-for-battles)

## How to start

#### Requirements:
  - [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
  - MySql Database (on Debian i suggest LAMP with PMA or on windows i suggest XAMPP with PMA)

for Ubuntu use these commands to set it up:
```
mkdir ClashRoyale
git clone https://github.com/Zordon1337/ZrdRoyale.git && cd ClashRoyale/src/ClashRoyale

dotnet publish "ClashRoyale.csproj" -c Release -o app
```
Run the server once (```dotnet bin/Release/net8.0/ClashRoyale.dll```) to create the config.json file.

To configurate your server, such as the database you have to edit the ```config.json``` file.

Then run the server again to start it: ```dotnet bin/Release/net8.0/ClashRoyale.dll```

it should look like this: ![alt text](https://i.imgur.com/QKKW9QV.png)

#### Run the server:

###### Main Server:
```dotnet app/ClashRoyale.dll```

###### Battle Server:
```dotnet app/ClashRoyale.Battles.dll```

#### Update the server:
###### Main Server:
```git pull && dotnet publish "ClashRoyale.csproj" -c Release -o app && dotnet app/ClashRoyale.dll```

###### Battle Server:
```git pull && dotnet publish "ClashRoyale.Battles.csproj" -c Release -o app && dotnet app/ClashRoyale.Battles.dll```

## Need help?
Contact me on Telegram (https://t.me/TZordon) or open an issue.

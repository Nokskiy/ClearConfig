# ClearConfig
> [!IMPORTANT]
> The program is in the early stages of development

> [!TIP]
> - [About](#about)
> - [How to use](#how-to-use)
>   - [CMD](#cmd)
>   - [Config](#config)
>     - [FISD](#file-in-same-directory)
>     - [Config](#config-1)

## About

The purpose of this project is to enable fast deletion of files from the device as specified in the config

## How to use

> [!TIP]
> ### CMD
>
> - ```help``` - shows a list of commands and a short description
>   - doesn't matter
> - ```update_links``` - updates links to configs
>   - list all links (true/false)
> - ```remove``` deletes everything from config files
>   - link to config (link)
>
> ### Config
> #### File in same directory
> 
> The file, located in the same directory as the program, must have the following 
> content type:
>
> ```link C:\Example1\ClearConfig.config```
>
> ```link C:\Example2\ClearConfig.config```
>
> #### Config
>
> Configuration example
>
> ```extension .png```
>
> Types:
> - ```extension``` accepts the extension of files to be deleted
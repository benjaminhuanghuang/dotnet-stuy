
## Create a .NET core app
In windows terminal
```bash
mkdir raspberrypi.net.core && cd raspberrypi.net.core

dotnet new console --langVersion=latest && dotnet add package iot.device.bindings
```

## Transfer the app to Raspberry Pi
Rsync will check for the file sizes and modification timestamps to make sure only changes or differences are copied

task.json
```
{
    "version": "2.0.0",
    "tasks": [
        {
            "label": "RpiPublish",
            "command": "sh",
            "type": "shell",
            "problemMatcher": "$msCompile",
            "args": [
                "-c",
                "\"dotnet publish -r linux-arm -c Debug -o ./bin/linux-arm/publish ./${workspaceFolderBasename}.csproj && rsync -rvuz ./bin/linux-arm/publish/ pi@192.168.0.80:~/${workspaceFolderBasename}\"",
            ]
        }
    ]
}
```

launch.json
```
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": "Rpi Publish and Debug",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "RpiPublish",
            "program": "~/${workspaceFolderBasename}/${workspaceFolderBasename}",
            "cwd": "~/${workspaceFolderBasename}",
            "stopAtEntry": false,
            "console": "internalConsole",
            "pipeTransport": {
                "pipeCwd": "${workspaceRoot}",
                "pipeProgram": "/usr/bin/ssh",
                "pipeArgs": [
                    "pi@192.168.0.80"
                ],
                "debuggerPath": "~/vsdbg/vsdbg"
            }
        }
    ]
}
```

create an Azure IoT Hub and make your application send the temperature data to it

Azure IoT Hub is an Azure service that helps you ingest telemetry data from your IoT devices into the cloud to store and process

## Creating an Azure IoT Hub
```
az iot hub create --name apressiothub --resource-group apressbook --sku S1
```


## Registering a Device in the IoT Hub
A device must be registered in your IoT Hub before it can connect. 


## Connecting Raspberry Pi to Azure IoT Hub
```
dotnet add package Microsoft.Azure.Devices.Client
dotnet add package Newtonsoft.Json
```

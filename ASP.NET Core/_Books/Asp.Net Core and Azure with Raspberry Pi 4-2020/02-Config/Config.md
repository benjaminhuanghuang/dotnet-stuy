
## SSH
To manually connect and deploy our applications to the Raspberry Pi and allow remote login, we must enable the SSH
	
Save a ssh file to the boot drive of your SD card.

## Enabling Wi-Fi
Save wpa_supplicant.conf to the boot drive of your SD card.
```
country=US
ctrl_interface=DIR=/var/run/wpa_supplicant GROUP=netdev
update_config=1
network={
    ssid="NETWORK-NAME"
    psk="NETWORK-PASSWORD"
}
```

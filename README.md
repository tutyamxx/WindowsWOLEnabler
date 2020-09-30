# Windows Wake-on-LAN Enabler

<p align="center">
  <img src="https://i.imgur.com/QsLIJI4.png"><br/>
</p>

# Information
* NOTE: In the picture listed above, the IPv4 and MAC addresses are **FAKE** due to privacy reasons, but it will list your real stuff once you run the program.
* Simple Windows 10 tool to enable Wake-on-LAN with one single click
* Obviously, you need to enable WOL in your `BIOS` settings first. To do that, simply Google `how to enable wake on lan in BIOS`

# What it does (IN ONE CLICK ONLY)
* It enables Wake-on-LAN options in the currently used network adapter for Windows OS.
* It disables `Energy Efficient Ethernet`, enables `Wake on magic packet` and `Shutdown Wake Up` advanced network adapter properties, in order to be able to be awaken by [Magic Packets](https://en.wikipedia.org/wiki/Wake-on-LAN#Magic_packet)
* It disables `Turn on fast start-up (recommended)` option in system power settings, because this is known causing problems to many computers using Wake-on-LAN
* It disables `PCI Express -> Link State Power Management` for the current power plan running by the OS.
* It provides your device MAC address and local IPv4 address for using it with your mobile phone Wake on LAN applications or your scripts.

# Download

* Download `WindowsWOLEnabler.exe` from the [releases](https://github.com/tutyamxx/WindowsWOLEnabler/releases) page or you can just compile it yourself.

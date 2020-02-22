# SmartPlug
SmartPlug Application using MQTT with Raspberry Pi 3 / C#,Python,Arduino

- Used it in my final thesis.
- It basically makes you control any amount of plugs in your house considering they are connected to the grid with the system.
- Application shows ampere/energy(watt) usage for every different plug. Also shows detailed graphs for different timelines.
- You can control plugs from unlimited distance.(Considering you have internet.)
- It also shows daily,monthly expenses and compares to earlier expenses.
- All of this can also be shown live.

**Detailed Explanation of How Application Works**

- Application controls the relays that connected to the grid paralely. It also gets data from the Raspberry Pi 3 B+ through MQTT 
and handles the data . 
- MQTT used for communication through mobile , PC and Raspberry Pi
- You create a MQTT server in Raspberry Pi 
- You connect that server through PC or Mobile.
- You join the MQTT room that you created through Raspberry Pi
- Send a message to the server which can open or close relays.
- Raspberry Pi also sends data every 10-15 seconds through message system.
- PC gets the message , process and shows it in application.
- Ampere / Watt measured through ACS712.
- ACS712's connected to Arduino - ADC . Because Raspberry Pi doesnt have one.
- Arduino communicates with Raspberry Pi with Serial connection to give the current data.

**

- Application designed to work only my computer and whitelisted mobile phones and PC's.
- Repository only shows PC application. It does not show serverside Python code,android code and mobile code. It also doenst show any 
preparations you have to do connect MQTT , create MQTT server and electronic side of the circuit.
- You can see the UI of the application through dashboard.jpeg.

- If you want to really open the application , you can change the pathings in the code to your computers , it should work.


import paho.mqtt.publish as publish

publish.single("mqtt/smartplug", "Relays OFF", hostname="iot.eclipse.org")
#publish.single("mqtt/smartplug", "World!", hostname="test.mosquitto.org")
print("Done")

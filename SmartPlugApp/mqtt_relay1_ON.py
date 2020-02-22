import paho.mqtt.publish as publish
publish.single("mqtt/smartplug", "Relay1 ON", hostname="iot.eclipse.org")
print("Done")

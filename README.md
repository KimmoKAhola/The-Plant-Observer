# The IoT Temperature Observer 
## Kimmo Ahola (ka223pd)
Give a short and brief overview of what your project is about. What needs to be included:

- [x] Title
- [x] Your name and student credentials (ka223pd)
- [ ] Short project overview
- [ ] How much time it might take to do (approximation)

This repository serves as the code base for an IoT project for the summer course 24ST - 1DT305 at [LNU](https://lnu-ftk.instructure.com/courses/402).
The purpose of this project has been to create a simple endpoint that I can place somewhere in my apartment and have it collect data. Users can interact with this controller by using a telegram app (some functionality is not available for everyone at the moment, like subscriber).

Current implementation: one microcontroller that reads values from different sensors and saves to a database. A telegram bot is connected to this microcontroller and users can, if they want to, request selected live data from the microcontroller.

Future ideas: implement more sensors and create a smart home. Want to create a network of sensors and visualize the data on a personal website. Want to receive triggers on my phone through a telegram bot/phone app whenever a trigger event happens.

How much time it may take: 6-10 depending on experience (for the python part only).

# Introduction - tutorial on how to....
# Objective

I want to create a sensor network. This is a tutorial to build the first sensor and save information to a database

Objective

Describe why you have chosen to build this specific device. What purpose does it serve? What do you want to do with the data, and what new insights do you think it will give?

- [ ] Why you chose the project
- [ ] What purpose does it serve
- [ ] What insights you think it will give

# Materials

Sensors used in this example: DHT_11 (temp + humidity). Analogue temperature sensor.

Material: Breadboard, Raspberry pi pico, jumper cables, USB cable

- [ ] List of material
      
| Product | Quantity | Link  | Price (SEK) |
| :---         |     ---:       |          :--- | ---: |
| Raspberry Pi Pico WH   | 1     | [electrokit](https://www.electrokit.com/raspberry-pi-pico-wh)    | 109 |
| Kopplingsdäck 840 anslutningar      | 1       | [electrokit](https://www.electrokit.com/kopplingsdack-840-anslutningar)      | 69 |
| jumper cables | 1 | [electrokit](smth) | -1 |
| DHT 11 | 1 | [electrokit](link) | -1 |
| temp sensor | 1 | [electrokit](link) | - 1 |
| Total price | | | -2000 |

- [ ] What the different things (sensors, wires, controllers) do - short specifications
- [ ] Where you bought them and how much they cost
- [ ] Create a table of BoM here

# Setup

Chosen IDE/Editor - VSCode, Rider for the .net api.
Pymakr

[VSCODE](https://code.visualstudio.com/)
[Pymark](https://docs.pycom.io/gettingstarted/software/vscode/)

# place images here on how to find it in the vscode plugin store etc

- [ ] Chosen IDE
- [ ] How the code is uploaded
- [ ] Steps that you needed to do for your computer. Installation of Node.js, extra drivers, etc.

[For the api](https://www.jetbrains.com/rider/)


### chosen IDE/Editor
### How the code is uploaded
### Steps needed, installation etc


# Circuit Diagram

- [ ] Circuit diagram (can be hand drawn)
- [ ] *Electrical calculations (higher grade)

https://fritzing.org/

# Code snippets

# Connectivity

- [ ] How often is the data sent?
- [ ] Which wireless protocols did you use (WiFi, LoRa, etc …)?
- [ ] Which transport protocols were used (MQTT, webhook, etc …)
- [ ] *Elaborate on the design choices regarding data transmission and wireless protocols. That is how your choices affect the device range and battery consumption.

# Data Visualization/presentation

- [ ] Provide visual examples on how the dashboard looks. Pictures needed.
- [ ] How often is data saved in the database.
- [ ] *Explain your choice of database.
- [ ] *Automation/triggers of the data.
- [ ] Describe platform in terms of functionality
- [ ] *Explain and elaborate what made you choose this platform
Ubidots as well as Azure (free for 12 months if you are a student)
## Ubidots Dashboard
https://stem.ubidots.com/app/dashboards/public/dashboard/QiS5cV6BLo26QOs3kU8ZUUYNLR0JPOHqLFPNH-FtdNE
## Azure SQL server
Why azure? I study .net and it is very integrated with that tech stack. Also possible to use the service for free for up to 12 months (a certain amount of credit is provided) if you apply for it with school email.
https://azure.microsoft.com/sv-se

# Final thoughts


- [ ] Show final results of the project
- [ ] Pictures


## API
https://plantobserverapi.azurewebsites.net/swagger/index.html

## Telegram chat bot
Interact with it if you want to. Note that some options may only work for me personally at the moment.
https://t.me/PlantObserverBot



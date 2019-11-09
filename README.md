# MSDAD

**Course:** Design and Implementation of Distributed Applications  
**University:** Instituto Superior Técnico  
**Academic year:** 2019-20

### Team

- 73891 - David Gonçalves ([david.s.goncalves@tecnico.ulisboa.pt](mailto:david.s.goncalves@tecnico.ulisboa.pt))
- 87630 - André Moreira ([andre.moreira@tecnico.ulisboa.pt](mailto:andre.moreira@tecnico.ulisboa.pt))
- 94104 - Leonardo Troeira ([leonardo.troeira@tecnico.ulisboa.pt](mailto:leonardo.troeira@tecnico.ulisboa.pt))

### Links

[MSDAD FAQ](https://docs.google.com/document/d/1MTVyKDmzUeJcLIJTsvw5frO-d6pnYSTjL2flAF0IC2k/edit)

## Assignment

See [documentation/Assignment.md](documentation/Assignment.md)

## Coding conventions

See [documentation/Conventions.md](documentation/Conventions.md)

## FAQ

See [documentation/FAQ.md](documentation/FAQ.md)

## Run Instructions

*Note: Service addresses (aka. Remoting Address) are in the form `tcp://ip:port/channel`*

### Puppet Master

The Puppet Master is the program we use to start and manage servers and clients. It can also run a script file to automate this task (specification in the assignment). The script file can also contain comments (start with ';'). In order for the PM to work, a PCS must be running on the machine where processes will be created. The PM listens on TCP port 10001. For starting servers and clients, their remoting addresses must be provided and are what the user decides.

![PM_Main](documentation/screenshots/PM_Main.png) ![PM_CreateServer](documentation/screenshots/PM_CreateServer.png) ![PM_CreateClient](documentation/screenshots/PM_CreateClient.png) ![PM_ManageServers](documentation/screenshots/PM_ManageServers.png)

### Process Creation Service

This process runs on the machines where servers and clients will be launched. It listens on TCP port 10000.

![PCS](documentation/screenshots/PCS.png)

### Server

The server program **must** receive 5 arguments:

- Server ID
- Server service address
- Server max. tolerated faults
- Server min. delay
- Server max. delay

![Server](documentation/screenshots/Server.png)

### Client

The client program **must** receive 3 arguments:

- Client username
- Client service address
- Server service address

And may receive one 4th optional argument, a script file path (specification in the assignment). If running with Visual Studio, this can be our test script file `../../script.txt`. The script file can also contain comments (start with ';').

![Client_Main](documentation/screenshots/Client_Main.png) ![Client_Create](documentation/screenshots/Client_Create.png) ![Client_Join](documentation/screenshots/Client_Join.png) ![Client_Close](documentation/screenshots/Client_Close.png)

### Visual Studio startup projects

![startup_projects](documentation/screenshots/startup_projects.png)

## Checkpoint

**Not yet implemented:**

- Client functionality not 100%
  - UC tab indexes
  - missing error checks
    - server does not detect repeated slots in a meeting
    - join meetings topic combo box should not show already joined meetings
    - duplicates in invitees combo box
  - list meetings should show more information
  - meeting shows in close combo box of who did not create it
  - meeting shows in join of who was not invited and server lets it join!
  - close meeting (must review)
  - close meeting of another coordinator throws non specific error
  - sign in form in case arguments are not passed at startup
- Server should have different list methods for different situations
- Client list in script?
- Server replication
- PM Status command
- Fault tolerance
- Meeting diffusion algorithm
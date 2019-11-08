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

### Process Creation Service

This process runs on the machines where servers and clients will be launched. It listens on TCP port 10000.

### Server

The server program **must** receive 5 arguments:

- Server ID
- Server service address
- Server max. tolerated faults
- Server min. delay
- Server max. delay

### Client

The client program **must** receive 3 arguments:

- Client username
- Client service address
- Server service address

And may receive one 4th optional argument, a script file path (specification in the assignment). If running with Visual Studio, this can be our test script file `../../script.txt`. The script file can also contain comments (start with ';').

![startup_projects](documentation/startup_projects.png)

## Checkpoint

**Not yet implemented:**

- Client functionality not 100%
  - missing error checks
    - server crash
    - don't allow adding repeated slots
    - don't allow repeated topics
    - join meetings topic combo box should not show already joined meetings
    - don't allow adding meeting without slots and joining meeting without slots
  - topic combo boxes not yet filled
  - list meetings could show more information
  - close meeting 
  - server not informing client when a client joins (the client queries the server instead)
- Server replication
- PM Status command
- Fault tolerance
- Meeting diffusion algorithm
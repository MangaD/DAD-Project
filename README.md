# MSDAD

**Course:** Design and Implementation of Distributed Applications  
**University:** Instituto Superior Técnico  
**Academic year:** 2019-20

### Team

- 73891 - David Gonçalves ([david.s.goncalves@tecnico.ulisboa.pt](mailto:david.s.goncalves@tecnico.ulisboa.pt))
- 87630 - André Moreira ([andre.moreira@tecnico.ulisboa.pt](mailto:andre.moreira@tecnico.ulisboa.pt))
- 94104 - Leonardo Troeira ([leonardo.troeira@tecnico.ulisboa.pt](mailto:leonardo.troeira@tecnico.ulisboa.pt))

### Links

DIDA FAQ

## Assignment

See [documentation/Assignment.md](documentation/Assignment.md)

## Coding conventions

See [documentation/Conventions.md](documentation/Conventions.md)

## FAQ

See [documentation/FAQ.md](documentation/FAQ.md)

## Run Instructions

### Client

The client program *must* receive the file name of a script file as an argument.
If running with Visual Studio, this can be our test script file `../../script.txt`
The script file can also contain comments (start with ';').

### Puppet Master

The Puppet Master *may* receive the file name of a script file as an argument, in
the same fashion as the client. However, it can also receive the commands as input
on the console. The Puppet Master also has an additional command - `Init PCS_URL` -
in order to establish connection to a PCS.

The script file can also contain comments (start with ';').
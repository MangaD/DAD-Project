# Conventions

## Writing output

We use the functions `Utilities.WriteDebug(string)` and `Utilities.WriteError(string)` for debug and error output respectively.

## Remoting address

```csharp
var ra = RemotingAddress.FromString("tcp://localhost:21000/S");
ra.address; // localhost
ra.port; // 21000
ra.channel; // S
ra.ToString(); // "tcp://localhost:21000/S"
```

## Meeting slots

```csharp
Slot s = Slot.FromString("Lisboa,2019-11-05");
s.location; // "Lisboa"
s.date; // DateTime object
s.ToString(); // "Lisboa,2019-11-05"
```
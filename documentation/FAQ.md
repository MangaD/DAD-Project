# DIDA 2019-2020 Project FAQ

### Last Update:

Questions without timestamp were added when the FAQ was created.  
Questions that were added later have a timestamp so readers may identify what is new.

## Questions about the Project

1. **[2019-10-22] What should the system do if the same meeting is started concurrently by 2 different clients on two different servers?**
   You may assume that it will not happen that two meetings with the same topic will be created concurrently.
2. **[2019-10-22] Should the client's list command show all existing meetings?**
   No. The list command should show only the meetings that the client where the command was issued knows about. However, this client should ask a server for a refresh of the status of these meetings.
3. **[2019-10-22] Should the client be terminated as soon as its input script ends?**
   No. The client should continue running until the user terminates it explicitly (close window or Ctrl-C) and can eventually participate in the meeting diffusion algorithm.
4. **[2019-10-22] Can additional parameters be added to the PuppetMaster or client script besides those specified in the Project Statement and the Project FAQ?** 
   No.
5. **[2019-10-22] Can additional parameters be passed as arguments when the Server and Client processes are created (i.e. tell a starting server the URL of one or more existing servers)?**
   Yes.
6. **[2019-10-22] How can a server find additional servers?**
   All servers may have a list with the URLs of all possible server addresses.
7. **[2019-10-22] Do the server names (locations) have to match all the room locations?**
   No.
8. **[2019-10-22] COMMAND SYNTAX CORRECTION:** The join command must include the slots that are acceptable for the user issuing the command. The correct syntax should be: 
   `join meeting_topic slot_count slot1 ... slotn`
   where `meeting_topic` is the topic of the meeting, `slot_count` is the number of slots this users can attend and `slot1` through `slotn` are all the slots (e.g. ”Lisboa,2020-01-02”) that this user can attend.

## C# Issues

1. **Is it possible to wait for multiple objects (thread, async calls, etc,...) in C#?****

   If you want to wait for multiple objects, create an array of `EventWaitHandle`, assign each of them to your tasks, **signal** the corresponding `EventWaitHandle` at the end of a task, and block the current thread using[ WaitHandle.WaitAll](http://msdn.microsoft.com/en-us/library/system.threading.waithandle(v=VS.100).aspx), until all the wait handles are signaled. Simple example:
```csharp
AutoResetEvent[] handles = new AutoResetEvent[2];
handles[0] = new AutoResetEvent(false);
handles[1] = new AutoResetEvent(false);

Thread task0 = new Thread(() =>
{            
    //do something
    handles[0].Set();
});
Thread task1 = new Thread(() =>
{
    //do something
    handles[1].Set();
});
//start the tasks
WaitHandle.WaitAll(handles);
```

## .Net Remoting Issues

1. **How can a server receive connect commands from the library when it’s disconnected?**
   A disconnected server should reject Remoting class from other servers but should answer to the library at his latest active port. When a client issues a new recover command, this should be sent to the old port. After that, the client should connect to the new port, for example:
```csharp
TcpChannel oldChannel = new TcpChannel(8086);
TcpChannel newChannel = new TcpChannel(9000);

ChannelServices.RegisterChannel(oldChannel,false);
ChannelServices.UnregisterChannel(oldChannel);
ChannelServices.RegisterChannel(newChannel, false);
```

2. **When a remoting call throws a programmer-generated exceptions (a sub-class of ApplicationException), the process throws a SerializationException. How can we correct this?**
In this case, you should program custom serialization for the exception class. This code should call the super-class's custom serialization. Here is an example:
```csharp
public class MyException : ApplicationException {

    protected MyException(SerializationInfo info, StreamingContext context) : base (info, context)
    {
    }

    [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter =true)]
    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }
}
```

3. **When a .NET Remoting client-server application is run on separate machines the remote exception mechanism does not work. How can we solve this?**
In this case, you have to add an XML configuration file to the project with the following options:
```xml
<configuration>
    <system.runtime.remoting>
        <customErrors mode="off" />
    </system.runtime.remoting>
</configuration>
```

Don't forget to add to the server code, the call to load the configuration file:
`RemotingConfiguration.Configure("App.config", true);`

4. **Before calling a method on a remote object, I have to create a TcpChannel to handle the communication. Do I have to create a TcpChannel for input and another for output?**
No. The TcpChannel class combines the functionality of a *TcpServerChannel* and of a *TcpClientChannel*. Therefore all the communication needs are met by the TcpChannel. You can find more details at the[ MSDN documentation on the TcpChannel class](http://msdn2.microsoft.com/en-us/library/system.runtime.remoting.channels.tcp.tcpchannel(vs.80).aspx).

5. **When we are debugging, Visual Studio throws an exception on the server side if we try to pass an exception to the client, i.e. throw the exception on a server call so that it would be caught by the client. The error that is returned on the server side is "MyException was unhandled by user code". What is the problem?**
Most probably, you have configured Visual Studio to break the execution when an exception is thrown, whether they are handled ny your code or not. Th change this behaviour, disable the following debug options:"Enable the exception assistant" and "Enable just my code" (within Tools -> Options -> Debugging). Alternatively, press F5 to continue the execution when the program stops.

6. **How can we pass objects by value, as a call parameter or return value, in remote calls?**
    In order to pass an object by value, it has to be serializable. All primitive types in .NET are serializable. To make a class serializable, you need to label it as Serializable. For example:
```csharp
[Serializable]
public class MyClass {
    private int _x;
    private string _y;
}
```
For more information, go to the MSDN documentation website.

7. **Our program is receiving exceptions that are related to the security level when we try to pass proxy objects or delegates in remote calls. How can we overcome this?**
You have to increase the automatic serialization level to "Full". There are two ways to do this: 1) using an XML configuration file or 2) using procedural C# code. The code version is:
```csharp
BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider();
provider.TypeFilterLevel = TypeFilterLevel.Full;
IDictionary props = new Hashtable();
props["port"] = 8085;
TcpChannel chan = new TcpChannel(props, null, provider);
```
Alternatively, you can add a configuration file with the following statements:
```xml
 <system.runtime.remoting>
    <application>
        <channel ref="tcp" port="8086">
            <serverProviders>
                <formatter ref="binary" **typeFilterLevel="Full"** />
            </serverProviders>
        </channel>
    </application>
</system.runtime.remoting>
```
It is essential to load the configuration file before creating the channel by doing:

`ConfigurationServices.Configure(<filename>,false);`

8. **We are having problems when we spend a long period without calling a server. We create the proxy without problems, but when we try to communicate the following exception is thrown: RemotingException - Requested Service not Found. What is happening**
Probably the lease on the server you are using has expired and is therefore no longer accessible. You can solve this by never allowing the lease to expire. Add to the class providing the services, the following method:
```csharp
public override object InitializeLifetimeService(){
    return null;
}
```

9. **We are getting an AuthenticationException when we try to run clients and servers on different machines. How can this be solved?**
Disable the security restrictions when you register the TCP channel (i.e. when you call ChannelServices.RegisterChannel, pass false as the second argument). If you are loading an XML options file, check that security is off (i.e. RemotingConfiguration.Configure("App.config", false); ).

10. **How can we, in a remoting client, configure the timeout we are using for the server responses?**
You can adjust that by changing the properties of the channel that you are using. For example:
```csharp
BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider();

IDictionary props = new Hashtable();
props["port"] = 8085;
props["timeout"] = 1000; // in milliseconds
TcpChannel chan = new TcpChannel(props, null, provider);
```

## User Interface

1. **How can we change the GUI from the threads that handle Remoting calls?**
Recall the lab class. You need to use the reflection mechanism `Invoke` since only the thread that created a Windows Form may change it directly. If the Form class has a method to change it, e.g. UpdateMyForm, you can call it from the Remoting thread by doing:
```csharp
f.Invoke(new delUF(UpdateMyForm), new object[] { param1, param2 }); //delUF is a public delegate with the same parameters and return values as UpdateMyForm
// param1, param2 are the hypothetical parameters of method UpdateMyForm
```
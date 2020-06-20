# Message Pack - .NeT Core
[![Build status](https://dev.azure.com/reginaldo-aguiar/MessagePack/_apis/build/status/messagepack%20-%201%20-%20CI)](https://dev.azure.com/reginaldo-aguiar/MessagePack/_build/latest?definitionId=3)
[![Build Status](https://img.shields.io/nuget/v/messagePack?style=plastic)](https://www.nuget.org/packages/MessagePack/)
[![Build Status](https://img.shields.io/github/issues/reginaldobrz/MessagePack_CSharp?style=plastic)](https://github.com/reginaldobrz/MessagePack_CSharp/issues)
[![Build Status](https://img.shields.io/github/issues-pr/reginaldobrz/MessagePack_CSharp?style=plastic)](https://github.com/reginaldobrz/MessagePack_CSharp/pulls) 

🤠 This project is a simple proof of concept about the message pack strategy to compact our data. Go get your pop corn and enjoy it! 

##  💻 Install

```
Install-Package MessagePack
```

Remember, this project its all about .Net Core so just install this packages

``` 
Install-Package MessagePack
```
and this to give you some warnings about mistakes or fix suggestions
```
Install-Package MessagePackAnalyzer

```

##  🧤 Hands On

First Of all we need the class annotate ```[MessagePackObject]``` but there is not all, the values needs to have annotate to, ok? see

```
 [MessagePackObject]
    public class TodoItem
    {
        [Key(0)]
        public long Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public bool IsComplete { get; set; }
    }
```

Now we almost there, come with me!

The strategy its been like json strategy, see!

We need to serialize and then deserialize our object!

Obviosly we will convert this ```deserialize``` return into a ```ConvertToJson```, and you thinking that will be free from json`s!🧛‍♀️

Into your method put this comands, look

To serialize:
```
byte[] serialize = MessagePackSerializer.Serialize(<Your Object Return>);
```

To desirialize:
```
TodoItem deserialize = MessagePackSerializer.Deserialize<TodoItem>(bytes);
```

Or
```
var json = MessagePackSerializer.ConvertToJson(bytes);
```

That all, see, simple ham! Feel free to contribute!

## 💡 WHERE I FOUND THIS?
<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore -->
<table>
  <tr>
    <td align="center"><a href="https://github.com/neuecc/MessagePack-CSharp"><img alt="" width="100" height="100" class="avatar width-full height-full rounded-2" src="https://avatars2.githubusercontent.com/u/46207?s=460&amp;u=8bb6c0de12451db4c1bf1165166b26d52d1d8747&amp;v=4"><br /><sub><b>Yoshifumi Kawai</b></sub></a><br />💻</a></td>
  </tr>
</table>

<!-- ALL-CONTRIBUTORS-LIST:END -->

# 0.1.3-beta (2017-06-16)
Added support for Arrays and Lists of primitive types mapping(*int*, *decimal*, *string*, etc)

# 0.1.1-beta (2017-03-23)
Added support for *Dictionary<,>* mapping

# 0.1.0-beta (2016-10-06)
First working version is released. Its Api provides two public methods:

* DeepCopyTo<T>(destination)

```c#
public void Foo()
{
    Bar bar = new Bar();
    
    Bar newBar = bar.DeepCopyTo<Bar>();
}
```

* Map(source, destination)

```c#
public void Foo()
{
    Bar bar = new Bar() { Guid = Guid.NewGuid(), String = "string", Int = 123 };
    Bar newBar = new Bar();
    
    Mapper.Map(bar, newBar);
}
```

It supports a limited amount of mapping configuration(which are unit tested):
* mapping Arrays and Lists by having the source and destination of the same type
* mapping Arrays and Lists by having the source and destination of different types
* mapping source and destination of the same type
* mapping source and destination of different types
* mapping for aggregate types
* mapping for objects having circular reference

# 0.0.1-alpha (2016-10-05)
This is a pre-beta release version which contains no actual code. It is a simple test of publishing a NuGet package.

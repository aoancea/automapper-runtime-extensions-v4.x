# 0.1.0-beta (2016-10-06)
First working version is released. Its Api provides two public methods

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
    
    Mapper.Map(bar, destination);
}
```

# 0.0.1-alpha (2016-10-05)
This is a pre-beta release version which contains no actual code. It is a simple test of publishing a NuGet package.

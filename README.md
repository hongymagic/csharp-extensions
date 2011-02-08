# C# Extensions #

Set of useful C# extension methods that I use on a daily basis. First initial commit
contains list extensions for Arrays that mimic JavaScript Array-like syntax.

## Arrays ##

    // given
    var podium = new[] { 1, 2, 3 };

### Push ###

    ArrayExtensions.Push(ref podium, 4);
    // podium = {1, 2, 3, 4}

### Pop ###

    var popped = ArrayExtensions.Pop(ref podium);
    // popped = 4
    // podium = {1, 2, 3}

### Shift ###

    var shifted = ArrayExtensions.Shift(ref a);
    // shifted = 1
    // podium = {2, 3}
    
### Filter ###

    var filtered = podium.Filter(x => x == 2);
    // filtered = {2}
    // podium = {2, 3}

### Map ###

    var mapped = podium.Map(x => x * 2);
    // mapped = {4, 6}
    // podium = {2, 3}

## How to contribute ##

If you have anything you wish to add, send me a pull request.

## TODO ##

- Add more useful string, dictionary, object extensions
- Provide some examples other than test project (?)
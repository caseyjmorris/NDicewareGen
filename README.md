# NDicewareGen
A .NET Diceware password generator

# What is it?
I read about [Diceware](http://world.std.com/~reinhold/diceware.html) and 
thought it was a neat idea but that I'd like to do it on the computer.  Here we are.

# Are these passwords truly random?
Well, the words are scrambled with 
[RNGCryptoServiceProvider](https://msdn.microsoft.com/en-us/library/system.security.cryptography.rngcryptoserviceprovider%28v=vs.110%29.aspx),
so, they're as good as the implementation of that.  [Arnold Reinhold claims Java's secureRandom is OK and I imagine that is roughly comparable](http://world.std.com/~reinhold/dicewarefaq.html#computer), but of course it may be more secure to go through the tedious dice and paper method if you don't trust the random number generator.

# What is needed to run it?
Just the program and a dictionary file with words separated by line breaks, like one of these:  

* http://world.std.com/~reinhold/diceware8k.txt
* https://users.cs.duke.edu/~ola/ap/linuxwords

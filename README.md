# NDicewareGen
A .NET Diceware password generator

# What is it?
I read about [Diceware](http://world.std.com/~reinhold/diceware.html) and 
thought it was a neat idea but that I'd like to do it on the computer.  Here we are.

# Are these passwords truly random?
Well, the words are scrambled with 
RNGCryptoServiceProvider (https://msdn.microsoft.com/en-us/library/system.security.cryptography.rngcryptoserviceprovider(v=vs.110).aspx),
so, they're as good as the implementation of that.

# What is needed to run it?
Just the program and a dictionary file with words separated by line breaks, like the one here:  http://world.std.com/~reinhold/diceware8k.txt

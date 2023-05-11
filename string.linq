<Query Kind="Statements" />

var message = "abcabb";

Console.WriteLine(message.Length);

var starting = "a";
var ending = "z";

for(int i=0; i<message.Length; i++) {

	var difference = (int)ending[0] - ((int)message[i] - (int)starting[0]);
	
	Console.WriteLine("{0}", (char)difference);
}

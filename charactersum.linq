<Query Kind="Statements" />

string s = "abbddeeiossddcc";

string vowels = "aeious";

Console.WriteLine(s);

string vowelResult = "";
string consonantsResult = "";

foreach(var vowel in s) {	
	if(vowels.Contains(vowel)) {
		vowelResult += vowel.ToString();
	} else {
		consonantsResult+= vowel.ToString();
	}
}

//Console.WriteLine("P1 :{0} & P2: {1}",vowelResult,consonantsResult);

char start = 'a';

var index = (int)start;


Func<string, int> CharacterSum = (string s) => {
	int characterSum = 0;
	foreach(var i in s) {
		characterSum +=((int)i + 1) - index;
	}
	return characterSum;
};

var vowelSum = CharacterSum(vowelResult);
var consonantSum = CharacterSum(consonantsResult);

if (vowelSum > consonantSum) {
	Console.WriteLine("vowels wins {0}", vowelSum);
} else {
	Console.WriteLine("consonants wins {1}", consonantSum);
}
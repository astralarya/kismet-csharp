//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from KismetLexer.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace KismetLanguage.Grammar {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public partial class KismetLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LPAREN=1, RPAREN=2, PLUS=3, MINUS=4, TIMES=5, DIV=6, IDIV=7, MOD=8, GT=9, 
		LT=10, GTE=11, LTE=12, EQ=13, NEQ=14, AND=15, OR=16, COMMA=17, POINT=18, 
		POW=19, ROLL=20, ROLL_FUNC=21, DIE=22, PI=23, EULER=24, I=25, VARIABLE=26, 
		NUMBER=27, WHITESPACE=28;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LPAREN", "RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "IDIV", "MOD", "GT", 
		"LT", "GTE", "LTE", "EQ", "NEQ", "AND", "OR", "COMMA", "POINT", "POW", 
		"ROLL", "ROLL_FUNC", "DIE", "PI", "EULER", "I", "VARIABLE", "ID_START", 
		"ID_CHAR", "NUMBER", "NUMBER_PART", "E1", "E2", "SIGN", "WHITESPACE"
	};


	public KismetLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public KismetLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'+'", "'-'", "'*'", "'/'", "'//'", "'%'", "'>'", 
		"'<'", null, null, "'=='", null, "'&&'", "'||'", "','", "'.'", "'^'", 
		null, null, null, "'pi'", null, "'i'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LPAREN", "RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "IDIV", "MOD", 
		"GT", "LT", "GTE", "LTE", "EQ", "NEQ", "AND", "OR", "COMMA", "POINT", 
		"POW", "ROLL", "ROLL_FUNC", "DIE", "PI", "EULER", "I", "VARIABLE", "NUMBER", 
		"WHITESPACE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "KismetLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static KismetLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1E', '\xC1', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x5', '\f', '`', 
		'\n', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x5', '\r', '\x65', 
		'\n', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x5', '\xF', 'm', '\n', '\xF', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x15', '\x3', '\x15', '\x6', '\x15', '}', '\n', '\x15', 
		'\r', '\x15', '\xE', '\x15', '~', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', 
		'\x1A', '\x3', '\x1B', '\x3', '\x1B', '\a', '\x1B', '\x90', '\n', '\x1B', 
		'\f', '\x1B', '\xE', '\x1B', '\x93', '\v', '\x1B', '\x3', '\x1C', '\x5', 
		'\x1C', '\x96', '\n', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x5', '\x1D', 
		'\x9A', '\n', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x5', 
		'\x1E', '\x9F', '\n', '\x1E', '\x3', '\x1E', '\x5', '\x1E', '\xA2', '\n', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x5', '\x1E', '\xA6', '\n', '\x1E', 
		'\x3', '\x1F', '\x6', '\x1F', '\xA9', '\n', '\x1F', '\r', '\x1F', '\xE', 
		'\x1F', '\xAA', '\x3', '\x1F', '\x3', '\x1F', '\x6', '\x1F', '\xAF', '\n', 
		'\x1F', '\r', '\x1F', '\xE', '\x1F', '\xB0', '\x5', '\x1F', '\xB3', '\n', 
		'\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', 
		'\"', '\x3', '#', '\x6', '#', '\xBC', '\n', '#', '\r', '#', '\xE', '#', 
		'\xBD', '\x3', '#', '\x3', '#', '\x2', '\x2', '$', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', 
		'%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', 
		'\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x2', 
		'\x39', '\x2', ';', '\x1D', '=', '\x2', '?', '\x2', '\x41', '\x2', '\x43', 
		'\x2', '\x45', '\x1E', '\x3', '\x2', '\x6', '\x4', '\x2', '\x46', '\x46', 
		'\x66', '\x66', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', 
		'\x4', '\x2', '-', '-', '/', '/', '\x5', '\x2', '\v', '\f', '\xF', '\xF', 
		'\"', '\"', '\x2', '\xC7', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '\x3', 'G', '\x3', '\x2', '\x2', '\x2', '\x5', 'I', 
		'\x3', '\x2', '\x2', '\x2', '\a', 'K', '\x3', '\x2', '\x2', '\x2', '\t', 
		'M', '\x3', '\x2', '\x2', '\x2', '\v', 'O', '\x3', '\x2', '\x2', '\x2', 
		'\r', 'Q', '\x3', '\x2', '\x2', '\x2', '\xF', 'S', '\x3', '\x2', '\x2', 
		'\x2', '\x11', 'V', '\x3', '\x2', '\x2', '\x2', '\x13', 'X', '\x3', '\x2', 
		'\x2', '\x2', '\x15', 'Z', '\x3', '\x2', '\x2', '\x2', '\x17', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x64', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\x66', '\x3', '\x2', '\x2', '\x2', '\x1D', 'l', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', 'n', '\x3', '\x2', '\x2', '\x2', '!', 'q', '\x3', '\x2', 
		'\x2', '\x2', '#', 't', '\x3', '\x2', '\x2', '\x2', '%', 'v', '\x3', '\x2', 
		'\x2', '\x2', '\'', 'x', '\x3', '\x2', '\x2', '\x2', ')', 'z', '\x3', 
		'\x2', '\x2', '\x2', '+', '\x80', '\x3', '\x2', '\x2', '\x2', '-', '\x84', 
		'\x3', '\x2', '\x2', '\x2', '/', '\x86', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x89', '\x3', '\x2', '\x2', '\x2', '\x33', '\x8B', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x37', '\x95', '\x3', 
		'\x2', '\x2', '\x2', '\x39', '\x99', '\x3', '\x2', '\x2', '\x2', ';', 
		'\x9B', '\x3', '\x2', '\x2', '\x2', '=', '\xA8', '\x3', '\x2', '\x2', 
		'\x2', '?', '\xB4', '\x3', '\x2', '\x2', '\x2', '\x41', '\xB6', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\xB8', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\xBB', '\x3', '\x2', '\x2', '\x2', 'G', 'H', '\a', '*', '\x2', '\x2', 
		'H', '\x4', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', '+', '\x2', '\x2', 
		'J', '\x6', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', '-', '\x2', '\x2', 
		'L', '\b', '\x3', '\x2', '\x2', '\x2', 'M', 'N', '\a', '/', '\x2', '\x2', 
		'N', '\n', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', ',', '\x2', '\x2', 
		'P', '\f', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\a', '\x31', '\x2', 
		'\x2', 'R', '\xE', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\a', '\x31', 
		'\x2', '\x2', 'T', 'U', '\a', '\x31', '\x2', '\x2', 'U', '\x10', '\x3', 
		'\x2', '\x2', '\x2', 'V', 'W', '\a', '\'', '\x2', '\x2', 'W', '\x12', 
		'\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\a', '@', '\x2', '\x2', 'Y', '\x14', 
		'\x3', '\x2', '\x2', '\x2', 'Z', '[', '\a', '>', '\x2', '\x2', '[', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\\', ']', '\a', '@', '\x2', '\x2', ']', '`', 
		'\a', '?', '\x2', '\x2', '^', '`', '\a', '\x2267', '\x2', '\x2', '_', 
		'\\', '\x3', '\x2', '\x2', '\x2', '_', '^', '\x3', '\x2', '\x2', '\x2', 
		'`', '\x18', '\x3', '\x2', '\x2', '\x2', '\x61', '\x62', '\a', '>', '\x2', 
		'\x2', '\x62', '\x65', '\a', '?', '\x2', '\x2', '\x63', '\x65', '\a', 
		'\x2266', '\x2', '\x2', '\x64', '\x61', '\x3', '\x2', '\x2', '\x2', '\x64', 
		'\x63', '\x3', '\x2', '\x2', '\x2', '\x65', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x66', 'g', '\a', '?', '\x2', '\x2', 'g', 'h', '\a', '?', '\x2', 
		'\x2', 'h', '\x1C', '\x3', '\x2', '\x2', '\x2', 'i', 'j', '\a', '#', '\x2', 
		'\x2', 'j', 'm', '\a', '?', '\x2', '\x2', 'k', 'm', '\a', '\x2262', '\x2', 
		'\x2', 'l', 'i', '\x3', '\x2', '\x2', '\x2', 'l', 'k', '\x3', '\x2', '\x2', 
		'\x2', 'm', '\x1E', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', '(', '\x2', 
		'\x2', 'o', 'p', '\a', '(', '\x2', '\x2', 'p', ' ', '\x3', '\x2', '\x2', 
		'\x2', 'q', 'r', '\a', '~', '\x2', '\x2', 'r', 's', '\a', '~', '\x2', 
		'\x2', 's', '\"', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\a', '.', '\x2', 
		'\x2', 'u', '$', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', '\x30', '\x2', 
		'\x2', 'w', '&', '\x3', '\x2', '\x2', '\x2', 'x', 'y', '\a', '`', '\x2', 
		'\x2', 'y', '(', '\x3', '\x2', '\x2', '\x2', 'z', '|', '\x5', '-', '\x17', 
		'\x2', '{', '}', '\x4', '\x32', ';', '\x2', '|', '{', '\x3', '\x2', '\x2', 
		'\x2', '}', '~', '\x3', '\x2', '\x2', '\x2', '~', '|', '\x3', '\x2', '\x2', 
		'\x2', '~', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x7F', '*', '\x3', '\x2', 
		'\x2', '\x2', '\x80', '\x81', '\x5', '-', '\x17', '\x2', '\x81', '\x82', 
		'\a', '\x30', '\x2', '\x2', '\x82', '\x83', '\x5', '\x35', '\x1B', '\x2', 
		'\x83', ',', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\t', '\x2', 
		'\x2', '\x2', '\x85', '.', '\x3', '\x2', '\x2', '\x2', '\x86', '\x87', 
		'\a', 'r', '\x2', '\x2', '\x87', '\x88', '\a', 'k', '\x2', '\x2', '\x88', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', '\x5', '\x41', '!', 
		'\x2', '\x8A', '\x32', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x8C', '\a', 
		'k', '\x2', '\x2', '\x8C', '\x34', '\x3', '\x2', '\x2', '\x2', '\x8D', 
		'\x91', '\x5', '\x37', '\x1C', '\x2', '\x8E', '\x90', '\x5', '\x39', '\x1D', 
		'\x2', '\x8F', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x90', '\x93', '\x3', 
		'\x2', '\x2', '\x2', '\x91', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x91', 
		'\x92', '\x3', '\x2', '\x2', '\x2', '\x92', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\x93', '\x91', '\x3', '\x2', '\x2', '\x2', '\x94', '\x96', '\t', 
		'\x3', '\x2', '\x2', '\x95', '\x94', '\x3', '\x2', '\x2', '\x2', '\x96', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\x97', '\x9A', '\x5', '\x37', '\x1C', 
		'\x2', '\x98', '\x9A', '\x4', '\x32', ';', '\x2', '\x99', '\x97', '\x3', 
		'\x2', '\x2', '\x2', '\x99', '\x98', '\x3', '\x2', '\x2', '\x2', '\x9A', 
		':', '\x3', '\x2', '\x2', '\x2', '\x9B', '\xA5', '\x5', '=', '\x1F', '\x2', 
		'\x9C', '\x9F', '\x5', '?', ' ', '\x2', '\x9D', '\x9F', '\x5', '\x41', 
		'!', '\x2', '\x9E', '\x9C', '\x3', '\x2', '\x2', '\x2', '\x9E', '\x9D', 
		'\x3', '\x2', '\x2', '\x2', '\x9F', '\xA1', '\x3', '\x2', '\x2', '\x2', 
		'\xA0', '\xA2', '\x5', '\x43', '\"', '\x2', '\xA1', '\xA0', '\x3', '\x2', 
		'\x2', '\x2', '\xA1', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', 
		'\x3', '\x2', '\x2', '\x2', '\xA3', '\xA4', '\x5', '=', '\x1F', '\x2', 
		'\xA4', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA5', '\x9E', '\x3', '\x2', 
		'\x2', '\x2', '\xA5', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA6', '<', 
		'\x3', '\x2', '\x2', '\x2', '\xA7', '\xA9', '\x4', '\x32', ';', '\x2', 
		'\xA8', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', '\x3', '\x2', 
		'\x2', '\x2', '\xAA', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', 
		'\x3', '\x2', '\x2', '\x2', '\xAB', '\xB2', '\x3', '\x2', '\x2', '\x2', 
		'\xAC', '\xAE', '\a', '\x30', '\x2', '\x2', '\xAD', '\xAF', '\x4', '\x32', 
		';', '\x2', '\xAE', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xB0', 
		'\x3', '\x2', '\x2', '\x2', '\xB0', '\xAE', '\x3', '\x2', '\x2', '\x2', 
		'\xB0', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xB3', '\x3', '\x2', 
		'\x2', '\x2', '\xB2', '\xAC', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB3', 
		'\x3', '\x2', '\x2', '\x2', '\xB3', '>', '\x3', '\x2', '\x2', '\x2', '\xB4', 
		'\xB5', '\a', 'G', '\x2', '\x2', '\xB5', '@', '\x3', '\x2', '\x2', '\x2', 
		'\xB6', '\xB7', '\a', 'g', '\x2', '\x2', '\xB7', '\x42', '\x3', '\x2', 
		'\x2', '\x2', '\xB8', '\xB9', '\t', '\x4', '\x2', '\x2', '\xB9', '\x44', 
		'\x3', '\x2', '\x2', '\x2', '\xBA', '\xBC', '\t', '\x5', '\x2', '\x2', 
		'\xBB', '\xBA', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\x3', '\x2', 
		'\x2', '\x2', '\xBD', '\xBB', '\x3', '\x2', '\x2', '\x2', '\xBD', '\xBE', 
		'\x3', '\x2', '\x2', '\x2', '\xBE', '\xBF', '\x3', '\x2', '\x2', '\x2', 
		'\xBF', '\xC0', '\b', '#', '\x2', '\x2', '\xC0', '\x46', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x2', '_', '\x64', 'l', '~', '\x91', '\x95', '\x99', 
		'\x9E', '\xA1', '\xA5', '\xAA', '\xB0', '\xB2', '\xBD', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace KismetLanguage.Grammar
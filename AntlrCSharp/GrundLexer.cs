//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from e:\coding\test\AntlrCSharp\Grund.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class GrundLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, WHILE=22, FUNC=23, BOOL_OPERATOR=24, 
		INTEGER=25, FLOAT=26, STRING=27, BOOL=28, NULL=29, WS=30, LINE_COMMENT=31, 
		IDENTIFIER=32;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "WHILE", "FUNC", "BOOL_OPERATOR", 
		"INTEGER", "FLOAT", "STRING", "BOOL", "NULL", "WS", "LINE_COMMENT", "IDENTIFIER"
	};


	public GrundLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public GrundLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'IF'", "'ELSE'", "'='", "'('", "','", "')'", "'!'", "'*'", 
		"'/'", "'%'", "'+'", "'-'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", 
		"':'", "'END'", null, "'FUNC'", null, null, null, null, null, "'NULL'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, "WHILE", "FUNC", 
		"BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "BOOL", "NULL", "WS", "LINE_COMMENT", 
		"IDENTIFIER"
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

	public override string GrammarFileName { get { return "Grund.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static GrundLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\"', '\xDE', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
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
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', 
		'\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x5', '\x17', 
		'\x83', '\n', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x5', 
		'\x19', '\x92', '\n', '\x19', '\x3', '\x1A', '\x6', '\x1A', '\x95', '\n', 
		'\x1A', '\r', '\x1A', '\xE', '\x1A', '\x96', '\x3', '\x1B', '\x6', '\x1B', 
		'\x9A', '\n', '\x1B', '\r', '\x1B', '\xE', '\x1B', '\x9B', '\x3', '\x1B', 
		'\x3', '\x1B', '\x6', '\x1B', '\xA0', '\n', '\x1B', '\r', '\x1B', '\xE', 
		'\x1B', '\xA1', '\x3', '\x1C', '\x3', '\x1C', '\a', '\x1C', '\xA6', '\n', 
		'\x1C', '\f', '\x1C', '\xE', '\x1C', '\xA9', '\v', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1C', '\a', '\x1C', '\xAE', '\n', '\x1C', '\f', 
		'\x1C', '\xE', '\x1C', '\xB1', '\v', '\x1C', '\x3', '\x1C', '\x5', '\x1C', 
		'\xB4', '\n', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', 
		'\x1D', '\x5', '\x1D', '\xBF', '\n', '\x1D', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x6', '\x1F', 
		'\xC7', '\n', '\x1F', '\r', '\x1F', '\xE', '\x1F', '\xC8', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\a', ' ', 
		'\xD1', '\n', ' ', '\f', ' ', '\xE', ' ', '\xD4', '\v', ' ', '\x3', ' ', 
		'\x3', ' ', '\x3', '!', '\x3', '!', '\a', '!', '\xDA', '\n', '!', '\f', 
		'!', '\xE', '!', '\xDD', '\v', '!', '\x2', '\x2', '\"', '\x3', '\x3', 
		'\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', 
		'\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', 
		'/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x3', 
		'\x2', '\t', '\x3', '\x2', '\x32', ';', '\x3', '\x2', '$', '$', '\x3', 
		'\x2', ')', ')', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', 
		'\x2', '\f', '\f', '\xF', '\xF', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x2', '\xEA', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x3', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '\x45', '\x3', '\x2', '\x2', '\x2', '\a', 'H', '\x3', 
		'\x2', '\x2', '\x2', '\t', 'M', '\x3', '\x2', '\x2', '\x2', '\v', 'O', 
		'\x3', '\x2', '\x2', '\x2', '\r', 'Q', '\x3', '\x2', '\x2', '\x2', '\xF', 
		'S', '\x3', '\x2', '\x2', '\x2', '\x11', 'U', '\x3', '\x2', '\x2', '\x2', 
		'\x13', 'W', '\x3', '\x2', '\x2', '\x2', '\x15', 'Y', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '[', '\x3', '\x2', '\x2', '\x2', '\x19', ']', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', '_', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '\x1F', '\x64', '\x3', '\x2', '\x2', '\x2', 
		'!', 'g', '\x3', '\x2', '\x2', '\x2', '#', 'i', '\x3', '\x2', '\x2', '\x2', 
		'%', 'k', '\x3', '\x2', '\x2', '\x2', '\'', 'n', '\x3', '\x2', '\x2', 
		'\x2', ')', 'q', '\x3', '\x2', '\x2', '\x2', '+', 's', '\x3', '\x2', '\x2', 
		'\x2', '-', '\x82', '\x3', '\x2', '\x2', '\x2', '/', '\x84', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x91', '\x3', '\x2', '\x2', '\x2', '\x33', '\x94', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x99', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\xB3', '\x3', '\x2', '\x2', '\x2', '\x39', '\xBE', '\x3', '\x2', 
		'\x2', '\x2', ';', '\xC0', '\x3', '\x2', '\x2', '\x2', '=', '\xC6', '\x3', 
		'\x2', '\x2', '\x2', '?', '\xCC', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\xD7', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\a', '=', '\x2', 
		'\x2', '\x44', '\x4', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\a', 
		'K', '\x2', '\x2', '\x46', 'G', '\a', 'H', '\x2', '\x2', 'G', '\x6', '\x3', 
		'\x2', '\x2', '\x2', 'H', 'I', '\a', 'G', '\x2', '\x2', 'I', 'J', '\a', 
		'N', '\x2', '\x2', 'J', 'K', '\a', 'U', '\x2', '\x2', 'K', 'L', '\a', 
		'G', '\x2', '\x2', 'L', '\b', '\x3', '\x2', '\x2', '\x2', 'M', 'N', '\a', 
		'?', '\x2', '\x2', 'N', '\n', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', 
		'*', '\x2', '\x2', 'P', '\f', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\a', 
		'.', '\x2', '\x2', 'R', '\xE', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\a', 
		'+', '\x2', '\x2', 'T', '\x10', '\x3', '\x2', '\x2', '\x2', 'U', 'V', 
		'\a', '#', '\x2', '\x2', 'V', '\x12', '\x3', '\x2', '\x2', '\x2', 'W', 
		'X', '\a', ',', '\x2', '\x2', 'X', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'Y', 'Z', '\a', '\x31', '\x2', '\x2', 'Z', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '[', '\\', '\a', '\'', '\x2', '\x2', '\\', '\x18', '\x3', '\x2', 
		'\x2', '\x2', ']', '^', '\a', '-', '\x2', '\x2', '^', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', '_', '`', '\a', '/', '\x2', '\x2', '`', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '\x61', '\x62', '\a', '?', '\x2', '\x2', '\x62', '\x63', 
		'\a', '?', '\x2', '\x2', '\x63', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x64', 
		'\x65', '\a', '#', '\x2', '\x2', '\x65', '\x66', '\a', '?', '\x2', '\x2', 
		'\x66', ' ', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\a', '@', '\x2', '\x2', 
		'h', '\"', '\x3', '\x2', '\x2', '\x2', 'i', 'j', '\a', '>', '\x2', '\x2', 
		'j', '$', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\a', '@', '\x2', '\x2', 
		'l', 'm', '\a', '?', '\x2', '\x2', 'm', '&', '\x3', '\x2', '\x2', '\x2', 
		'n', 'o', '\a', '>', '\x2', '\x2', 'o', 'p', '\a', '?', '\x2', '\x2', 
		'p', '(', '\x3', '\x2', '\x2', '\x2', 'q', 'r', '\a', '<', '\x2', '\x2', 
		'r', '*', '\x3', '\x2', '\x2', '\x2', 's', 't', '\a', 'G', '\x2', '\x2', 
		't', 'u', '\a', 'P', '\x2', '\x2', 'u', 'v', '\a', '\x46', '\x2', '\x2', 
		'v', ',', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\a', 'Y', '\x2', '\x2', 
		'x', 'y', '\a', 'J', '\x2', '\x2', 'y', 'z', '\a', 'K', '\x2', '\x2', 
		'z', '{', '\a', 'N', '\x2', '\x2', '{', '\x83', '\a', 'G', '\x2', '\x2', 
		'|', '}', '\a', 'W', '\x2', '\x2', '}', '~', '\a', 'P', '\x2', '\x2', 
		'~', '\x7F', '\a', 'N', '\x2', '\x2', '\x7F', '\x80', '\a', 'G', '\x2', 
		'\x2', '\x80', '\x81', '\a', 'U', '\x2', '\x2', '\x81', '\x83', '\a', 
		'U', '\x2', '\x2', '\x82', 'w', '\x3', '\x2', '\x2', '\x2', '\x82', '|', 
		'\x3', '\x2', '\x2', '\x2', '\x83', '.', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'\x85', '\a', 'H', '\x2', '\x2', '\x85', '\x86', '\a', 'W', '\x2', '\x2', 
		'\x86', '\x87', '\a', 'P', '\x2', '\x2', '\x87', '\x88', '\a', '\x45', 
		'\x2', '\x2', '\x88', '\x30', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', 
		'\a', '\x43', '\x2', '\x2', '\x8A', '\x8B', '\a', 'P', '\x2', '\x2', '\x8B', 
		'\x92', '\a', '\x46', '\x2', '\x2', '\x8C', '\x8D', '\a', 'Q', '\x2', 
		'\x2', '\x8D', '\x92', '\a', 'T', '\x2', '\x2', '\x8E', '\x8F', '\a', 
		'Z', '\x2', '\x2', '\x8F', '\x90', '\a', 'Q', '\x2', '\x2', '\x90', '\x92', 
		'\a', 'T', '\x2', '\x2', '\x91', '\x89', '\x3', '\x2', '\x2', '\x2', '\x91', 
		'\x8C', '\x3', '\x2', '\x2', '\x2', '\x91', '\x8E', '\x3', '\x2', '\x2', 
		'\x2', '\x92', '\x32', '\x3', '\x2', '\x2', '\x2', '\x93', '\x95', '\t', 
		'\x2', '\x2', '\x2', '\x94', '\x93', '\x3', '\x2', '\x2', '\x2', '\x95', 
		'\x96', '\x3', '\x2', '\x2', '\x2', '\x96', '\x94', '\x3', '\x2', '\x2', 
		'\x2', '\x96', '\x97', '\x3', '\x2', '\x2', '\x2', '\x97', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\x98', '\x9A', '\t', '\x2', '\x2', '\x2', '\x99', 
		'\x98', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9B', '\x3', '\x2', '\x2', 
		'\x2', '\x9B', '\x99', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\x3', 
		'\x2', '\x2', '\x2', '\x9C', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9D', 
		'\x9F', '\a', '\x30', '\x2', '\x2', '\x9E', '\xA0', '\t', '\x2', '\x2', 
		'\x2', '\x9F', '\x9E', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', 
		'\x2', '\x2', '\x2', '\xA1', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xA1', 
		'\xA2', '\x3', '\x2', '\x2', '\x2', '\xA2', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\xA3', '\xA7', '\a', '$', '\x2', '\x2', '\xA4', '\xA6', '\n', 
		'\x3', '\x2', '\x2', '\xA5', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA6', 
		'\xA9', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA5', '\x3', '\x2', '\x2', 
		'\x2', '\xA7', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xAA', '\x3', 
		'\x2', '\x2', '\x2', '\xA9', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xAA', 
		'\xB4', '\a', '$', '\x2', '\x2', '\xAB', '\xAF', '\a', ')', '\x2', '\x2', 
		'\xAC', '\xAE', '\n', '\x4', '\x2', '\x2', '\xAD', '\xAC', '\x3', '\x2', 
		'\x2', '\x2', '\xAE', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xAD', 
		'\x3', '\x2', '\x2', '\x2', '\xAF', '\xB0', '\x3', '\x2', '\x2', '\x2', 
		'\xB0', '\xB2', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xAF', '\x3', '\x2', 
		'\x2', '\x2', '\xB2', '\xB4', '\a', ')', '\x2', '\x2', '\xB3', '\xA3', 
		'\x3', '\x2', '\x2', '\x2', '\xB3', '\xAB', '\x3', '\x2', '\x2', '\x2', 
		'\xB4', '\x38', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\a', 'v', 
		'\x2', '\x2', '\xB6', '\xB7', '\a', 't', '\x2', '\x2', '\xB7', '\xB8', 
		'\a', 'w', '\x2', '\x2', '\xB8', '\xBF', '\a', 'g', '\x2', '\x2', '\xB9', 
		'\xBA', '\a', 'h', '\x2', '\x2', '\xBA', '\xBB', '\a', '\x63', '\x2', 
		'\x2', '\xBB', '\xBC', '\a', 'n', '\x2', '\x2', '\xBC', '\xBD', '\a', 
		'u', '\x2', '\x2', '\xBD', '\xBF', '\a', 'g', '\x2', '\x2', '\xBE', '\xB5', 
		'\x3', '\x2', '\x2', '\x2', '\xBE', '\xB9', '\x3', '\x2', '\x2', '\x2', 
		'\xBF', ':', '\x3', '\x2', '\x2', '\x2', '\xC0', '\xC1', '\a', 'P', '\x2', 
		'\x2', '\xC1', '\xC2', '\a', 'W', '\x2', '\x2', '\xC2', '\xC3', '\a', 
		'N', '\x2', '\x2', '\xC3', '\xC4', '\a', 'N', '\x2', '\x2', '\xC4', '<', 
		'\x3', '\x2', '\x2', '\x2', '\xC5', '\xC7', '\t', '\x5', '\x2', '\x2', 
		'\xC6', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\x3', '\x2', 
		'\x2', '\x2', '\xC8', '\xC6', '\x3', '\x2', '\x2', '\x2', '\xC8', '\xC9', 
		'\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\x3', '\x2', '\x2', '\x2', 
		'\xCA', '\xCB', '\b', '\x1F', '\x2', '\x2', '\xCB', '>', '\x3', '\x2', 
		'\x2', '\x2', '\xCC', '\xCD', '\a', '\x31', '\x2', '\x2', '\xCD', '\xCE', 
		'\a', '\x31', '\x2', '\x2', '\xCE', '\xD2', '\x3', '\x2', '\x2', '\x2', 
		'\xCF', '\xD1', '\n', '\x6', '\x2', '\x2', '\xD0', '\xCF', '\x3', '\x2', 
		'\x2', '\x2', '\xD1', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD0', 
		'\x3', '\x2', '\x2', '\x2', '\xD2', '\xD3', '\x3', '\x2', '\x2', '\x2', 
		'\xD3', '\xD5', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD2', '\x3', '\x2', 
		'\x2', '\x2', '\xD5', '\xD6', '\b', ' ', '\x2', '\x2', '\xD6', '@', '\x3', 
		'\x2', '\x2', '\x2', '\xD7', '\xDB', '\t', '\a', '\x2', '\x2', '\xD8', 
		'\xDA', '\t', '\b', '\x2', '\x2', '\xD9', '\xD8', '\x3', '\x2', '\x2', 
		'\x2', '\xDA', '\xDD', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xD9', '\x3', 
		'\x2', '\x2', '\x2', '\xDB', '\xDC', '\x3', '\x2', '\x2', '\x2', '\xDC', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDB', '\x3', '\x2', '\x2', 
		'\x2', '\xF', '\x2', '\x82', '\x91', '\x96', '\x9B', '\xA1', '\xA7', '\xAF', 
		'\xB3', '\xBE', '\xC8', '\xD2', '\xDB', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}

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
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		IFBLOCK=25, WHILE=26, FUNC=27, BOOL_OPERATOR=28, INTEGER=29, FLOAT=30, 
		STRING=31, BOOL=32, NULL=33, WS=34, LINE_COMMENT=35, IDENTIFIER=36;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "IFBLOCK", 
		"WHILE", "FUNC", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "BOOL", 
		"NULL", "WS", "LINE_COMMENT", "IDENTIFIER"
	};


	public GrundLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public GrundLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'ELSE'", "'='", "'('", "','", "')'", "'!'", "'*'", "'/'", 
		"'%'", "'+'", "'-'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", "'['", 
		"']'", "'{'", "'}'", "':'", "'END'", "'IF'", null, "'FUNK'", null, null, 
		null, null, null, "'NULL'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "IFBLOCK", "WHILE", "FUNC", "BOOL_OPERATOR", "INTEGER", "FLOAT", 
		"STRING", "BOOL", "NULL", "WS", "LINE_COMMENT", "IDENTIFIER"
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
		'\x5964', '\x2', '&', '\xF4', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
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
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', 
		'\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x5', '\x1B', '\x93', 
		'\n', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x5', '\x1D', 
		'\xA2', '\n', '\x1D', '\x3', '\x1E', '\x5', '\x1E', '\xA5', '\n', '\x1E', 
		'\x3', '\x1E', '\x6', '\x1E', '\xA8', '\n', '\x1E', '\r', '\x1E', '\xE', 
		'\x1E', '\xA9', '\x3', '\x1F', '\x5', '\x1F', '\xAD', '\n', '\x1F', '\x3', 
		'\x1F', '\x6', '\x1F', '\xB0', '\n', '\x1F', '\r', '\x1F', '\xE', '\x1F', 
		'\xB1', '\x3', '\x1F', '\x3', '\x1F', '\x6', '\x1F', '\xB6', '\n', '\x1F', 
		'\r', '\x1F', '\xE', '\x1F', '\xB7', '\x3', ' ', '\x3', ' ', '\a', ' ', 
		'\xBC', '\n', ' ', '\f', ' ', '\xE', ' ', '\xBF', '\v', ' ', '\x3', ' ', 
		'\x3', ' ', '\x3', ' ', '\a', ' ', '\xC4', '\n', ' ', '\f', ' ', '\xE', 
		' ', '\xC7', '\v', ' ', '\x3', ' ', '\x5', ' ', '\xCA', '\n', ' ', '\x3', 
		'!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', 
		'!', '\x3', '!', '\x3', '!', '\x5', '!', '\xD5', '\n', '!', '\x3', '\"', 
		'\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x6', 
		'#', '\xDD', '\n', '#', '\r', '#', '\xE', '#', '\xDE', '\x3', '#', '\x3', 
		'#', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '$', '\a', '$', '\xE7', 
		'\n', '$', '\f', '$', '\xE', '$', '\xEA', '\v', '$', '\x3', '$', '\x3', 
		'$', '\x3', '%', '\x3', '%', '\a', '%', '\xF0', '\n', '%', '\f', '%', 
		'\xE', '%', '\xF3', '\v', '%', '\x2', '\x2', '&', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', 
		'%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', 
		'\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', '\x3', '\x2', '\t', '\x3', '\x2', 
		'\x32', ';', '\x3', '\x2', '$', '$', '\x3', '\x2', ')', ')', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', '\x2', '\f', '\f', '\xF', 
		'\xF', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x6', 
		'\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x2', 
		'\x102', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x3', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x5', 'M', '\x3', '\x2', '\x2', '\x2', '\a', 'R', '\x3', '\x2', 
		'\x2', '\x2', '\t', 'T', '\x3', '\x2', '\x2', '\x2', '\v', 'V', '\x3', 
		'\x2', '\x2', '\x2', '\r', 'X', '\x3', '\x2', '\x2', '\x2', '\xF', 'Z', 
		'\x3', '\x2', '\x2', '\x2', '\x11', '\\', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '^', '\x3', '\x2', '\x2', '\x2', '\x15', '`', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x62', '\x3', '\x2', '\x2', '\x2', '\x19', '\x64', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\x66', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'i', '\x3', '\x2', '\x2', '\x2', '\x1F', 'l', '\x3', '\x2', '\x2', '\x2', 
		'!', 'n', '\x3', '\x2', '\x2', '\x2', '#', 'p', '\x3', '\x2', '\x2', '\x2', 
		'%', 's', '\x3', '\x2', '\x2', '\x2', '\'', 'v', '\x3', '\x2', '\x2', 
		'\x2', ')', 'x', '\x3', '\x2', '\x2', '\x2', '+', 'z', '\x3', '\x2', '\x2', 
		'\x2', '-', '|', '\x3', '\x2', '\x2', '\x2', '/', '~', '\x3', '\x2', '\x2', 
		'\x2', '\x31', '\x80', '\x3', '\x2', '\x2', '\x2', '\x33', '\x84', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\x92', '\x3', '\x2', '\x2', '\x2', '\x37', 
		'\x94', '\x3', '\x2', '\x2', '\x2', '\x39', '\xA1', '\x3', '\x2', '\x2', 
		'\x2', ';', '\xA4', '\x3', '\x2', '\x2', '\x2', '=', '\xAC', '\x3', '\x2', 
		'\x2', '\x2', '?', '\xC9', '\x3', '\x2', '\x2', '\x2', '\x41', '\xD4', 
		'\x3', '\x2', '\x2', '\x2', '\x43', '\xD6', '\x3', '\x2', '\x2', '\x2', 
		'\x45', '\xDC', '\x3', '\x2', '\x2', '\x2', 'G', '\xE2', '\x3', '\x2', 
		'\x2', '\x2', 'I', '\xED', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', 
		'=', '\x2', '\x2', 'L', '\x4', '\x3', '\x2', '\x2', '\x2', 'M', 'N', '\a', 
		'G', '\x2', '\x2', 'N', 'O', '\a', 'N', '\x2', '\x2', 'O', 'P', '\a', 
		'U', '\x2', '\x2', 'P', 'Q', '\a', 'G', '\x2', '\x2', 'Q', '\x6', '\x3', 
		'\x2', '\x2', '\x2', 'R', 'S', '\a', '?', '\x2', '\x2', 'S', '\b', '\x3', 
		'\x2', '\x2', '\x2', 'T', 'U', '\a', '*', '\x2', '\x2', 'U', '\n', '\x3', 
		'\x2', '\x2', '\x2', 'V', 'W', '\a', '.', '\x2', '\x2', 'W', '\f', '\x3', 
		'\x2', '\x2', '\x2', 'X', 'Y', '\a', '+', '\x2', '\x2', 'Y', '\xE', '\x3', 
		'\x2', '\x2', '\x2', 'Z', '[', '\a', '#', '\x2', '\x2', '[', '\x10', '\x3', 
		'\x2', '\x2', '\x2', '\\', ']', '\a', ',', '\x2', '\x2', ']', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '^', '_', '\a', '\x31', '\x2', '\x2', '_', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '`', '\x61', '\a', '\'', '\x2', '\x2', 
		'\x61', '\x16', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\a', '-', 
		'\x2', '\x2', '\x63', '\x18', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', 
		'\a', '/', '\x2', '\x2', '\x65', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x66', 
		'g', '\a', '?', '\x2', '\x2', 'g', 'h', '\a', '?', '\x2', '\x2', 'h', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', 'i', 'j', '\a', '#', '\x2', '\x2', 
		'j', 'k', '\a', '?', '\x2', '\x2', 'k', '\x1E', '\x3', '\x2', '\x2', '\x2', 
		'l', 'm', '\a', '@', '\x2', '\x2', 'm', ' ', '\x3', '\x2', '\x2', '\x2', 
		'n', 'o', '\a', '>', '\x2', '\x2', 'o', '\"', '\x3', '\x2', '\x2', '\x2', 
		'p', 'q', '\a', '@', '\x2', '\x2', 'q', 'r', '\a', '?', '\x2', '\x2', 
		'r', '$', '\x3', '\x2', '\x2', '\x2', 's', 't', '\a', '>', '\x2', '\x2', 
		't', 'u', '\a', '?', '\x2', '\x2', 'u', '&', '\x3', '\x2', '\x2', '\x2', 
		'v', 'w', '\a', ']', '\x2', '\x2', 'w', '(', '\x3', '\x2', '\x2', '\x2', 
		'x', 'y', '\a', '_', '\x2', '\x2', 'y', '*', '\x3', '\x2', '\x2', '\x2', 
		'z', '{', '\a', '}', '\x2', '\x2', '{', ',', '\x3', '\x2', '\x2', '\x2', 
		'|', '}', '\a', '\x7F', '\x2', '\x2', '}', '.', '\x3', '\x2', '\x2', '\x2', 
		'~', '\x7F', '\a', '<', '\x2', '\x2', '\x7F', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '\x80', '\x81', '\a', 'G', '\x2', '\x2', '\x81', '\x82', '\a', 
		'P', '\x2', '\x2', '\x82', '\x83', '\a', '\x46', '\x2', '\x2', '\x83', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', 'K', '\x2', 
		'\x2', '\x85', '\x86', '\a', 'H', '\x2', '\x2', '\x86', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\x87', '\x88', '\a', 'Y', '\x2', '\x2', '\x88', 
		'\x89', '\a', 'J', '\x2', '\x2', '\x89', '\x8A', '\a', 'K', '\x2', '\x2', 
		'\x8A', '\x8B', '\a', 'N', '\x2', '\x2', '\x8B', '\x93', '\a', 'G', '\x2', 
		'\x2', '\x8C', '\x8D', '\a', 'W', '\x2', '\x2', '\x8D', '\x8E', '\a', 
		'P', '\x2', '\x2', '\x8E', '\x8F', '\a', 'N', '\x2', '\x2', '\x8F', '\x90', 
		'\a', 'G', '\x2', '\x2', '\x90', '\x91', '\a', 'U', '\x2', '\x2', '\x91', 
		'\x93', '\a', 'U', '\x2', '\x2', '\x92', '\x87', '\x3', '\x2', '\x2', 
		'\x2', '\x92', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x93', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\x94', '\x95', '\a', 'H', '\x2', '\x2', '\x95', 
		'\x96', '\a', 'W', '\x2', '\x2', '\x96', '\x97', '\a', 'P', '\x2', '\x2', 
		'\x97', '\x98', '\a', 'M', '\x2', '\x2', '\x98', '\x38', '\x3', '\x2', 
		'\x2', '\x2', '\x99', '\x9A', '\a', '\x43', '\x2', '\x2', '\x9A', '\x9B', 
		'\a', 'P', '\x2', '\x2', '\x9B', '\xA2', '\a', '\x46', '\x2', '\x2', '\x9C', 
		'\x9D', '\a', 'Q', '\x2', '\x2', '\x9D', '\xA2', '\a', 'T', '\x2', '\x2', 
		'\x9E', '\x9F', '\a', 'Z', '\x2', '\x2', '\x9F', '\xA0', '\a', 'Q', '\x2', 
		'\x2', '\xA0', '\xA2', '\a', 'T', '\x2', '\x2', '\xA1', '\x99', '\x3', 
		'\x2', '\x2', '\x2', '\xA1', '\x9C', '\x3', '\x2', '\x2', '\x2', '\xA1', 
		'\x9E', '\x3', '\x2', '\x2', '\x2', '\xA2', ':', '\x3', '\x2', '\x2', 
		'\x2', '\xA3', '\xA5', '\a', '/', '\x2', '\x2', '\xA4', '\xA3', '\x3', 
		'\x2', '\x2', '\x2', '\xA4', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA5', 
		'\xA7', '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA8', '\t', '\x2', '\x2', 
		'\x2', '\xA7', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\x3', 
		'\x2', '\x2', '\x2', '\xA9', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA9', 
		'\xAA', '\x3', '\x2', '\x2', '\x2', '\xAA', '<', '\x3', '\x2', '\x2', 
		'\x2', '\xAB', '\xAD', '\a', '/', '\x2', '\x2', '\xAC', '\xAB', '\x3', 
		'\x2', '\x2', '\x2', '\xAC', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xAD', 
		'\xAF', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xB0', '\t', '\x2', '\x2', 
		'\x2', '\xAF', '\xAE', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\x3', 
		'\x2', '\x2', '\x2', '\xB1', '\xAF', '\x3', '\x2', '\x2', '\x2', '\xB1', 
		'\xB2', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB3', '\x3', '\x2', '\x2', 
		'\x2', '\xB3', '\xB5', '\a', '\x30', '\x2', '\x2', '\xB4', '\xB6', '\t', 
		'\x2', '\x2', '\x2', '\xB5', '\xB4', '\x3', '\x2', '\x2', '\x2', '\xB6', 
		'\xB7', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xB5', '\x3', '\x2', '\x2', 
		'\x2', '\xB7', '\xB8', '\x3', '\x2', '\x2', '\x2', '\xB8', '>', '\x3', 
		'\x2', '\x2', '\x2', '\xB9', '\xBD', '\a', '$', '\x2', '\x2', '\xBA', 
		'\xBC', '\n', '\x3', '\x2', '\x2', '\xBB', '\xBA', '\x3', '\x2', '\x2', 
		'\x2', '\xBC', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xBD', '\xBB', '\x3', 
		'\x2', '\x2', '\x2', '\xBD', '\xBE', '\x3', '\x2', '\x2', '\x2', '\xBE', 
		'\xC0', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xBD', '\x3', '\x2', '\x2', 
		'\x2', '\xC0', '\xCA', '\a', '$', '\x2', '\x2', '\xC1', '\xC5', '\a', 
		')', '\x2', '\x2', '\xC2', '\xC4', '\n', '\x4', '\x2', '\x2', '\xC3', 
		'\xC2', '\x3', '\x2', '\x2', '\x2', '\xC4', '\xC7', '\x3', '\x2', '\x2', 
		'\x2', '\xC5', '\xC3', '\x3', '\x2', '\x2', '\x2', '\xC5', '\xC6', '\x3', 
		'\x2', '\x2', '\x2', '\xC6', '\xC8', '\x3', '\x2', '\x2', '\x2', '\xC7', 
		'\xC5', '\x3', '\x2', '\x2', '\x2', '\xC8', '\xCA', '\a', ')', '\x2', 
		'\x2', '\xC9', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xC1', '\x3', 
		'\x2', '\x2', '\x2', '\xCA', '@', '\x3', '\x2', '\x2', '\x2', '\xCB', 
		'\xCC', '\a', 'v', '\x2', '\x2', '\xCC', '\xCD', '\a', 't', '\x2', '\x2', 
		'\xCD', '\xCE', '\a', 'w', '\x2', '\x2', '\xCE', '\xD5', '\a', 'g', '\x2', 
		'\x2', '\xCF', '\xD0', '\a', 'h', '\x2', '\x2', '\xD0', '\xD1', '\a', 
		'\x63', '\x2', '\x2', '\xD1', '\xD2', '\a', 'n', '\x2', '\x2', '\xD2', 
		'\xD3', '\a', 'u', '\x2', '\x2', '\xD3', '\xD5', '\a', 'g', '\x2', '\x2', 
		'\xD4', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xCF', '\x3', '\x2', 
		'\x2', '\x2', '\xD5', '\x42', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xD7', 
		'\a', 'P', '\x2', '\x2', '\xD7', '\xD8', '\a', 'W', '\x2', '\x2', '\xD8', 
		'\xD9', '\a', 'N', '\x2', '\x2', '\xD9', '\xDA', '\a', 'N', '\x2', '\x2', 
		'\xDA', '\x44', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xDD', '\t', '\x5', 
		'\x2', '\x2', '\xDC', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', 
		'\x3', '\x2', '\x2', '\x2', '\xDE', '\xDC', '\x3', '\x2', '\x2', '\x2', 
		'\xDE', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xDF', '\xE0', '\x3', '\x2', 
		'\x2', '\x2', '\xE0', '\xE1', '\b', '#', '\x2', '\x2', '\xE1', '\x46', 
		'\x3', '\x2', '\x2', '\x2', '\xE2', '\xE3', '\a', '\x31', '\x2', '\x2', 
		'\xE3', '\xE4', '\a', '\x31', '\x2', '\x2', '\xE4', '\xE8', '\x3', '\x2', 
		'\x2', '\x2', '\xE5', '\xE7', '\n', '\x6', '\x2', '\x2', '\xE6', '\xE5', 
		'\x3', '\x2', '\x2', '\x2', '\xE7', '\xEA', '\x3', '\x2', '\x2', '\x2', 
		'\xE8', '\xE6', '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE9', '\x3', '\x2', 
		'\x2', '\x2', '\xE9', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xEA', '\xE8', 
		'\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\b', '$', '\x2', '\x2', '\xEC', 
		'H', '\x3', '\x2', '\x2', '\x2', '\xED', '\xF1', '\t', '\a', '\x2', '\x2', 
		'\xEE', '\xF0', '\t', '\b', '\x2', '\x2', '\xEF', '\xEE', '\x3', '\x2', 
		'\x2', '\x2', '\xF0', '\xF3', '\x3', '\x2', '\x2', '\x2', '\xF1', '\xEF', 
		'\x3', '\x2', '\x2', '\x2', '\xF1', '\xF2', '\x3', '\x2', '\x2', '\x2', 
		'\xF2', 'J', '\x3', '\x2', '\x2', '\x2', '\xF3', '\xF1', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x2', '\x92', '\xA1', '\xA4', '\xA9', '\xAC', '\xB1', 
		'\xB7', '\xBD', '\xC5', '\xC9', '\xD4', '\xDE', '\xE8', '\xF1', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}

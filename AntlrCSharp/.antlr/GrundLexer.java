// Generated from /home/noah/Desktop/Codeing/Grund-Lang/AntlrCSharp/Grund.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class GrundLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, IFBLOCK=29, WHILE=30, THIS=31, 
		STATIC=32, CLASSPOINTER=33, EXTENDS=34, FUNC=35, STRUCT=36, BOOL_OPERATOR=37, 
		INTEGER=38, FLOAT=39, STRING=40, BOOL=41, NULL=42, WS=43, LINE_COMMENT=44, 
		IDENTIFIER=45;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
			"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
			"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
			"T__25", "T__26", "T__27", "IFBLOCK", "WHILE", "THIS", "STATIC", "CLASSPOINTER", 
			"EXTENDS", "FUNC", "STRUCT", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", 
			"BOOL", "NULL", "WS", "LINE_COMMENT", "IDENTIFIER"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "';'", "'('", "')'", "'ELSE'", "':'", "'END'", "'{'", "'}'", "'='", 
			"'VAR'", "','", "'['", "']'", "'.'", "'!'", "'*'", "'/'", "'%'", "'+'", 
			"'-'", "'++'", "'--'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", 
			"'IF'", null, "'THIS:'", "'STATIC'", "'=>'", "'EXTENDS'", null, "'STRUK'", 
			null, null, null, null, null, "'NULL'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, "IFBLOCK", "WHILE", "THIS", "STATIC", "CLASSPOINTER", 
			"EXTENDS", "FUNC", "STRUCT", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", 
			"BOOL", "NULL", "WS", "LINE_COMMENT", "IDENTIFIER"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public GrundLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Grund.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2/\u0132\b\1\4\2\t"+
		"\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4"+
		",\t,\4-\t-\4.\t.\3\2\3\2\3\3\3\3\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3\6\3\6\3"+
		"\7\3\7\3\7\3\7\3\b\3\b\3\t\3\t\3\n\3\n\3\13\3\13\3\13\3\13\3\f\3\f\3\r"+
		"\3\r\3\16\3\16\3\17\3\17\3\20\3\20\3\21\3\21\3\22\3\22\3\23\3\23\3\24"+
		"\3\24\3\25\3\25\3\26\3\26\3\26\3\27\3\27\3\27\3\30\3\30\3\30\3\31\3\31"+
		"\3\31\3\32\3\32\3\33\3\33\3\34\3\34\3\34\3\35\3\35\3\35\3\36\3\36\3\36"+
		"\3\37\3\37\3\37\3\37\3\37\3\37\3\37\3\37\3\37\3\37\3\37\5\37\u00b1\n\37"+
		"\3 \3 \3 \3 \3 \3 \3!\3!\3!\3!\3!\3!\3!\3\"\3\"\3\"\3#\3#\3#\3#\3#\3#"+
		"\3#\3#\3$\3$\3$\3$\3$\3$\3$\3$\5$\u00d3\n$\3%\3%\3%\3%\3%\3%\3&\3&\3&"+
		"\3&\3&\5&\u00e0\n&\3\'\5\'\u00e3\n\'\3\'\6\'\u00e6\n\'\r\'\16\'\u00e7"+
		"\3(\5(\u00eb\n(\3(\6(\u00ee\n(\r(\16(\u00ef\3(\3(\6(\u00f4\n(\r(\16(\u00f5"+
		"\3)\3)\7)\u00fa\n)\f)\16)\u00fd\13)\3)\3)\3)\7)\u0102\n)\f)\16)\u0105"+
		"\13)\3)\5)\u0108\n)\3*\3*\3*\3*\3*\3*\3*\3*\3*\5*\u0113\n*\3+\3+\3+\3"+
		"+\3+\3,\6,\u011b\n,\r,\16,\u011c\3,\3,\3-\3-\3-\3-\7-\u0125\n-\f-\16-"+
		"\u0128\13-\3-\3-\3.\3.\7.\u012e\n.\f.\16.\u0131\13.\2\2/\3\3\5\4\7\5\t"+
		"\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23"+
		"%\24\'\25)\26+\27-\30/\31\61\32\63\33\65\34\67\359\36;\37= ?!A\"C#E$G"+
		"%I&K\'M(O)Q*S+U,W-Y.[/\3\2\t\3\2\62;\3\2$$\3\2))\5\2\13\f\17\17\"\"\4"+
		"\2\f\f\17\17\5\2C\\aac|\6\2\62;C\\aac|\2\u0140\2\3\3\2\2\2\2\5\3\2\2\2"+
		"\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3"+
		"\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2"+
		"\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3\2"+
		"\2\2\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63\3\2"+
		"\2\2\2\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2;\3\2\2\2\2=\3\2\2\2\2?\3\2"+
		"\2\2\2A\3\2\2\2\2C\3\2\2\2\2E\3\2\2\2\2G\3\2\2\2\2I\3\2\2\2\2K\3\2\2\2"+
		"\2M\3\2\2\2\2O\3\2\2\2\2Q\3\2\2\2\2S\3\2\2\2\2U\3\2\2\2\2W\3\2\2\2\2Y"+
		"\3\2\2\2\2[\3\2\2\2\3]\3\2\2\2\5_\3\2\2\2\7a\3\2\2\2\tc\3\2\2\2\13h\3"+
		"\2\2\2\rj\3\2\2\2\17n\3\2\2\2\21p\3\2\2\2\23r\3\2\2\2\25t\3\2\2\2\27x"+
		"\3\2\2\2\31z\3\2\2\2\33|\3\2\2\2\35~\3\2\2\2\37\u0080\3\2\2\2!\u0082\3"+
		"\2\2\2#\u0084\3\2\2\2%\u0086\3\2\2\2\'\u0088\3\2\2\2)\u008a\3\2\2\2+\u008c"+
		"\3\2\2\2-\u008f\3\2\2\2/\u0092\3\2\2\2\61\u0095\3\2\2\2\63\u0098\3\2\2"+
		"\2\65\u009a\3\2\2\2\67\u009c\3\2\2\29\u009f\3\2\2\2;\u00a2\3\2\2\2=\u00b0"+
		"\3\2\2\2?\u00b2\3\2\2\2A\u00b8\3\2\2\2C\u00bf\3\2\2\2E\u00c2\3\2\2\2G"+
		"\u00d2\3\2\2\2I\u00d4\3\2\2\2K\u00df\3\2\2\2M\u00e2\3\2\2\2O\u00ea\3\2"+
		"\2\2Q\u0107\3\2\2\2S\u0112\3\2\2\2U\u0114\3\2\2\2W\u011a\3\2\2\2Y\u0120"+
		"\3\2\2\2[\u012b\3\2\2\2]^\7=\2\2^\4\3\2\2\2_`\7*\2\2`\6\3\2\2\2ab\7+\2"+
		"\2b\b\3\2\2\2cd\7G\2\2de\7N\2\2ef\7U\2\2fg\7G\2\2g\n\3\2\2\2hi\7<\2\2"+
		"i\f\3\2\2\2jk\7G\2\2kl\7P\2\2lm\7F\2\2m\16\3\2\2\2no\7}\2\2o\20\3\2\2"+
		"\2pq\7\177\2\2q\22\3\2\2\2rs\7?\2\2s\24\3\2\2\2tu\7X\2\2uv\7C\2\2vw\7"+
		"T\2\2w\26\3\2\2\2xy\7.\2\2y\30\3\2\2\2z{\7]\2\2{\32\3\2\2\2|}\7_\2\2}"+
		"\34\3\2\2\2~\177\7\60\2\2\177\36\3\2\2\2\u0080\u0081\7#\2\2\u0081 \3\2"+
		"\2\2\u0082\u0083\7,\2\2\u0083\"\3\2\2\2\u0084\u0085\7\61\2\2\u0085$\3"+
		"\2\2\2\u0086\u0087\7\'\2\2\u0087&\3\2\2\2\u0088\u0089\7-\2\2\u0089(\3"+
		"\2\2\2\u008a\u008b\7/\2\2\u008b*\3\2\2\2\u008c\u008d\7-\2\2\u008d\u008e"+
		"\7-\2\2\u008e,\3\2\2\2\u008f\u0090\7/\2\2\u0090\u0091\7/\2\2\u0091.\3"+
		"\2\2\2\u0092\u0093\7?\2\2\u0093\u0094\7?\2\2\u0094\60\3\2\2\2\u0095\u0096"+
		"\7#\2\2\u0096\u0097\7?\2\2\u0097\62\3\2\2\2\u0098\u0099\7@\2\2\u0099\64"+
		"\3\2\2\2\u009a\u009b\7>\2\2\u009b\66\3\2\2\2\u009c\u009d\7@\2\2\u009d"+
		"\u009e\7?\2\2\u009e8\3\2\2\2\u009f\u00a0\7>\2\2\u00a0\u00a1\7?\2\2\u00a1"+
		":\3\2\2\2\u00a2\u00a3\7K\2\2\u00a3\u00a4\7H\2\2\u00a4<\3\2\2\2\u00a5\u00a6"+
		"\7Y\2\2\u00a6\u00a7\7J\2\2\u00a7\u00a8\7K\2\2\u00a8\u00a9\7N\2\2\u00a9"+
		"\u00b1\7G\2\2\u00aa\u00ab\7W\2\2\u00ab\u00ac\7P\2\2\u00ac\u00ad\7N\2\2"+
		"\u00ad\u00ae\7G\2\2\u00ae\u00af\7U\2\2\u00af\u00b1\7U\2\2\u00b0\u00a5"+
		"\3\2\2\2\u00b0\u00aa\3\2\2\2\u00b1>\3\2\2\2\u00b2\u00b3\7V\2\2\u00b3\u00b4"+
		"\7J\2\2\u00b4\u00b5\7K\2\2\u00b5\u00b6\7U\2\2\u00b6\u00b7\7<\2\2\u00b7"+
		"@\3\2\2\2\u00b8\u00b9\7U\2\2\u00b9\u00ba\7V\2\2\u00ba\u00bb\7C\2\2\u00bb"+
		"\u00bc\7V\2\2\u00bc\u00bd\7K\2\2\u00bd\u00be\7E\2\2\u00beB\3\2\2\2\u00bf"+
		"\u00c0\7?\2\2\u00c0\u00c1\7@\2\2\u00c1D\3\2\2\2\u00c2\u00c3\7G\2\2\u00c3"+
		"\u00c4\7Z\2\2\u00c4\u00c5\7V\2\2\u00c5\u00c6\7G\2\2\u00c6\u00c7\7P\2\2"+
		"\u00c7\u00c8\7F\2\2\u00c8\u00c9\7U\2\2\u00c9F\3\2\2\2\u00ca\u00cb\7H\2"+
		"\2\u00cb\u00cc\7W\2\2\u00cc\u00cd\7P\2\2\u00cd\u00d3\7M\2\2\u00ce\u00cf"+
		"\7O\2\2\u00cf\u00d0\7G\2\2\u00d0\u00d1\7V\2\2\u00d1\u00d3\7J\2\2\u00d2"+
		"\u00ca\3\2\2\2\u00d2\u00ce\3\2\2\2\u00d3H\3\2\2\2\u00d4\u00d5\7U\2\2\u00d5"+
		"\u00d6\7V\2\2\u00d6\u00d7\7T\2\2\u00d7\u00d8\7W\2\2\u00d8\u00d9\7M\2\2"+
		"\u00d9J\3\2\2\2\u00da\u00db\7C\2\2\u00db\u00dc\7P\2\2\u00dc\u00e0\7F\2"+
		"\2\u00dd\u00de\7Q\2\2\u00de\u00e0\7T\2\2\u00df\u00da\3\2\2\2\u00df\u00dd"+
		"\3\2\2\2\u00e0L\3\2\2\2\u00e1\u00e3\7/\2\2\u00e2\u00e1\3\2\2\2\u00e2\u00e3"+
		"\3\2\2\2\u00e3\u00e5\3\2\2\2\u00e4\u00e6\t\2\2\2\u00e5\u00e4\3\2\2\2\u00e6"+
		"\u00e7\3\2\2\2\u00e7\u00e5\3\2\2\2\u00e7\u00e8\3\2\2\2\u00e8N\3\2\2\2"+
		"\u00e9\u00eb\7/\2\2\u00ea\u00e9\3\2\2\2\u00ea\u00eb\3\2\2\2\u00eb\u00ed"+
		"\3\2\2\2\u00ec\u00ee\t\2\2\2\u00ed\u00ec\3\2\2\2\u00ee\u00ef\3\2\2\2\u00ef"+
		"\u00ed\3\2\2\2\u00ef\u00f0\3\2\2\2\u00f0\u00f1\3\2\2\2\u00f1\u00f3\7\60"+
		"\2\2\u00f2\u00f4\t\2\2\2\u00f3\u00f2\3\2\2\2\u00f4\u00f5\3\2\2\2\u00f5"+
		"\u00f3\3\2\2\2\u00f5\u00f6\3\2\2\2\u00f6P\3\2\2\2\u00f7\u00fb\7$\2\2\u00f8"+
		"\u00fa\n\3\2\2\u00f9\u00f8\3\2\2\2\u00fa\u00fd\3\2\2\2\u00fb\u00f9\3\2"+
		"\2\2\u00fb\u00fc\3\2\2\2\u00fc\u00fe\3\2\2\2\u00fd\u00fb\3\2\2\2\u00fe"+
		"\u0108\7$\2\2\u00ff\u0103\7)\2\2\u0100\u0102\n\4\2\2\u0101\u0100\3\2\2"+
		"\2\u0102\u0105\3\2\2\2\u0103\u0101\3\2\2\2\u0103\u0104\3\2\2\2\u0104\u0106"+
		"\3\2\2\2\u0105\u0103\3\2\2\2\u0106\u0108\7)\2\2\u0107\u00f7\3\2\2\2\u0107"+
		"\u00ff\3\2\2\2\u0108R\3\2\2\2\u0109\u010a\7v\2\2\u010a\u010b\7t\2\2\u010b"+
		"\u010c\7w\2\2\u010c\u0113\7g\2\2\u010d\u010e\7h\2\2\u010e\u010f\7c\2\2"+
		"\u010f\u0110\7n\2\2\u0110\u0111\7u\2\2\u0111\u0113\7g\2\2\u0112\u0109"+
		"\3\2\2\2\u0112\u010d\3\2\2\2\u0113T\3\2\2\2\u0114\u0115\7P\2\2\u0115\u0116"+
		"\7W\2\2\u0116\u0117\7N\2\2\u0117\u0118\7N\2\2\u0118V\3\2\2\2\u0119\u011b"+
		"\t\5\2\2\u011a\u0119\3\2\2\2\u011b\u011c\3\2\2\2\u011c\u011a\3\2\2\2\u011c"+
		"\u011d\3\2\2\2\u011d\u011e\3\2\2\2\u011e\u011f\b,\2\2\u011fX\3\2\2\2\u0120"+
		"\u0121\7\61\2\2\u0121\u0122\7\61\2\2\u0122\u0126\3\2\2\2\u0123\u0125\n"+
		"\6\2\2\u0124\u0123\3\2\2\2\u0125\u0128\3\2\2\2\u0126\u0124\3\2\2\2\u0126"+
		"\u0127\3\2\2\2\u0127\u0129\3\2\2\2\u0128\u0126\3\2\2\2\u0129\u012a\b-"+
		"\2\2\u012aZ\3\2\2\2\u012b\u012f\t\7\2\2\u012c\u012e\t\b\2\2\u012d\u012c"+
		"\3\2\2\2\u012e\u0131\3\2\2\2\u012f\u012d\3\2\2\2\u012f\u0130\3\2\2\2\u0130"+
		"\\\3\2\2\2\u0131\u012f\3\2\2\2\22\2\u00b0\u00d2\u00df\u00e2\u00e7\u00ea"+
		"\u00ef\u00f5\u00fb\u0103\u0107\u0112\u011c\u0126\u012f\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
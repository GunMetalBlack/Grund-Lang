// Generated from /home/noah/Desktop/Codeing/Grund-Lang/AntlrCSharp/Grund.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue"})
public class GrundParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, IFBLOCK=28, WHILE=29, THIS=30, STATIC=31, 
		FUNC=32, STRUCT=33, BOOL_OPERATOR=34, INTEGER=35, FLOAT=36, STRING=37, 
		BOOL=38, NULL=39, WS=40, LINE_COMMENT=41, IDENTIFIER=42;
	public static final int
		RULE_program = 0, RULE_line = 1, RULE_statement = 2, RULE_ifBlock = 3, 
		RULE_elseIfBlock = 4, RULE_whileBlock = 5, RULE_blockScopeAssignment = 6, 
		RULE_assignment = 7, RULE_declaration = 8, RULE_functionCall = 9, RULE_inLineIncrement = 10, 
		RULE_parameter = 11, RULE_strucDefinition = 12, RULE_functionDefinition = 13, 
		RULE_expression = 14, RULE_multOP = 15, RULE_addOP = 16, RULE_compareOP = 17, 
		RULE_inLineOP = 18, RULE_boolOP = 19, RULE_constant = 20, RULE_collections = 21, 
		RULE_list = 22, RULE_dictionary = 23, RULE_block = 24;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "line", "statement", "ifBlock", "elseIfBlock", "whileBlock", 
			"blockScopeAssignment", "assignment", "declaration", "functionCall", 
			"inLineIncrement", "parameter", "strucDefinition", "functionDefinition", 
			"expression", "multOP", "addOP", "compareOP", "inLineOP", "boolOP", "constant", 
			"collections", "list", "dictionary", "block"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "';'", "'('", "')'", "'ELSE'", "':'", "'END'", "'{'", "'}'", "'='", 
			"'VAR'", "','", "'['", "']'", "'.'", "'!'", "'*'", "'/'", "'%'", "'+'", 
			"'-'", "'++'", "'--'", "'=='", "'!='", "'<'", "'>='", "'<='", "'IF'", 
			null, "'THIS:'", "'STATIC'", null, "'>'", null, null, null, null, null, 
			"'NULL'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, "IFBLOCK", "WHILE", "THIS", "STATIC", "FUNC", 
			"STRUCT", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "BOOL", "NULL", 
			"WS", "LINE_COMMENT", "IDENTIFIER"
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

	@Override
	public String getGrammarFileName() { return "Grund.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public GrundParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ProgramContext extends ParserRuleContext {
		public TerminalNode EOF() { return getToken(GrundParser.EOF, 0); }
		public List<LineContext> line() {
			return getRuleContexts(LineContext.class);
		}
		public LineContext line(int i) {
			return getRuleContext(LineContext.class,i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_program; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterProgram(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitProgram(this);
		}
	}

	public final ProgramContext program() throws RecognitionException {
		ProgramContext _localctx = new ProgramContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(53);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 5479036130436L) != 0)) {
				{
				{
				setState(50);
				line();
				}
				}
				setState(55);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(56);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LineContext extends ParserRuleContext {
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public IfBlockContext ifBlock() {
			return getRuleContext(IfBlockContext.class,0);
		}
		public WhileBlockContext whileBlock() {
			return getRuleContext(WhileBlockContext.class,0);
		}
		public FunctionDefinitionContext functionDefinition() {
			return getRuleContext(FunctionDefinitionContext.class,0);
		}
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public AssignmentContext assignment() {
			return getRuleContext(AssignmentContext.class,0);
		}
		public InLineIncrementContext inLineIncrement() {
			return getRuleContext(InLineIncrementContext.class,0);
		}
		public StrucDefinitionContext strucDefinition() {
			return getRuleContext(StrucDefinitionContext.class,0);
		}
		public LineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_line; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterLine(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitLine(this);
		}
	}

	public final LineContext line() throws RecognitionException {
		LineContext _localctx = new LineContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_line);
		try {
			setState(66);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(58);
				statement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(59);
				ifBlock();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(60);
				whileBlock();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(61);
				functionDefinition();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(62);
				functionCall();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(63);
				assignment();
				}
				break;
			case 7:
				enterOuterAlt(_localctx, 7);
				{
				setState(64);
				inLineIncrement();
				}
				break;
			case 8:
				enterOuterAlt(_localctx, 8);
				{
				setState(65);
				strucDefinition();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class StatementContext extends ParserRuleContext {
		public AssignmentContext assignment() {
			return getRuleContext(AssignmentContext.class,0);
		}
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public BlockScopeAssignmentContext blockScopeAssignment() {
			return getRuleContext(BlockScopeAssignmentContext.class,0);
		}
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterStatement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitStatement(this);
		}
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_statement);
		int _la;
		try {
			setState(77);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(71);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,2,_ctx) ) {
				case 1:
					{
					setState(68);
					assignment();
					}
					break;
				case 2:
					{
					setState(69);
					functionCall();
					}
					break;
				case 3:
					{
					setState(70);
					blockScopeAssignment();
					}
					break;
				}
				setState(74);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__0) {
					{
					setState(73);
					match(T__0);
					}
				}

				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(76);
				expression(0);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IfBlockContext extends ParserRuleContext {
		public TerminalNode IFBLOCK() { return getToken(GrundParser.IFBLOCK, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public ElseIfBlockContext elseIfBlock() {
			return getRuleContext(ElseIfBlockContext.class,0);
		}
		public IfBlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ifBlock; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterIfBlock(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitIfBlock(this);
		}
	}

	public final IfBlockContext ifBlock() throws RecognitionException {
		IfBlockContext _localctx = new IfBlockContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_ifBlock);
		int _la;
		try {
			setState(101);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(79);
				match(IFBLOCK);
				setState(81);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,5,_ctx) ) {
				case 1:
					{
					setState(80);
					match(T__1);
					}
					break;
				}
				setState(83);
				expression(0);
				setState(85);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__2) {
					{
					setState(84);
					match(T__2);
					}
				}

				setState(87);
				block();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(89);
				match(IFBLOCK);
				setState(91);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
				case 1:
					{
					setState(90);
					match(T__1);
					}
					break;
				}
				setState(93);
				expression(0);
				setState(95);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__2) {
					{
					setState(94);
					match(T__2);
					}
				}

				setState(97);
				block();
				{
				setState(98);
				match(T__3);
				setState(99);
				elseIfBlock();
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ElseIfBlockContext extends ParserRuleContext {
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public IfBlockContext ifBlock() {
			return getRuleContext(IfBlockContext.class,0);
		}
		public ElseIfBlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_elseIfBlock; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterElseIfBlock(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitElseIfBlock(this);
		}
	}

	public final ElseIfBlockContext elseIfBlock() throws RecognitionException {
		ElseIfBlockContext _localctx = new ElseIfBlockContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_elseIfBlock);
		try {
			setState(105);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__4:
			case T__6:
				enterOuterAlt(_localctx, 1);
				{
				setState(103);
				block();
				}
				break;
			case IFBLOCK:
				enterOuterAlt(_localctx, 2);
				{
				setState(104);
				ifBlock();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class WhileBlockContext extends ParserRuleContext {
		public TerminalNode WHILE() { return getToken(GrundParser.WHILE, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public ElseIfBlockContext elseIfBlock() {
			return getRuleContext(ElseIfBlockContext.class,0);
		}
		public WhileBlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_whileBlock; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterWhileBlock(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitWhileBlock(this);
		}
	}

	public final WhileBlockContext whileBlock() throws RecognitionException {
		WhileBlockContext _localctx = new WhileBlockContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_whileBlock);
		try {
			setState(117);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(107);
				match(WHILE);
				setState(108);
				expression(0);
				setState(109);
				block();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(111);
				match(WHILE);
				setState(112);
				expression(0);
				setState(113);
				block();
				{
				setState(114);
				match(T__3);
				setState(115);
				elseIfBlock();
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class BlockScopeAssignmentContext extends ParserRuleContext {
		public TerminalNode STATIC() { return getToken(GrundParser.STATIC, 0); }
		public List<AssignmentContext> assignment() {
			return getRuleContexts(AssignmentContext.class);
		}
		public AssignmentContext assignment(int i) {
			return getRuleContext(AssignmentContext.class,i);
		}
		public BlockScopeAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_blockScopeAssignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterBlockScopeAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitBlockScopeAssignment(this);
		}
	}

	public final BlockScopeAssignmentContext blockScopeAssignment() throws RecognitionException {
		BlockScopeAssignmentContext _localctx = new BlockScopeAssignmentContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_blockScopeAssignment);
		int _la;
		try {
			setState(137);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,14,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(119);
				match(STATIC);
				setState(120);
				match(T__4);
				setState(124);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 5476083340420L) != 0)) {
					{
					{
					setState(121);
					assignment();
					}
					}
					setState(126);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(127);
				match(T__5);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(128);
				match(STATIC);
				setState(129);
				match(T__6);
				setState(133);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 5476083340420L) != 0)) {
					{
					{
					setState(130);
					assignment();
					}
					}
					setState(135);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(136);
				match(T__7);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class AssignmentContext extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitAssignment(this);
		}
	}

	public final AssignmentContext assignment() throws RecognitionException {
		AssignmentContext _localctx = new AssignmentContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_assignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(139);
			expression(0);
			setState(140);
			match(T__8);
			setState(141);
			expression(0);
			setState(143);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,15,_ctx) ) {
			case 1:
				{
				setState(142);
				match(T__0);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class DeclarationContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(GrundParser.IDENTIFIER, 0); }
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterDeclaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitDeclaration(this);
		}
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_declaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(145);
			match(T__9);
			setState(146);
			match(IDENTIFIER);
			setState(148);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,16,_ctx) ) {
			case 1:
				{
				setState(147);
				match(T__0);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class FunctionCallContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(GrundParser.IDENTIFIER, 0); }
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public FunctionCallContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionCall; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterFunctionCall(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitFunctionCall(this);
		}
	}

	public final FunctionCallContext functionCall() throws RecognitionException {
		FunctionCallContext _localctx = new FunctionCallContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_functionCall);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(150);
			match(IDENTIFIER);
			setState(151);
			match(T__1);
			setState(160);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & 5476083340420L) != 0)) {
				{
				setState(152);
				expression(0);
				setState(157);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__10) {
					{
					{
					setState(153);
					match(T__10);
					setState(154);
					expression(0);
					}
					}
					setState(159);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(162);
			match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class InLineIncrementContext extends ParserRuleContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public InLineOPContext inLineOP() {
			return getRuleContext(InLineOPContext.class,0);
		}
		public InLineIncrementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_inLineIncrement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterInLineIncrement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitInLineIncrement(this);
		}
	}

	public final InLineIncrementContext inLineIncrement() throws RecognitionException {
		InLineIncrementContext _localctx = new InLineIncrementContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_inLineIncrement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(164);
			expression(0);
			setState(165);
			inLineOP();
			setState(167);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0) {
				{
				setState(166);
				match(T__0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ParameterContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(GrundParser.IDENTIFIER, 0); }
		public ParameterContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameter; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterParameter(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitParameter(this);
		}
	}

	public final ParameterContext parameter() throws RecognitionException {
		ParameterContext _localctx = new ParameterContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_parameter);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(169);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class StrucDefinitionContext extends ParserRuleContext {
		public TerminalNode STRUCT() { return getToken(GrundParser.STRUCT, 0); }
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public StrucDefinitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_strucDefinition; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterStrucDefinition(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitStrucDefinition(this);
		}
	}

	public final StrucDefinitionContext strucDefinition() throws RecognitionException {
		StrucDefinitionContext _localctx = new StrucDefinitionContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_strucDefinition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(171);
			match(STRUCT);
			setState(172);
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class FunctionDefinitionContext extends ParserRuleContext {
		public TerminalNode FUNC() { return getToken(GrundParser.FUNC, 0); }
		public TerminalNode IDENTIFIER() { return getToken(GrundParser.IDENTIFIER, 0); }
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public List<ParameterContext> parameter() {
			return getRuleContexts(ParameterContext.class);
		}
		public ParameterContext parameter(int i) {
			return getRuleContext(ParameterContext.class,i);
		}
		public FunctionDefinitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionDefinition; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterFunctionDefinition(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitFunctionDefinition(this);
		}
	}

	public final FunctionDefinitionContext functionDefinition() throws RecognitionException {
		FunctionDefinitionContext _localctx = new FunctionDefinitionContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_functionDefinition);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(174);
			match(FUNC);
			setState(175);
			match(IDENTIFIER);
			setState(176);
			match(T__1);
			setState(185);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==IDENTIFIER) {
				{
				setState(177);
				parameter();
				setState(182);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__10) {
					{
					{
					setState(178);
					match(T__10);
					setState(179);
					parameter();
					}
					}
					setState(184);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(187);
			match(T__2);
			setState(188);
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ExpressionContext extends ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	 
		public ExpressionContext() { }
		public void copyFrom(ExpressionContext ctx) {
			super.copyFrom(ctx);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class DotExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public DotExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterDotExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitDotExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ConstantExpressionContext extends ExpressionContext {
		public ConstantContext constant() {
			return getRuleContext(ConstantContext.class,0);
		}
		public ConstantExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterConstantExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitConstantExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class AdditiveExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public AddOPContext addOP() {
			return getRuleContext(AddOPContext.class,0);
		}
		public AdditiveExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterAdditiveExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitAdditiveExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class IdentifierExpressionContext extends ExpressionContext {
		public TerminalNode IDENTIFIER() { return getToken(GrundParser.IDENTIFIER, 0); }
		public IdentifierExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterIdentifierExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitIdentifierExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class FunctionDefinitionExpressionContext extends ExpressionContext {
		public FunctionDefinitionContext functionDefinition() {
			return getRuleContext(FunctionDefinitionContext.class,0);
		}
		public FunctionDefinitionExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterFunctionDefinitionExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitFunctionDefinitionExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class NotExpressionContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public NotExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterNotExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitNotExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ComparisonExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public CompareOPContext compareOP() {
			return getRuleContext(CompareOPContext.class,0);
		}
		public ComparisonExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterComparisonExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitComparisonExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class MultiplicativeExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public MultOPContext multOP() {
			return getRuleContext(MultOPContext.class,0);
		}
		public MultiplicativeExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterMultiplicativeExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitMultiplicativeExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class StrucDefinitionExpressionContext extends ExpressionContext {
		public StrucDefinitionContext strucDefinition() {
			return getRuleContext(StrucDefinitionContext.class,0);
		}
		public StrucDefinitionExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterStrucDefinitionExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitStrucDefinitionExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class BooleanExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public BoolOPContext boolOP() {
			return getRuleContext(BoolOPContext.class,0);
		}
		public BooleanExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterBooleanExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitBooleanExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class CollectionsExpressionContext extends ExpressionContext {
		public CollectionsContext collections() {
			return getRuleContext(CollectionsContext.class,0);
		}
		public CollectionsExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterCollectionsExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitCollectionsExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ParenthesizedExpressionContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public ParenthesizedExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterParenthesizedExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitParenthesizedExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class FunctionCallExpressionContext extends ExpressionContext {
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public FunctionCallExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterFunctionCallExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitFunctionCallExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ListAccessionExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public ListAccessionExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterListAccessionExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitListAccessionExpression(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class DeclarationsExpressionContext extends ExpressionContext {
		public DeclarationContext declaration() {
			return getRuleContext(DeclarationContext.class,0);
		}
		public DeclarationsExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterDeclarationsExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitDeclarationsExpression(this);
		}
	}

	public final ExpressionContext expression() throws RecognitionException {
		return expression(0);
	}

	private ExpressionContext expression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 28;
		enterRecursionRule(_localctx, 28, RULE_expression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(204);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,22,_ctx) ) {
			case 1:
				{
				_localctx = new ConstantExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				setState(191);
				constant();
				}
				break;
			case 2:
				{
				_localctx = new CollectionsExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(192);
				collections();
				}
				break;
			case 3:
				{
				_localctx = new IdentifierExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(193);
				match(IDENTIFIER);
				}
				break;
			case 4:
				{
				_localctx = new DeclarationsExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(194);
				declaration();
				}
				break;
			case 5:
				{
				_localctx = new FunctionDefinitionExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(195);
				functionDefinition();
				}
				break;
			case 6:
				{
				_localctx = new FunctionCallExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(196);
				functionCall();
				}
				break;
			case 7:
				{
				_localctx = new StrucDefinitionExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(197);
				strucDefinition();
				}
				break;
			case 8:
				{
				_localctx = new ParenthesizedExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(198);
				match(T__1);
				setState(199);
				expression(0);
				setState(200);
				match(T__2);
				}
				break;
			case 9:
				{
				_localctx = new NotExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(202);
				match(T__14);
				setState(203);
				expression(5);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(232);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(230);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,23,_ctx) ) {
					case 1:
						{
						_localctx = new DotExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(206);
						if (!(precpred(_ctx, 7))) throw new FailedPredicateException(this, "precpred(_ctx, 7)");
						setState(207);
						match(T__13);
						setState(208);
						expression(8);
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(209);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						setState(210);
						multOP();
						setState(211);
						expression(5);
						}
						break;
					case 3:
						{
						_localctx = new AdditiveExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(213);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(214);
						addOP();
						setState(215);
						expression(4);
						}
						break;
					case 4:
						{
						_localctx = new ComparisonExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(217);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(218);
						compareOP();
						setState(219);
						expression(3);
						}
						break;
					case 5:
						{
						_localctx = new BooleanExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(221);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(222);
						boolOP();
						setState(223);
						expression(2);
						}
						break;
					case 6:
						{
						_localctx = new ListAccessionExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(225);
						if (!(precpred(_ctx, 13))) throw new FailedPredicateException(this, "precpred(_ctx, 13)");
						setState(226);
						match(T__11);
						setState(227);
						expression(0);
						setState(228);
						match(T__12);
						}
						break;
					}
					} 
				}
				setState(234);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class MultOPContext extends ParserRuleContext {
		public MultOPContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_multOP; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterMultOP(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitMultOP(this);
		}
	}

	public final MultOPContext multOP() throws RecognitionException {
		MultOPContext _localctx = new MultOPContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_multOP);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(235);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 458752L) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class AddOPContext extends ParserRuleContext {
		public AddOPContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_addOP; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterAddOP(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitAddOP(this);
		}
	}

	public final AddOPContext addOP() throws RecognitionException {
		AddOPContext _localctx = new AddOPContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_addOP);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(237);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 7864320L) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CompareOPContext extends ParserRuleContext {
		public TerminalNode STRUCT() { return getToken(GrundParser.STRUCT, 0); }
		public CompareOPContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_compareOP; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterCompareOP(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitCompareOP(this);
		}
	}

	public final CompareOPContext compareOP() throws RecognitionException {
		CompareOPContext _localctx = new CompareOPContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_compareOP);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(239);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 8849981440L) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class InLineOPContext extends ParserRuleContext {
		public InLineOPContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_inLineOP; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterInLineOP(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitInLineOP(this);
		}
	}

	public final InLineOPContext inLineOP() throws RecognitionException {
		InLineOPContext _localctx = new InLineOPContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_inLineOP);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(241);
			_la = _input.LA(1);
			if ( !(_la==T__20 || _la==T__21) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class BoolOPContext extends ParserRuleContext {
		public TerminalNode BOOL_OPERATOR() { return getToken(GrundParser.BOOL_OPERATOR, 0); }
		public BoolOPContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_boolOP; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterBoolOP(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitBoolOP(this);
		}
	}

	public final BoolOPContext boolOP() throws RecognitionException {
		BoolOPContext _localctx = new BoolOPContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_boolOP);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(243);
			match(BOOL_OPERATOR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ConstantContext extends ParserRuleContext {
		public TerminalNode INTEGER() { return getToken(GrundParser.INTEGER, 0); }
		public TerminalNode FLOAT() { return getToken(GrundParser.FLOAT, 0); }
		public TerminalNode STRING() { return getToken(GrundParser.STRING, 0); }
		public TerminalNode BOOL() { return getToken(GrundParser.BOOL, 0); }
		public TerminalNode NULL() { return getToken(GrundParser.NULL, 0); }
		public ConstantContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constant; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterConstant(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitConstant(this);
		}
	}

	public final ConstantContext constant() throws RecognitionException {
		ConstantContext _localctx = new ConstantContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_constant);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(245);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 1065151889408L) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CollectionsContext extends ParserRuleContext {
		public ListContext list() {
			return getRuleContext(ListContext.class,0);
		}
		public DictionaryContext dictionary() {
			return getRuleContext(DictionaryContext.class,0);
		}
		public CollectionsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_collections; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterCollections(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitCollections(this);
		}
	}

	public final CollectionsContext collections() throws RecognitionException {
		CollectionsContext _localctx = new CollectionsContext(_ctx, getState());
		enterRule(_localctx, 42, RULE_collections);
		try {
			setState(249);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__11:
				enterOuterAlt(_localctx, 1);
				{
				setState(247);
				list();
				}
				break;
			case T__6:
				enterOuterAlt(_localctx, 2);
				{
				setState(248);
				dictionary();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ListContext extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public ListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_list; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterList(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitList(this);
		}
	}

	public final ListContext list() throws RecognitionException {
		ListContext _localctx = new ListContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(251);
			match(T__11);
			setState(260);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & 5476083340420L) != 0)) {
				{
				setState(252);
				expression(0);
				setState(257);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__10) {
					{
					{
					setState(253);
					match(T__10);
					setState(254);
					expression(0);
					}
					}
					setState(259);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(262);
			match(T__12);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class DictionaryContext extends ParserRuleContext {
		public List<TerminalNode> STRING() { return getTokens(GrundParser.STRING); }
		public TerminalNode STRING(int i) {
			return getToken(GrundParser.STRING, i);
		}
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public DictionaryContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_dictionary; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterDictionary(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitDictionary(this);
		}
	}

	public final DictionaryContext dictionary() throws RecognitionException {
		DictionaryContext _localctx = new DictionaryContext(_ctx, getState());
		enterRule(_localctx, 46, RULE_dictionary);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(264);
			match(T__6);
			setState(278);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==STRING) {
				{
				setState(272);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,28,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(265);
						match(STRING);
						setState(266);
						match(T__4);
						setState(267);
						expression(0);
						setState(268);
						match(T__10);
						}
						} 
					}
					setState(274);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,28,_ctx);
				}
				{
				setState(275);
				match(STRING);
				setState(276);
				match(T__4);
				setState(277);
				expression(0);
				}
				}
			}

			setState(280);
			match(T__7);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class BlockContext extends ParserRuleContext {
		public List<LineContext> line() {
			return getRuleContexts(LineContext.class);
		}
		public LineContext line(int i) {
			return getRuleContext(LineContext.class,i);
		}
		public BlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_block; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).enterBlock(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GrundListener ) ((GrundListener)listener).exitBlock(this);
		}
	}

	public final BlockContext block() throws RecognitionException {
		BlockContext _localctx = new BlockContext(_ctx, getState());
		enterRule(_localctx, 48, RULE_block);
		int _la;
		try {
			setState(298);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__4:
				enterOuterAlt(_localctx, 1);
				{
				setState(282);
				match(T__4);
				setState(286);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 5479036130436L) != 0)) {
					{
					{
					setState(283);
					line();
					}
					}
					setState(288);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(289);
				match(T__5);
				}
				break;
			case T__6:
				enterOuterAlt(_localctx, 2);
				{
				setState(290);
				match(T__6);
				setState(294);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 5479036130436L) != 0)) {
					{
					{
					setState(291);
					line();
					}
					}
					setState(296);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(297);
				match(T__7);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 14:
			return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 7);
		case 1:
			return precpred(_ctx, 4);
		case 2:
			return precpred(_ctx, 3);
		case 3:
			return precpred(_ctx, 2);
		case 4:
			return precpred(_ctx, 1);
		case 5:
			return precpred(_ctx, 13);
		}
		return true;
	}

	public static final String _serializedATN =
		"\u0004\u0001*\u012d\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002"+
		"\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002"+
		"\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002"+
		"\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b\u0007\u000b\u0002"+
		"\f\u0007\f\u0002\r\u0007\r\u0002\u000e\u0007\u000e\u0002\u000f\u0007\u000f"+
		"\u0002\u0010\u0007\u0010\u0002\u0011\u0007\u0011\u0002\u0012\u0007\u0012"+
		"\u0002\u0013\u0007\u0013\u0002\u0014\u0007\u0014\u0002\u0015\u0007\u0015"+
		"\u0002\u0016\u0007\u0016\u0002\u0017\u0007\u0017\u0002\u0018\u0007\u0018"+
		"\u0001\u0000\u0005\u00004\b\u0000\n\u0000\f\u00007\t\u0000\u0001\u0000"+
		"\u0001\u0000\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001"+
		"\u0001\u0001\u0001\u0001\u0001\u0001\u0003\u0001C\b\u0001\u0001\u0002"+
		"\u0001\u0002\u0001\u0002\u0003\u0002H\b\u0002\u0001\u0002\u0003\u0002"+
		"K\b\u0002\u0001\u0002\u0003\u0002N\b\u0002\u0001\u0003\u0001\u0003\u0003"+
		"\u0003R\b\u0003\u0001\u0003\u0001\u0003\u0003\u0003V\b\u0003\u0001\u0003"+
		"\u0001\u0003\u0001\u0003\u0001\u0003\u0003\u0003\\\b\u0003\u0001\u0003"+
		"\u0001\u0003\u0003\u0003`\b\u0003\u0001\u0003\u0001\u0003\u0001\u0003"+
		"\u0001\u0003\u0003\u0003f\b\u0003\u0001\u0004\u0001\u0004\u0003\u0004"+
		"j\b\u0004\u0001\u0005\u0001\u0005\u0001\u0005\u0001\u0005\u0001\u0005"+
		"\u0001\u0005\u0001\u0005\u0001\u0005\u0001\u0005\u0001\u0005\u0003\u0005"+
		"v\b\u0005\u0001\u0006\u0001\u0006\u0001\u0006\u0005\u0006{\b\u0006\n\u0006"+
		"\f\u0006~\t\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0005"+
		"\u0006\u0084\b\u0006\n\u0006\f\u0006\u0087\t\u0006\u0001\u0006\u0003\u0006"+
		"\u008a\b\u0006\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0003\u0007"+
		"\u0090\b\u0007\u0001\b\u0001\b\u0001\b\u0003\b\u0095\b\b\u0001\t\u0001"+
		"\t\u0001\t\u0001\t\u0001\t\u0005\t\u009c\b\t\n\t\f\t\u009f\t\t\u0003\t"+
		"\u00a1\b\t\u0001\t\u0001\t\u0001\n\u0001\n\u0001\n\u0003\n\u00a8\b\n\u0001"+
		"\u000b\u0001\u000b\u0001\f\u0001\f\u0001\f\u0001\r\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0001\r\u0005\r\u00b5\b\r\n\r\f\r\u00b8\t\r\u0003\r\u00ba\b"+
		"\r\u0001\r\u0001\r\u0001\r\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e"+
		"\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e"+
		"\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0003\u000e\u00cd\b\u000e"+
		"\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e"+
		"\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e"+
		"\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e"+
		"\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e"+
		"\u0005\u000e\u00e7\b\u000e\n\u000e\f\u000e\u00ea\t\u000e\u0001\u000f\u0001"+
		"\u000f\u0001\u0010\u0001\u0010\u0001\u0011\u0001\u0011\u0001\u0012\u0001"+
		"\u0012\u0001\u0013\u0001\u0013\u0001\u0014\u0001\u0014\u0001\u0015\u0001"+
		"\u0015\u0003\u0015\u00fa\b\u0015\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0005\u0016\u0100\b\u0016\n\u0016\f\u0016\u0103\t\u0016\u0003\u0016"+
		"\u0105\b\u0016\u0001\u0016\u0001\u0016\u0001\u0017\u0001\u0017\u0001\u0017"+
		"\u0001\u0017\u0001\u0017\u0001\u0017\u0005\u0017\u010f\b\u0017\n\u0017"+
		"\f\u0017\u0112\t\u0017\u0001\u0017\u0001\u0017\u0001\u0017\u0003\u0017"+
		"\u0117\b\u0017\u0001\u0017\u0001\u0017\u0001\u0018\u0001\u0018\u0005\u0018"+
		"\u011d\b\u0018\n\u0018\f\u0018\u0120\t\u0018\u0001\u0018\u0001\u0018\u0001"+
		"\u0018\u0005\u0018\u0125\b\u0018\n\u0018\f\u0018\u0128\t\u0018\u0001\u0018"+
		"\u0003\u0018\u012b\b\u0018\u0001\u0018\u0000\u0001\u001c\u0019\u0000\u0002"+
		"\u0004\u0006\b\n\f\u000e\u0010\u0012\u0014\u0016\u0018\u001a\u001c\u001e"+
		" \"$&(*,.0\u0000\u0005\u0001\u0000\u0010\u0012\u0001\u0000\u0013\u0016"+
		"\u0002\u0000\u0017\u001b!!\u0001\u0000\u0015\u0016\u0001\u0000#\'\u0146"+
		"\u00005\u0001\u0000\u0000\u0000\u0002B\u0001\u0000\u0000\u0000\u0004M"+
		"\u0001\u0000\u0000\u0000\u0006e\u0001\u0000\u0000\u0000\bi\u0001\u0000"+
		"\u0000\u0000\nu\u0001\u0000\u0000\u0000\f\u0089\u0001\u0000\u0000\u0000"+
		"\u000e\u008b\u0001\u0000\u0000\u0000\u0010\u0091\u0001\u0000\u0000\u0000"+
		"\u0012\u0096\u0001\u0000\u0000\u0000\u0014\u00a4\u0001\u0000\u0000\u0000"+
		"\u0016\u00a9\u0001\u0000\u0000\u0000\u0018\u00ab\u0001\u0000\u0000\u0000"+
		"\u001a\u00ae\u0001\u0000\u0000\u0000\u001c\u00cc\u0001\u0000\u0000\u0000"+
		"\u001e\u00eb\u0001\u0000\u0000\u0000 \u00ed\u0001\u0000\u0000\u0000\""+
		"\u00ef\u0001\u0000\u0000\u0000$\u00f1\u0001\u0000\u0000\u0000&\u00f3\u0001"+
		"\u0000\u0000\u0000(\u00f5\u0001\u0000\u0000\u0000*\u00f9\u0001\u0000\u0000"+
		"\u0000,\u00fb\u0001\u0000\u0000\u0000.\u0108\u0001\u0000\u0000\u00000"+
		"\u012a\u0001\u0000\u0000\u000024\u0003\u0002\u0001\u000032\u0001\u0000"+
		"\u0000\u000047\u0001\u0000\u0000\u000053\u0001\u0000\u0000\u000056\u0001"+
		"\u0000\u0000\u000068\u0001\u0000\u0000\u000075\u0001\u0000\u0000\u0000"+
		"89\u0005\u0000\u0000\u00019\u0001\u0001\u0000\u0000\u0000:C\u0003\u0004"+
		"\u0002\u0000;C\u0003\u0006\u0003\u0000<C\u0003\n\u0005\u0000=C\u0003\u001a"+
		"\r\u0000>C\u0003\u0012\t\u0000?C\u0003\u000e\u0007\u0000@C\u0003\u0014"+
		"\n\u0000AC\u0003\u0018\f\u0000B:\u0001\u0000\u0000\u0000B;\u0001\u0000"+
		"\u0000\u0000B<\u0001\u0000\u0000\u0000B=\u0001\u0000\u0000\u0000B>\u0001"+
		"\u0000\u0000\u0000B?\u0001\u0000\u0000\u0000B@\u0001\u0000\u0000\u0000"+
		"BA\u0001\u0000\u0000\u0000C\u0003\u0001\u0000\u0000\u0000DH\u0003\u000e"+
		"\u0007\u0000EH\u0003\u0012\t\u0000FH\u0003\f\u0006\u0000GD\u0001\u0000"+
		"\u0000\u0000GE\u0001\u0000\u0000\u0000GF\u0001\u0000\u0000\u0000HJ\u0001"+
		"\u0000\u0000\u0000IK\u0005\u0001\u0000\u0000JI\u0001\u0000\u0000\u0000"+
		"JK\u0001\u0000\u0000\u0000KN\u0001\u0000\u0000\u0000LN\u0003\u001c\u000e"+
		"\u0000MG\u0001\u0000\u0000\u0000ML\u0001\u0000\u0000\u0000N\u0005\u0001"+
		"\u0000\u0000\u0000OQ\u0005\u001c\u0000\u0000PR\u0005\u0002\u0000\u0000"+
		"QP\u0001\u0000\u0000\u0000QR\u0001\u0000\u0000\u0000RS\u0001\u0000\u0000"+
		"\u0000SU\u0003\u001c\u000e\u0000TV\u0005\u0003\u0000\u0000UT\u0001\u0000"+
		"\u0000\u0000UV\u0001\u0000\u0000\u0000VW\u0001\u0000\u0000\u0000WX\u0003"+
		"0\u0018\u0000Xf\u0001\u0000\u0000\u0000Y[\u0005\u001c\u0000\u0000Z\\\u0005"+
		"\u0002\u0000\u0000[Z\u0001\u0000\u0000\u0000[\\\u0001\u0000\u0000\u0000"+
		"\\]\u0001\u0000\u0000\u0000]_\u0003\u001c\u000e\u0000^`\u0005\u0003\u0000"+
		"\u0000_^\u0001\u0000\u0000\u0000_`\u0001\u0000\u0000\u0000`a\u0001\u0000"+
		"\u0000\u0000ab\u00030\u0018\u0000bc\u0005\u0004\u0000\u0000cd\u0003\b"+
		"\u0004\u0000df\u0001\u0000\u0000\u0000eO\u0001\u0000\u0000\u0000eY\u0001"+
		"\u0000\u0000\u0000f\u0007\u0001\u0000\u0000\u0000gj\u00030\u0018\u0000"+
		"hj\u0003\u0006\u0003\u0000ig\u0001\u0000\u0000\u0000ih\u0001\u0000\u0000"+
		"\u0000j\t\u0001\u0000\u0000\u0000kl\u0005\u001d\u0000\u0000lm\u0003\u001c"+
		"\u000e\u0000mn\u00030\u0018\u0000nv\u0001\u0000\u0000\u0000op\u0005\u001d"+
		"\u0000\u0000pq\u0003\u001c\u000e\u0000qr\u00030\u0018\u0000rs\u0005\u0004"+
		"\u0000\u0000st\u0003\b\u0004\u0000tv\u0001\u0000\u0000\u0000uk\u0001\u0000"+
		"\u0000\u0000uo\u0001\u0000\u0000\u0000v\u000b\u0001\u0000\u0000\u0000"+
		"wx\u0005\u001f\u0000\u0000x|\u0005\u0005\u0000\u0000y{\u0003\u000e\u0007"+
		"\u0000zy\u0001\u0000\u0000\u0000{~\u0001\u0000\u0000\u0000|z\u0001\u0000"+
		"\u0000\u0000|}\u0001\u0000\u0000\u0000}\u007f\u0001\u0000\u0000\u0000"+
		"~|\u0001\u0000\u0000\u0000\u007f\u008a\u0005\u0006\u0000\u0000\u0080\u0081"+
		"\u0005\u001f\u0000\u0000\u0081\u0085\u0005\u0007\u0000\u0000\u0082\u0084"+
		"\u0003\u000e\u0007\u0000\u0083\u0082\u0001\u0000\u0000\u0000\u0084\u0087"+
		"\u0001\u0000\u0000\u0000\u0085\u0083\u0001\u0000\u0000\u0000\u0085\u0086"+
		"\u0001\u0000\u0000\u0000\u0086\u0088\u0001\u0000\u0000\u0000\u0087\u0085"+
		"\u0001\u0000\u0000\u0000\u0088\u008a\u0005\b\u0000\u0000\u0089w\u0001"+
		"\u0000\u0000\u0000\u0089\u0080\u0001\u0000\u0000\u0000\u008a\r\u0001\u0000"+
		"\u0000\u0000\u008b\u008c\u0003\u001c\u000e\u0000\u008c\u008d\u0005\t\u0000"+
		"\u0000\u008d\u008f\u0003\u001c\u000e\u0000\u008e\u0090\u0005\u0001\u0000"+
		"\u0000\u008f\u008e\u0001\u0000\u0000\u0000\u008f\u0090\u0001\u0000\u0000"+
		"\u0000\u0090\u000f\u0001\u0000\u0000\u0000\u0091\u0092\u0005\n\u0000\u0000"+
		"\u0092\u0094\u0005*\u0000\u0000\u0093\u0095\u0005\u0001\u0000\u0000\u0094"+
		"\u0093\u0001\u0000\u0000\u0000\u0094\u0095\u0001\u0000\u0000\u0000\u0095"+
		"\u0011\u0001\u0000\u0000\u0000\u0096\u0097\u0005*\u0000\u0000\u0097\u00a0"+
		"\u0005\u0002\u0000\u0000\u0098\u009d\u0003\u001c\u000e\u0000\u0099\u009a"+
		"\u0005\u000b\u0000\u0000\u009a\u009c\u0003\u001c\u000e\u0000\u009b\u0099"+
		"\u0001\u0000\u0000\u0000\u009c\u009f\u0001\u0000\u0000\u0000\u009d\u009b"+
		"\u0001\u0000\u0000\u0000\u009d\u009e\u0001\u0000\u0000\u0000\u009e\u00a1"+
		"\u0001\u0000\u0000\u0000\u009f\u009d\u0001\u0000\u0000\u0000\u00a0\u0098"+
		"\u0001\u0000\u0000\u0000\u00a0\u00a1\u0001\u0000\u0000\u0000\u00a1\u00a2"+
		"\u0001\u0000\u0000\u0000\u00a2\u00a3\u0005\u0003\u0000\u0000\u00a3\u0013"+
		"\u0001\u0000\u0000\u0000\u00a4\u00a5\u0003\u001c\u000e\u0000\u00a5\u00a7"+
		"\u0003$\u0012\u0000\u00a6\u00a8\u0005\u0001\u0000\u0000\u00a7\u00a6\u0001"+
		"\u0000\u0000\u0000\u00a7\u00a8\u0001\u0000\u0000\u0000\u00a8\u0015\u0001"+
		"\u0000\u0000\u0000\u00a9\u00aa\u0005*\u0000\u0000\u00aa\u0017\u0001\u0000"+
		"\u0000\u0000\u00ab\u00ac\u0005!\u0000\u0000\u00ac\u00ad\u00030\u0018\u0000"+
		"\u00ad\u0019\u0001\u0000\u0000\u0000\u00ae\u00af\u0005 \u0000\u0000\u00af"+
		"\u00b0\u0005*\u0000\u0000\u00b0\u00b9\u0005\u0002\u0000\u0000\u00b1\u00b6"+
		"\u0003\u0016\u000b\u0000\u00b2\u00b3\u0005\u000b\u0000\u0000\u00b3\u00b5"+
		"\u0003\u0016\u000b\u0000\u00b4\u00b2\u0001\u0000\u0000\u0000\u00b5\u00b8"+
		"\u0001\u0000\u0000\u0000\u00b6\u00b4\u0001\u0000\u0000\u0000\u00b6\u00b7"+
		"\u0001\u0000\u0000\u0000\u00b7\u00ba\u0001\u0000\u0000\u0000\u00b8\u00b6"+
		"\u0001\u0000\u0000\u0000\u00b9\u00b1\u0001\u0000\u0000\u0000\u00b9\u00ba"+
		"\u0001\u0000\u0000\u0000\u00ba\u00bb\u0001\u0000\u0000\u0000\u00bb\u00bc"+
		"\u0005\u0003\u0000\u0000\u00bc\u00bd\u00030\u0018\u0000\u00bd\u001b\u0001"+
		"\u0000\u0000\u0000\u00be\u00bf\u0006\u000e\uffff\uffff\u0000\u00bf\u00cd"+
		"\u0003(\u0014\u0000\u00c0\u00cd\u0003*\u0015\u0000\u00c1\u00cd\u0005*"+
		"\u0000\u0000\u00c2\u00cd\u0003\u0010\b\u0000\u00c3\u00cd\u0003\u001a\r"+
		"\u0000\u00c4\u00cd\u0003\u0012\t\u0000\u00c5\u00cd\u0003\u0018\f\u0000"+
		"\u00c6\u00c7\u0005\u0002\u0000\u0000\u00c7\u00c8\u0003\u001c\u000e\u0000"+
		"\u00c8\u00c9\u0005\u0003\u0000\u0000\u00c9\u00cd\u0001\u0000\u0000\u0000"+
		"\u00ca\u00cb\u0005\u000f\u0000\u0000\u00cb\u00cd\u0003\u001c\u000e\u0005"+
		"\u00cc\u00be\u0001\u0000\u0000\u0000\u00cc\u00c0\u0001\u0000\u0000\u0000"+
		"\u00cc\u00c1\u0001\u0000\u0000\u0000\u00cc\u00c2\u0001\u0000\u0000\u0000"+
		"\u00cc\u00c3\u0001\u0000\u0000\u0000\u00cc\u00c4\u0001\u0000\u0000\u0000"+
		"\u00cc\u00c5\u0001\u0000\u0000\u0000\u00cc\u00c6\u0001\u0000\u0000\u0000"+
		"\u00cc\u00ca\u0001\u0000\u0000\u0000\u00cd\u00e8\u0001\u0000\u0000\u0000"+
		"\u00ce\u00cf\n\u0007\u0000\u0000\u00cf\u00d0\u0005\u000e\u0000\u0000\u00d0"+
		"\u00e7\u0003\u001c\u000e\b\u00d1\u00d2\n\u0004\u0000\u0000\u00d2\u00d3"+
		"\u0003\u001e\u000f\u0000\u00d3\u00d4\u0003\u001c\u000e\u0005\u00d4\u00e7"+
		"\u0001\u0000\u0000\u0000\u00d5\u00d6\n\u0003\u0000\u0000\u00d6\u00d7\u0003"+
		" \u0010\u0000\u00d7\u00d8\u0003\u001c\u000e\u0004\u00d8\u00e7\u0001\u0000"+
		"\u0000\u0000\u00d9\u00da\n\u0002\u0000\u0000\u00da\u00db\u0003\"\u0011"+
		"\u0000\u00db\u00dc\u0003\u001c\u000e\u0003\u00dc\u00e7\u0001\u0000\u0000"+
		"\u0000\u00dd\u00de\n\u0001\u0000\u0000\u00de\u00df\u0003&\u0013\u0000"+
		"\u00df\u00e0\u0003\u001c\u000e\u0002\u00e0\u00e7\u0001\u0000\u0000\u0000"+
		"\u00e1\u00e2\n\r\u0000\u0000\u00e2\u00e3\u0005\f\u0000\u0000\u00e3\u00e4"+
		"\u0003\u001c\u000e\u0000\u00e4\u00e5\u0005\r\u0000\u0000\u00e5\u00e7\u0001"+
		"\u0000\u0000\u0000\u00e6\u00ce\u0001\u0000\u0000\u0000\u00e6\u00d1\u0001"+
		"\u0000\u0000\u0000\u00e6\u00d5\u0001\u0000\u0000\u0000\u00e6\u00d9\u0001"+
		"\u0000\u0000\u0000\u00e6\u00dd\u0001\u0000\u0000\u0000\u00e6\u00e1\u0001"+
		"\u0000\u0000\u0000\u00e7\u00ea\u0001\u0000\u0000\u0000\u00e8\u00e6\u0001"+
		"\u0000\u0000\u0000\u00e8\u00e9\u0001\u0000\u0000\u0000\u00e9\u001d\u0001"+
		"\u0000\u0000\u0000\u00ea\u00e8\u0001\u0000\u0000\u0000\u00eb\u00ec\u0007"+
		"\u0000\u0000\u0000\u00ec\u001f\u0001\u0000\u0000\u0000\u00ed\u00ee\u0007"+
		"\u0001\u0000\u0000\u00ee!\u0001\u0000\u0000\u0000\u00ef\u00f0\u0007\u0002"+
		"\u0000\u0000\u00f0#\u0001\u0000\u0000\u0000\u00f1\u00f2\u0007\u0003\u0000"+
		"\u0000\u00f2%\u0001\u0000\u0000\u0000\u00f3\u00f4\u0005\"\u0000\u0000"+
		"\u00f4\'\u0001\u0000\u0000\u0000\u00f5\u00f6\u0007\u0004\u0000\u0000\u00f6"+
		")\u0001\u0000\u0000\u0000\u00f7\u00fa\u0003,\u0016\u0000\u00f8\u00fa\u0003"+
		".\u0017\u0000\u00f9\u00f7\u0001\u0000\u0000\u0000\u00f9\u00f8\u0001\u0000"+
		"\u0000\u0000\u00fa+\u0001\u0000\u0000\u0000\u00fb\u0104\u0005\f\u0000"+
		"\u0000\u00fc\u0101\u0003\u001c\u000e\u0000\u00fd\u00fe\u0005\u000b\u0000"+
		"\u0000\u00fe\u0100\u0003\u001c\u000e\u0000\u00ff\u00fd\u0001\u0000\u0000"+
		"\u0000\u0100\u0103\u0001\u0000\u0000\u0000\u0101\u00ff\u0001\u0000\u0000"+
		"\u0000\u0101\u0102\u0001\u0000\u0000\u0000\u0102\u0105\u0001\u0000\u0000"+
		"\u0000\u0103\u0101\u0001\u0000\u0000\u0000\u0104\u00fc\u0001\u0000\u0000"+
		"\u0000\u0104\u0105\u0001\u0000\u0000\u0000\u0105\u0106\u0001\u0000\u0000"+
		"\u0000\u0106\u0107\u0005\r\u0000\u0000\u0107-\u0001\u0000\u0000\u0000"+
		"\u0108\u0116\u0005\u0007\u0000\u0000\u0109\u010a\u0005%\u0000\u0000\u010a"+
		"\u010b\u0005\u0005\u0000\u0000\u010b\u010c\u0003\u001c\u000e\u0000\u010c"+
		"\u010d\u0005\u000b\u0000\u0000\u010d\u010f\u0001\u0000\u0000\u0000\u010e"+
		"\u0109\u0001\u0000\u0000\u0000\u010f\u0112\u0001\u0000\u0000\u0000\u0110"+
		"\u010e\u0001\u0000\u0000\u0000\u0110\u0111\u0001\u0000\u0000\u0000\u0111"+
		"\u0113\u0001\u0000\u0000\u0000\u0112\u0110\u0001\u0000\u0000\u0000\u0113"+
		"\u0114\u0005%\u0000\u0000\u0114\u0115\u0005\u0005\u0000\u0000\u0115\u0117"+
		"\u0003\u001c\u000e\u0000\u0116\u0110\u0001\u0000\u0000\u0000\u0116\u0117"+
		"\u0001\u0000\u0000\u0000\u0117\u0118\u0001\u0000\u0000\u0000\u0118\u0119"+
		"\u0005\b\u0000\u0000\u0119/\u0001\u0000\u0000\u0000\u011a\u011e\u0005"+
		"\u0005\u0000\u0000\u011b\u011d\u0003\u0002\u0001\u0000\u011c\u011b\u0001"+
		"\u0000\u0000\u0000\u011d\u0120\u0001\u0000\u0000\u0000\u011e\u011c\u0001"+
		"\u0000\u0000\u0000\u011e\u011f\u0001\u0000\u0000\u0000\u011f\u0121\u0001"+
		"\u0000\u0000\u0000\u0120\u011e\u0001\u0000\u0000\u0000\u0121\u012b\u0005"+
		"\u0006\u0000\u0000\u0122\u0126\u0005\u0007\u0000\u0000\u0123\u0125\u0003"+
		"\u0002\u0001\u0000\u0124\u0123\u0001\u0000\u0000\u0000\u0125\u0128\u0001"+
		"\u0000\u0000\u0000\u0126\u0124\u0001\u0000\u0000\u0000\u0126\u0127\u0001"+
		"\u0000\u0000\u0000\u0127\u0129\u0001\u0000\u0000\u0000\u0128\u0126\u0001"+
		"\u0000\u0000\u0000\u0129\u012b\u0005\b\u0000\u0000\u012a\u011a\u0001\u0000"+
		"\u0000\u0000\u012a\u0122\u0001\u0000\u0000\u0000\u012b1\u0001\u0000\u0000"+
		"\u0000!5BGJMQU[_eiu|\u0085\u0089\u008f\u0094\u009d\u00a0\u00a7\u00b6\u00b9"+
		"\u00cc\u00e6\u00e8\u00f9\u0101\u0104\u0110\u0116\u011e\u0126\u012a";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
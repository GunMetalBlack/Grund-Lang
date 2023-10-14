// Generated from /home/noah/Desktop/Codeing/Grund-Lang/AntlrCSharp/Grund.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link GrundParser}.
 */
public interface GrundListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link GrundParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(GrundParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(GrundParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#line}.
	 * @param ctx the parse tree
	 */
	void enterLine(GrundParser.LineContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#line}.
	 * @param ctx the parse tree
	 */
	void exitLine(GrundParser.LineContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#statement}.
	 * @param ctx the parse tree
	 */
	void enterStatement(GrundParser.StatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#statement}.
	 * @param ctx the parse tree
	 */
	void exitStatement(GrundParser.StatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#ifBlock}.
	 * @param ctx the parse tree
	 */
	void enterIfBlock(GrundParser.IfBlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#ifBlock}.
	 * @param ctx the parse tree
	 */
	void exitIfBlock(GrundParser.IfBlockContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#elseIfBlock}.
	 * @param ctx the parse tree
	 */
	void enterElseIfBlock(GrundParser.ElseIfBlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#elseIfBlock}.
	 * @param ctx the parse tree
	 */
	void exitElseIfBlock(GrundParser.ElseIfBlockContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#whileBlock}.
	 * @param ctx the parse tree
	 */
	void enterWhileBlock(GrundParser.WhileBlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#whileBlock}.
	 * @param ctx the parse tree
	 */
	void exitWhileBlock(GrundParser.WhileBlockContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#blockScopeAssignment}.
	 * @param ctx the parse tree
	 */
	void enterBlockScopeAssignment(GrundParser.BlockScopeAssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#blockScopeAssignment}.
	 * @param ctx the parse tree
	 */
	void exitBlockScopeAssignment(GrundParser.BlockScopeAssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#assignment}.
	 * @param ctx the parse tree
	 */
	void enterAssignment(GrundParser.AssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#assignment}.
	 * @param ctx the parse tree
	 */
	void exitAssignment(GrundParser.AssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterDeclaration(GrundParser.DeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitDeclaration(GrundParser.DeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#functionCall}.
	 * @param ctx the parse tree
	 */
	void enterFunctionCall(GrundParser.FunctionCallContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#functionCall}.
	 * @param ctx the parse tree
	 */
	void exitFunctionCall(GrundParser.FunctionCallContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#inLineIncrement}.
	 * @param ctx the parse tree
	 */
	void enterInLineIncrement(GrundParser.InLineIncrementContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#inLineIncrement}.
	 * @param ctx the parse tree
	 */
	void exitInLineIncrement(GrundParser.InLineIncrementContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#parameter}.
	 * @param ctx the parse tree
	 */
	void enterParameter(GrundParser.ParameterContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#parameter}.
	 * @param ctx the parse tree
	 */
	void exitParameter(GrundParser.ParameterContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#strucDefinition}.
	 * @param ctx the parse tree
	 */
	void enterStrucDefinition(GrundParser.StrucDefinitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#strucDefinition}.
	 * @param ctx the parse tree
	 */
	void exitStrucDefinition(GrundParser.StrucDefinitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#functionDefinition}.
	 * @param ctx the parse tree
	 */
	void enterFunctionDefinition(GrundParser.FunctionDefinitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#functionDefinition}.
	 * @param ctx the parse tree
	 */
	void exitFunctionDefinition(GrundParser.FunctionDefinitionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code dotExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterDotExpression(GrundParser.DotExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code dotExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitDotExpression(GrundParser.DotExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code constantExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterConstantExpression(GrundParser.ConstantExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code constantExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitConstantExpression(GrundParser.ConstantExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code additiveExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterAdditiveExpression(GrundParser.AdditiveExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code additiveExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitAdditiveExpression(GrundParser.AdditiveExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code identifierExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterIdentifierExpression(GrundParser.IdentifierExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code identifierExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitIdentifierExpression(GrundParser.IdentifierExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code functionDefinitionExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterFunctionDefinitionExpression(GrundParser.FunctionDefinitionExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code functionDefinitionExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitFunctionDefinitionExpression(GrundParser.FunctionDefinitionExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code notExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterNotExpression(GrundParser.NotExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code notExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitNotExpression(GrundParser.NotExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code comparisonExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterComparisonExpression(GrundParser.ComparisonExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code comparisonExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitComparisonExpression(GrundParser.ComparisonExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code multiplicativeExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterMultiplicativeExpression(GrundParser.MultiplicativeExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code multiplicativeExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitMultiplicativeExpression(GrundParser.MultiplicativeExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code booleanExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterBooleanExpression(GrundParser.BooleanExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code booleanExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitBooleanExpression(GrundParser.BooleanExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code collectionsExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterCollectionsExpression(GrundParser.CollectionsExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code collectionsExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitCollectionsExpression(GrundParser.CollectionsExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code parenthesizedExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterParenthesizedExpression(GrundParser.ParenthesizedExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code parenthesizedExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitParenthesizedExpression(GrundParser.ParenthesizedExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code functionCallExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterFunctionCallExpression(GrundParser.FunctionCallExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code functionCallExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitFunctionCallExpression(GrundParser.FunctionCallExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code listAccessionExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterListAccessionExpression(GrundParser.ListAccessionExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code listAccessionExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitListAccessionExpression(GrundParser.ListAccessionExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code declarationsExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterDeclarationsExpression(GrundParser.DeclarationsExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code declarationsExpression}
	 * labeled alternative in {@link GrundParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitDeclarationsExpression(GrundParser.DeclarationsExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#multOP}.
	 * @param ctx the parse tree
	 */
	void enterMultOP(GrundParser.MultOPContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#multOP}.
	 * @param ctx the parse tree
	 */
	void exitMultOP(GrundParser.MultOPContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#addOP}.
	 * @param ctx the parse tree
	 */
	void enterAddOP(GrundParser.AddOPContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#addOP}.
	 * @param ctx the parse tree
	 */
	void exitAddOP(GrundParser.AddOPContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#compareOP}.
	 * @param ctx the parse tree
	 */
	void enterCompareOP(GrundParser.CompareOPContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#compareOP}.
	 * @param ctx the parse tree
	 */
	void exitCompareOP(GrundParser.CompareOPContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#inLineOP}.
	 * @param ctx the parse tree
	 */
	void enterInLineOP(GrundParser.InLineOPContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#inLineOP}.
	 * @param ctx the parse tree
	 */
	void exitInLineOP(GrundParser.InLineOPContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#boolOP}.
	 * @param ctx the parse tree
	 */
	void enterBoolOP(GrundParser.BoolOPContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#boolOP}.
	 * @param ctx the parse tree
	 */
	void exitBoolOP(GrundParser.BoolOPContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#constant}.
	 * @param ctx the parse tree
	 */
	void enterConstant(GrundParser.ConstantContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#constant}.
	 * @param ctx the parse tree
	 */
	void exitConstant(GrundParser.ConstantContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#collections}.
	 * @param ctx the parse tree
	 */
	void enterCollections(GrundParser.CollectionsContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#collections}.
	 * @param ctx the parse tree
	 */
	void exitCollections(GrundParser.CollectionsContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#list}.
	 * @param ctx the parse tree
	 */
	void enterList(GrundParser.ListContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#list}.
	 * @param ctx the parse tree
	 */
	void exitList(GrundParser.ListContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#dictionary}.
	 * @param ctx the parse tree
	 */
	void enterDictionary(GrundParser.DictionaryContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#dictionary}.
	 * @param ctx the parse tree
	 */
	void exitDictionary(GrundParser.DictionaryContext ctx);
	/**
	 * Enter a parse tree produced by {@link GrundParser#block}.
	 * @param ctx the parse tree
	 */
	void enterBlock(GrundParser.BlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link GrundParser#block}.
	 * @param ctx the parse tree
	 */
	void exitBlock(GrundParser.BlockContext ctx);
}
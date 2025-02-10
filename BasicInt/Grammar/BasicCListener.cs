//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:/Users/marciohenrique/Downloads/uenp/TF_Compiladores-main/BasicC.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


  namespace BasicInt.Grammar;

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="BasicCParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IBasicCListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicCParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] BasicCParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicCParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] BasicCParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>includeDirective</c>
	/// labeled alternative in <see cref="BasicCParser.preprocessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIncludeDirective([NotNull] BasicCParser.IncludeDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>includeDirective</c>
	/// labeled alternative in <see cref="BasicCParser.preprocessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIncludeDirective([NotNull] BasicCParser.IncludeDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>defineDirective</c>
	/// labeled alternative in <see cref="BasicCParser.preprocessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefineDirective([NotNull] BasicCParser.DefineDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>defineDirective</c>
	/// labeled alternative in <see cref="BasicCParser.preprocessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefineDirective([NotNull] BasicCParser.DefineDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>mainFunctionBlock</c>
	/// labeled alternative in <see cref="BasicCParser.mainFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMainFunctionBlock([NotNull] BasicCParser.MainFunctionBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>mainFunctionBlock</c>
	/// labeled alternative in <see cref="BasicCParser.mainFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMainFunctionBlock([NotNull] BasicCParser.MainFunctionBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnWithReturn</c>
	/// labeled alternative in <see cref="BasicCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnWithReturn([NotNull] BasicCParser.FnWithReturnContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnWithReturn</c>
	/// labeled alternative in <see cref="BasicCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnWithReturn([NotNull] BasicCParser.FnWithReturnContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnWithoutReturn</c>
	/// labeled alternative in <see cref="BasicCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnWithoutReturn([NotNull] BasicCParser.FnWithoutReturnContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnWithoutReturn</c>
	/// labeled alternative in <see cref="BasicCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnWithoutReturn([NotNull] BasicCParser.FnWithoutReturnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] BasicCParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] BasicCParser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariavelExistenteString</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariavelExistenteString([NotNull] BasicCParser.VariavelExistenteStringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariavelExistenteString</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariavelExistenteString([NotNull] BasicCParser.VariavelExistenteStringContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariavelNovaString</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariavelNovaString([NotNull] BasicCParser.VariavelNovaStringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariavelNovaString</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariavelNovaString([NotNull] BasicCParser.VariavelNovaStringContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariavelNova</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariavelNova([NotNull] BasicCParser.VariavelNovaContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariavelNova</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariavelNova([NotNull] BasicCParser.VariavelNovaContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariavelNovaFuncao</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariavelNovaFuncao([NotNull] BasicCParser.VariavelNovaFuncaoContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariavelNovaFuncao</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariavelNovaFuncao([NotNull] BasicCParser.VariavelNovaFuncaoContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariavelNovaBoolean</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariavelNovaBoolean([NotNull] BasicCParser.VariavelNovaBooleanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariavelNovaBoolean</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariavelNovaBoolean([NotNull] BasicCParser.VariavelNovaBooleanContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariavelExistente</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariavelExistente([NotNull] BasicCParser.VariavelExistenteContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariavelExistente</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariavelExistente([NotNull] BasicCParser.VariavelExistenteContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariavelExistenteBoolean</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariavelExistenteBoolean([NotNull] BasicCParser.VariavelExistenteBooleanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariavelExistenteBoolean</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariavelExistenteBoolean([NotNull] BasicCParser.VariavelExistenteBooleanContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>inputVar</c>
	/// labeled alternative in <see cref="BasicCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInputVar([NotNull] BasicCParser.InputVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>inputVar</c>
	/// labeled alternative in <see cref="BasicCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInputVar([NotNull] BasicCParser.InputVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>inputStr</c>
	/// labeled alternative in <see cref="BasicCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInputStr([NotNull] BasicCParser.InputStrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>inputStr</c>
	/// labeled alternative in <see cref="BasicCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInputStr([NotNull] BasicCParser.InputStrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>outputStr</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputStr([NotNull] BasicCParser.OutputStrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>outputStr</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputStr([NotNull] BasicCParser.OutputStrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>outputVar</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputVar([NotNull] BasicCParser.OutputVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>outputVar</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputVar([NotNull] BasicCParser.OutputVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>outputExpr</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputExpr([NotNull] BasicCParser.OutputExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>outputExpr</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputExpr([NotNull] BasicCParser.OutputExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>outputStrVar</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputStrVar([NotNull] BasicCParser.OutputStrVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>outputStrVar</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputStrVar([NotNull] BasicCParser.OutputStrVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>outputStrLine</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputStrLine([NotNull] BasicCParser.OutputStrLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>outputStrLine</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputStrLine([NotNull] BasicCParser.OutputStrLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprSum</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprSum([NotNull] BasicCParser.ExprSumContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprSum</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprSum([NotNull] BasicCParser.ExprSumContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprSub</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprSub([NotNull] BasicCParser.ExprSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprSub</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprSub([NotNull] BasicCParser.ExprSubContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprTerm([NotNull] BasicCParser.ExprTermContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprTerm([NotNull] BasicCParser.ExprTermContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermMult([NotNull] BasicCParser.TermMultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermMult([NotNull] BasicCParser.TermMultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermDiv([NotNull] BasicCParser.TermDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermDiv([NotNull] BasicCParser.TermDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>termMod</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermMod([NotNull] BasicCParser.TermModContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termMod</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermMod([NotNull] BasicCParser.TermModContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermFactor([NotNull] BasicCParser.TermFactorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermFactor([NotNull] BasicCParser.TermFactorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorExpr([NotNull] BasicCParser.FactorExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorExpr([NotNull] BasicCParser.FactorExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorVar([NotNull] BasicCParser.FactorVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorVar([NotNull] BasicCParser.FactorVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>factorNumD</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorNumD([NotNull] BasicCParser.FactorNumDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>factorNumD</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorNumD([NotNull] BasicCParser.FactorNumDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorNum([NotNull] BasicCParser.FactorNumContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorNum([NotNull] BasicCParser.FactorNumContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>factorStr</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorStr([NotNull] BasicCParser.FactorStrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>factorStr</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorStr([NotNull] BasicCParser.FactorStrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ifBlock</c>
	/// labeled alternative in <see cref="BasicCParser.controlflow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] BasicCParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ifBlock</c>
	/// labeled alternative in <see cref="BasicCParser.controlflow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] BasicCParser.IfBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ifElseBlock</c>
	/// labeled alternative in <see cref="BasicCParser.controlflow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfElseBlock([NotNull] BasicCParser.IfElseBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ifElseBlock</c>
	/// labeled alternative in <see cref="BasicCParser.controlflow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfElseBlock([NotNull] BasicCParser.IfElseBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>loopBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoopBlock([NotNull] BasicCParser.LoopBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>loopBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoopBlock([NotNull] BasicCParser.LoopBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>forLoopBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForLoopBlock([NotNull] BasicCParser.ForLoopBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>forLoopBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForLoopBlock([NotNull] BasicCParser.ForLoopBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>doWhileBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoWhileBlock([NotNull] BasicCParser.DoWhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>doWhileBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoWhileBlock([NotNull] BasicCParser.DoWhileBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="BasicCParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockLine([NotNull] BasicCParser.BlockLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="BasicCParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockLine([NotNull] BasicCParser.BlockLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="BasicCParser.rblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnBlockLine([NotNull] BasicCParser.FnBlockLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="BasicCParser.rblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnBlockLine([NotNull] BasicCParser.FnBlockLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnBodyLine([NotNull] BasicCParser.FnBodyLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnBodyLine([NotNull] BasicCParser.FnBodyLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnBodyLineMore([NotNull] BasicCParser.FnBodyLineMoreContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnBodyLineMore([NotNull] BasicCParser.FnBodyLineMoreContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnReturnBoolLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnReturnBoolLine([NotNull] BasicCParser.FnReturnBoolLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnReturnBoolLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnReturnBoolLine([NotNull] BasicCParser.FnReturnBoolLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnReturnStrLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnReturnStrLine([NotNull] BasicCParser.FnReturnStrLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnReturnStrLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnReturnStrLine([NotNull] BasicCParser.FnReturnStrLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnReturnExprLine([NotNull] BasicCParser.FnReturnExprLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnReturnExprLine([NotNull] BasicCParser.FnReturnExprLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnReturnLine([NotNull] BasicCParser.FnReturnLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnReturnLine([NotNull] BasicCParser.FnReturnLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bexprNot</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBexprNot([NotNull] BasicCParser.BexprNotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bexprNot</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBexprNot([NotNull] BasicCParser.BexprNotContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bexprOr</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBexprOr([NotNull] BasicCParser.BexprOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bexprOr</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBexprOr([NotNull] BasicCParser.BexprOrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bexprExpr</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBexprExpr([NotNull] BasicCParser.BexprExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bexprExpr</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBexprExpr([NotNull] BasicCParser.BexprExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bexprRelop</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBexprRelop([NotNull] BasicCParser.BexprRelopContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bexprRelop</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBexprRelop([NotNull] BasicCParser.BexprRelopContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bexprAnd</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBexprAnd([NotNull] BasicCParser.BexprAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bexprAnd</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBexprAnd([NotNull] BasicCParser.BexprAndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>uniqueParam</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUniqueParam([NotNull] BasicCParser.UniqueParamContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>uniqueParam</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUniqueParam([NotNull] BasicCParser.UniqueParamContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multipleParams</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultipleParams([NotNull] BasicCParser.MultipleParamsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multipleParams</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultipleParams([NotNull] BasicCParser.MultipleParamsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>noneParam</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoneParam([NotNull] BasicCParser.NoneParamContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>noneParam</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoneParam([NotNull] BasicCParser.NoneParamContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>uniqueParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUniqueParamCall([NotNull] BasicCParser.UniqueParamCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>uniqueParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUniqueParamCall([NotNull] BasicCParser.UniqueParamCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multipleParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultipleParamCall([NotNull] BasicCParser.MultipleParamCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multipleParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultipleParamCall([NotNull] BasicCParser.MultipleParamCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>noneParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoneParamCall([NotNull] BasicCParser.NoneParamCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>noneParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoneParamCall([NotNull] BasicCParser.NoneParamCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>funcInvoc</c>
	/// labeled alternative in <see cref="BasicCParser.callFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncInvoc([NotNull] BasicCParser.FuncInvocContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>funcInvoc</c>
	/// labeled alternative in <see cref="BasicCParser.callFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncInvoc([NotNull] BasicCParser.FuncInvocContext context);
}

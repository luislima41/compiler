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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="BasicCParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IBasicCVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicCParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] BasicCParser.ProgContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>includeDirective</c>
	/// labeled alternative in <see cref="BasicCParser.preprocessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIncludeDirective([NotNull] BasicCParser.IncludeDirectiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>defineDirective</c>
	/// labeled alternative in <see cref="BasicCParser.preprocessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefineDirective([NotNull] BasicCParser.DefineDirectiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>mainFunctionBlock</c>
	/// labeled alternative in <see cref="BasicCParser.mainFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMainFunctionBlock([NotNull] BasicCParser.MainFunctionBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnWithReturn</c>
	/// labeled alternative in <see cref="BasicCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnWithReturn([NotNull] BasicCParser.FnWithReturnContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnWithoutReturn</c>
	/// labeled alternative in <see cref="BasicCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnWithoutReturn([NotNull] BasicCParser.FnWithoutReturnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] BasicCParser.LineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariavelExistenteString</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariavelExistenteString([NotNull] BasicCParser.VariavelExistenteStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariavelNovaString</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariavelNovaString([NotNull] BasicCParser.VariavelNovaStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariavelNova</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariavelNova([NotNull] BasicCParser.VariavelNovaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariavelNovaFuncao</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariavelNovaFuncao([NotNull] BasicCParser.VariavelNovaFuncaoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariavelNovaBoolean</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariavelNovaBoolean([NotNull] BasicCParser.VariavelNovaBooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariavelExistente</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariavelExistente([NotNull] BasicCParser.VariavelExistenteContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariavelExistenteBoolean</c>
	/// labeled alternative in <see cref="BasicCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariavelExistenteBoolean([NotNull] BasicCParser.VariavelExistenteBooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>inputVar</c>
	/// labeled alternative in <see cref="BasicCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInputVar([NotNull] BasicCParser.InputVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>inputStr</c>
	/// labeled alternative in <see cref="BasicCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInputStr([NotNull] BasicCParser.InputStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputStr</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputStr([NotNull] BasicCParser.OutputStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputVar</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputVar([NotNull] BasicCParser.OutputVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputExpr</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputExpr([NotNull] BasicCParser.OutputExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputStrVar</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputStrVar([NotNull] BasicCParser.OutputStrVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputStrLine</c>
	/// labeled alternative in <see cref="BasicCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputStrLine([NotNull] BasicCParser.OutputStrLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprSum</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprSum([NotNull] BasicCParser.ExprSumContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprSub</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprSub([NotNull] BasicCParser.ExprSubContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="BasicCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprTerm([NotNull] BasicCParser.ExprTermContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermMult([NotNull] BasicCParser.TermMultContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermDiv([NotNull] BasicCParser.TermDivContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termMod</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermMod([NotNull] BasicCParser.TermModContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="BasicCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermFactor([NotNull] BasicCParser.TermFactorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorExpr([NotNull] BasicCParser.FactorExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorVar([NotNull] BasicCParser.FactorVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorNumD</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorNumD([NotNull] BasicCParser.FactorNumDContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorNum([NotNull] BasicCParser.FactorNumContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorStr</c>
	/// labeled alternative in <see cref="BasicCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorStr([NotNull] BasicCParser.FactorStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifBlock</c>
	/// labeled alternative in <see cref="BasicCParser.controlflow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] BasicCParser.IfBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifElseBlock</c>
	/// labeled alternative in <see cref="BasicCParser.controlflow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfElseBlock([NotNull] BasicCParser.IfElseBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>loopBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoopBlock([NotNull] BasicCParser.LoopBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>forLoopBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForLoopBlock([NotNull] BasicCParser.ForLoopBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>doWhileBlock</c>
	/// labeled alternative in <see cref="BasicCParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDoWhileBlock([NotNull] BasicCParser.DoWhileBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="BasicCParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockLine([NotNull] BasicCParser.BlockLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="BasicCParser.rblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBlockLine([NotNull] BasicCParser.FnBlockLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBodyLine([NotNull] BasicCParser.FnBodyLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBodyLineMore([NotNull] BasicCParser.FnBodyLineMoreContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnReturnBoolLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnReturnBoolLine([NotNull] BasicCParser.FnReturnBoolLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnReturnStrLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnReturnStrLine([NotNull] BasicCParser.FnReturnStrLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnReturnExprLine([NotNull] BasicCParser.FnReturnExprLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="BasicCParser.rbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnReturnLine([NotNull] BasicCParser.FnReturnLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>bexprNot</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBexprNot([NotNull] BasicCParser.BexprNotContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>bexprOr</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBexprOr([NotNull] BasicCParser.BexprOrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>bexprExpr</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBexprExpr([NotNull] BasicCParser.BexprExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>bexprRelop</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBexprRelop([NotNull] BasicCParser.BexprRelopContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>bexprAnd</c>
	/// labeled alternative in <see cref="BasicCParser.bexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBexprAnd([NotNull] BasicCParser.BexprAndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>uniqueParam</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUniqueParam([NotNull] BasicCParser.UniqueParamContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multipleParams</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultipleParams([NotNull] BasicCParser.MultipleParamsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>noneParam</c>
	/// labeled alternative in <see cref="BasicCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoneParam([NotNull] BasicCParser.NoneParamContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>uniqueParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUniqueParamCall([NotNull] BasicCParser.UniqueParamCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multipleParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultipleParamCall([NotNull] BasicCParser.MultipleParamCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>noneParamCall</c>
	/// labeled alternative in <see cref="BasicCParser.paramsCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoneParamCall([NotNull] BasicCParser.NoneParamCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcInvoc</c>
	/// labeled alternative in <see cref="BasicCParser.callFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncInvoc([NotNull] BasicCParser.FuncInvocContext context);
}

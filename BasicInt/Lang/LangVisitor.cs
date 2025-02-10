using System.Globalization;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using BasicInt.Grammar;

namespace Lang
{
    //após a criação da arvore sintática, o visitor percorre a arvore e executa ações,
    //interpretanto o código
    public class LangVisitor : BasicCBaseVisitor<object?> 
    {
        public Dictionary<string, object> Functions { get; protected set; } = new Dictionary<string, object>();
        public Dictionary<string, object> Variables { get; private set; } = new Dictionary<string, object>();
        public Dictionary<string, object> LocalVariables { get; private set; } = new Dictionary<string, object>();
        public string caminho = "";
        public string isFunction = "";
        private FunctionAttributes? currentFunction = null;

        struct VariableAttributes
        {
            public int type;
            public object? value;

            public VariableAttributes(int _type, object? _value)
            {
                type = _type;
                value = _value;
            }

            public int GetType()
            {
                return type;
            }

            public object? GetValue()
            {
                return value;
            }

            public void SetType(int _type)
            {
                type = _type;
            }

            public void SetValue(object? _value)
            {
                value = _value;
            }
        }

        class FunctionAttributes
        {
            public int type;

            public List<LocalVariablesAttributes>? variables;
            public IParseTree value;

            public FunctionAttributes(int _type, IParseTree _value)
            {
                type = _type;
                value = _value;
            }

            public int GetType()
            {
                return type;
            }

            public IParseTree GetValue()
            {
                return value;
            }

            public void SetType(int _type)
            {
                type = _type;
            }

            public void SetValue(IParseTree _value)
            {
                value = _value;
            }

            public void SetVariables(List<LocalVariablesAttributes>? _variables)
            {
                variables = _variables;
            }

            public List<LocalVariablesAttributes>? GetVariables()
            {
                return variables;
            }
        }

        public class LocalVariablesAttributes
        {
            public int type;
            public object? value;
            public string name;

            public LocalVariablesAttributes(int _type, object? _value, string _name)
            {
                type = _type;
                value = _value;
                name = _name;
            }

            public int GetType()
            {
                return type;
            }

            public object? GetValue()
            {
                return value;
            }

            public string GetName()
            {
                return name;
            }

            public void SetType(int _type)
            {
                type = _type;
            }

            public void SetValue(object? _value)
            {
                value = _value;
            }

            public void SetName(string _name)
            {
                name = _name;
            }
        }

        public Boolean VerificaTipo(int varType, string varValue)
        {
            switch(varType)
            {
                case BasicCLexer.INTEGER:
                    int valorInteiro = 0;
                    if (!int.TryParse(varValue, out valorInteiro))
                    {
                        Console.WriteLine("Entrada inválida para o tipo INT");
                        return false;
                    }
                    break;
                case BasicCLexer.DOUBLE:
                    double valorDouble = 0.0;
                    if (!double.TryParse(varValue, out valorDouble))
                    {
                        Console.WriteLine("Entrada inválida para o tipo DOUBLE");
                        return false;
                    }
                    break;
                case BasicCLexer.BOOLEAN:
                    bool valorBooleano = false;
                    if (!bool.TryParse(varValue, out valorBooleano))
                    {
                        Console.WriteLine("Entrada inválida para o tipo BOOLEAN");
                        return false;
                    }
                    break;
                //ARRUMAR
                case BasicCLexer.STRING:
                    if (varValue[0] != '"' || varValue[varValue.Length - 1] != '"')
                    {
                        Console.WriteLine("Entrada inválida para o tipo STRING");
                        return false;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo de variável inválido");
                    return false;
            }
            return true;
        }


        #region Main
        public override object? VisitMainFunctionBlock([NotNull] BasicCParser.MainFunctionBlockContext context)
        {
            Visit(context.rblock());
            return null;
        }
        #endregion

        #region I/O Statements
        public override object? VisitVariavelNovaFuncao([NotNull] BasicCParser.VariavelNovaFuncaoContext context)
        {
            var varName = context.VAR().GetText();
            var varType = context.TYPE.Type;

            var value = Visit(context.callFunction());

                if (isFunction == "")
                {
                    Variables.Add(varName, new VariableAttributes(varType, value));
                }
                else
                {
                    LocalVariables.Add(isFunction, new LocalVariablesAttributes(varType, value, varName));
                }
            

            return null;
        }

        public override object? VisitVariavelNova([NotNull] BasicCParser.VariavelNovaContext context)
        {
            var varName = context.VAR().GetText();
            var varType = context.TYPE.Type;
            var varValue = context.expr().GetText();
            
            bool result = VerificaTipo(varType, varValue);
            if (result)
            {
                if (isFunction == "")
                {
                    Variables.Add(varName, new VariableAttributes(varType, varValue));
                }
                else
                {
                    LocalVariables.Add(isFunction, new LocalVariablesAttributes(varType, varValue, varName));
                }
            }

            return null;
        }

        public override object? VisitVariavelExistente([NotNull] BasicCParser.VariavelExistenteContext context)
        {
            var varName = context.VAR().GetText();
            var varNewValue = Visit(context.expr());
            
            if (isFunction == "" && Variables.ContainsKey(varName))
            {
                var variableAttributes = (VariableAttributes)Variables[varName];
                bool result = VerificaTipo(variableAttributes.GetType(), varNewValue.ToString());
                if (result)
                    Variables[varName] = new VariableAttributes(variableAttributes.GetType(), varNewValue);
            }
            else
            {
                if(LocalVariables.ContainsKey(isFunction))
                {
                    var localVariablesAttributes = (LocalVariablesAttributes)LocalVariables[isFunction];
                    bool result = VerificaTipo(localVariablesAttributes.GetType(), varNewValue.ToString());
                    if (result)
                        LocalVariables[isFunction] = new LocalVariablesAttributes(localVariablesAttributes.GetType(), varNewValue, varName);
                }
                else{
                    Console.WriteLine("Variável '"+ varName + "' não foi encontrada no escopo atual");
                }
            }

            return null;
        }

        public override object? VisitVariavelNovaString([NotNull] BasicCParser.VariavelNovaStringContext context)
        {
            var varName = context.VAR().GetText();
            var varType = BasicCLexer.STRING;
            var varValue = context.STR().GetText();

            bool result = VerificaTipo(varType, varValue);
            if (result)
            {
                if (isFunction == "")
                {
                    Variables.Add(varName, new VariableAttributes(varType, varValue));
                }
                else
                {
                    LocalVariables.Add(isFunction, new LocalVariablesAttributes(varType, varValue, varName));
                }
            }

            return null;
        }

        public override object? VisitVariavelExistenteString([NotNull] BasicCParser.VariavelExistenteStringContext context)
        {
            var varName = context.VAR().GetText();
            var varNewValue = context.STR().GetText();
            var variableAttributes = (VariableAttributes)Variables[varName];
            
            bool result = VerificaTipo(BasicCLexer.STRING, varNewValue);
            if (result)
                Variables[varName] = new VariableAttributes(variableAttributes.GetType(), varNewValue);
            
            return null;
        }

        public override object VisitVariavelNovaBoolean([NotNull] BasicCParser.VariavelNovaBooleanContext context)
        {
            var varName = context.VAR().GetText();
            var varType = BasicCLexer.BOOLEAN;
            var varValue = context.BOOL().GetText();

            bool result = VerificaTipo(varType, varValue);
            if (result)
            {
                if (isFunction == "")
                {
                    Variables.Add(varName, new VariableAttributes(varType, varValue));
                }
                else
                {
                    LocalVariables.Add(isFunction, new LocalVariablesAttributes(varType, varValue, varName));
                }
            }

            return null;
        }

        public override object? VisitOutputVar([NotNull] BasicCParser.OutputVarContext context)
        {
            var varName = context.VAR().GetText();

            if (Variables.ContainsKey(varName))
            {
                var variableAttributes = (VariableAttributes)Variables[varName];
                Console.WriteLine(variableAttributes.GetValue());
            }
            else if (currentFunction != null)
            {
                var variables = currentFunction.GetVariables();
                if (variables != null)
                {
                    var localVar = variables
                        .FirstOrDefault(v => v.GetName() == varName);

                    Console.WriteLine(localVar.GetValue());
                }
            } else {
                Console.WriteLine($"Erro: Variável '{varName}' não encontrada.");
            }

            return null;
        }

        public override object? VisitOutputStr([NotNull] BasicCParser.OutputStrContext context)
        {
            var varText = context.STR().GetText();
            varText  = varText.Substring(1, varText.Length - 2);
            Console.WriteLine(varText);

            return null;
        }

        public override object? VisitOutputExpr([NotNull] BasicCParser.OutputExprContext context)
        {
            var exprValue = Visit(context.expr());
            Console.WriteLine(exprValue);

            return null;
        }

        public override object? VisitOutputStrVar([NotNull] BasicCParser.OutputStrVarContext context)
        {
            var formatString = context.STR().GetText();
            formatString = formatString.Substring(1, formatString.Length - 2);

            // Obtém a lista de variáveis
            var variables = context.VAR().Select(varCtx => varCtx.GetText()).ToList();

            // Substitui cada placeholder pelo valor correspondente
            foreach (var varName in variables)
            {
                if (Variables.ContainsKey(varName))
                {
                    var variableAttributes = (VariableAttributes)Variables[varName];
                    var value = variableAttributes.GetValue();
                    formatString = formatString.ReplaceFirst("%d", value.ToString())
                                            .ReplaceFirst("%f", value.ToString())
                                            .ReplaceFirst("%s", value.ToString());
                }
                else
                {
                    Console.WriteLine($"Erro: Variável '{varName}' não encontrada.");
                    return null;
                }
            }

            // Exibe a string formatada
            Console.WriteLine(formatString);
            return null;
        }

        public override object? VisitOutputStrLine([NotNull] BasicCParser.OutputStrLineContext context)
        {
            // Obtém o nome da variável
            var varName = context.VAR().GetText();

            // Verifica se a variável existe no dicionário de variáveis
            if (Variables.ContainsKey(varName))
            {
                var variableAttributes = (VariableAttributes)Variables[varName];
                var value = variableAttributes.GetValue();
                var type = variableAttributes.GetType();
                // Verifica se o tipo da variável é STRING
                if (type == BasicCLexer.STRING)
                {
                    // Remove as aspas da string e imprime
                    var output = value?.ToString()?.Trim('"');
                    Console.WriteLine(output + "\n");
                }
                else
                {
                    Console.WriteLine($"Erro: A variável '{varName}' não é uma string.");
                }
            }
            else
            {
                Console.WriteLine($"Erro: Variável '{varName}' não encontrada.");
            }

            return null;
        }

        public override object? VisitInputStr([NotNull] BasicCParser.InputStrContext context)
        {
            // Obtém o nome da variável
            var varName = context.VAR().GetText();

            // Lê a entrada do usuário
            var varValue = Console.ReadLine();

            // Verifica se a entrada não é nula
            if (varValue != null)
            {
                // Armazena a string como tipo STRING no dicionário de variáveis
                Variables[varName] = new VariableAttributes(BasicCLexer.STRING, '"' + varValue + '"');
            }
            else
            {
                Console.WriteLine($"Erro: Entrada inválida para a variável '{varName}'.");
            }

            return null;
        }

        public override object? VisitInputVar([NotNull] BasicCParser.InputVarContext context)
        {
            var varName = context.VAR().GetText();
            var scanfFormat = context.SCANF_FORMAT().GetText();
            var varType = scanfFormat switch
            {
                "\"%d\"" => BasicCLexer.INTEGER,
                "\"%f\"" => BasicCLexer.DOUBLE,
                "\"%s\"" => BasicCLexer.STRING,

                _ => throw new InvalidOperationException($"Formato {scanfFormat} não suportado.")
            };

            var varValue = Console.ReadLine();

            if (varType == BasicCLexer.STRING)
                varValue = '"' + varValue + '"';

            bool result = VerificaTipo(varType, varValue);
            if (result)
                Variables.Add(varName, new VariableAttributes(varType, varValue));
            else
                Console.WriteLine($"Erro: O valor '{varValue}' não corresponde ao tipo esperado '{varType}'.");

            return null;
        }
        #endregion

        #region Operations
        protected (Double, Double) GetDoubles(IParseTree tree1, IParseTree tree2)
        {
            var t1 = Visit(tree1);
            var t2 = Visit(tree2);

            if (t1 is VariableAttributes && t2 is VariableAttributes)
            {
                Double.TryParse(((VariableAttributes)t1).GetValue().ToString(), out var d1);
                Double.TryParse(((VariableAttributes)t2).GetValue().ToString(), out var d2);
                return (d1, d2);
            }
            else if (t1 is VariableAttributes && t2 is not VariableAttributes)
            {
                Double.TryParse(((VariableAttributes)t1).GetValue().ToString(), out var d1);
                Double.TryParse(t2.ToString(), out var d2);
                return (d1, d2);
            }
            else if (t1 is not VariableAttributes && t2 is VariableAttributes)
            {
                Double.TryParse(t1.ToString(), out var d1);
                Double.TryParse(((VariableAttributes)t2).GetValue().ToString(), out var d2);
                return (d1, d2);
            }
            else
            {
                double.TryParse(t1.ToString(), out var d1);
                double.TryParse(t2.ToString(), out var d2);
                return (d1, d2);
            }
        }
        
        public override object VisitExprSum([NotNull] BasicCParser.ExprSumContext context)
        {

            var d = GetDoubles(context.term(), context.expr());
            return d.Item1 + d.Item2;
        }

        public override object VisitExprSub([NotNull] BasicCParser.ExprSubContext context)
        {
            var d = GetDoubles(context.term(), context.expr());
            return d.Item1 - d.Item2;
        }

        public override object? VisitExprTerm([NotNull] BasicCParser.ExprTermContext context)
        {
            return Visit(context.term());
        }

        public override object VisitTermMult([NotNull] BasicCParser.TermMultContext context)
        {
            var d = GetDoubles(context.factor(), context.term());
            return d.Item1 * d.Item2;
        }

        public override object VisitTermDiv([NotNull] BasicCParser.TermDivContext context)
        {
            var d = GetDoubles(context.factor(), context.term());
            return d.Item1 / d.Item2;
        }

        public override object VisitTermMod([NotNull] BasicCParser.TermModContext context)
        {
            var d = GetDoubles(context.factor(), context.term());
            return d.Item1 % d.Item2;
        }

        public override object? VisitTermFactor([NotNull] BasicCParser.TermFactorContext context)
        {
            return Visit(context.factor());
        }

        public override object VisitFactorVar([NotNull] BasicCParser.FactorVarContext context)
        {
            var varName = context.VAR().GetText();
            
            if (currentFunction != null)
            {
                var variables = currentFunction.GetVariables();
                if (variables != null)
                {
                    var localVar = variables
                        .FirstOrDefault(v => v.GetName() == varName);

                    return localVar.GetValue();
                }
            }

            return Variables[varName];
        }

        public override object VisitFactorNumD([NotNull] BasicCParser.FactorNumDContext context)
        {
            var txtNum = context.NUMD().GetText();
            var formattedNum = txtNum.Replace('.', ',');
            return double.Parse(formattedNum);
        }

        public override object? VisitFactorNum([NotNull] BasicCParser.FactorNumContext context)
        {
            var txtNum = context.NUM().GetText();
            return double.Parse(txtNum);
        }

        public override object? VisitFactorExpr([NotNull] BasicCParser.FactorExprContext context)
        {
            return Visit(context.expr());
        }
        #endregion

        #region function
        public override object? VisitFuncInvoc([NotNull] BasicCParser.FuncInvocContext context)
        {
            var fnName = context.VAR().GetText();
            currentFunction = Functions.ContainsKey(fnName) ? (FunctionAttributes)Functions[fnName] : null;

            if (!Functions.ContainsKey(fnName))
            {
                Console.WriteLine($"Erro: Função {fnName} não declarada.");
                return null;
            }
            var functionAttributes = (FunctionAttributes)Functions[fnName];

            var variables = functionAttributes.GetVariables()?.ToDictionary(v => v.GetName());
            if (variables == null)
            {
                Console.WriteLine($"Erro: A função {fnName} não possui parâmetros.");
                return null;
            }

            var providedArgs = new List<object?>();
            VisitParamsCall(context.paramsCall(), providedArgs);

            if (providedArgs.Count != variables.Count)
            {
                Console.WriteLine($"Erro: Número de argumentos inválido para função {fnName}.");
                return null;
            }

            int i = 0;
            foreach (var variable in variables.Values)
            {
                var value = providedArgs[i++];
                var convertedValue = ConvertToType(value.ToString(), variable.GetType());
                if (!ValidateType(variable.GetType(), convertedValue))
                {
                    Console.WriteLine($"Erro:{variable.GetType()} na variavel {variable.GetName()} com valor {value}.");
                    Console.WriteLine($"Erro: Tipo do argumento inválido para o parâmetro {variable.GetName()} na função {fnName}.");
                    return null;
                }
                variable.SetValue(value);
            }

            var fnReturnValue = Visit(functionAttributes.GetValue());

            var convertedReturnValue = ConvertToType(fnReturnValue, functionAttributes.GetType());

            if (!ValidateType(functionAttributes.GetType(), convertedReturnValue))
            {
                Console.WriteLine($"Erro: Tipo de retorno inválido na função {fnName}.");
                return null;
            }

            currentFunction = null;

            return convertedReturnValue;
        }

        private object? ConvertToType(object value, int type)
        {
            try
            {
                switch (type)
                {
                    case BasicCLexer.INTEGER:
                        return int.Parse(value.ToString());
                    case BasicCLexer.DOUBLE:
                        return double.Parse(value.ToString(), CultureInfo.InvariantCulture);
                    case BasicCLexer.BOOLEAN:
                        return bool.Parse(value.ToString());
                    case BasicCLexer.STRING:
                        return value.ToString(); // Strings não precisam de conversão.
                    case BasicCLexer.VOID:
                        return null; // Retorna nulo para funções sem retorno.
                    default:
                        throw new InvalidOperationException($"Tipo desconhecido: {type}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao converter o valor '{value}' para o tipo {type}: {ex.Message}");
                return null; // Retorna nulo se a conversão falhar.
            }
        }

        private bool ValidateType(int type, object? value)
        {
            try
            {
                switch (type)
                {
                    case BasicCLexer.INTEGER:
                        return value is int;
                    case BasicCLexer.DOUBLE:
                        return value is double;
                    case BasicCLexer.BOOLEAN:
                        return value is bool;
                    case BasicCLexer.STRING:
                        return value is string;
                    case BasicCLexer.VOID:
                        return value == null;
                    default:
                        Console.WriteLine($"Tipo desconhecido: {type}");
                        return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na validação do tipo: {ex.Message}");
                return false;
            }
        }

        private void VisitParamsCall(BasicCParser.ParamsCallContext context, List<object?> providedArgs)
        {
            if (context == null)
                return;

            if (context is BasicCParser.UniqueParamCallContext singleArg)
            {
                providedArgs.Add(Visit(singleArg.factor()));
            }

            if (context is BasicCParser.MultipleParamCallContext multiArgs)
            {
                VisitParamsCall(multiArgs.paramsCall(), providedArgs); 
                providedArgs.Add(Visit(multiArgs.factor()));
            }
        }

        public override object? VisitFnWithReturn([NotNull] BasicCParser.FnWithReturnContext context)
        {
            var fnName = context.VAR().GetText();
            var fnType = context.TYPE.Type;

            var variables = new List<LocalVariablesAttributes>();

            VisitParams(context.@params(), variables);

            var functionAttributes = new FunctionAttributes(fnType, context.rblock());
            functionAttributes.SetVariables(variables);
            Functions.Add(fnName, functionAttributes);
            
            return null;
        }

        public override object? VisitFnWithoutReturn([NotNull] BasicCParser.FnWithoutReturnContext context)
        {
            
            var fnName = context.VAR().GetText();
            var fnType = BasicCLexer.VOID;
            var variables = new List<LocalVariablesAttributes>();

            VisitParams(context.@params(), variables);

            var functionAttributes = new FunctionAttributes(fnType, context.rblock());
            functionAttributes.SetVariables(variables);

            Console.WriteLine("FnWithoutReturn " + fnName);
            Functions.Add(fnName, functionAttributes);

            return null;
        }

        private void VisitParams(BasicCParser.ParamsContext context, List<LocalVariablesAttributes> variables)
        {
            if (context == null)
                return;

            // Processar parâmetro único
            if (context is BasicCParser.UniqueParamContext singleParam)
            {
                var paramType = singleParam.TYPE.Type;
                var paramName = singleParam.VAR().GetText();
                variables.Add(new LocalVariablesAttributes(paramType, null, paramName));
            }

            if (context is BasicCParser.MultipleParamsContext multiParams)
            {
                VisitParams(multiParams.@params(), variables);
                var paramType = multiParams.TYPE.Type;
                var paramName = multiParams.VAR().GetText();
                variables.Add(new LocalVariablesAttributes(paramType, null, paramName));
            }
        }


        public override object? VisitFnBlockLine([NotNull] BasicCParser.FnBlockLineContext context)
        {
            return Visit(context.rbody());
        }

        public override object? VisitFnBodyLine([NotNull] BasicCParser.FnBodyLineContext context)
        {
            return Visit(context.line());
        }

        public override object? VisitFnBodyLineMore([NotNull] BasicCParser.FnBodyLineMoreContext context)
        {
            Visit(context.line());
            return Visit(context.rbody());
        }

        public override object? VisitFnReturnExprLine([NotNull] BasicCParser.FnReturnExprLineContext context)
        {
            caminho = "fnReturnExpr";
            return Visit(context.expr());
        }

        public override object? VisitFnReturnStrLine([NotNull] BasicCParser.FnReturnStrLineContext context)
        {
            caminho = "fnReturnStr";
            return Visit(context.STR());
        }

        public override object? VisitFnReturnBoolLine([NotNull] BasicCParser.FnReturnBoolLineContext context)
        {
            caminho = "fnReturnBool";
            return Visit(context.BOOL());
        }
        #endregion


        #region controlflow
        public override object? VisitIfBlock([NotNull] BasicCParser.IfBlockContext context)
        {
            var condition = Visit(context.bexpr());
            
            
            if (condition != null && (bool)condition)
            {
                Visit(context.block());
            }
            return null;
        }

        public override object? VisitIfElseBlock([NotNull] BasicCParser.IfElseBlockContext context)
        {
            var condition = Visit(context.bexpr());
            
            if (condition != null && (bool)condition)
            {
                Visit(context.block(0));
            }
            else
            {
                Visit(context.block(1));
            }
            return null;
        }

        public override object? VisitBexprRelop([NotNull] BasicCParser.BexprRelopContext context)
        {
            var d = GetDoubles(context.expr(0), context.expr(1));
            switch (context.RELOP.Type)
            {
                case BasicCLexer.LT:
                    return d.Item1 < d.Item2;
                case BasicCLexer.LE:
                    return d.Item1 <= d.Item2;
                case BasicCLexer.GT:
                    return d.Item1 > d.Item2;
                case BasicCLexer.GE:
                    return d.Item1 >= d.Item2;
                case BasicCLexer.EQ:
                    return d.Item1 == d.Item2;
                case BasicCLexer.NE:
                    return d.Item1 != d.Item2;
                default:
                    return null;
            }
        }

        public override object? VisitBexprAnd([NotNull] BasicCParser.BexprAndContext context)
        {
            // Avalia as subexpressões
            var left = (bool)Visit(context.bexpr(0))!;
            var right = (bool)Visit(context.bexpr(1))!;

            // Retorna o resultado do AND lógico
            return left && right;
        }

        public override object? VisitBexprOr([NotNull] BasicCParser.BexprOrContext context)
        {
            // Avalia as subexpressões
            var left = (bool)Visit(context.bexpr(0))!;
            var right = (bool)Visit(context.bexpr(1))!;

            // Retorna o resultado do OR lógico
            return left || right;
        }

        public override object? VisitBexprNot([NotNull] BasicCParser.BexprNotContext context)
        {
            // Avalia a subexpressão
            var value = (bool)Visit(context.bexpr())!;

            // Retorna o resultado do NOT lógico
            return !value;
        }

        public override object? VisitLoopBlock([NotNull] BasicCParser.LoopBlockContext context)
        {
            var cond = Visit(context.bexpr());
            while (cond != null && (bool)cond)
            {
                Visit(context.block());
                cond = Visit(context.bexpr());
            }
            return null;
        }

        public override object? VisitDoWhileBlock(BasicCParser.DoWhileBlockContext context)
        {
            var body = context.block();
            var condition = context.bexpr();

            do
            {
                Visit(body);
            }
            while (EvaluateCondition(condition));

            return null;
        }

        public override object? VisitForLoopBlock(BasicCParser.ForLoopBlockContext context)
        {
            // Inicialização
            Visit(context.atrib(0)); // Visita a primeira atribuição (inicialização)

            // Condição
            var condition = context.bexpr();

            // Incremento
            var increment = context.atrib(1);

            // Corpo do bloco
            var body = context.block();

            // Geração de código ou execução
            while (EvaluateCondition(condition))
            {
                Visit(body);  // Executa o bloco do `for`
                Visit(increment); // Executa o incremento
            }

            return null;
        }

        private bool EvaluateCondition(BasicCParser.BexprContext condition)
        {
            var result = Visit(condition);

            // Verifica se o resultado é um booleano
            if (result is bool boolResult)
            {
                return boolResult;
            }
            else
            {
                Console.WriteLine("Erro: A condição do loop `for` deve ser um booleano.");
                return false;
            }
        }
        #endregion

    }
}
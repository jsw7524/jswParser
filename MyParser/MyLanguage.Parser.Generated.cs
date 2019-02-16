// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  DESKTOP-RBKG4QN
// DateTime: 2019/2/7 �U�� 10:16:25
// UserName: netsp
// Input file <MyLanguage.Language.grammar.y - 2019/2/7 �U�� 10:16:24>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace MyParser
{
internal enum Token {error=2,EOF=3,NUMBER=4,Add=5,Minus=6,
    Mul=7,Div=8,Pow=9,LeftPar=10,RightPar=11};

internal partial struct ValueType
{ 
			public Decimal n; 
			public string s; 
	   }
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal partial class MyLanguageParser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[12];
  private static State[] states = new State[21];
  private static string[] nonTerms = new string[] {
      "main", "$accept", "expr1", "expr2", "expr3", };

  static MyLanguageParser() {
    states[0] = new State(new int[]{4,10,10,17},new int[]{-1,1,-3,3,-4,16,-5,20});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{9,4,5,6,6,12,3,-2});
    states[4] = new State(new int[]{4,5});
    states[5] = new State(-11);
    states[6] = new State(new int[]{4,10,10,17},new int[]{-4,7,-5,20,-3,11});
    states[7] = new State(new int[]{7,8,8,14,9,-3,5,-3,6,-3,3,-4,11,-4});
    states[8] = new State(new int[]{4,10,10,17},new int[]{-5,9,-3,11,-4,16});
    states[9] = new State(new int[]{7,-6,8,-6,9,-6,5,-6,6,-6,3,-8,11,-8});
    states[10] = new State(-10);
    states[11] = new State(new int[]{9,4,5,6,6,12});
    states[12] = new State(new int[]{4,10,10,17},new int[]{-4,13,-5,20,-3,11});
    states[13] = new State(new int[]{7,8,8,14,9,-3,5,-3,6,-3,3,-5,11,-5});
    states[14] = new State(new int[]{4,10,10,17},new int[]{-5,15,-3,11,-4,16});
    states[15] = new State(new int[]{7,-6,8,-6,9,-6,5,-6,6,-6,3,-9,11,-9});
    states[16] = new State(new int[]{7,8,8,14,9,-3,5,-3,6,-3,3,-3,11,-3});
    states[17] = new State(new int[]{4,10,10,17},new int[]{-3,18,-4,16,-5,20});
    states[18] = new State(new int[]{11,19,9,4,5,6,6,12});
    states[19] = new State(-7);
    states[20] = new State(-6);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,3});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-3, new int[]{-4});
    rules[4] = new Rule(-3, new int[]{-3,5,-4});
    rules[5] = new Rule(-3, new int[]{-3,6,-4});
    rules[6] = new Rule(-4, new int[]{-5});
    rules[7] = new Rule(-4, new int[]{10,-3,11});
    rules[8] = new Rule(-4, new int[]{-4,7,-5});
    rules[9] = new Rule(-4, new int[]{-4,8,-5});
    rules[10] = new Rule(-5, new int[]{4});
    rules[11] = new Rule(-5, new int[]{-3,9,4});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Token.error, (int)Token.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // main -> expr1
{ Console.WriteLine("Rule -> number: {0}", ValueStack[ValueStack.Depth-1].n); }
        break;
      case 3: // expr1 -> expr2
{ CurrentSemanticValue.n= ValueStack[ValueStack.Depth-1].n;}
        break;
      case 4: // expr1 -> expr1, Add, expr2
{ CurrentSemanticValue.n= ValueStack[ValueStack.Depth-3].n+ValueStack[ValueStack.Depth-1].n ;}
        break;
      case 5: // expr1 -> expr1, Minus, expr2
{ CurrentSemanticValue.n= ValueStack[ValueStack.Depth-3].n-ValueStack[ValueStack.Depth-1].n ;}
        break;
      case 6: // expr2 -> expr3
{ CurrentSemanticValue.n= ValueStack[ValueStack.Depth-1].n;}
        break;
      case 7: // expr2 -> LeftPar, expr1, RightPar
{ CurrentSemanticValue.n= ValueStack[ValueStack.Depth-2].n;}
        break;
      case 8: // expr2 -> expr2, Mul, expr3
{ CurrentSemanticValue.n= ValueStack[ValueStack.Depth-3].n*ValueStack[ValueStack.Depth-1].n ;}
        break;
      case 9: // expr2 -> expr2, Div, expr3
{ CurrentSemanticValue.n= ValueStack[ValueStack.Depth-3].n/ValueStack[ValueStack.Depth-1].n ;}
        break;
      case 10: // expr3 -> NUMBER
{ CurrentSemanticValue.n= ValueStack[ValueStack.Depth-1].n;}
        break;
      case 11: // expr3 -> expr1, Pow, NUMBER
{ CurrentSemanticValue.n=(decimal) Math.Pow((double)ValueStack[ValueStack.Depth-3].n, (double)ValueStack[ValueStack.Depth-1].n) ;}
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Token)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Token)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}

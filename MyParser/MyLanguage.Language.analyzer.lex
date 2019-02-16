%namespace MyParser
%scannertype MyLanguageScanner
%visibility internal
%tokentype Token

%option stack, minimize, parser, verbose, persistbuffer, noembedbuffers 

Eol             (\r\n?|\n)
NotWh           [^ \t\r\n]
Space           [ \t]
Number          [0-9.]+
OpAdd           +
OpMinus		    -
OpMul           *
OpDiv		    /
OpPow           "^"
LeftPar         "("
RightPar        ")"


%{

%}

%%

/* Scanner body */

{Number}		{ Console.WriteLine("token: {0}", yytext);		GetNumber(); return (int)Token.NUMBER; }

{Space}+		/* skip */
{OpAdd}             {  return (int)Token.Add; }
{OpMinus}           {  return (int)Token.Minus; }
{OpMul}             {  return (int)Token.Mul; }
{OpDiv}           {  return (int)Token.Div; }
{OpPow}           {  Console.WriteLine("XXXXX"); return (int)Token.Pow; }
{LeftPar}             {  return (int)Token.LeftPar; }
{RightPar}           {  return (int)Token.RightPar; }


%%
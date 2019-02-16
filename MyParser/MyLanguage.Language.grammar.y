%namespace MyParser
%partial
%parsertype MyLanguageParser
%visibility internal
%tokentype Token

%union { 
			public Decimal n; 
			public string s; 
	   }

%start main

%token NUMBER
%token Add
%token Minus
%token Mul
%token Div
%token Pow
%token LeftPar
%token RightPar

%%

main   : expr1                            { Console.WriteLine("Rule -> number: {0}", $1.n); }
       ;

expr1   : expr2                            { $$.n= $1.n;}
	   | expr1 Add expr2                   { $$.n= $1.n+$3.n ;}
	   | expr1 Minus expr2                   { $$.n= $1.n-$3.n ;}

       ;
	    
expr2   : expr3                          { $$.n= $1.n;}
       | LeftPar expr1 RightPar          { $$.n= $2.n;}
       | expr2 Mul expr3                { $$.n= $1.n*$3.n ;}
	   | expr2 Div expr3                { $$.n= $1.n/$3.n ;}
	   ;

expr3   : NUMBER                          { $$.n= $1.n;}
       | expr1 Pow NUMBER                 { $$.n=(decimal) Math.Pow((double)$1.n, (double)$3.n) ;}
	   ;
%%
using System;
using System.Collections.Generic;
using System.Text;

namespace MyParser
{
    internal partial class MyLanguageScanner
    {

        void GetNumber()
        {
            yylval.s = yytext;
            yylval.n = decimal.Parse(yytext);
        }

		public override void yyerror(string format, params object[] args)
		{
			base.yyerror(format, args);
			Console.WriteLine(format, args);
			Console.WriteLine();
		}
    }
}

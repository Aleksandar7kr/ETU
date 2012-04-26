
namespace CSharp
{ 
    using System;
    
    sealed public class HTMLTokenVisitor : ITokenVisitor
    {
        public void Visit(ILineStartToken line)
        {
            Console.Write("<span class = \"line_number\">");
            Console.Write("{0,3}", line.Number());
            Console.Write("</span>");
        }

        public void Visit(ILineEndToken t)
        {
            Console.Write("\n");
        }

        public void Visit(IIdentifierToken token)
        {
            SpannedFilteredWhite("identifer", token);
        }

        public void Visit(ICommentToken token)
        {   
            SpannedFilteredWhite("comment", token);
        }

        public void Visit(IKeywordToken token)
        {
            SpannedFilteredWhite("keyword", token);
        }

        public void Visit(IWhiteSpaceToken token)
        {
            Console.Write(token.ToString());
        }

        public void Visit(IOtherToken token)
        {
            FilteredWhite(token);
        }

        public void Visit(IDirectiveToken token)
        {
            SpannedFilteredWhite("directive", token);
        }

        private void FilteredWhite(IToken token)
        {
            String str = token.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                string dst;
                switch (str[i])
                {
                    case '<':
                        dst = "&lt"; break;
                    case '>':
                        dst = "&gt"; break;
                    case '&':
                        dst = "&amp"; break;
                    default:
                        dst = new string(str[i], 1); break;
                }
                Console.Write(dst);
            }
        }

        private void SpannedFilteredWhite(string spanName, IToken token)
        {
            Console.Write("<span class = \"{0}\">", spanName);
            FilteredWhite(token);
            Console.Write("</span>");
        }
    }

}

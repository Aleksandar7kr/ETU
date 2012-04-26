
namespace CSharp
{
    using System;
    
    sealed class CountingTokenVisitor : ITokenVisitor
    {
        public void Visit(ILineStartToken t) 
        {
            line_count++;
        }
    
        public void Visit(ILineEndToken t) {}
               
        public void Visit(ICommentToken    t) 
        {
            comment_count++;
        }
    
        public void Visit(IDirectiveToken  t) 
        {
            directive_count++;
        }
    
        public void Visit(IIdentifierToken t) 
        {
            identifier_count++;
        }
    
        public void Visit(IKeywordToken    t) 
        {
            keyword_count++;
        }
        
        public void Visit(IWhiteSpaceToken t) 
        {
            whitespace_count++;
        }
 
        public void Visit(IOtherToken t) 
        {
            other_count++;
        }
                
        public void Report()
        {
            Console.WriteLine("Token Counts");
            Console.WriteLine("Lines      : {0}", line_count);
            Console.WriteLine("Comments   : {0}", comment_count);
            Console.WriteLine("Directives : {0}", directive_count);
            Console.WriteLine("Identifiers: {0}", identifier_count);
            Console.WriteLine("Keywords   : {0}", keyword_count);
            Console.WriteLine("Whitespace : {0}", whitespace_count);
            Console.WriteLine("Other      : {0}", other_count);
        }
        
        private int 
            line_count,
            comment_count,
            directive_count,
            identifier_count,
            keyword_count,
            whitespace_count,
            other_count;           
    }
}

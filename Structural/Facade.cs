using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public sealed class Facade {
        public void Compile(Stream iStream, Stream oStream) {
            Scanner scanner = new Scanner(iStream);
            ProgramNodeBuilder builder = new ProgramNodeBuilder();

            Parser parser = new Parser();
            parser.Parse(scanner, builder);
            builder.GetTree().Walk(new DefaultCodeGenerator(oStream));
        }
    }


    #region Compiler subsystem

    sealed class Token {
        public Token() { }
    }

    sealed class ProgramNode {
        public ProgramNode() {
        }
        public void Walk(CodeGenerator g) {
        }
    }

    sealed class Scanner {
        readonly Stream iStream;

        public Scanner(Stream iStream) {
            this.iStream = iStream;
        }
    }

    sealed class ProgramNodeBuilder {
        public ProgramNodeBuilder() {
        }
        public ProgramNode GetTree() { return new ProgramNode(); }
    }

    sealed class Parser {
        public Parser() {
        }
        public void Parse(Scanner scanner, ProgramNodeBuilder builder) {
        }
    }

    abstract class CodeGenerator {
        public CodeGenerator(Stream oStream) {
        }
    }

    sealed class DefaultCodeGenerator : CodeGenerator {
        public DefaultCodeGenerator(Stream oStream)
            : base(oStream) {
        }
    }

    #endregion
}
